Public Class Default_Vb


	' #region radtabcontrol-templating-custom-header-template_1
	Public Class HeaderSelector
		Inherits Telerik.Windows.Controls.DataTemplateSelector
	End Class
	' #endregion

	' #region radtabcontrol-templating-custom-header-template_3
	Public Class HeaderSelector
		Inherits Telerik.Windows.Controls.DataTemplateSelector
		Public Overrides Function SelectTemplate(item As Object, container As DependencyObject) As DataTemplate
			If TypeOf item Is Animal Then
				Return TryCast(Application.Current.Resources("AnimalDataTemplate"), DataTemplate)
			Else
				Return TryCast(Application.Current.Resources("PlantDataTemplate"), DataTemplate)
			End If
		End Function
	End Class
	' #endregion
End Class
