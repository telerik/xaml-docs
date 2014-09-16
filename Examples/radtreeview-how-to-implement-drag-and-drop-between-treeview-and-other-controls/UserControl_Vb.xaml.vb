Public Class Default_Vb


' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-0
Public Class GridViewDragDropBehavior
	Private _associatedObject As RadGridView
	''' <summary>
	''' object that will be associated with the RadGridView instance that enables the behavior
	''' </summary>
	Public Property AssociatedObject() As RadGridView
		Get
			Return _associatedObject
		End Get
		Set
			_associatedObject = value
		End Set
	End Property

	Private Shared instances As Dictionary(Of RadGridView, GridViewDragDropBehavior)

	Shared Sub New()
		instances = New Dictionary(Of RadGridView, GridViewDragDropBehavior)()
	End Sub

	Public Shared Function GetIsEnabled(obj As DependencyObject) As Boolean
		Return CBool(obj.GetValue(IsEnabledProperty))
	End Function

	Public Shared Sub SetIsEnabled(obj As DependencyObject, value As Boolean)
		Dim behavior As GridViewDragDropBehavior = GetAttachedBehavior(TryCast(obj, RadGridView))

		behavior.AssociatedObject = TryCast(obj, RadGridView)

		If value Then
			behavior.Initialize()
		Else
			behavior.CleanUp()
		End If
		obj.SetValue(IsEnabledProperty, value)
	End Sub

	' Using a DependencyProperty as the backing store for IsEnabled state of the behavior
	Public Shared ReadOnly IsEnabledProperty As DependencyProperty = DependencyProperty.RegisterAttached("IsEnabled", GetType(Boolean), GetType(GridViewDragDropBehavior), New PropertyMetadata(New PropertyChangedCallback(AddressOf OnIsEnabledPropertyChanged)))

	Public Shared Sub OnIsEnabledPropertyChanged(dependencyObject As DependencyObject, e As DependencyPropertyChangedEventArgs)
		SetIsEnabled(dependencyObject, CBool(e.NewValue))
	End Sub

	Private Shared Function GetAttachedBehavior(gridview As RadGridView) As GridViewDragDropBehavior
		If Not instances.ContainsKey(gridview) Then
			instances(gridview) = New GridViewDragDropBehavior()
			instances(gridview).AssociatedObject = gridview
		End If

		Return instances(gridview)
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

' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-1
Private Sub SubscribeToDragDropEvents()
	DragDropManager.AddDragInitializeHandler(Me.AssociatedObject, OnDragInitialize)
	DragDropManager.AddGiveFeedbackHandler(Me.AssociatedObject, OnGiveFeedback)
	DragDropManager.AddDropHandler(Me.AssociatedObject, OnDrop)
	DragDropManager.AddDragDropCompletedHandler(Me.AssociatedObject, OnDragDropCompleted)
	DragDropManager.AddDragOverHandler(Me.AssociatedObject, OnDragOver)
End Sub

Private Sub UnsubscribeFromDragDropEvents()
	DragDropManager.RemoveDragInitializeHandler(Me.AssociatedObject, OnDragInitialize)
	DragDropManager.RemoveGiveFeedbackHandler(Me.AssociatedObject, OnGiveFeedback)
	DragDropManager.RemoveDropHandler(Me.AssociatedObject, OnDrop)
	DragDropManager.RemoveDragDropCompletedHandler(Me.AssociatedObject, OnDragDropCompleted)
	DragDropManager.RemoveDragOverHandler(Me.AssociatedObject, OnDragOver)
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

' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-2
Public Class DropIndicationDetails
	Inherits ViewModelBase
	Private m_currentDraggedItem As Object
	Private m_currentDropPosition As DropPosition
	Private m_currentDraggedOverItem As Object

	Public Property CurrentDraggedOverItem() As Object
		Get
			Return m_currentDraggedOverItem
		End Get
		Set
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
		Set
			m_DropIndex = Value
		End Set
	End Property
	Private m_DropIndex As Integer

	Public Property CurrentDropPosition() As DropPosition
		Get
			Return Me.m_currentDropPosition
		End Get
		Set
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
		Set
			If Me.m_currentDraggedItem IsNot value Then
				Me.m_currentDraggedItem = value
				OnPropertyChanged("CurrentDraggedItem")
			End If
		End Set
	End Property
End Class
' #endregion

' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-3
Private Sub OnDragInitialize(sender As Object, e As DragInitializeEventArgs)
	Dim details As New DropIndicationDetails()
	Dim row = If(TryCast(e.OriginalSource, GridViewRow), TryCast(e.OriginalSource, FrameworkElement).ParentOfType(Of GridViewRow)())

	Dim item = If(row IsNot Nothing, row.Item, TryCast(sender, RadGridView).SelectedItem)
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

' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-4
Private Sub OnGiveFeedback(sender As Object, e As Telerik.Windows.DragDrop.GiveFeedbackEventArgs)
	e.SetCursor(Cursors.Arrow)
	e.Handled = True
End Sub
' #endregion

' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-5
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
' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-6
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
		Dim collection = TryCast(TryCast(sender, RadGridView).ItemsSource, IList)
		collection.Add(draggedItem)
	End If
	e.Handled = True
End Sub

Private Sub OnDragDropCompleted(sender As Object, e As DragDropCompletedEventArgs)
	Dim draggedItem = DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedData")

	If e.Effects <> DragDropEffects.None Then
		Dim collection = TryCast(TryCast(sender, RadGridView).ItemsSource, IList)
		collection.Remove(draggedItem)
	End If
End Sub
' #endregion
' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-7
DragDropManager.AddDropHandler(allProductsView, OnDrop)
' #endregion
' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-8
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
' #region radtreeview-how-to-implement-drag-and-drop-between-treeview-and-other-controls-9
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



