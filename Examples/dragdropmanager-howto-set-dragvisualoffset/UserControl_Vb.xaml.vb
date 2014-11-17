Public Class Default_Vb


    ' #region dragdropmanager-howto-set-dragvisualoffset_1
    Private Sub OnDragInitialize(sender As Object, args As DragInitializeEventArgs)
        args.DragVisualOffset = New Point(args.RelativeStartPoint.X - 25, args.RelativeStartPoint.Y - 25)
    End Sub
    ' #endregion
End Class
