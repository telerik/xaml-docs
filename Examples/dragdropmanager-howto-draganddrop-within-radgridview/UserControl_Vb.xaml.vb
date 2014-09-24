Public Class Default_Vb


    ' #region dragdropmanager-howto-draganddrop-within-radgridview_2
    Public Class MessageViewModel
        Public Shared Function Generate() As IList
            Dim data As IList = New ObservableCollection(Of MessageViewModel)()
            data.Add(New MessageViewModel("tom@hanna-barbera.com", "Cats are cool", 100))
            data.Add(New MessageViewModel("jerry@hanna-barbera.com", "Mice are cool", 100))
            data.Add(New MessageViewModel("spike@hanna-barbera.com", "Dogs are cool", 100))
            data.Add(New MessageViewModel("jerry2@hanna-barbera.com", "2Mice are cool", 200))
            data.Add(New MessageViewModel("spike2@hanna-barbera.com", "2Dogs are cool", 200))
            data.Add(New MessageViewModel("jerry3@hanna-barbera.com", "3Mice are cool", 300))
            data.Add(New MessageViewModel("spike3@hanna-barbera.com", "3Dogs are cool", 300))
            data.Add(New MessageViewModel("spike3@hanna-barbera.com", "3Dogs are cool", 300))
            data.Add(New MessageViewModel("spike3@hanna-barbera.com", "3Dogs are cool", 300))
            Return data
        End Function
        Public Sub New(ByVal sender As String, ByVal subject As String, ByVal size As Integer)
            Me.Sender = sender
            Me.Subject = subject
            Me.Size = size
        End Sub
        Private _Subject As String
        Public Property Subject() As String
            Get
                Return _Subject
            End Get
            Set(ByVal value As String)
                _Subject = value
            End Set
        End Property
        Private _Sender As String
        Public Property Sender() As String
            Get
                Return _Sender
            End Get
            Set(ByVal value As String)
                _Sender = value
            End Set
        End Property
        Private _Size As Integer
        Public Property Size() As Integer
            Get
                Return _Size
            End Get
            Set(ByVal value As Integer)
                _Size = value
            End Set
        End Property
        Public Overrides Function ToString() As String
            Return Me.Sender
        End Function
    End Class
    ' #endregion
    ' #region dragdropmanager-howto-draganddrop-within-radgridview_4
Me.radGridView.ItemsSource = MessageViewModel.Generate()
    ' #endregion
    ' #region dragdropmanager-howto-draganddrop-within-radgridview_8
    Public Class ReorderingEventArgs
        Inherits CancelEventArgs
        Public Property SourceGrid() As GridViewDataControl
            Get
                Return m_SourceGrid
            End Get
            Private Set(value As GridViewDataControl)
                m_SourceGrid = Value
            End Set
        End Property
        Private m_SourceGrid As GridViewDataControl
        Public Property DraggedItems() As IEnumerable(Of Object)
            Get
                Return m_DraggedItems
            End Get
            Private Set(value As IEnumerable(Of Object))
                m_DraggedItems = Value
            End Set
        End Property
        Private m_DraggedItems As IEnumerable(Of Object)
        Public Property DropIndex() As Integer
            Get
                Return m_DropIndex
            End Get
            Private Set(value As Integer)
                m_DropIndex = Value
            End Set
        End Property
        Private m_DropIndex As Integer
        Public Sub New(sourceGrid As GridViewDataControl, draggedItems As IEnumerable(Of Object), dropIndex As Integer)
            MyBase.New(False)
            Me.SourceGrid = sourceGrid
            Me.DraggedItems = draggedItems
            Me.DropIndex = dropIndex
        End Sub
    End Class
    ' #endregion
    ' #region dragdropmanager-howto-draganddrop-within-radgridview_10
    Public Class ReorderedEventArgs
        Inherits EventArgs
        Public Property SourceGrid() As GridViewDataControl
            Get
                Return m_SourceGrid
            End Get
            Private Set(value As GridViewDataControl)
                m_SourceGrid = Value
            End Set
        End Property
        Private m_SourceGrid As GridViewDataControl
        Public Property DraggedItems() As IEnumerable(Of Object)
            Get
                Return m_DraggedItems
            End Get
            Private Set(value As IEnumerable(Of Object))
                m_DraggedItems = Value
            End Set
        End Property
        Private m_DraggedItems As IEnumerable(Of Object)
        Public Sub New(sourceGrid As GridViewDataControl, draggedItems As IEnumerable(Of Object))
            MyBase.New()
            Me.SourceGrid = sourceGrid
            Me.DraggedItems = draggedItems
        End Sub
    End Class
    ' #endregion
    ' #region dragdropmanager-howto-draganddrop-within-radgridview_12
    Public Class DragStartedEventArgs
        Inherits EventArgs
        Public Property SourceGrid() As RadGridView
            Get
                Return m_SourceGrid
            End Get
            Private Set(value As RadGridView)
                m_SourceGrid = Value
            End Set
        End Property
        Private m_SourceGrid As RadGridView
        Public Property DraggedItems() As IEnumerable(Of Object)
            Get
                Return m_DraggedItems
            End Get
            Private Set(value As IEnumerable(Of Object))
                m_DraggedItems = Value
            End Set
        End Property
        Private m_DraggedItems As IEnumerable(Of Object)
        Public Sub New(sourceGrid As RadGridView, draggedItems As IEnumerable(Of Object))
            MyBase.New()
            Me.SourceGrid = sourceGrid
            Me.DraggedItems = draggedItems
        End Sub
    End Class
    ' #endregion
    ' #region dragdropmanager-howto-draganddrop-within-radgridview_14
    Public Class BeginningDragEventArgs
        Inherits CancelEventArgs
        Public Property SourceGrid() As RadGridView
            Get
                Return m_SourceGrid
            End Get
            Private Set(value As RadGridView)
                m_SourceGrid = Value
            End Set
        End Property
        Private m_SourceGrid As RadGridView
        Public Property DraggedItems() As IEnumerable(Of Object)
            Get
                Return m_DraggedItems
            End Get
            Private Set(value As IEnumerable(Of Object))
                m_DraggedItems = Value
            End Set
        End Property
        Private m_DraggedItems As IEnumerable(Of Object)
        Public Sub New(sourceGrid As RadGridView, draggedItems As IEnumerable(Of Object))
            MyBase.New()
            Me.SourceGrid = sourceGrid
            Me.DraggedItems = draggedItems
        End Sub
    End Class
    ' #endregion
    ' #region dragdropmanager-howto-draganddrop-within-radgridview_16
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
                If Me.m_currentDraggedOverItem <> value Then
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
                If Me.m_currentDraggedItem <> value Then
                    Me.m_currentDraggedItem = value
                    OnPropertyChanged("CurrentDraggedItem")
                End If
            End Set
        End Property
    End Class
    ' #endregion
    ' #region dragdropmanager-howto-draganddrop-within-radgridview_18
    Public Class RowReorderBehavior
        Private Const DropPositionFeedbackElementName As String = "DragBetweenItemsFeedback"
        Private dropPositionFeedbackPresenter As ContentPresenter
        Private dropPositionFeedbackPresenterHost As Grid

        Private _associatedObject As RadGridView

        ''' <summary>
        ''' AssociatedObject Property
        ''' </summary>
        Public Property AssociatedObject() As RadGridView
            Get
                Return _associatedObject
            End Get
            Set(value As RadGridView)
                _associatedObject = value
            End Set
        End Property

        Private Shared instances As Dictionary(Of RadGridView, RowReorderBehavior)

        Shared Sub New()
            instances = New Dictionary(Of RadGridView, RowReorderBehavior)()
        End Sub

        Public Shared Function GetIsEnabled(obj As DependencyObject) As Boolean
            Return CBool(obj.GetValue(IsEnabledProperty))
        End Function

        Public Shared Sub SetIsEnabled(obj As DependencyObject, value As Boolean)
            Dim behavior As RowReorderBehavior = GetAttachedBehavior(TryCast(obj, RadGridView))

            behavior.AssociatedObject = TryCast(obj, RadGridView)

            If value Then
                behavior.Initialize()
            Else
                behavior.CleanUp()
            End If
            obj.SetValue(IsEnabledProperty, value)
        End Sub

        ' Using a DependencyProperty as the backing store for IsEnabled.  This enables animation, styling, binding, etc...
        Public Shared ReadOnly IsEnabledProperty As DependencyProperty = DependencyProperty.RegisterAttached("IsEnabled", GetType(Boolean), GetType(RowReorderBehavior), New PropertyMetadata(New PropertyChangedCallback(OnIsEnabledPropertyChanged)))

        Public Shared Sub OnIsEnabledPropertyChanged(dependencyObject As DependencyObject, e As DependencyPropertyChangedEventArgs)
            SetIsEnabled(dependencyObject, CBool(e.NewValue))
        End Sub

        Private Shared Function GetAttachedBehavior(gridview As RadGridView) As RowReorderBehavior
            If Not instances.ContainsKey(gridview) Then
                instances(gridview) = New RowReorderBehavior()
                instances(gridview).AssociatedObject = gridview
            End If

            Return instances(gridview)
        End Function

        Public Sub New()
            Me.dropPositionFeedbackPresenter = New ContentPresenter()
            Me.dropPositionFeedbackPresenter.Name = DropPositionFeedbackElementName
            Me.dropPositionFeedbackPresenter.HorizontalAlignment = HorizontalAlignment.Left
            Me.dropPositionFeedbackPresenter.VerticalAlignment = VerticalAlignment.Top
            Me.dropPositionFeedbackPresenter.RenderTransformOrigin = New Point(0.5, 0.5)
        End Sub

        Protected Overridable Sub Initialize()
            Me.AssociatedObject.RowLoaded -= Me.AssociatedObject_RowLoaded
            Me.AssociatedObject.RowLoaded += Me.AssociatedObject_RowLoaded
            Me.UnsubscribeFromDragDropEvents()
            Me.SubscribeToDragDropEvents()
            Me.AssociatedObject.DataLoaded -= AssociatedObject_DataLoaded
            Me.AssociatedObject.DataLoaded += AssociatedObject_DataLoaded

        End Sub

        Private Sub AssociatedObject_DataLoaded(sender As Object, e As EventArgs)

            Me.AssociatedObject.DataLoaded -= AssociatedObject_DataLoaded
            Me.AttachDropPositionFeedback()
        End Sub

        Protected Overridable Sub CleanUp()
            Me.AssociatedObject.RowLoaded -= Me.AssociatedObject_RowLoaded
            Me.UnsubscribeFromDragDropEvents()
            Me.AssociatedObject.DataLoaded -= AssociatedObject_DataLoaded


            Me.DetachDropPositionFeedback()

        End Sub

        Private Sub AssociatedObject_RowLoaded(sender As Object, e As Telerik.Windows.Controls.GridView.RowLoadedEventArgs)
            If TypeOf e.Row Is GridViewHeaderRow OrElse TypeOf e.Row Is GridViewNewRow OrElse TypeOf e.Row Is GridViewFooterRow Then
                Return
            End If

            Dim row As GridViewRow = TryCast(e.Row, GridViewRow)
            Me.InitializeRowDragAndDrop(row)
        End Sub

        Private Sub InitializeRowDragAndDrop(row As GridViewRow)
            If row Is Nothing Then
                Return
            End If

            DragDropManager.RemoveDragOverHandler(row, OnRowDragOver)
            DragDropManager.AddDragOverHandler(row, OnRowDragOver)
        End Sub

        Private Sub SubscribeToDragDropEvents()
            DragDropManager.AddDragInitializeHandler(Me.AssociatedObject, OnDragInitialize)
            DragDropManager.AddGiveFeedbackHandler(Me.AssociatedObject, OnGiveFeedback)
            DragDropManager.AddDropHandler(Me.AssociatedObject, OnDrop)
            DragDropManager.AddDragDropCompletedHandler(Me.AssociatedObject, OnDragDropCompleted)
        End Sub



        Private Sub UnsubscribeFromDragDropEvents()
            DragDropManager.RemoveDragInitializeHandler(Me.AssociatedObject, OnDragInitialize)
            DragDropManager.RemoveGiveFeedbackHandler(Me.AssociatedObject, OnGiveFeedback)
            DragDropManager.RemoveDropHandler(Me.AssociatedObject, OnDrop)
            DragDropManager.RemoveDragDropCompletedHandler(Me.AssociatedObject, OnDragDropCompleted)

        End Sub

        Private Sub OnDragDropCompleted(sender As Object, e As DragDropCompletedEventArgs)
            Me.HideDropPositionFeedbackPresenter()
        End Sub

        Private Sub OnDragInitialize(sender As Object, e As DragInitializeEventArgs)
            Dim sourceRow = If(TryCast(e.OriginalSource, GridViewRow), TryCast(e.OriginalSource, FrameworkElement).ParentOfType(Of GridViewRow)())
            If sourceRow IsNot Nothing AndAlso sourceRow.Name <> "PART_RowResizer" Then
                Dim details As New DropIndicationDetails()
                Dim item = sourceRow.Item
                details.CurrentDraggedItem = item

                Dim dragPayload As IDragPayload = DragDropPayloadManager.GeneratePayload(Nothing)

                dragPayload.SetData("DraggedItem", item)
                dragPayload.SetData("DropDetails", details)

                e.Data = dragPayload

                e.DragVisual = New DragVisual() With { _
                 .Content = details, _
                 .ContentTemplate = TryCast(Me.AssociatedObject.Resources("DraggedItemTemplate"), DataTemplate) _
                }
                e.DragVisualOffset = e.RelativeStartPoint
                e.AllowedEffects = DragDropEffects.All
            End If
        End Sub

        Private Sub OnGiveFeedback(sender As Object, e As Telerik.Windows.DragDrop.GiveFeedbackEventArgs)
            e.SetCursor(Cursors.Arrow)
            e.Handled = True
        End Sub

        Private Sub OnDrop(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
            Dim draggedItem = DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedItem")
            Dim details = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, "DropDetails"), DropIndicationDetails)

            If details Is Nothing OrElse draggedItem Is Nothing Then
                Return
            End If

            If e.Effects = DragDropEffects.Move OrElse e.Effects = DragDropEffects.All Then
                TryCast(TryCast(sender, RadGridView).ItemsSource, IList).Remove(draggedItem)
            End If

            If e.Effects <> DragDropEffects.None Then
                Dim collection = TryCast(TryCast(sender, RadGridView).ItemsSource, IList)
                Dim index As Integer = If(details.DropIndex < 0, 0, details.DropIndex)
                index = If(details.DropIndex > collection.Count - 1, collection.Count, index)

                collection.Insert(index, draggedItem)
            End If

            HideDropPositionFeedbackPresenter()
        End Sub

        Private Sub OnRowDragOver(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
            Dim row = TryCast(sender, GridViewRow)
            Dim details = TryCast(DragDropPayloadManager.GetDataFromObject(e.Data, "DropDetails"), DropIndicationDetails)

            If details Is Nothing OrElse row Is Nothing Then
                Return
            End If

            details.CurrentDraggedOverItem = row.DataContext

            If details.CurrentDraggedItem = details.CurrentDraggedOverItem Then
                e.Effects = DragDropEffects.None
                e.Handled = True
                Return
            End If

            details.CurrentDropPosition = GetDropPositionFromPoint(e.GetPosition(row), row)
            Dim dropIndex As Integer = TryCast(Me.AssociatedObject.Items, IList).IndexOf(row.DataContext)
            Dim draggedItemIdex As Integer = TryCast(Me.AssociatedObject.Items, IList).IndexOf(DragDropPayloadManager.GetDataFromObject(e.Data, "DraggedItem"))

            If dropIndex >= row.GridViewDataControl.Items.Count - 1 AndAlso details.CurrentDropPosition = DropPosition.After Then
                details.DropIndex = dropIndex
                Me.ShowDropPositionFeedbackPresenter(Me.AssociatedObject, row, details.CurrentDropPosition)
                Return
            End If

            dropIndex = If(draggedItemIdex > dropIndex, dropIndex, dropIndex - 1)
            details.DropIndex = If(details.CurrentDropPosition = DropPosition.Before, dropIndex, dropIndex + 1)

            Me.ShowDropPositionFeedbackPresenter(Me.AssociatedObject, row, details.CurrentDropPosition)
        End Sub

        Public Overridable Function GetDropPositionFromPoint(absoluteMousePosition As Point, row As GridViewRow) As DropPosition
            If row IsNot Nothing Then
                Return If(absoluteMousePosition.Y < row.ActualHeight / 2, DropPosition.Before, DropPosition.After)
            End If

            Return DropPosition.Inside
        End Function

        Private Function IsDropPositionFeedbackAvailable() As Boolean
            Return Me.dropPositionFeedbackPresenterHost IsNot Nothing AndAlso Me.dropPositionFeedbackPresenter IsNot Nothing
        End Function

        Private Sub ShowDropPositionFeedbackPresenter(gridView As GridViewDataControl, row As GridViewRow, lastRowDropPosition As DropPosition)
            If Not Me.IsDropPositionFeedbackAvailable() Then
                Return
            End If
            Dim yOffset = Me.GetDropPositionFeedbackOffset(row, lastRowDropPosition)
            Me.dropPositionFeedbackPresenter.Visibility = Visibility.Visible
            Me.dropPositionFeedbackPresenter.Width = row.ActualWidth
            Me.dropPositionFeedbackPresenter.RenderTransform = New TranslateTransform() With { _
             .Y = yOffset _
            }
        End Sub

        Private Sub HideDropPositionFeedbackPresenter()
            Me.dropPositionFeedbackPresenter.RenderTransform = New TranslateTransform() With { _
             .X = 0, _
             .Y = -234324 _
            }
        End Sub

        Private Function GetDropPositionFeedbackOffset(row As GridViewRow, dropPosition__1 As DropPosition) As Double
            Dim yOffset = row.TransformToVisual(Me.dropPositionFeedbackPresenterHost).Transform(New Point(0, 0)).Y
            If dropPosition__1 = DropPosition.After Then
                yOffset += row.ActualHeight
            End If
            yOffset -= (Me.dropPositionFeedbackPresenter.ActualHeight / 2.0)
            Return yOffset
        End Function

        Private Sub DetachDropPositionFeedback()
            If Me.IsDropPositionFeedbackAvailable() Then
                Me.dropPositionFeedbackPresenterHost.Children.Remove(Me.dropPositionFeedbackPresenter)
            End If
        End Sub

        Private Sub AttachDropPositionFeedback()
            Me.dropPositionFeedbackPresenterHost = Me.AssociatedObject.ParentOfType(Of Grid)()
            If Me.dropPositionFeedbackPresenterHost IsNot Nothing Then
                Me.dropPositionFeedbackPresenter.Content = CreateDefaultDropPositionFeedback()
                Me.dropPositionFeedbackPresenterHost.Children.Add(Me.dropPositionFeedbackPresenter)
            End If
            Me.HideDropPositionFeedbackPresenter()
        End Sub

        Private Shared Function CreateDefaultDropPositionFeedback() As UIElement
            Dim grid__1 As New Grid() With { _
             .Height = 8, _
             .HorizontalAlignment = HorizontalAlignment.Stretch, _
             .IsHitTestVisible = False, _
             .VerticalAlignment = VerticalAlignment.Stretch _
            }
            grid__1.ColumnDefinitions.Add(New ColumnDefinition() With { _
             .Width = New GridLength(8) _
            })
            grid__1.ColumnDefinitions.Add(New ColumnDefinition())
            Dim ellipse As New Ellipse() With { _
             .Stroke = New SolidColorBrush(Colors.Orange), _
             .StrokeThickness = 2, _
             .Fill = New SolidColorBrush(Colors.Orange), _
             .HorizontalAlignment = HorizontalAlignment.Stretch, _
             .VerticalAlignment = VerticalAlignment.Stretch, _
             .Width = 8, _
             .Height = 8 _
            }
            Dim rectangle As New Rectangle() With { _
             .Fill = New SolidColorBrush(Colors.Orange), _
             .RadiusX = 2, _
             .RadiusY = 2, _
             .VerticalAlignment = VerticalAlignment.Stretch, _
             .HorizontalAlignment = HorizontalAlignment.Stretch, _
             .Height = 2 _
            }
            Grid.SetColumn(ellipse, 0)
            Grid.SetColumn(rectangle, 1)
            grid__1.Children.Add(ellipse)
            grid__1.Children.Add(rectangle)
            Return grid__1
        End Function
    End Class
    ' #endregion
End Class
