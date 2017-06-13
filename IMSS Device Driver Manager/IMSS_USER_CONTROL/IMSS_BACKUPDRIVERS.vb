Imports Microsoft.Win32
Imports System.IO
Imports System.Text
Imports System.Xml

Public Class IMSS_BACKUPDRIVERS
    Private Shared _IMSS_CONTROl As IMSS_BACKUPDRIVERS
    Public Shared Function _IMSS_CREATE_CONTROl() As IMSS_BACKUPDRIVERS
        If _IMSS_CONTROl Is Nothing Then
            _IMSS_CONTROl = New IMSS_BACKUPDRIVERS
            _IMSS_CONTROl.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROl
    End Function


    Private Sub _IMSS_LOAD_DRIVERS()
        Dim _IMSS_REGISTRY_KEY As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Class")
        For Each _IMSS_SUBKEY In _IMSS_REGISTRY_KEY.GetSubKeyNames()
            Application.DoEvents()

            If _IMSS_CHECK_SECTION("SYSTEM\CurrentControlSet\Control\Class\" & _IMSS_SUBKEY) Then
                Try
                    Dim _IMSS_DRIVES_SECTION As String = My.Computer.Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Class\" & _IMSS_SUBKEY).GetValue("").ToString()

                    With _IMSS_TREEVIEW.Nodes.Add(_IMSS_DRIVES_SECTION & " (" & _IMSS_GET_NUMBER_OF_DEVICES_IN_SECTION(True, "SYSTEM\CurrentControlSet\Control\Class\" & _IMSS_SUBKEY) & " Devices)")
                        .Checked = True
                        .ImageIndex = 0
                        .Tag = _IMSS_SUBKEY
                        Dim _IMSS_LOCALListOfSectionDrivers As List(Of String) = _IMSS_GET_NUMBER_OF_DEVICES_IN_SECTION(False, "SYSTEM\CurrentControlSet\Control\Class\" & _IMSS_SUBKEY)
                        For Each _IMSS_ITEM In _IMSS_LOCALListOfSectionDrivers

                            With .Nodes.Add(_IMSS_ITEM.Split("|")(0))
                                .Checked = True
                                .ImageIndex = 1
                                .Tag = _IMSS_ITEM.Split("|")(1)
                            End With

                        Next _IMSS_ITEM



                    End With

                Catch : End Try
            End If




        Next _IMSS_SUBKEY

        _IMSS_REGISTRY_KEY.Close()
        _IMSS_TREEVIEW.ExpandAll()
        _IMSS_TREEVIEW.Nodes(0).EnsureVisible()
    End Sub





    Private Function _IMSS_GET_NUMBER_OF_DEVICES_IN_SECTION(ByVal _IMSS_STATUS_TYPE As Boolean, ByVal _IMSS_SECTION_TARGET As String) As Object
        Dim _IMSS_ListOfValues As New List(Of String)
        Dim _IMSS_ListOfValuesSubKeys As New List(Of String)
        Try
            For Each _IMSS_KEY In My.Computer.Registry.LocalMachine.OpenSubKey(_IMSS_SECTION_TARGET).GetSubKeyNames()
                For Each _IMSS_VALUE In My.Computer.Registry.LocalMachine.OpenSubKey(_IMSS_SECTION_TARGET & "\" & _IMSS_KEY).GetValueNames()
                    Dim _IMSS_DriverDesc_Value As String = My.Computer.Registry.LocalMachine.OpenSubKey(_IMSS_SECTION_TARGET & "\" & _IMSS_KEY).GetValue("DriverDesc").ToString()
                    If Not _IMSS_ListOfValues.Contains(_IMSS_DriverDesc_Value) Then
                        _IMSS_ListOfValues.Add(_IMSS_DriverDesc_Value)
                        _IMSS_ListOfValuesSubKeys.Add(_IMSS_DriverDesc_Value & "|" & _IMSS_KEY)
                    End If
                Next _IMSS_VALUE
            Next _IMSS_KEY
        Catch : End Try
        If _IMSS_STATUS_TYPE = True Then Return _IMSS_ListOfValues.Count() Else Return _IMSS_ListOfValuesSubKeys
    End Function


    Private Function _IMSS_CHECK_SECTION(ByVal _IMSS_SECTION_TARGET As String) As Boolean
        Dim _IMSS_TOTAL_VALUIS As Short = 0
        For Each _IMSS_KEY In My.Computer.Registry.LocalMachine.OpenSubKey(_IMSS_SECTION_TARGET).GetSubKeyNames()
            _IMSS_TOTAL_VALUIS += 1
        Next _IMSS_KEY
        If _IMSS_TOTAL_VALUIS > 1 Then Return True Else Return False
    End Function


    Private Sub IMSS_MANGEDRIVERS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _IMSS_TREEVIEW.BeginUpdate()
        _IMSS_LOAD_DRIVERS()
        _IMSS_TREEVIEW.EndUpdate()
    End Sub

    Private Sub _IMSS_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Refresh.Click
        _IMSS_TREEVIEW.BeginUpdate()
        _IMSS_TREEVIEW.Nodes.Clear()
        _IMSS_LOAD_DRIVERS()
        _IMSS_TREEVIEW.EndUpdate()
    End Sub

    Private Sub _IMSS_Backup_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Backup_Button.Click
        _IMSS_Backup_Button.Enabled = False
        _IMSS_Refresh.Enabled = False
        _IMSS_PROGRESS_BAR.Maximum = _IMSS_TREEVIEW.Nodes.Count()
        _IMSS_PROGRESS_BAR.Value = 0
        _IMSS_PROGRESS_BAR.Visible = True
        Dim _IMSS_THREAD As New Threading.Thread(AddressOf _IMSS_START_BACKUP_PROCESSES) : _IMSS_THREAD.Start()
    End Sub

    Private Sub _IMSS_START_BACKUP_PROCESSES()
        Dim _IMSS_BACKUP_TARGET_DIRECTORY As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Device Driver Backup Files -- " & _IMSS_GeneratePassword() & "\"

        For Each _IMSS_NODE As TreeNode In _IMSS_TREEVIEW.Nodes
            _IMSS_AddValueToProgressBar()
            If _IMSS_NODE.Checked = True Then
                For Each _IMSS_CHILD_NODE As TreeNode In _IMSS_NODE.Nodes
                    If _IMSS_CHILD_NODE.Checked = True Then
                        _IMSS_BACKUP_DRIVE(New String() {_IMSS_NODE.Tag.ToString(), _IMSS_CHILD_NODE.Tag.ToString(), _IMSS_BACKUP_TARGET_DIRECTORY})
                    End If
                Next _IMSS_CHILD_NODE
            End If
        Next _IMSS_NODE

        _IMSS_StopProgress()
        _IMSS_EnableBackupButton()
        _IMSS_EnableRefreshButton()
        If IO.Directory.Exists(_IMSS_BACKUP_TARGET_DIRECTORY) = True Then Process.Start(_IMSS_BACKUP_TARGET_DIRECTORY)

    End Sub

    Private Sub _IMSS_BACKUP_DRIVE(ByRef _IMSS_LIST() As String)
        '
        '             * Driver Info.
        '             

        Dim driverInfoArray As String() = _IMSS_LIST
        Dim classGUID As String = driverInfoArray(0)
        Dim driverID As String = driverInfoArray(1)
        Dim backupLocation As String = driverInfoArray(2)
        Dim infFile As String, infFilePath As String
        Dim driverDesc As String
        Dim _IMSS_WindowsRoot As String = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 2) & "\Windows\"

        Dim regDriverType As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Class\" & classGUID)
        Dim driverType As String = regDriverType.GetValue("").ToString()
        Dim driverInfo As RegistryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Control\Class\" & classGUID & "\" & driverID)
        driverDesc = driverInfo.GetValue("DriverDesc").ToString()
        infFile = driverInfo.GetValue("InfPath").ToString()
        infFilePath = _IMSS_WindowsRoot & "inf\" & infFile.ToString()

        '
        '             * Create backup directory.
        '             

        If Not IO.Directory.Exists(backupLocation) Then IO.Directory.CreateDirectory(backupLocation)

        If driverType.Length > 0 Then
            If Not Directory.Exists(backupLocation + driverType) Then Directory.CreateDirectory(backupLocation + driverType)
        End If
        If Not Directory.Exists(backupLocation + driverType + "\" & driverDesc.Replace(":\", "")) Then Directory.CreateDirectory(backupLocation + driverType + "\" & driverDesc.Replace(":\", ""))



        '
        '             * Copy over inf file.
        '             

        Try
            File.Copy(infFilePath, backupLocation + driverType + "\" & driverDesc & "\" & infFile)
            _IMSS_WRITE_TO_BACKUP_DATA(New String() {backupLocation, Environment.NewLine() & driverType & "|" & driverDesc & "|" & "[WINDOWS]\Inf\" & infFile})
        Catch : End Try

        '
        '             * Backup driver files.
        '             

        Dim driverIniFile As New INIFiles()
        Dim driverFiles As List(Of String) = driverIniFile.GetKeys(infFilePath, "SourceDisksFiles")
        For Each driverFile As String In driverFiles
            If driverFile.Split("."c).Length > 1 Then
                '
                '                         * Copy driver files from the right place.
                '                         

                If driverFile.Split("."c)(1) = "hlp" Then
                    Try
                        If Not IO.File.Exists(backupLocation + driverType + "\" & driverDesc & "\" & driverFile) Then
                            File.Copy(_IMSS_WindowsRoot & "Help\" & driverFile, backupLocation + driverType + "\" & driverDesc & "\" & driverFile)
                            _IMSS_WRITE_TO_BACKUP_DATA(New String() {backupLocation, Environment.NewLine() & driverType & "|" & driverDesc & "|" & "[WINDOWS]\Help\" & driverFile})
                        End If : Catch : End Try
                ElseIf driverFile.Split("."c)(1) = "sys" Then
                    Try
                        If Not IO.File.Exists(backupLocation + driverType + "\" & driverDesc & "\" & driverFile) Then
                            File.Copy(_IMSS_WindowsRoot & "System32\drivers\" & driverFile, backupLocation + driverType + "\" & driverDesc & "\" & driverFile)
                            _IMSS_WRITE_TO_BACKUP_DATA(New String() {backupLocation, Environment.NewLine() & driverType & "|" & driverDesc & "|" & "[WINDOWS]\System32\drivers\" & driverFile})
                        End If : Catch : End Try
                Else
                    Try
                        If Not IO.File.Exists(backupLocation + driverType + "\" & driverDesc & "\" & driverFile) Then
                            File.Copy(_IMSS_WindowsRoot & driverFile, backupLocation + driverType + "\" & driverDesc & "\" & driverFile)
                            _IMSS_WRITE_TO_BACKUP_DATA(New String() {backupLocation, Environment.NewLine() & driverType & "|" & driverDesc & "|" & "[WINDOWS]\" & driverFile})
                        End If : Catch : End Try

                    Try
                        If Not IO.File.Exists(backupLocation + driverType + "\" & driverDesc & "\" & driverFile) Then
                            File.Copy(_IMSS_WindowsRoot & "System32\" & driverFile, backupLocation + driverType + "\" & driverDesc & "\" & driverFile)
                            _IMSS_WRITE_TO_BACKUP_DATA(New String() {backupLocation, Environment.NewLine() & driverType & "|" & driverDesc & "|" & "[WINDOWS]\System32\" & driverFile})
                        End If : Catch : End Try
                End If
            End If
        Next

        '
        '             * Close registry.
        '             

        regDriverType.Close()
        driverInfo.Close()

    End Sub

    Private Sub _IMSS_WRITE_TO_BACKUP_DATA(ByVal _IMSS_TARGETS() As String)
        If Not IO.File.Exists(_IMSS_TARGETS(0) & "IMSS_BACKUP_DATA.IMSSDATA") = True Then IO.File.Create(_IMSS_TARGETS(0) & "IMSS_BACKUP_DATA.IMSSDATA").Dispose()
        IO.File.AppendAllText(_IMSS_TARGETS(0) & "IMSS_BACKUP_DATA.IMSSDATA", _IMSS_TARGETS(1))
    End Sub
    Private Function _IMSS_GeneratePassword()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Delegate Sub _IMSS_INVOKE_DELEGATE()
    Private Sub _IMSS_AddValueToProgressBar()
        If _IMSS_PROGRESS_BAR.InvokeRequired = True Then
            _IMSS_PROGRESS_BAR.Invoke(New _IMSS_INVOKE_DELEGATE(AddressOf _IMSS_AddValueToProgressBar))
        Else
            _IMSS_PROGRESS_BAR.Value += 1
        End If
    End Sub

    Private Sub _IMSS_StopProgress()
        If _IMSS_PROGRESS_BAR.InvokeRequired = True Then
            _IMSS_PROGRESS_BAR.Invoke(New _IMSS_INVOKE_DELEGATE(AddressOf _IMSS_StopProgress))
        Else
            _IMSS_PROGRESS_BAR.Visible = False
        End If
    End Sub

    Private Sub _IMSS_EnableBackupButton()
        If _IMSS_Backup_Button.InvokeRequired = True Then
            _IMSS_Backup_Button.Invoke(New _IMSS_INVOKE_DELEGATE(AddressOf _IMSS_EnableBackupButton))
        Else
            _IMSS_Backup_Button.Enabled = True
        End If
    End Sub

    Private Sub _IMSS_EnableRefreshButton()
        If _IMSS_Refresh.InvokeRequired = True Then
            _IMSS_Refresh.Invoke(New _IMSS_INVOKE_DELEGATE(AddressOf _IMSS_EnableRefreshButton))
        Else
            _IMSS_Refresh.Enabled = True
        End If
    End Sub

End Class
