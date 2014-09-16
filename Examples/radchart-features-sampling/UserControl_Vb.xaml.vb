Public Class Default_Vb


' #region radchart-features-sampling_3
Public NotInheritable Class Statistics
            Private Sub New()
            End Sub
            Public Shared Function StdDev(Of TSource)(ByVal source As IEnumerable(Of TSource), ByVal selector As Func(Of TSource, MyClass)) As Double
                  Return StdDev(Of TSource, MyClass)(source, selector)
            End Function
            Public Shared Function StdDev(Of TSource, TResult As [MyClass])(ByVal source As IEnumerable(Of TSource), ByVal selector As Func(Of TSource, TResult)) As Double
                  Dim itemCount As Integer = source.Count()
                  If itemCount > 1 Then
                        Dim values As IEnumerable(Of Double) = From i In source
                                                               Select Convert.ToDouble(selector(i).Y)
                        Dim sum As Double = SumAvg(values)
                        Return Math.Sqrt(sum / (itemCount - 1))
                  End If
                  Return 0
            End Function
            Private Shared Function SumAvg(ByVal values As IEnumerable(Of Double)) As Double
                  Dim average As Double = values.Average()
                  Dim sum As Double = 0
                  For Each item As Double In values
                        sum += Math.Pow(item - average, 2)
                  Next item
                  Return sum
            End Function
End Class
' #endregion

' #region radchart-features-sampling_5
Public Class StandardDeviationFunction
      Inherits EnumerableSelectorAggregateFunction
            Protected Overrides ReadOnly Property AggregateMethodName() As String
                  Get
                        Return "StdDev"
                  End Get
            End Property
            Protected Overrides ReadOnly Property ExtensionMethodsType() As Type
                  Get
                        Return GetType(Statistics)
                  End Get
            End Property
End Class
' #endregion

' #region radchart-features-sampling_7
...
InitializeComponent()
RadChar1.DefaultView.ChartArea.AxisX.LabelStep = 4
Dim data As New List(Of MyClass)()
For i As Integer = 0 To 999
data.Add(New [MyClass]() With {.Y = i})
Next i
RadChar1.ItemsSource = data
...
Public Class [MyClass]
Public Property Y() As Double
End Class
' #endregion
End Class
