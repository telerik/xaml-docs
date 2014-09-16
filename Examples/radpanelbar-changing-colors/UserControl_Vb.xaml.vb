Public Class Default_Vb

	'#region radpanelbar-changing-colors_1
	Dim myPanelBar As New RadPanelBar() With {
	 .Background = New SolidColorBrush(Color.FromArgb(&HFF, &HBA, &HDD, &H27))
	}
	'#endregion

	'#region radpanelbar-changing-colors_4
	myPanelBar.Foreground = New SolidColorBrush(Colors.Red)
	' #endregion

	' #region radpanelbar-changing-colors_7
	myPanelBar.BorderThickness = New Thickness(2)
	myPanelBar.BorderBrush = New SolidColorBrush(Colors.Red)
	' #endregion
End Class
