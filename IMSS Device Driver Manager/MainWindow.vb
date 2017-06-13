Public Class MainWindow
    Private _IMSS_MANGEDRIVERS_CONTROL As IMSS_MANGEDRIVERS = IMSS_MANGEDRIVERS._IMSS_CREATE_CONTROl()
    Private _IMSS_BACKUPDRIVER_CONTROL As IMSS_BACKUPDRIVERS = IMSS_BACKUPDRIVERS._IMSS_CREATE_CONTROl()
    Private _IMSS_RESTORBACKUP_CONTROL As IMSS_RESTORBACKUP = IMSS_RESTORBACKUP._IMSS_CREATE_CONTROl()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_SETUP_CONTROLS()
    End Sub


    Private Sub _IMSS_SETUP_CONTROLS()
        _IMSS_MAIN_TAP_CONTROl.SelectedTabIndex = 0
        _IMSS_MANAGEDRIVERS_PANEL.Controls.Add(_IMSS_MANGEDRIVERS_CONTROL)
        _IMSS_BACKUPMAIN_PANEL.Controls.Add(_IMSS_BACKUPDRIVER_CONTROL)
        _IMSS_RESTORBACKUP_PANEL.Controls.Add(_IMSS_RESTORBACKUP_CONTROL)
    End Sub

End Class
