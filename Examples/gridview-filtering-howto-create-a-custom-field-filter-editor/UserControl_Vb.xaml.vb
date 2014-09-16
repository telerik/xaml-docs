Public Class Default_Vb

' #region gridview-filtering-howto-create-a-custom-field-filter-editor_0
Public Class MyDateTimeColumn
	Inherits Telerik.Windows.Controls.GridViewDataColumn
	Public Overrides Function CreateFieldFilterEditor() As FrameworkElement
		Dim dateTimePicker As New Telerik.Windows.Controls.RadDateTimePicker()

		' This binding will transfer the significant property of your editor to the filtering view model.
		Dim selectedValueBinding As New Binding("Value")
		selectedValueBinding.Mode = BindingMode.TwoWay
		selectedValueBinding.FallbackValue = Nothing
		selectedValueBinding.Converter = New DateTimeFilterEditorConverter()

		dateTimePicker.SetBinding(Telerik.Windows.Controls.RadDateTimePicker.SelectedValueProperty, selectedValueBinding)

		Return dateTimePicker
	End Function

	Private Class DateTimeFilterEditorConverter
		Implements IValueConverter
		Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
			If [Object].Equals(value, Telerik.Windows.Data.FilterDescriptor.UnsetValue) Then
				' When the filter is turned off this is what your editor will get.
				Return Nothing
			End If

			Return value
		End Function

		Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			If value Is Nothing Then
				' When your editor want to turn off the filter this is what it should return.
				Return Telerik.Windows.Data.FilterDescriptor.UnsetValue
			End If

			Return value
		End Function

	End Class
End Class
' #endregion

End Class
