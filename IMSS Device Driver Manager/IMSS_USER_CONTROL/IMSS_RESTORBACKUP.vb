Public Class IMSS_RESTORBACKUP
    Private Shared _IMSS_CONTROl As IMSS_RESTORBACKUP
    Private _IMSS_CURRENT_BACKUP_DIRECTORY_LOCATION As String = String.Empty
    Public Shared Function _IMSS_CREATE_CONTROl() As IMSS_RESTORBACKUP
        If _IMSS_CONTROl Is Nothing Then
            _IMSS_CONTROl = New IMSS_RESTORBACKUP
            _IMSS_CONTROl.Dock = DockStyle.Fill
        End If
        Return _IMSS_CONTROl
    End Function

    Private Sub _IMSS_SELECTBACKUPFILE_PICTUREBOX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _IMSS_SELECTBACKUPFILE_PICTUREBOX.MouseDown
        _IMSS_SELECT_LABEL.ForeColor = Color.Gray
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Image = My.Resources._IMSS_SELECBACKUPFILE_OnMouseDown_Icon_256x256
    End Sub

    Private Sub _IMSS_SELECTBACKUPFILE_PICTUREBOX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_SELECTBACKUPFILE_PICTUREBOX.MouseEnter
        _IMSS_SELECT_LABEL.ForeColor = Color.Black
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Image = My.Resources._IMSS_SELECBACKUPFILE_OnMuseOver_Icon_256x256
    End Sub

    Private Sub _IMSS_SELECTBACKUPFILE_PICTUREBOX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_SELECTBACKUPFILE_PICTUREBOX.MouseLeave
        _IMSS_SELECT_LABEL.ForeColor = SystemColors.ControlDarkDark
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Image = My.Resources._IMSS_SELECBACKUPFILE_Icon_256x256
    End Sub

    Private Sub _IMSS_SELECTBACKUPFILE_PICTUREBOX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _IMSS_SELECTBACKUPFILE_PICTUREBOX.MouseUp
        _IMSS_SELECT_LABEL.ForeColor = Color.Black
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Image = My.Resources._IMSS_SELECBACKUPFILE_Icon_256x256
    End Sub

    Private Sub _IMSS_SELECT_LABEL_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _IMSS_SELECT_LABEL.MouseDown
        _IMSS_SELECT_LABEL.ForeColor = Color.Gray
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Image = My.Resources._IMSS_SELECBACKUPFILE_OnMouseDown_Icon_256x256
    End Sub

    Private Sub _IMSS_SELECT_LABEL_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_SELECT_LABEL.MouseEnter
        _IMSS_SELECT_LABEL.ForeColor = Color.Black
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Image = My.Resources._IMSS_SELECBACKUPFILE_OnMuseOver_Icon_256x256
    End Sub

    Private Sub _IMSS_SELECT_LABEL_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IMSS_SELECT_LABEL.MouseLeave
        _IMSS_SELECT_LABEL.ForeColor = SystemColors.ControlDarkDark
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Image = My.Resources._IMSS_SELECBACKUPFILE_Icon_256x256
    End Sub

    Private Sub _IMSS_SELECT_LABEL_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _IMSS_SELECT_LABEL.MouseUp
        _IMSS_SELECT_LABEL.ForeColor = Color.Black
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Image = My.Resources._IMSS_SELECBACKUPFILE_Icon_256x256
    End Sub

    Private Sub _IMSS_SELECT_LABEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SELECT_LABEL.Click
        If _IMSS_SELECTFILE_DIALOG.ShowDialog() = DialogResult.OK Then

            _IMSS_CURRENT_BACKUP_DIRECTORY_LOCATION = IO.Path.GetDirectoryName(_IMSS_SELECTFILE_DIALOG.FileName)

            _IMSS_LOADING_PROGRESS.Visible = True

            _IMSS_LOAD_BACKUP_FILE()

            _IMSS_LOADING_PROGRESS.Visible = False

            For i As Short = 0 To -518 Step -44
                _IMSS_SLIDE_PANEL.Location = New Point(_IMSS_SLIDE_PANEL.Location.X, i)
                Application.DoEvents()
            Next i : _IMSS_SLIDE_PANEL.Location = New Point(0, -518)
        End If
    End Sub

    Private Sub _IMSS_SELECTBACKUPFILE_PICTUREBOX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_SELECTBACKUPFILE_PICTUREBOX.Click
        _IMSS_SELECT_LABEL_Click(Nothing, Nothing)
    End Sub

    Private Sub _IMSS_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Cancel.Click
        _IMSS_TREEVIEW.Nodes.Clear()
        _IMSS_LOADING_PROGRESS.Visible = False
        _IMSS_LOADING_PROGRESS.Value = 0
        _IMSS_PROGRESS_BAR.Value = 0
        _IMSS_SLIDE_PANEL.Location = New Point(0, 0)
    End Sub


    Private Sub _IMSS_LOAD_BACKUP_FILE()

        Dim _IMSS_TEXT_CONTINER As New TextBox
        _IMSS_TEXT_CONTINER.Text = IO.File.ReadAllText(_IMSS_SELECTFILE_DIALOG.FileName)

        _IMSS_LOADING_PROGRESS.Maximum = _IMSS_TEXT_CONTINER.Lines.Length()

        Dim _IMSS_DICTONRY As New Dictionary(Of String, String)

        For Each _IMSS_TEXT_LINE As String In _IMSS_TEXT_CONTINER.Lines

            _IMSS_LOADING_PROGRESS.Value += 1

            Application.DoEvents()

            Dim _IMSS_LIST_TARGETS() As String = _IMSS_TEXT_LINE.Split("|")



            If _IMSS_LIST_TARGETS(0).Length > 0 Then

                If Not _IMSS_DICTONRY.ContainsKey(_IMSS_LIST_TARGETS(0)) Then
                    _IMSS_DICTONRY.Add(_IMSS_LIST_TARGETS(0), _IMSS_LIST_TARGETS(1))
                Else
                    If Not _IMSS_DICTONRY.Item(_IMSS_LIST_TARGETS(0)).Contains(_IMSS_LIST_TARGETS(1)) Then
                        _IMSS_DICTONRY.Item(_IMSS_LIST_TARGETS(0)) += "|" & _IMSS_LIST_TARGETS(1)
                    End If
                End If


            End If



        Next _IMSS_TEXT_LINE

        For Each _IMSS_MAIN_KEY In _IMSS_DICTONRY
            With _IMSS_TREEVIEW.Nodes
                With .Add(_IMSS_MAIN_KEY.Key)
                    .ImageIndex = 0
                    .Checked = True

                    Dim _IMSS_MAIN_SUB_ITEMS() As String = _IMSS_MAIN_KEY.Value.Split("|")

                    For Each _IMSS_ITEM As String In _IMSS_MAIN_SUB_ITEMS
                        With .Nodes.Add(_IMSS_ITEM)
                            .ImageIndex = 1
                            .Checked = True
                        End With
                    Next _IMSS_ITEM

                End With

            End With

        Next _IMSS_MAIN_KEY

        For Each _IMSS_TEXT_LINE As String In _IMSS_TEXT_CONTINER.Lines

            Dim _IMSS_LIST_TARGETS() As String = _IMSS_TEXT_LINE.Split("|")

            For Each _IMSS_MAIN_NODE As TreeNode In _IMSS_TREEVIEW.Nodes

                If _IMSS_MAIN_NODE.Text = _IMSS_LIST_TARGETS(0) Then

                    For Each _IMSS_MAIN_SUB_NODE As TreeNode In _IMSS_MAIN_NODE.Nodes

                        If _IMSS_MAIN_SUB_NODE.Text = _IMSS_LIST_TARGETS(1) Then
                            With _IMSS_MAIN_SUB_NODE.Nodes.Add(_IMSS_LIST_TARGETS(2).Replace("[WINDOWS]", Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 2) & "\Windows"))
                                .Tag = _IMSS_CURRENT_BACKUP_DIRECTORY_LOCATION & "\" & _IMSS_LIST_TARGETS(0) & "\" & _IMSS_LIST_TARGETS(1) & "\" & _IMSS_LIST_TARGETS(2).Split("\")(UBound(_IMSS_LIST_TARGETS(2).Split("\")))
                                .ImageIndex = 2
                                .Checked = True
                            End With
                        End If
                    Next _IMSS_MAIN_SUB_NODE


                End If

            Next _IMSS_MAIN_NODE

        Next _IMSS_TEXT_LINE

        For Each _IMSS_MAIN_NODE As TreeNode In _IMSS_TREEVIEW.Nodes
            _IMSS_MAIN_NODE.Expand()
        Next _IMSS_MAIN_NODE

        _IMSS_TREEVIEW.Nodes(0).EnsureVisible()

    End Sub

    Private Sub _IMSS_Backup_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Backup_Button.Click
        Dim _IMSS_TOTAL_NUMBE_OFMAIN_NODES As Short = 0
        For Each _IMSS_MAIN_ITEM As TreeNode In _IMSS_TREEVIEW.Nodes
            _IMSS_TOTAL_NUMBE_OFMAIN_NODES += 1
            If Not _IMSS_MAIN_ITEM.Checked = True Then
                _IMSS_MAIN_ITEM.Remove()
            Else
                For Each _IMSS_SUB_ITEM As TreeNode In _IMSS_MAIN_ITEM.Nodes
                    If Not _IMSS_SUB_ITEM.Checked = True Then
                        _IMSS_SUB_ITEM.Remove()
                    Else
                        For Each _IMSS_SUB_FILE_ITEM As TreeNode In _IMSS_SUB_ITEM.Nodes
                            If Not _IMSS_SUB_FILE_ITEM.Checked = True Then
                                _IMSS_SUB_FILE_ITEM.Remove()
                            End If
                        Next _IMSS_SUB_FILE_ITEM
                    End If
                Next _IMSS_SUB_ITEM
            End If
        Next _IMSS_MAIN_ITEM

        _IMSS_TREEVIEW.BeginUpdate()
        _IMSS_TREEVIEW.CheckBoxes = False
        For Each _IMSS_MAIN_NODE As TreeNode In _IMSS_TREEVIEW.Nodes
            If Not _IMSS_MAIN_NODE.Nodes.Count > 0 Then
                _IMSS_MAIN_NODE.Remove()
            Else
                _IMSS_MAIN_NODE.Expand()
            End If
        Next _IMSS_MAIN_NODE
        _IMSS_TREEVIEW.Nodes(0).EnsureVisible()
        _IMSS_TREEVIEW.EndUpdate()

        _IMSS_PROGRESS_BAR.Maximum = _IMSS_TOTAL_NUMBE_OFMAIN_NODES

        For Each _IMSS_MAIN_NODE As TreeNode In _IMSS_TREEVIEW.Nodes
            _IMSS_PROGRESS_BAR.Value += 1
            _IMSS_MAIN_NODE.BackColor = Color.LightSkyBlue

            For Each _IMSS_MAIN_SUB_NODE As TreeNode In _IMSS_MAIN_NODE.Nodes
                For Each _IMSS_MAIN_SUB_FILE_NODE As TreeNode In _IMSS_MAIN_SUB_NODE.Nodes
                    Try
                        If Not IO.File.Exists(_IMSS_MAIN_SUB_FILE_NODE.Text) = True Then
                            IO.File.Copy(_IMSS_MAIN_SUB_NODE.Tag.ToString(), _IMSS_MAIN_SUB_NODE.Text)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Next _IMSS_MAIN_SUB_FILE_NODE
            Next _IMSS_MAIN_SUB_NODE
        Next _IMSS_MAIN_NODE

        MessageBox.Show("All selected devices drivers has been restored successfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        _IMSS_Cancel.PerformClick()

    End Sub
End Class
