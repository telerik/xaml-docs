Public Class Default_Vb


' #region radcombobox-howto-set-character-casing_1
Public Class EditableComboBox
    Public Shared Function GetCharacterCasing(ByVal obj As DependencyObject) As Integer
        Return CInt(obj.GetValue(CharacterCasingProperty))
    End Function
    Public Shared Sub SetCharacterCasing(ByVal obj As DependencyObject, ByVal value As Integer)
        obj.SetValue(CharacterCasingProperty, value)
    End Sub
    Public Shared ReadOnly CharacterCasingProperty As DependencyProperty = DependencyProperty.RegisterAttached("CharacterCasing", GetType(Integer), GetType(EditableComboBox), New UIPropertyMetadata(OnCharacterCasingChanged))
    Private Shared Sub OnCharacterCasingChanged(ByVal obj As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
    End Sub
End Class
' #endregion
End Class
