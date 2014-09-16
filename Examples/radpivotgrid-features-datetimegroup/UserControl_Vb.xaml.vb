'#region radpivotgrid-features-datetimegroup_1
Dim dateTimeGroupDescription1 As New DateTimeGroupDescription()
dateTimeGroupDescription1.PropertyName = "Date"
dateTimeGroupDescription1.Step = DateTimeStep.Quarter
Dim dateTimeGroupDescription2 As New DateTimeGroupDescription()
dateTimeGroupDescription2.PropertyName = "Date"
dateTimeGroupDescription2.Step = DateTimeStep.Month
Dim propertyGroupDescription As New Telerik.Pivot.Core.PropertyGroupDescription()
propertyGroupDescription.PropertyName = "Date"

Dim dataProvider = New LocalDataSourceProvider()
dataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription1)
dataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription2)
dataProvider.RowGroupDescriptions.Add(propertyGroupDescription)
'#endregion

'#region radpivotgrid-features-datetimegroup_2
Dim dataProvider = New LocalDataSourceProvider()
dataProvider.ItemsSource = New Source()
Dim descriptionProvider = New LocalDataSourceFieldDescriptionsProvider()
descriptionProvider.AddingContainerNode += LocalDataSourceFieldDescriptionsProvider_ContainerNodeAdded
dataProvider.FieldDescriptionsProvider = descriptionProvider
'#endregion

'#region radpivotgrid-features-datetimegroup_3
Private Sub LocalDataSourceFieldDescriptionsProvider_ContainerNodeAdded(ByVal sender As Object, ByVal e As ContainerNodeEventArgs)
	'Use the name of the DateTime property, in our case it is Date
	If e.ContainerNode.Name = "Date" Then
		For Each containerNode In e.ContainerNode.Children
			Dim fin As FieldInfoNode = TryCast(containerNode, FieldInfoNode)
			If containerNode.Name = "Date.Hour" Then
				'Show Hour from the DateTime tree
				TryCast(fin.FieldInfo, PropertyFieldInfo).AutoGenerateField = True
			End If
		Next containerNode
	End If
End Sub
'#endregion

'#region radpivotgrid-features-datetimegroup_4
Private Sub LocalDataSourceFieldDescriptionsProvider_ContainerNodeAdded(ByVal sender As Object, ByVal e As ContainerNodeEventArgs)
	'Use the name of the DateTime property, in our case it is Date
	If e.ContainerNode.Name = "Date" Then
		For Each containerNode In e.ContainerNode.Children
			Dim fin As FieldInfoNode = TryCast(containerNode, FieldInfoNode)
			If containerNode.Name = "Date.Year" Then
				'Remove Year from the DateTime tree
				TryCast(fin.FieldInfo, PropertyFieldInfo).AutoGenerateField = False
			End If
		Next containerNode
	End If
End Sub
'#endregion

'#region radpivotgrid-features-datetimegroup_5
Private Sub LocalDataSourceFieldDescriptionsProvider_ContainerNodeAdded(ByVal sender As Object, ByVal e As ContainerNodeEventArgs)
	'Use the name of the DateTime property, in our case it is Date
	If e.ContainerNode.Name = "Date" Then
		e.Cancel = True
	End If
End Sub
'#endregion

'#region radpivotgrid-features-datetimegroup_6
Private Sub LocalDataSourceFieldDescriptionsProvider_ContainerNodeAdded(ByVal sender As Object, ByVal e As ContainerNodeEventArgs)
	'Use the name of the DateTime property, in our case it is Date
	If e.ContainerNode.Name = "Date" Then
		'Find the children Date.Month and show it.
		Dim fin As FieldInfoNode = TryCast(e.ContainerNode.Children.First(Function(cn) cn.Name = "Date.Month"), FieldInfoNode)
		e.ContainerNode = fin
	End If
End Sub
'#endregion