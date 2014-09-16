Public Class UserControl_Vb


' #region radchart-features-tooltip_4
Public Class QuarterToVisibilityConverter
    Implements IValueConverter
    Public Function Convert(value As Object, targetType As System.Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
        If value Is Nothing Then
            Return Visibility.Collapsed
        End If
        Return Visibility.Visible
    End Function
    Public Function ConvertBack(value As Object, targetType As System.Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
        Throw New NotImplementedException
    End Function
End Class
Public Class ProfitToBrushConverter
    Implements IValueConverter
    Public Function Convert(value As Object, targetType As System.Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
        Dim profitDifference As Double = DirectCast(value, Double)
        If (profitDifference < 0) Then
            Return New SolidColorBrush(Colors.Red)
        End If
        If (profitDifference > 0) Then
            Return New SolidColorBrush(Colors.Green)
        End If
        Return New SolidColorBrush(Colors.Blue)
    End Function
    Public Function ConvertBack(value As Object, targetType As System.Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
        Throw New NotImplementedException
    End Function
End Class
' #endregion

' #region radchart-features-tooltip_6
Public Class ProfitDifferenceContext
    Dim _quarter As String
    Dim _profit As Double
    Dim _previousQuarter As Object
    Dim _previousDifference As Double
    Dim _nextQuarter As Object
    Dim _nextDifference As Double


    Public Property Quarter() As String
        Get
            Return Me._quarter
        End Get
        Set(value As String
            Me._quarter = value
        End Set
    End Property
   
    Public Property Profit() As Double
        Get
            Return Me._profit
        End Get
        Set(value As Double)
            Me._profit = value
        End Set
    End Property

  Public Property PreviousQuarter() As Object
        Get
            Return Me._previousQuarter
        End Get
        Set(value As Object)
            Me._previousQuarter = value
        End Set
    End Property
   
    Public Property Profit() As Double
        Get
            Return Me._previousDifference 
        End Get
        Set(value As Double)
            Me._previousDifference = value
        End Set
    End Property

  Public Property NextQuarter() As Object
        Get
            Return Me._nextQuarter 
        End Get
        Set(value As Object)
            Me._nextQuarter = value
        End Set
    End Property
   
    Public Property NextDifference() As Double
        Get
            Return Me._nextDifference 
        End Get
        Set(value As Double)
            Me._nextDifference = value
        End Set
    End Property    
End Class
' #endregion
End Class
