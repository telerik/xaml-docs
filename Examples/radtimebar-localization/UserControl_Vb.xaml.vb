Public Class Default_Vb


' #region radtimebar-localization_1
LocalizationManager.Manager = New LocalizationManager()
LocalizationManager.Manager.ResourceManager = ScheduleViewResources.ResourceManager
' #endregion

' #region radtimebar-localization_3
Dim culture As New CultureInfo("de")
System.Threading.Thread.CurrentThread.CurrentCulture = culture
System.Threading.Thread.CurrentThread.CurrentUICulture = culture
' #endregion

' #region radtimebar-localization_5
Friend Class CustomLocalizationManager Inherits LocalizationManager
Public Overrides Function GetStringOverride(ByVal key As String) As String
   Select Case key
          Case "Day"
               Return "Tag"
          Case "Week"
               Return "Woche"
          Case "Month"
               Return "Monat"
          Case "Quarter"
               Return "Quartal"
    End Select
Return MyBase.GetStringOverride(key)
End Function
End Class
' #endregion

' #region radtimebar-localization_7
LocalizationManager.Manager = New CustomLocalizationManager()
' #endregion

' #region radtimebar-localization_9
Public Sub New()
   System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("de")
   System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("de")
   Me.Startup += Me.Application_Startup
   Me.Exit += Me.Application_Exit
   Me.UnhandledException += Me.Application_UnhandledException
   InitializeComponent()
End Sub
' #endregion
End Class
