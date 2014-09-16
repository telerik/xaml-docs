Public Class Default_Vb


' #region common-localization_1
LocalizationManager.Manager = New CustomLocalizationManager()
' #endregion

' #region common-localization_3
LocalizationManager.Manager = New LocalizationManager()
LocalizationManager.Manager.ResourceManager = GridViewResources.ResourceManager
' #endregion

' #region common-localization_6
Public Class CustomLocalizationManager
 Inherits LocalizationManager
 Public Overrides Function GetStringOverride(key As String) As String
  Select Case key
   Case "GridViewGroupPanelText"
    Return "Zum gruppieren ziehen Sie den Spaltenkopf in diesen Bereich."
   '---------------------- RadGridView Filter Dropdown items texts:
   Case "GridViewClearFilter"
    Return "Filter löschen"
   Case "GridViewFilterShowRowsWithValueThat"
    Return "Anzeigen der Werte mit Bedingung:"
   Case "GridViewFilterSelectAll"
    Return "Alles anzeigen"
   Case "GridViewFilterContains"
    Return "Enthält"
   Case "GridViewFilterEndsWith"
    Return "Endet mit"
   Case "GridViewFilterIsContainedIn"
    Return "Enthalten in"
   Case "GridViewFilterIsEqualTo"
    Return "Gleich"
   Case "GridViewFilterIsGreaterThan"
    Return "Grösser als "
   Case "GridViewFilterIsGreaterThanOrEqualTo"
    Return "Grösser oder gleich"
   Case "GridViewFilterIsLessThan"
    Return "Kleiner als"
   Case "GridViewFilterIsLessThanOrEqualTo"
    Return "Kleiner oder gleich"
   Case "GridViewFilterIsNotEqualTo"
    Return "Ungleich"
   Case "GridViewFilterStartsWith"
    Return "Beginnt mit"
   Case "GridViewFilterAnd"
    Return "Und"
   Case "GridViewFilter"
    Return "Filter"
  End Select
  Return MyBase.GetStringOverride(key)
 End Function
End Class
' #endregion

' #region common-localization_8
Public Overloads Overrides Function GetStringOverride(ByVal key As String) As String
    Select Case key
        '----------------------
        Case "GridViewClearFilter"
            Return GridViewResources.GridViewClearFilter
        '----------------------
    End Select
    Return MyBase.GetStringOverride(key)
End Function
    ' #endregion
    ' #region common-localization_10
    Public Sub New()
        Thread.CurrentThread.CurrentCulture = New CultureInfo("de")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("de")
    End Sub
    ' #endregion
    ' #region common-localization_12    
    Private Sub Application_Startup(sender As Object, e As StartupEventArgs)
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("es")

        Me.RootVisual = New MainPage()
    End Sub
    ' #endregion
End Class
