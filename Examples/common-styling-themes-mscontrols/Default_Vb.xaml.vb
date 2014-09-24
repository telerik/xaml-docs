Public Class Default_Vb


    ' #region common-styling-themes-mscontrols_3
    Public Sub New()
        Me.Startup += Me.Application_Startup
        Me.[Exit] += Me.Application_Exit
        Me.UnhandledException += Me.Application_UnhandledException
        StyleManager.ApplicationTheme = New Windows7Theme()
        InitializeComponent()
        StyleManager.SetBasedOn(DirectCast(Current.Resources(GetType(Button)), Style), StyleManager.ApplicationTheme)
    End Sub
' #endregion
End Class
