Public Class Default_Vb

    ' #region radpropertygrid-scrolling_0
    Me.PropertyGrid1.Item = New Employee() With { _
	Key .FirstName = "Sarah", _
	Key .LastName = "Blake", _
	Key .Ocupation = "Supplied Manager", _
	Key .IsMarried = True, _
	Key .Salary = 3500 _
}
    ' #endregion

    ' #region radpropertygrid-scrolling_1
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs)
        Dim propertyDefinition = Me.PropertyGrid1.PropertyDefinitions.Where(Function(x) x.DisplayName = "IsMarried").FirstOrDefault()
        If propertyDefinition IsNot Nothing Then
            PropertyGrid1.ScrollIntoViewAsync(propertyDefinition, New Action(Of PropertyGridField)(Function(f) InlineAssignHelper(f.IsSelected, True)))
        End If
    End Sub
    ' #endregion

End Class
