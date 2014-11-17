Public Class Default_Vb


' #region radscheduleview-localization_1
LocalizationManager.Manager = New CustomLocalizationManager()
' #endregion

' #region radscheduleview-localization_3
LocalizationManager.Manager = New LocalizationManager()
LocalizationManager.Manager.ResourceManager = ScheduleViewResources.ResourceManager
' #endregion

' #region radscheduleview-localization_5
Public Class CustomLocalizationManager
    Inherits LocalizationManager
    Public Overloads Overrides Function GetStringOverride(ByVal key As String) As String
        Select Case key
            Case "Timeline"
                Return "Zeitline"
            Case "Day"
                Return "Tag"
            Case "Week"
                Return "Woche"
            Case "Month"
                Return "Monat"
            Case "SaveAndCloseCommandText"
                Return "Speichern & Sliessen"
            Case "EditRecurrence"
                Return "Serie bearbeithen"
            Case "Categories"
                Return "Kategrisieren"
        End Select
        Return MyBase.GetStringOverride(key)
    End Function
End Class
' #endregion

' #region radscheduleview-localization_7
Public Overloads Overrides Function GetStringOverride(ByVal key As String) As String
    Select Case key
        '----------------------
        Case "Timeline"
            Return ScheduleViewResources.Timeline
        '----------------------
    End Select
    Return MyBase.GetStringOverride(key)
End Function
' #endregion
End Class
