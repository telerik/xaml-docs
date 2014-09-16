Public Class Default_Vb


' #region radribbonview-localization_1
LocalizationManager.Manager = New LocalizationManager()
LocalizationManager.Manager.ResourceManager = RibbonResources.ResourceManager
' #endregion

' #region radribbonview-localization_3
Public Class CustomLocalizationManager
    Inherits LocalizationManager
    Public Overloads Overrides Function GetStringOverride(ByVal key As String) As String
        Select Case key
				Case "RibbonViewQATMinimize"
					Return "Minimieren der Multifunktionsleiste"
				Case "RibbonViewQATCustomize"
					Return "Anpassen Sie die Symbolleiste"
				Case "RibbonViewQATShowBelow"
					Return "Zeigen unten die Multifunktionsleiste"
			End Select

        Return MyBase.GetStringOverride(key)
    End Function
End Class
' #endregion

' #region radribbonview-localization_5
Public Overloads Overrides Function GetStringOverride(ByVal key As String) As String
    Select Case key
        '----------------------
			Case "RibbonViewQATMinimize"
				Return RibbonBarResources.RibbonBarQATMinimize
				'----------------------
		End Select
    Return MyBase.GetStringOverride(key)
End Function
' #endregion
End Class
