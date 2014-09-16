Public Class Default_Vb


' #region gridview-localization-setting-default-startup-language3_2
Private Sub Application_Startup(ByVal sender As Object, ByVal e As StartupEventArgs)
     Thread.CurrentThread.CurrentCulture = New CultureInfo("es")
     Thread.CurrentThread.CurrentUICulture = New CultureInfo("es")
     Me.RootVisual = New MainPage()
End Sub
    ' #endregion
    ' #region gridview-localization-setting-default-startup-language3_4
   Public Sub New()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es")
    End Sub
    ' #endregion
End Class
