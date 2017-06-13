<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_MAIN_TAP_CONTROl = New DevComponents.DotNetBar.SuperTabControl()
        Me._IMSS_MANAGEDRIVERS_PANEL = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_DriverManage_Tap = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_BACKUPMAIN_PANEL = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMS_DriverBackup_Tap = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_RESTORBACKUP_PANEL = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me._IMSS_DriverRestore_Tap = New DevComponents.DotNetBar.SuperTabItem()
        Me._IMSS_MainPanel.SuspendLayout()
        CType(Me._IMSS_MAIN_TAP_CONTROl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_MAIN_TAP_CONTROl.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_MAIN_TAP_CONTROl)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(690, 529)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        '_IMSS_MAIN_TAP_CONTROl
        '
        '
        '
        '
        '
        '
        '
        Me._IMSS_MAIN_TAP_CONTROl.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me._IMSS_MAIN_TAP_CONTROl.ControlBox.MenuBox.Name = ""
        Me._IMSS_MAIN_TAP_CONTROl.ControlBox.Name = ""
        Me._IMSS_MAIN_TAP_CONTROl.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_MAIN_TAP_CONTROl.ControlBox.MenuBox, Me._IMSS_MAIN_TAP_CONTROl.ControlBox.CloseBox})
        Me._IMSS_MAIN_TAP_CONTROl.Controls.Add(Me._IMSS_MANAGEDRIVERS_PANEL)
        Me._IMSS_MAIN_TAP_CONTROl.Controls.Add(Me._IMSS_BACKUPMAIN_PANEL)
        Me._IMSS_MAIN_TAP_CONTROl.Controls.Add(Me._IMSS_RESTORBACKUP_PANEL)
        Me._IMSS_MAIN_TAP_CONTROl.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MAIN_TAP_CONTROl.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MAIN_TAP_CONTROl.Name = "_IMSS_MAIN_TAP_CONTROl"
        Me._IMSS_MAIN_TAP_CONTROl.ReorderTabsEnabled = True
        Me._IMSS_MAIN_TAP_CONTROl.SelectedTabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_MAIN_TAP_CONTROl.SelectedTabIndex = 1
        Me._IMSS_MAIN_TAP_CONTROl.Size = New System.Drawing.Size(690, 529)
        Me._IMSS_MAIN_TAP_CONTROl.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
        Me._IMSS_MAIN_TAP_CONTROl.TabFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me._IMSS_MAIN_TAP_CONTROl.TabIndex = 1
        Me._IMSS_MAIN_TAP_CONTROl.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me._IMSS_DriverManage_Tap, Me._IMS_DriverBackup_Tap, Me._IMSS_DriverRestore_Tap})
        Me._IMSS_MAIN_TAP_CONTROl.TabVerticalSpacing = 6
        '
        '_IMSS_MANAGEDRIVERS_PANEL
        '
        Me._IMSS_MANAGEDRIVERS_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MANAGEDRIVERS_PANEL.Location = New System.Drawing.Point(131, 0)
        Me._IMSS_MANAGEDRIVERS_PANEL.Name = "_IMSS_MANAGEDRIVERS_PANEL"
        Me._IMSS_MANAGEDRIVERS_PANEL.Size = New System.Drawing.Size(559, 529)
        Me._IMSS_MANAGEDRIVERS_PANEL.TabIndex = 1
        Me._IMSS_MANAGEDRIVERS_PANEL.TabItem = Me._IMSS_DriverManage_Tap
        '
        '_IMSS_DriverManage_Tap
        '
        Me._IMSS_DriverManage_Tap.AttachedControl = Me._IMSS_MANAGEDRIVERS_PANEL
        Me._IMSS_DriverManage_Tap.GlobalItem = False
        Me._IMSS_DriverManage_Tap.Image = CType(resources.GetObject("_IMSS_DriverManage_Tap.Image"), System.Drawing.Image)
        Me._IMSS_DriverManage_Tap.Name = "_IMSS_DriverManage_Tap"
        Me._IMSS_DriverManage_Tap.Text = "Manage drivers"
        '
        '_IMSS_BACKUPMAIN_PANEL
        '
        Me._IMSS_BACKUPMAIN_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_BACKUPMAIN_PANEL.Location = New System.Drawing.Point(131, 0)
        Me._IMSS_BACKUPMAIN_PANEL.Name = "_IMSS_BACKUPMAIN_PANEL"
        Me._IMSS_BACKUPMAIN_PANEL.Size = New System.Drawing.Size(559, 529)
        Me._IMSS_BACKUPMAIN_PANEL.TabIndex = 0
        Me._IMSS_BACKUPMAIN_PANEL.TabItem = Me._IMS_DriverBackup_Tap
        '
        '_IMS_DriverBackup_Tap
        '
        Me._IMS_DriverBackup_Tap.AttachedControl = Me._IMSS_BACKUPMAIN_PANEL
        Me._IMS_DriverBackup_Tap.GlobalItem = False
        Me._IMS_DriverBackup_Tap.Image = CType(resources.GetObject("_IMS_DriverBackup_Tap.Image"), System.Drawing.Image)
        Me._IMS_DriverBackup_Tap.Name = "_IMS_DriverBackup_Tap"
        Me._IMS_DriverBackup_Tap.Text = "Backup drivers"
        '
        '_IMSS_RESTORBACKUP_PANEL
        '
        Me._IMSS_RESTORBACKUP_PANEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_RESTORBACKUP_PANEL.Location = New System.Drawing.Point(131, 0)
        Me._IMSS_RESTORBACKUP_PANEL.Name = "_IMSS_RESTORBACKUP_PANEL"
        Me._IMSS_RESTORBACKUP_PANEL.Size = New System.Drawing.Size(559, 529)
        Me._IMSS_RESTORBACKUP_PANEL.TabIndex = 0
        Me._IMSS_RESTORBACKUP_PANEL.TabItem = Me._IMSS_DriverRestore_Tap
        '
        '_IMSS_DriverRestore_Tap
        '
        Me._IMSS_DriverRestore_Tap.AttachedControl = Me._IMSS_RESTORBACKUP_PANEL
        Me._IMSS_DriverRestore_Tap.GlobalItem = False
        Me._IMSS_DriverRestore_Tap.Image = CType(resources.GetObject("_IMSS_DriverRestore_Tap.Image"), System.Drawing.Image)
        Me._IMSS_DriverRestore_Tap.Name = "_IMSS_DriverRestore_Tap"
        Me._IMSS_DriverRestore_Tap.Text = "Restore drivers"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 529)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(706, 567)
        Me.MinimumSize = New System.Drawing.Size(706, 567)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Device Driver Manager"
        Me._IMSS_MainPanel.ResumeLayout(False)
        CType(Me._IMSS_MAIN_TAP_CONTROl, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_MAIN_TAP_CONTROl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_MAIN_TAP_CONTROl As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents _IMSS_MANAGEDRIVERS_PANEL As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_DriverManage_Tap As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_RESTORBACKUP_PANEL As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMSS_DriverRestore_Tap As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents _IMSS_BACKUPMAIN_PANEL As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents _IMS_DriverBackup_Tap As DevComponents.DotNetBar.SuperTabItem

End Class
