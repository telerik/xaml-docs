'#region "radpivotgrid-events-overview_1"
Private Sub OnPrepareDescriptionForField(ByVal sender As Object, ByVal e As Telerik.Pivot.Core.PrepareDescriptionForFieldEventArgs)
	' Get the current DoubleGroupDescription description.
	Dim doubleGroupDescription = TryCast(e.Description, DoubleGroupDescription)

	If e.DescriptionType = Telerik.Pivot.Core.DataProviderDescriptionType.Group AndAlso doubleGroupDescription IsNot Nothing Then
		' Replace it with PropertyGroupDescription.
		e.Description = New Telerik.Pivot.Core.PropertyGroupDescription() With {.PropertyName = doubleGroupDescription.PropertyName}
	End If
End Sub
'#endregion

'#region "radpivotgrid-events-overview_2"
Private Sub OnDataProviderStatusChanged(ByVal sender As Object, ByVal e As DataProviderStatusChangedEventArgs)
	If e.NewStatus = DataProviderStatus.Ready Then
		Dispatcher.BeginInvoke(New Action(Sub()
			' Execute custom logic here.
		End Sub))
	End If
End Sub
'#endregion

'#region "radpivotgrid-events-overview_3"
Private Sub OnGetDescriptionsDataAsyncCompleted(ByVal sender As Object, ByVal e As GetDescriptionsDataCompletedEventArgs)
	Dim rootItem = e.DescriptionsData.RootFieldInfo
	Dim allContainers = rootItem.Children.ToList()
	rootItem.Children.Clear()

	Dim firstFolder = New ContainerNode("First Folder", ContainerNodeRole.Folder)
	Dim secondFolder = New ContainerNode("Second Folder", ContainerNodeRole.Folder)

	For Each item In allContainers
		If item.Name = "Product" OrElse item.Name = "Quantity" Then
			firstFolder.Children.Add(item)
		ElseIf item.Name = "Net" OrElse item.Name = "Promotion" Then
			secondFolder.Children.Add(item)
		Else
			rootItem.Children.Add(item)
		End If
	Next item

	rootItem.Children.Add(firstFolder)
	rootItem.Children.Add(secondFolder)
End Sub
'#endregion