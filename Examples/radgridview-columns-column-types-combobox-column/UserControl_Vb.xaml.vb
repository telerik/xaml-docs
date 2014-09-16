Public Class Default_Vb


' #region radgridview-columns-column-types-combobox-column_2
Dim column As New GridViewComboBoxColumn()
Me.radGridView.Columns.Add( column )
' #endregion

' #region radgridview-columns-column-types-combobox-column_5
column.DataMemberBinding = New Binding("CountryId")
column.UniqueName = "Country"
' #endregion

' #region radgridview-columns-column-types-combobox-column_7
DirectCast(Me.radGridView.Columns("Country"), GridViewComboBoxColumn).ItemsSource = RadGridViewSampleData.GetCountries()
' #endregion

' #region radgridview-columns-column-types-combobox-column_10
column.SelectedValueMemberPath = "Id"
column.DisplayMemberPath = "Name"
' #endregion
End Class
