Imports Microsoft.Win32

Public Class IMSS_MANGEDRIVERS
    Private Shared _IMSS_CONTROl As IMSS_MANGEDRIVERS
    Public Shared Function _IMSS_CREATE_CONTROl() As IMSS_MANGEDRIVERS
        If _IMSS_CONTROl Is Nothing Then
            _IMSS_CONTROl = New IMSS_MANGEDRIVERS
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
                        .ImageIndex = 0
                        Dim _IMSS_LOCALListOfSectionDrivers As List(Of String) = _IMSS_GET_NUMBER_OF_DEVICES_IN_SECTION(False, "SYSTEM\CurrentControlSet\Control\Class\" & _IMSS_SUBKEY)
                        For Each _IMSS_ITEM In _IMSS_LOCALListOfSectionDrivers

                            With .Nodes.Add(_IMSS_ITEM)
                                .ImageIndex = 1

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
        Try
            For Each _IMSS_KEY In My.Computer.Registry.LocalMachine.OpenSubKey(_IMSS_SECTION_TARGET).GetSubKeyNames()
                For Each _IMSS_VALUE In My.Computer.Registry.LocalMachine.OpenSubKey(_IMSS_SECTION_TARGET & "\" & _IMSS_KEY).GetValueNames()
                    Dim _IMSS_DriverDesc_Value As String = My.Computer.Registry.LocalMachine.OpenSubKey(_IMSS_SECTION_TARGET & "\" & _IMSS_KEY).GetValue("DriverDesc").ToString()
                    If Not _IMSS_ListOfValues.Contains(_IMSS_DriverDesc_Value) Then
                        _IMSS_ListOfValues.Add(_IMSS_DriverDesc_Value)
                    End If
                Next _IMSS_VALUE
            Next _IMSS_KEY
        Catch : End Try
        If _IMSS_STATUS_TYPE = True Then Return _IMSS_ListOfValues.Count() Else Return _IMSS_ListOfValues
    End Function


    Private Function _IMSS_CHECK_SECTION(ByVal _IMSS_SECTION_TARGET As String) As Boolean
        Dim _IMSS_TOTAL_VALUIS As Short = 0
        For Each _IMSS_KEY In My.Computer.Registry.LocalMachine.OpenSubKey(_IMSS_SECTION_TARGET).GetSubKeyNames()
            _IMSS_TOTAL_VALUIS += 1
        Next _IMSS_KEY
        If _IMSS_TOTAL_VALUIS > 1 Then Return True Else Return False
    End Function


    Private Sub IMSS_MANGEDRIVERS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _IMSS_LOAD_DRIVERS()
    End Sub

    Private Sub _IMSS_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Refresh.Click
        _IMSS_TREEVIEW.BeginUpdate()
        _IMSS_TREEVIEW.Nodes.Clear()
        _IMSS_LOAD_DRIVERS()
        _IMSS_TREEVIEW.EndUpdate()
    End Sub
End Class
