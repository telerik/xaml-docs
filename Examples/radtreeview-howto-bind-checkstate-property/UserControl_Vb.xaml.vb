Public Class Default_Vb


' #region radtreeview-howto-bind-checkstate-property_1
Public Class Person
Private _IsChecked As Boolean
    Public Property IsChecked() As Boolean
        Get
            Return _IsChecked
        End Get
        Set(ByVal value As Boolean)
            _IsChecked = value
        End Set
    End Property
    ' Other class members...
End Class
' #endregion

' #region radtreeview-howto-bind-checkstate-property_4
Public Class CheckStateConverter
    Implements IValueConverter
    Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
        Dim result As Boolean = CBool(value)
        Return If(result, ToggleState.[On], ToggleState.Off)
    End Function
    Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
        Dim state As ToggleState = DirectCast(value, ToggleState)
        Return If(state = ToggleState.[On], True, False)
    End Function
End Class
' #endregion

' #region radtreeview-howto-bind-checkstate-property_7
Public Class CheckStateConverter
    Implements IValueConverter
    Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
        Dim result As Boolean = CBool(value)
        Return If(result, ToggleState.[On], ToggleState.Off)
    End Function
    Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
        Dim state As ToggleState = DirectCast(value, ToggleState)
        Return If(state = ToggleState.[On], True, False)
    End Function
End Class
' #endregion
End Class
