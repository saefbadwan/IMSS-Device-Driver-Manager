<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_BACKUPDRIVERS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMSS_BACKUPDRIVERS))
        Me._IMSS_Refresh = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_TREEVIEW = New System.Windows.Forms.TreeView()
        Me._IMSS_MAIN_IMAGE_LIST = New System.Windows.Forms.ImageList(Me.components)
        Me._IMSS_Backup_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_PROGRESS_BAR = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        '_IMSS_Refresh
        '
        Me._IMSS_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Refresh.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Refresh.Location = New System.Drawing.Point(370, 490)
        Me._IMSS_Refresh.Name = "_IMSS_Refresh"
        Me._IMSS_Refresh.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_Refresh.Size = New System.Drawing.Size(85, 26)
        Me._IMSS_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Refresh.TabIndex = 8
        Me._IMSS_Refresh.Text = "Refresh"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelX1.Location = New System.Drawing.Point(12, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(532, 23)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "This is a list of the installed drivers on your computer, you can click on the ba" & _
            "ckup button to backup drivers..."
        '
        '_IMSS_TREEVIEW
        '
        Me._IMSS_TREEVIEW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_TREEVIEW.CheckBoxes = True
        Me._IMSS_TREEVIEW.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_TREEVIEW.ImageIndex = 0
        Me._IMSS_TREEVIEW.ImageList = Me._IMSS_MAIN_IMAGE_LIST
        Me._IMSS_TREEVIEW.Location = New System.Drawing.Point(12, 32)
        Me._IMSS_TREEVIEW.Name = "_IMSS_TREEVIEW"
        Me._IMSS_TREEVIEW.SelectedImageIndex = 0
        Me._IMSS_TREEVIEW.ShowLines = False
        Me._IMSS_TREEVIEW.Size = New System.Drawing.Size(534, 445)
        Me._IMSS_TREEVIEW.TabIndex = 6
        '
        '_IMSS_MAIN_IMAGE_LIST
        '
        Me._IMSS_MAIN_IMAGE_LIST.ImageStream = CType(resources.GetObject("_IMSS_MAIN_IMAGE_LIST.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._IMSS_MAIN_IMAGE_LIST.TransparentColor = System.Drawing.Color.Transparent
        Me._IMSS_MAIN_IMAGE_LIST.Images.SetKeyName(0, "_IMSS_MAIN_DRIVE_Icon_16x16.png")
        Me._IMSS_MAIN_IMAGE_LIST.Images.SetKeyName(1, "_IMSS_SUB_DRIVE_Icon_16x16.png")
        '
        '_IMSS_Backup_Button
        '
        Me._IMSS_Backup_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_Backup_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Backup_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_Backup_Button.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Backup_Button.Location = New System.Drawing.Point(461, 490)
        Me._IMSS_Backup_Button.Name = "_IMSS_Backup_Button"
        Me._IMSS_Backup_Button.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4, 0, 0, 4)
        Me._IMSS_Backup_Button.Size = New System.Drawing.Size(85, 26)
        Me._IMSS_Backup_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_Backup_Button.TabIndex = 9
        Me._IMSS_Backup_Button.Text = "Backup..."
        '
        '_IMSS_PROGRESS_BAR
        '
        Me._IMSS_PROGRESS_BAR.Location = New System.Drawing.Point(12, 490)
        Me._IMSS_PROGRESS_BAR.Name = "_IMSS_PROGRESS_BAR"
        Me._IMSS_PROGRESS_BAR.Size = New System.Drawing.Size(352, 26)
        Me._IMSS_PROGRESS_BAR.TabIndex = 10
        Me._IMSS_PROGRESS_BAR.Visible = False
        '
        'IMSS_BACKUPDRIVERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_PROGRESS_BAR)
        Me.Controls.Add(Me._IMSS_Backup_Button)
        Me.Controls.Add(Me._IMSS_Refresh)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me._IMSS_TREEVIEW)
        Me.Name = "IMSS_BACKUPDRIVERS"
        Me.Size = New System.Drawing.Size(559, 529)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_Refresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_TREEVIEW As System.Windows.Forms.TreeView
    Friend WithEvents _IMSS_MAIN_IMAGE_LIST As System.Windows.Forms.ImageList
    Friend WithEvents _IMSS_Backup_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_PROGRESS_BAR As System.Windows.Forms.ProgressBar

End Class
