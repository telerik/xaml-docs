Public Class Default_Vb


	' #region radgridview-row-details-templateselector-0
	Public Class MyCustomRowDetailsTemplateSelector
		Inherits DataTemplateSelector

		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As System.Windows.DependencyObject) As System.Windows.DataTemplate
			If TypeOf item Is Club Then
				Dim club As Club = TryCast(item, Club)
				If club.StadiumCapacity > 50000 Then
					Return bigStadium
				Else
					Return smallStadium
				End If
			End If
			Return Nothing
		End Function
		Public Property bigStadium() As DataTemplate
		Public Property smallStadium() As DataTemplate
	End Class
	' #endregion
End Class
