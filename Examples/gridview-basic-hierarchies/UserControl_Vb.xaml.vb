Public Class Default_Vb


' #region gridview-basic-hierarchies_2
Dim d As New GridViewTableDefinition()
' #endregion

' #region gridview-basic-hierarchies_6
Dim d As New GridViewTableDefinition()
d.Relation = New Telerik.Windows.Data.PropertyRelation("Orders")
' #endregion

' #region gridview-basic-hierarchies_9
Me.radGridView.ChildTableDefinitions.Add(d)
' #endregion
End Class
