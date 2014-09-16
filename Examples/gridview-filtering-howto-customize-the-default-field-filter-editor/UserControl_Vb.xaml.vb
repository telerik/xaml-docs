Public Class Default_Vb

' #region gridview-filtering-howto-customize-the-default-field-filter-editor_0
Private Sub OnRadGridViewFieldFilterEditorCreated(sender As System.Object, e As Telerik.Windows.Controls.GridView.EditorCreatedEventArgs)
	If e.Column.UniqueName = "HireDate" Then
		Dim picker As Telerik.Windows.Controls.RadDateTimePicker = TryCast(e.Editor, Telerik.Windows.Controls.RadDateTimePicker)
		If picker IsNot Nothing Then
			picker.InputMode = Telerik.Windows.Controls.InputMode.DateTimePicker
		End If
	End If
End Sub
' #endregion

End Class
