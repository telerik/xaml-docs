Public Class Default_Vb


' #region gridview-managing-data-editors_3
Dim editor As New CheckBoxEditorSettings()
DirectCast(Me.EditorsGrid.Columns("Shipped"), GridViewDataColumn).EditorSettings = editor
' #endregion

' #region gridview-managing-data-editors_6
Dim editor As New DatePickerEditorSettings()
DirectCast(Me.EditorsGrid.Columns("OrderDate"), GridViewDataColumn).EditorSettings = editor
' #endregion

' #region gridview-managing-data-editors_9
Dim editor As ComboBoxEditorSettings = TryCast(DirectCast(Me.EditorsGrid.Columns("Country"), GridViewComboBoxColumn).EditorSettings, ComboBoxEditorSettings)
editor.ItemsSource = RadGridViewSampleData.GetCountries()
' #endregion

' #region gridview-managing-data-editors_14
Dim editor As New TextBoxEditorSettings()
DirectCast(Me.EditorsGrid.Columns("OrederNo"), GridViewDataColumn).EditorSettings = editor
' #endregion
End Class
