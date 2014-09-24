Public Class Default_Vb


	' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox-0
	Imports Telerik.Windows.DragDrop
	Imports Telerik.Windows.Controls
	Imports Telerik.Windows.DragDrop.Behaviors
	Imports Telerik.Windows.Controls.TreeView

	Public Class ListBoxDragDropBehavior
		Private _associatedObject As System.Windows.Controls.ListBox
		''' <summary>
		''' object that will be associated with the ListBox instance that enables the behavior
		''' </summary>
		Public Property AssociatedObject() As System.Windows.Controls.ListBox
			Get
				Return _associatedObject
			End Get
			Set(value As System.Windows.Controls.ListBox)
				_associatedObject = value
			End Set
		End Property

		Private Shared instances As Dictionary(Of System.Windows.Controls.ListBox, ListBoxDragDropBehavior)

		Shared Sub New()
			instances = New Dictionary(Of System.Windows.Controls.ListBox, ListBoxDragDropBehavior)()
		End Sub

		Public Shared Function GetIsEnabled(obj As DependencyObject) As Boolean
			Return CBool(obj.GetValue(IsEnabledProperty))
		End Function

		Public Shared Sub SetIsEnabled(obj As DependencyObject, value As Boolean)
			Dim behavior As ListBoxDragDropBehavior = GetAttachedBehavior(TryCast(obj, System.Windows.Controls.ListBox))

			behavior.AssociatedObject = TryCast(obj, System.Windows.Controls.ListBox)

			If value Then
				behavior.Initialize()
			Else
				behavior.CleanUp()
			End If
			obj.SetValue(IsEnabledProperty, value)
		End Sub

		' Using a DependencyProperty as the backing store for IsEnabled state of the behavior
		Public Shared ReadOnly IsEnabledProperty As DependencyProperty = DependencyProperty.RegisterAttached("IsEnabled", GetType(Boolean), GetType(ListBoxDragDropBehavior), New PropertyMetadata(New PropertyChangedCallback(AddressOf OnIsEnabledPropertyChanged)))

		Public Shared Sub OnIsEnabledPropertyChanged(dependencyObject As DependencyObject, e As DependencyPropertyChangedEventArgs)
			SetIsEnabled(dependencyObject, CBool(e.NewValue))
		End Sub

		Private Shared Function GetAttachedBehavior(listBox As System.Windows.Controls.ListBox) As ListBoxDragDropBehavior
			If Not instances.ContainsKey(listBox) Then
				instances(listBox) = New ListBoxDragDropBehavior()
				instances(listBox).AssociatedObject = listBox
			End If

			Return instances(listBox)
		End Function

		'initializes the behavior by detaching from any existing DragDropManager event handlers and attaching new DragDropManager event handlers
		Protected Overridable Sub Initialize()
			Me.UnsubscribeFromDragDropEvents()
			Me.SubscribeToDragDropEvents()
		End Sub

		'cleans up after disabling the behavior by detaching from the DragDropManager event handlers
		Protected Overridable Sub CleanUp()
			Me.UnsubscribeFromDragDropEvents()
		End Sub

		'attaching new DragDropManager event handlers
		Private Sub SubscribeToDragDropEvents()

		End Sub

		'unsubscribing from the DragDropManager event handlers
		Private Sub UnsubscribeFromDragDropEvents()

		End Sub
	End Class
	' #endregion

	' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox-1
	'attaching new DragDropManager event handlers
	Private Sub SubscribeToDragDropEvents()
		DragDropManager.AddDragInitializeHandler(Me.AssociatedObject, AddressOf OnDragInitialize)
		DragDropManager.AddGiveFeedbackHandler(Me.AssociatedObject, AddressOf OnGiveFeedback)
		DragDropManager.AddDropHandler(Me.AssociatedObject, AddressOf OnDrop)
		DragDropManager.AddDragDropCompletedHandler(Me.AssociatedObject, AddressOf OnDragDropCompleted)
		DragDropManager.AddDragOverHandler(Me.AssociatedObject, AddressOf OnDragOver)
	End Sub

	'unsubscribing from the DragDropManager event handlers
	Private Sub UnsubscribeFromDragDropEvents()
		DragDropManager.RemoveDragInitializeHandler(Me.AssociatedObject, AddressOf OnDragInitialize)
		DragDropManager.RemoveGiveFeedbackHandler(Me.AssociatedObject, AddressOf OnGiveFeedback)
		DragDropManager.RemoveDropHandler(Me.AssociatedObject, AddressOf OnDrop)
		DragDropManager.RemoveDragDropCompletedHandler(Me.AssociatedObject, AddressOf OnDragDropCompleted)
		DragDropManager.RemoveDragOverHandler(Me.AssociatedObject, AddressOf OnDragOver)

	End Sub
	Private Sub OnDragInitialize(sender As Object, e As DragInitializeEventArgs)
	End Sub

	Private Sub OnGiveFeedback(sender As Object, e As Telerik.Windows.DragDrop.GiveFeedbackEventArgs)
	End Sub

	Private Sub OnDragDropCompleted(sender As Object, e As DragDropCompletedEventArgs)
	End Sub

	Private Sub OnDrop(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
	End Sub

	Private Sub OnDragOver(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
	End Sub
	' #endregion

	' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox-2
	Imports Telerik.Windows.Controls

	Public Class DropIndicationDetails
		Inherits ViewModelBase
		Private m_currentDraggedItem As Object
		Private m_currentDropPosition As DropPosition
		Private m_currentDraggedOverItem As Object

		Public Property CurrentDraggedOverItem() As Object
			Get
				Return m_currentDraggedOverItem
			End Get
			Set(value As Object)
				If Me.m_currentDraggedOverItem IsNot value Then
					m_currentDraggedOverItem = value
					OnPropertyChanged("CurrentDraggedOverItem")
				End If
			End Set
		End Property

		Public Property DropIndex() As Integer
			Get
				Return m_DropIndex
			End Get
			Set(value As Integer)
				m_DropIndex = Value
			End Set
		End Property
		Private m_DropIndex As Integer

		Public Property CurrentDropPosition() As DropPosition
			Get
				Return Me.m_currentDropPosition
			End Get
			Set(value As DropPosition)
				If Me.m_currentDropPosition <> value Then
					Me.m_currentDropPosition = value
					OnPropertyChanged("CurrentDropPosition")
				End If
			End Set
		End Property

		Public Property CurrentDraggedItem() As Object
			Get
				Return Me.m_currentDraggedItem
			End Get
			Set(value As Object)
				If Me.m_currentDraggedItem IsNot value Then
					Me.m_currentDraggedItem = value
					OnPropertyChanged("CurrentDraggedItem")
				End If
			End Set
		End Property
	End Class
	' #endregion

	' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox-3
	Private Sub OnDragInitialize(sender As Object, e As DragInitializeEventArgs)
		Dim details As New DropIndicationDetails()
		Dim listBoxItem = If(TryCast(e.OriginalSource, System.Windows.Controls.ListBoxItem), TryCast(e.OriginalSource, FrameworkElement).ParentOfType(Of System.Windows.Controls.ListBoxItem)())

		Dim item = If(listBoxItem IsNot Nothing, listBoxItem.DataContext, TryCast(sender, System.Windows.Controls.ListBox).SelectedItem)
		details.CurrentDraggedItem = item

		Dim dragPayload As IDragPayload = DragDropPayloadManager.GeneratePayload(Nothing)

		dragPayload.SetData("DraggedData", item)
		dragPayload.SetData("DropDetails", details)

		e.Data = dragPayload

		e.DragVisual = New DragVisual() With {
			.Content = details,
			.ContentTemplate = TryCast(Me.AssociatedObject.Resources("DraggedItemTemplate"), DataTemplate)
		}
		e.DragVisualOffset = e.RelativeStartPoint
		e.AllowedEffects = DragDropEffects.All
	End Sub
	' #endregion

	' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox-4
	Private Sub OnGiveFeedback(sender As Object, e As Telerik.Windows.DragDrop.GiveFeedbackEventArgs)
		e.SetCursor(Cursors.Arrow)
		e.Handled = True
	End Sub
	' #endregion

	' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox-5
	Private Sub OnDragOver(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
		Dim options As TreeViewDragDropOptions = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
		If options Is Nothing Then
			e.Effects = DragDropEffects.None
			e.Handled = True
			Return
		End If
		Dim draggedItem = options.DraggedItems.FirstOrDefault()
		Dim itemsType = TryCast(Me.AssociatedObject.ItemsSource, IList).AsQueryable().ElementType


		If draggedItem.[GetType]() <> itemsType Then
			e.Effects = DragDropEffects.None
		Else
			TryCast(options.DragVisual, TreeViewDragVisual).IsDropPossible = True
			options.DropAction = DropAction.Move
			options.UpdateDragVisual()
		End If
		e.Handled = True
	End Sub
	' #endregion
	' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox-6
	Private Sub OnDrop(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
		Dim options As TreeViewDragDropOptions = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, TreeViewDragDropOptions.Key), TreeViewDragDropOptions)
		If options Is Nothing Then
			Return
		End If
		Dim draggedItem = options.DraggedItems.FirstOrDefault()

		If draggedItem Is Nothing Then
			Return
		End If

		If e.Effects <> DragDropEffects.None Then
			Dim collection = TryCast(TryCast(sender, System.Windows.Controls.ListBox).ItemsSource, IList)
			collection.Add(draggedItem)
		End If

		e.Handled = True
	End Sub

	Private Sub OnDragDropCompleted(sender As Object, e As DragDropCompletedEventArgs)
		Dim draggedItem = DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedData")

		If e.Effects <> DragDropEffects.None Then
			Dim collection = TryCast(TryCast(sender, System.Windows.Controls.ListBox).ItemsSource, IList)
			collection.Remove(draggedItem)
		End If
	End Sub
	' #endregion
	' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox-7
DragDropManager.AddDropHandler(allProductsView, OnDrop)
	' #endregion
	' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox-8
	Dim destinationItems As IList = Nothing
	Private Sub OnDrop(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
		Dim data = DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedData")
		If data Is Nothing Then
			Return
		End If
		If e.Effects <> DragDropEffects.None Then
			Dim destinationItem = TryCast(e.OriginalSource, FrameworkElement).ParentOfType(Of RadTreeViewItem)()
			Dim dropDetails = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, "DropDetails"), DropIndicationDetails)

			If destinationItems IsNot Nothing Then
				Dim dropIndex As Integer = If(dropDetails.DropIndex >= destinationItems.Count, destinationItems.Count, If(dropDetails.DropIndex < 0, 0, dropDetails.DropIndex))
				Me.destinationItems.Insert(dropIndex, data)
			End If
		End If
	End Sub
	' #endregion
	' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-listbox-9
	Private Sub OnItemDragOver(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
		Dim item = TryCast(e.OriginalSource, FrameworkElement).ParentOfType(Of RadTreeViewItem)()
		If item Is Nothing Then
			e.Effects = DragDropEffects.None
			e.Handled = True
			Return
		End If
		Dim position = GetPosition(item, e.GetPosition(item))
		If item.Level = 0 AndAlso position <> DropPosition.Inside Then
			e.Effects = DragDropEffects.None
			e.Handled = True
			Return
		End If
		Dim tree As RadTreeView = TryCast(sender, RadTreeView)
		Dim draggedData = DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedData")
		Dim dropDetails = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, "DropDetails"), DropIndicationDetails)

		If (draggedData Is Nothing AndAlso dropDetails Is Nothing) Then
			Return
		End If
		If position <> DropPosition.Inside Then
			e.Effects = DragDropEffects.All

			destinationItems = If(item.Level > 0, DirectCast(item.ParentItem.ItemsSource, IList), DirectCast(tree.ItemsSource, IList))
			Dim index As Integer = destinationItems.IndexOf(item.Item)
			dropDetails.DropIndex = If(position = DropPosition.Before, index, index + 1)
		Else
			destinationItems = DirectCast(item.ItemsSource, IList)
			Dim index As Integer = 0

			If destinationItems Is Nothing Then
				e.Effects = DragDropEffects.None
			Else
				e.Effects = DragDropEffects.All
				dropDetails.DropIndex = index
			End If
		End If

		dropDetails.CurrentDraggedOverItem = item.Item
		dropDetails.CurrentDropPosition = position

		e.Handled = True
	End Sub



	Private Function GetPosition(item As RadTreeViewItem, point As Point) As DropPosition
		Dim treeViewItemHeight As Double = 24
		If point.Y < treeViewItemHeight / 4 Then
			Return DropPosition.Before
		ElseIf point.Y > treeViewItemHeight * 3 / 4 Then
			Return DropPosition.After
		End If

		Return DropPosition.Inside
	End Function
	' #endregion
End Class



