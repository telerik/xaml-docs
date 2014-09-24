Public Class Default_Vb


    ' #region radsparkline_dataBinding_2
    Dim myLinearSparkline As New RadLinearSparkline()
    Dim r As New Random()
    Dim myData As New List(Of Double)()
For i As Integer = 0 To 19
      myData.Add(r.Next(0,100))
Next i
myLinearSparkline.ItemsSource = myData
    ' #endregion

    ' #region radsparkline_dataBinding_3
    Partial Public Class MainPage
        Inherits UserControl
        Public Sub New() 'MainWindow in WPF
            InitializeComponent()
            Dim today As Date = Date.Today

            Dim data As New List(Of MyCost)() From {New MyCost() With {.Cost = 1, .UnitCost = 2, .MyDate = today}, New MyCost() With {.Cost = 2, .UnitCost = 4, .MyDate = today.AddDays(1)}, New MyCost() With {.Cost = 3, .UnitCost = 6, .MyDate = today.AddDays(2)}, New MyCost() With {.Cost = 4, .UnitCost = 4, .MyDate = today.AddDays(3)}, New MyCost() With {.Cost = 5, .UnitCost = 8, .MyDate = today.AddDays(4)}}
            Me.DataContext = data
        End Sub
    End Class

    Public Class MyCost
        Public Property Cost() As Double
        Public Property UnitCost() As Double
        Public Property MyDate() As Date
    End Class
End Class
' #endregion
