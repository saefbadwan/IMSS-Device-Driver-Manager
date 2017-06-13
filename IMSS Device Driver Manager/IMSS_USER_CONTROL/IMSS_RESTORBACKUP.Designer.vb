<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_RESTORBACKUP
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_RESTORBACKUP))
        Me._IMSS_SLIDE_PANEL = New System.Windows.Forms.Panel()
        Me._IMSS_LOADING_PROGRESS = New System.Windows.Forms.ProgressBar()
        Me._IMSS_PROGRESS_BAR = New System.Windows.Forms.ProgressBar()
        Me._IMSS_Backup_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Cancel = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_TREEVIEW = New System.Windows.Forms.TreeView()
        Me._IMSS_MAIN_IMAGE_LIST = New System.Windows.Forms.ImageList(Me.components)
        Me._IMSS_SELECT_LABEL = New System.Windows.Forms.Label()
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX = New System.Windows.Forms.PictureBox()
        Me._IMSS_RESTORDESCRIPTION_LABEL = New System.Windows.Forms.Label()
        Me._IMSS_SELECTFILE_DIALOG = New System.Windows.Forms.OpenFileDialog()
        Me._IMSS_SLIDE_PANEL.SuspendLayout()
        CType(Me._IMSS_SELECTBACKUPFILE_PICTUREBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_SLIDE_PANEL
        '
        Me._IMSS_SLIDE_PANEL.Controls.Add(Me._IMSS_LOADING_PROGRESS)
        Me._IMSS_SLIDE_PANEL.Controls.Add(Me._IMSS_PROGRESS_BAR)
        Me._IMSS_SLIDE_PANEL.Controls.Add(Me._IMSS_Backup_Button)
        Me._IMSS_SLIDE_PANEL.Controls.Add(Me._IMSS_Cancel)
        Me._IMSS_SLIDE_PANEL.Controls.Add(Me.LabelX1)
        Me._IMSS_SLIDE_PANEL.Controls.Add(Me._IMSS_TREEVIEW)
        Me._IMSS_SLIDE_PANEL.Controls.Add(Me._IMSS_SELECT_LABEL)
        Me._IMSS_SLIDE_PANEL.Controls.Add(Me._IMSS_SELECTBACKUPFILE_PICTUREBOX)
        Me._IMSS_SLIDE_PANEL.Controls.Add(Me._IMSS_RESTORDESCRIPTION_LABEL)
        Me._IMSS_SLIDE_PANEL.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_SLIDE_PANEL.Name = "_IMSS_SLIDE_PANEL"
        Me._IMSS_SLIDE_PANEL.Size = New System.Drawing.Size(559, 1080)
        Me._IMSS_SLIDE_PANEL.TabIndex = 0
        '
        '_IMSS_LOADING_PROGRESS
        '
        Me._IMSS_LOADING_PROGRESS.Location = New System.Drawing.Point(53, 435)
        Me._IMSS_LOADING_PROGRESS.Name = "_IMSS_LOADING_PROGRESS"
        Me._IMSS_LOADING_PROGRESS.Size = New System.Drawing.Size(452, 23)
        Me._IMSS_LOADING_PROGRESS.TabIndex = 16
        Me._IMSS_LOADING_PROGRESS.Visible = False
        '
        '_IMSS_PROGRESS_BAR
        '
        Me._IMSS_PROGRESS_BAR.Location = New System.Drawing.Point(12, 1013)
        Me._IMSS_PROGRESS_BAR.Name = "_IMSS_PROGRESS_BAR"
        Me._IMSS_PROGRESS_BAR.Size = New System.Drawing.Size(352, 26)
        Me._IMSS_PROGRESS_BAR.TabIndex = 15
        Me._IMSS_PROGRESS_BAR.Visible = False
        '
        '_IMSS_Backup_Button
        '
        Me._IMSS_Backup_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Backup_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Backup_Button.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Backup_Button.Location = New System.Drawing.Point(461, 1013)
        Me._IMSS_Backup_Button.Name = "_IMSS_Backup_Button"
        Me._IMSS_Backup_Button.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_Backup_Button.Size = New System.Drawing.Size(85, 26)
        Me._IMSS_Backup_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Backup_Button.TabIndex = 14
        Me._IMSS_Backup_Button.Text = "Restore..."
        '
        '_IMSS_Cancel
        '
        Me._IMSS_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Cancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Cancel.Location = New System.Drawing.Point(370, 1013)
        Me._IMSS_Cancel.Name = "_IMSS_Cancel"
        Me._IMSS_Cancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_Cancel.Size = New System.Drawing.Size(85, 26)
        Me._IMSS_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Cancel.TabIndex = 13
        Me._IMSS_Cancel.Text = "Cancel"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX1.Location = New System.Drawing.Point(12, 532)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(532, 23)
        Me.LabelX1.TabIndex = 12
        Me.LabelX1.Text = "This is a list of backed up drivers you can choose what to restore by selecting t" & _
            "he item..."
        '
        '_IMSS_TREEVIEW
        '
        Me._IMSS_TREEVIEW.CheckBoxes = True
        Me._IMSS_TREEVIEW.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_TREEVIEW.ImageIndex = 0
        Me._IMSS_TREEVIEW.ImageList = Me._IMSS_MAIN_IMAGE_LIST
        Me._IMSS_TREEVIEW.Location = New System.Drawing.Point(12, 561)
        Me._IMSS_TREEVIEW.Name = "_IMSS_TREEVIEW"
        Me._IMSS_TREEVIEW.SelectedImageIndex = 0
        Me._IMSS_TREEVIEW.ShowLines = False
        Me._IMSS_TREEVIEW.Size = New System.Drawing.Size(534, 445)
        Me._IMSS_TREEVIEW.TabIndex = 11
        '
        '_IMSS_MAIN_IMAGE_LIST
        '
        Me._IMSS_MAIN_IMAGE_LIST.ImageStream = CType(resources.GetObject("_IMSS_MAIN_IMAGE_LIST.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_MAIN_IMAGE_LIST.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_MAIN_IMAGE_LIST.Images.SetKeyName(0, "_IMSS_MAIN_DRIVE_Icon_16x16.png")
        Me._IMSS_MAIN_IMAGE_LIST.Images.SetKeyName(1, "_IMSS_SUB_DRIVE_Icon_16x16.png")
        Me._IMSS_MAIN_IMAGE_LIST.Images.SetKeyName(2, "_IMSS_INIFile_Icon_16x16.png")
        '
        '_IMSS_SELECT_LABEL
        '
        Me._IMSS_SELECT_LABEL.AutoSize = True
        Me._IMSS_SELECT_LABEL.Font = New System.Drawing.Font("Berlin Sans FB Demi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_SELECT_LABEL.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me._IMSS_SELECT_LABEL.Location = New System.Drawing.Point(214, 284)
        Me._IMSS_SELECT_LABEL.MaximumSize = New System.Drawing.Size(132, 16)
        Me._IMSS_SELECT_LABEL.MinimumSize = New System.Drawing.Size(132, 16)
        Me._IMSS_SELECT_LABEL.Name = "_IMSS_SELECT_LABEL"
        Me._IMSS_SELECT_LABEL.Size = New System.Drawing.Size(132, 16)
        Me._IMSS_SELECT_LABEL.TabIndex = 4
        Me._IMSS_SELECT_LABEL.Text = "Select a backup file..."
        '
        '_IMSS_SELECTBACKUPFILE_PICTUREBOX
        '
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Image = Global.IMSS_Device_Driver_Manager.My.Resources.Resources._IMSS_SELECBACKUPFILE_Icon_256x256
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Location = New System.Drawing.Point(151, 136)
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Name = "_IMSS_SELECTBACKUPFILE_PICTUREBOX"
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.Size = New System.Drawing.Size(256, 256)
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.TabIndex = 3
        Me._IMSS_SELECTBACKUPFILE_PICTUREBOX.TabStop = False
        '
        '_IMSS_RESTORDESCRIPTION_LABEL
        '
        Me._IMSS_RESTORDESCRIPTION_LABEL.AutoSize = True
        Me._IMSS_RESTORDESCRIPTION_LABEL.Location = New System.Drawing.Point(4, 13)
        Me._IMSS_RESTORDESCRIPTION_LABEL.Name = "_IMSS_RESTORDESCRIPTION_LABEL"
        Me._IMSS_RESTORDESCRIPTION_LABEL.Size = New System.Drawing.Size(523, 26)
        Me._IMSS_RESTORDESCRIPTION_LABEL.TabIndex = 1
        Me._IMSS_RESTORDESCRIPTION_LABEL.Text = "  Welcome to the restore devices drivers section, you can restore all backup driv" & _
            "es by clicking on the button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  below and select your drivers backup file..."
        '
        '_IMSS_SELECTFILE_DIALOG
        '
        Me._IMSS_SELECTFILE_DIALOG.FileName = "Select a backup file ..."
        Me._IMSS_SELECTFILE_DIALOG.Filter = "IMSS Backup(*.IMSSDATA)|*.IMSSDATA"
        '
        'IMSS_RESTORBACKUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_SLIDE_PANEL)
        Me.Name = "IMSS_RESTORBACKUP"
        Me.Size = New System.Drawing.Size(559, 1080)
        Me._IMSS_SLIDE_PANEL.ResumeLayout(False)
        Me._IMSS_SLIDE_PANEL.PerformLayout()
        CType(Me._IMSS_SELECTBACKUPFILE_PICTUREBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_SLIDE_PANEL As System.Windows.Forms.Panel
    Friend WithEvents _IMSS_RESTORDESCRIPTION_LABEL As System.Windows.Forms.Label
    Friend WithEvents _IMSS_SELECTBACKUPFILE_PICTUREBOX As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_SELECT_LABEL As System.Windows.Forms.Label
    Friend WithEvents _IMSS_SELECTFILE_DIALOG As System.Windows.Forms.OpenFileDialog
    Friend WithEvents _IMSS_PROGRESS_BAR As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_Backup_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_Cancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_TREEVIEW As System.Windows.Forms.TreeView
    Friend WithEvents _IMSS_LOADING_PROGRESS As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_MAIN_IMAGE_LIST As System.Windows.Forms.ImageList

End Class
