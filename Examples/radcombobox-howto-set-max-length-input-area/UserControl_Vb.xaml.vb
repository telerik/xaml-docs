Public Class Default_Vb


' #region radcombobox-howto-set-max-length-input-area_1
Public Class EditableComboBox
    Public Shared ReadOnly MaxLengthProperty As DependencyProperty = DependencyProperty.RegisterAttached("MaxLength", GetType(Integer), GetType(EditableComboBox), New PropertyMetadata(OnMaxLengthChanged))
    Public Shared Function GetMaxLength(ByVal obj As DependencyObject) As Integer
        Return CInt(obj.GetValue(MaxLengthProperty))
    End Function
    Public Shared Sub SetMaxLength(ByVal obj As DependencyObject, ByVal value As Integer)
        obj.SetValue(MaxLengthProperty, value)
    End Sub
    Private Shared Sub OnMaxLengthChanged(ByVal obj As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
    End Sub
End Class
' #endregion

' #region radcombobox-howto-set-max-length-input-area_3
Public Class EditableComboBox
    Public Shared ReadOnly MaxLengthProperty As DependencyProperty = DependencyProperty.RegisterAttached("MaxLength", GetType(Integer), GetType(EditableComboBox), New PropertyMetadata(OnMaxLengthChanged))
    Public Shared Function GetMaxLength(ByVal obj As DependencyObject) As Integer
        Return CInt(obj.GetValue(MaxLengthProperty))
    End Function
    Public Shared Sub SetMaxLength(ByVal obj As DependencyObject, ByVal value As Integer)
        obj.SetValue(MaxLengthProperty, value)
    End Sub
    Private Shared Sub OnMaxLengthChanged(ByVal obj As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
        Dim comboBox = TryCast(obj, Telerik.Windows.Controls.RadComboBox)
        If comboBox Is Nothing Then
            Exit Sub
        End If
        comboBox.Dispatcher.BeginInvoke(Function() Do
            Dim rootElement = TryCast(VisualTreeHelper.GetChild(comboBox, 0), FrameworkElement)
            Dim textBox As TextBox = DirectCast(rootElement.FindName("PART_EditableTextBox"), TextBox)
            If textBox IsNot Nothing Then
                textBox.SetValue(TextBox.MaxLengthProperty, e.NewValue)
            End If 
       End Function)
    End Sub
End Class
' #endregion
End Class
