'#region raddiagram-howto-customize-dragging-0
Public Class MyDragging
    Inherits DraggingService

    Public Sub New(ByVal graph As RadDiagram)
        MyBase.New(TryCast(graph, IGraphInternal))

    End Sub

End Class
'#endregion
'#region raddiagram-howto-customize-dragging-1
Public Class MyDragging
    Inherits DraggingService
    Implements INotifyPropertyChanged

    Private restrictedToBounds As Boolean
    Private isOnValue As Boolean
    Private useRotateBounds As Boolean

    Public Sub New(ByVal graph As RadDiagram)
        MyBase.New(TryCast(graph, IGraphInternal))
        Me.DragAllowedArea = Rect.Empty
        Me.IsOn = True
        Me.UseRotaitonBounds = True
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property DragAllowedArea() As Rect
    Public Property IsRestrictedToBounds() As Boolean
        Get
            Return Me.restrictedToBounds
        End Get
        Set(ByVal value As Boolean)
            If Me.restrictedToBounds <> value Then
                Me.restrictedToBounds = value
                Me.OnPropertyChaged("IsRestrictedToBounds")
            End If
        End Set
    End Property
    Public Property UseRotaitonBounds() As Boolean
        Get
            Return Me.useRotateBounds
        End Get
        Set(ByVal value As Boolean)
            If Me.useRotateBounds <> value Then
                Me.useRotateBounds = value
                Me.OnPropertyChaged("UseRotaitonBounds")
            End If
        End Set
    End Property
    Public Property IsOn() As Boolean
        Get
            Return Me.isOnValue
        End Get
        Set(ByVal value As Boolean)
            If Me.isOnValue <> value Then
                Me.isOnValue = value
                Me.OnPropertyChaged("IsOn")
            End If
        End Set
    End Property

    Private Sub OnPropertyChaged(ByVal name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub
End Class
'#endregion
'#region raddiagram-howto-customize-dragging-2
Public Overrides Sub Drag(ByVal newPoint As Point)
    Dim dragPoint As Point = newPoint

    'if the mouse position during a drag operation should be restricted within the DragAllowedArea
    If Me.DragAllowedArea <> Rect.Empty AndAlso (Not Me.DragAllowedArea.Contains(newPoint)) Then
        'calculate the proper position of the dragPoint
        Dim X As Double = dragPoint.X
        Dim Y As Double = dragPoint.Y
        If X > Me.DragAllowedArea.Right Then
            X = Me.DragAllowedArea.Right
        ElseIf X < Me.DragAllowedArea.Left Then
            X = Me.DragAllowedArea.Left
        End If

        If Y > Me.DragAllowedArea.Bottom Then
            Y = Me.DragAllowedArea.Bottom
        ElseIf Y < Me.DragAllowedArea.Top Then
            Y = Me.DragAllowedArea.Top
        End If

        dragPoint = New Point(X, Y)
    End If
End Sub
'#endregion
'#region raddiagram-howto-customize-dragging-3
Private ReadOnly diagram As RadDiagram
'this method gets the bounds of the selected DiagramItems 
Private Function GetSelectionBounds() As Rect
    If Me.UseRotaitonBounds Then
        'find the selection bounds after a rotation
        Dim result As Rect = Rect.Empty
        For Each item In Me.diagram.SelectedItems
            Dim container = Me.diagram.ContainerGenerator.ContainerFromItem(item)
            Dim shape = TryCast(item, IShape)
            If shape IsNot Nothing Then
                result.Union(shape.ActualBounds)
            Else
                result.Union(container.Bounds)
            End If
        Next item

        Return result
    Else
        'or get the default selection bounds
        Return Me.diagram.SelectionBounds
    End If
End Function
'#endregion
'#region raddiagram-howto-customize-dragging-4
Public Sub New(ByVal graph As RadDiagram)
    MyBase.New(TryCast(graph, IGraphInternal))
    Me.diagram = graph

    Me.DragAllowedArea = Rect.Empty
    Me.IsOn = True
    Me.UseRotaitonBounds = True
End Sub
'#endregion
'#region raddiagram-howto-customize-dragging-5
Public Overrides Sub Drag(ByVal newPoint As Point)
    Dim dragPoint As Point = newPoint

    'if the actual bounds of the shape should be within the DragAllowedArea
    If Me.IsRestrictedToBounds Then
        'get the bounds of the selected RadDiagramItems
        Dim selectionBounds = Me.GetSelectionBounds()
        'find the drag offset by comparing the coordinates of the last and the new drag position 
        Dim offset = New Vector(newPoint.X - Me.lastPoint.X, newPoint.Y - Me.lastPoint.Y)
        'calculate the new bounds of the dragged selected items
        Dim newBounds = New Rect(selectionBounds.X + offset.X, selectionBounds.Y + offset.Y, selectionBounds.Width, selectionBounds.Height)

        'if there is no predefined draggable area or 
        'if the bounds of the dragged selected items are within the predefined draggable area
        'invoke the default implementation of the DraggingService Drag() method
        If Me.DragAllowedArea = Rect.Empty OrElse Me.DragAllowedArea.Contains(newBounds) Then
            MyBase.Drag(newPoint)
            Me.lastPoint = dragPoint
            Return
        End If

        'if the bounds of the selected items is outside the bounds of the draggable area, 
        'recalculate the coordinates of the drag point to make sure the bounds of the selected items is inside the draggable area 
        If Me.DragAllowedArea.Left > newBounds.Left Then
            dragPoint = New Point(dragPoint.X - (newBounds.Left - Me.DragAllowedArea.Left), dragPoint.Y)
        ElseIf Me.DragAllowedArea.Right < newBounds.Right Then
            dragPoint = New Point(dragPoint.X - (newBounds.Right - Me.DragAllowedArea.Right), dragPoint.Y)
        End If

        If Me.DragAllowedArea.Top > newBounds.Top Then
            dragPoint = New Point(dragPoint.X, dragPoint.Y - (newBounds.Top - Me.DragAllowedArea.Top))
        ElseIf Me.DragAllowedArea.Bottom < newBounds.Bottom Then
            dragPoint = New Point(dragPoint.X, dragPoint.Y - (newBounds.Bottom - Me.DragAllowedArea.Bottom))
        End If
    End If
End Sub
'#endregion
'#region raddiagram-howto-customize-dragging-6
Public Overrides Sub Drag(ByVal newPoint As Point)
    Dim dragPoint As Point = newPoint

    If Me.IsOn Then
        'if the actual bounds of the shape should be within the DragAllowedArea
        If Me.IsRestrictedToBounds Then
            'get the bounds of the selected RadDiagramItems
            Dim selectionBounds = Me.GetSelectionBounds()
            'find the drag offset by comparing the coordinates of the last and the new drag position 
            Dim offset = New Vector(newPoint.X - Me.lastPoint.X, newPoint.Y - Me.lastPoint.Y)
            'calculate the new bounds of the dragged selected items
            Dim newBounds = New Rect(selectionBounds.X + offset.X, selectionBounds.Y + offset.Y, selectionBounds.Width, selectionBounds.Height)

            'if there is no predefined draggable area or 
            'if the bounds of the dragged selected items are within the predefined draggable area
            'invoke the default implementation of the DraggingService Drag() method
            If Me.DragAllowedArea = Rect.Empty OrElse Me.DragAllowedArea.Contains(newBounds) Then
                MyBase.Drag(newPoint)
                Me.lastPoint = dragPoint
                Return
            End If

            'if the bounds of the selected items is outside the bounds of the draggable area, 
            'recalculate the coordinates of the drag point to make sure the bounds of the selected items is inside the draggable area 
            If Me.DragAllowedArea.Left > newBounds.Left Then
                dragPoint = New Point(dragPoint.X - (newBounds.Left - Me.DragAllowedArea.Left), dragPoint.Y)
            ElseIf Me.DragAllowedArea.Right < newBounds.Right Then
                dragPoint = New Point(dragPoint.X - (newBounds.Right - Me.DragAllowedArea.Right), dragPoint.Y)
            End If

            If Me.DragAllowedArea.Top > newBounds.Top Then
                dragPoint = New Point(dragPoint.X, dragPoint.Y - (newBounds.Top - Me.DragAllowedArea.Top))
            ElseIf Me.DragAllowedArea.Bottom < newBounds.Bottom Then
                dragPoint = New Point(dragPoint.X, dragPoint.Y - (newBounds.Bottom - Me.DragAllowedArea.Bottom))
            End If
        Else
            'if the mouse position during a drag operation should be restricted within the DragAllowedArea
            If Me.DragAllowedArea <> Rect.Empty AndAlso (Not Me.DragAllowedArea.Contains(newPoint)) Then
                'calculate the proper position of the dragPoint
                Dim X As Double = dragPoint.X
                Dim Y As Double = dragPoint.Y
                If X > Me.DragAllowedArea.Right Then
                    X = Me.DragAllowedArea.Right
                ElseIf X < Me.DragAllowedArea.Left Then
                    X = Me.DragAllowedArea.Left
                End If

                If Y > Me.DragAllowedArea.Bottom Then
                    Y = Me.DragAllowedArea.Bottom
                ElseIf Y < Me.DragAllowedArea.Top Then
                    Y = Me.DragAllowedArea.Top
                End If

                dragPoint = New Point(X, Y)
            End If
        End If
    End If
    'invoke the base implementation of the DraggingService Drag() method with the calculated proper coordinates of the dragPoint  
    MyBase.Drag(dragPoint)
    'update the lastPosition property to always keep track of the last drag position
    Me.lastPoint = dragPoint
End Sub
'#endregion
'#region raddiagram-howto-customize-dragging-7
'override this method to get the coordinates of the point where the drag started
Public Overrides Sub InitializeDrag(ByVal point As Point)
    Me.lastPoint = point
    MyBase.InitializeDrag(point)
End Sub
'#endregion
'#region raddiagram-howto-customize-dragging-8
Private newDraggingService As MyDragging

Public Sub New()
    InitializeComponent()

    Me.InitializeNewServices()
End Sub

Private Sub InitializeNewServices()
    'initialize MyDragging 
    Me.newDraggingService = New MyDragging(Me.diagram)
    'create a binding with Path=IsOn
    Dim binding As New Binding("IsOn")
    'use the newDraggingService as a source of the binding
    binding.Source = Me.newDraggingService
    binding.Mode = BindingMode.TwoWay
    'apply the binding on the toggleDrag RadToggleButton
    Me.toggleDrag.SetBinding(RadToggleButton.IsCheckedProperty, binding)

    'create a binding with Path=IsRestrictedToBounds
    binding = New Binding("IsRestrictedToBounds")
    'use the newDraggingService as a source of the binding
    binding.Source = Me.newDraggingService
    binding.Mode = BindingMode.TwoWay
    'apply the binding on the IsRestrictedToBounds RadToggleButton
    Me.IsRestrictedToBounds.SetBinding(RadToggleButton.IsCheckedProperty, binding)

    'create a binding with Path=UseRotaitonBounds
    binding = New Binding("UseRotaitonBounds")
    'use the newDraggingService as a source of the binding
    binding.Source = Me.newDraggingService
    binding.Mode = BindingMode.TwoWay
    'apply the binding on the useRotaitonBounds RadToggleButton
    Me.useRotaitonBounds.SetBinding(RadToggleButton.IsCheckedProperty, binding)
End Sub
'#endregion
'#region raddiagram-howto-customize-dragging-9
Public Sub New()
    InitializeComponent()
    Me.InitializeNewServices()
    Me.diagram.ServiceLocator.Register(Of IDraggingService)(Me.newDraggingService)
End Sub
'#endregion
'#region raddiagram-howto-customize-dragging-10
Private Sub SetRestrictRect(ByVal rect As Rect)
    If Me.newDraggingService IsNot Nothing Then
        Me.newDraggingService.DragAllowedArea = rect.InflateRect(-rect.Width \ 4, -rect.Height \ 4)
    End If
End Sub

Private Sub OnDiagramViewportChanged(ByVal sender As Object, ByVal e As PropertyEventArgs(Of Rect))
    Me.SetRestrictRect(e.NewValue)
    Me.border.Width = (e.NewValue.Width / 2) * Me.diagram.Zoom
    Me.border.Height = (e.NewValue.Height / 2) * Me.diagram.Zoom
End Sub
'#endregion