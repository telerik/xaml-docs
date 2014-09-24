Public Class Default_Vb


' #region radnumericupdown-howto-events_1
Private Sub Events()
        Dim numeric As RadNumericUpDown = New RadNumericUpDown
        AddHandler numeric.ValueChanged, AddressOf OnNumericValueChanged
        numeric.Value = 10;
    End Sub
    Private Sub OnNumericValueChanged(ByVal sender As Object, ByVal e As RoutedPropertyChangedEventArgs(Of double))
        RadWindow.Alert(String.Format("New value: {0}, Old value: {1}", e.NewValue, e.OldValue))
    End Sub
' #endregion
End Class
