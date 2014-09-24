Public Class Default_Vb


' #region dragdrompmanager-howto-set-drag-visual_2
Public Sub New()
 InitializeComponent()
 Me.DataContext = New ObservableCollection(Of String)(From c In Enumerable.Range(0, 10)"Item" & c)
 DragDropManager.AddDragInitializeHandler(Me, New DragInitializeEventHandler(AddressOf OnDragInitialized)) 
End Sub
    ' #endregion
    ' #region dragdrompmanager-howto-set-drag-visual_4
    Private Sub OnDragInitialize(ByVal sender As Object, ByVal args As DragInitializeEventArgs)
        args.Data = DirectCast(args.OriginalSource, FrameworkElement).DataContext
        args.DragVisual = New ContentControl With {.ContentTemplate = TryCast(Me.LayoutRoot.Resources("ItemTemplate"), DataTemplate), .Content = args.Data}
        args.AllowedEffects = DragDropEffects.All
        args.Handled = True
    End Sub
    ' #endregion
End Class
