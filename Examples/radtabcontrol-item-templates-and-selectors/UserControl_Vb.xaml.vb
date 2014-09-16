Public Class Default_Vb


' #region radtabcontrol-item-templates-and-selectors_6
Public Class ContentSelector 
    Inherits Telerik.Windows.Controls.DataTemplateSelector
End Class
' #endregion

' #region radtabcontrol-item-templates-and-selectors_8
Public Class ContentSelector Inherits Telerik.Windows.Controls.DataTemplateSelector
    Public Overloads Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
        If DirectCast(item, LifeForm).Type = LifeFormTypes.Animal Then
            Return TryCast(Application.Current.Resources("AnimalDataTemplate"), DataTemplate)
        Else
            Return TryCast(Application.Current.Resources("PlantDataTemplate"), DataTemplate)
        End If
    End Function
End Class
' #endregion
End Class
