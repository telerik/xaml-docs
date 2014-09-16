Public Class Default_Vb


' #region gridview-overview-mouse-support_2
Private Sub radGridView_MouseWheel(ByVal sender As Object, ByVal e As MouseWheelEventArgs)
    MessageBox.Show("The mouse wheel has changed: " & e.Delta)
End Sub
    ' #endregion

    ' #region gridview-overview-mouse-support_4
    Public Sub [AddHandler](ByVal routedEvent As RoutedEvent, ByVal handler As [Delegate], ByVal handledEventsToo As Boolean)
    End Sub
    ' #endregion
End Class
