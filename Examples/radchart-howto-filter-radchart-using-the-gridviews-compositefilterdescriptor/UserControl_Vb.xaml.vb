Public Class Default_Vb


' #region radchart-howto-filter-radchart-using-the-gridviews-compositefilterdescriptor_1
Public Class MyDateObject
            Public Property Value1() As Double
            Public Property Value2() As Double
            Public Property Value3() As Double
            Public Property [Date]() As Date
   End Class
      Public Class MyDataContext
            Public Const min As Integer = 21
            Public Const max As Integer = 79
            Public Property List() As ObservableCollection(Of MyDateObject)
            Private r As New Random()
            Private baseDate As Date = Date.Today
            Public Sub New()
                  Me.CreateChartData()
            End Sub
            Private Sub CreateChartData()
                  List = New ObservableCollection(Of MyDateObject)()
                  For i As Integer = 0 To 14
                        List.Add(New MyDateObject() With {.Value1 = r.Next(min, max), .Value2 = r.Next(min, max), .Value3 = r.Next(min, max), .Date = baseDate.AddDays(i)})
                  Next i
            End Sub
      End Class
' #endregion

' #region radchart-howto-filter-radchart-using-the-gridviews-compositefilterdescriptor_4
Dim chartFilterDescriptorCol As New CompositeFilterDescriptor()
Private Sub GridView1_Filtered(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridView.GridViewFilteredEventArgs)
If e.Added.Count() > 0 Then
For Each filter As FilterDescriptor In e.Added
Dim gridFilterDescriptor As FilterDescriptor = filter
chartFilterDescriptorCol.FilterDescriptors.Add(gridFilterDescriptor)
chartFilterDescriptorCol.LogicalOperator = FilterCompositionLogicalOperator.Or
Next filter
End If
Me.RadChart1.FilterDescriptors.Add(chartFilterDescriptorCol)
End Sub
' #endregion

' #region radchart-howto-filter-radchart-using-the-gridviews-compositefilterdescriptor_7
Imports Microsoft.VisualBasic
Private chartFilterDescriptorCol As New CompositeFilterDescriptor()
public MainPage()
            Public Sub New()
                  InitializeComponent()
                  RadChart1.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "ddd" & vbLf & "dd.MM"
                  Dim context As New MyDataContext()
                  Me.DataContext = context
            End Sub
            Private Sub GridView1_Filtered(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridView.GridViewFilteredEventArgs)
                  If e.Added.Count() > 0 Then
                        For Each filter As FilterDescriptor In e.Added
                              Dim gridFilterDescriptor As FilterDescriptor = filter
                              chartFilterDescriptorCol.FilterDescriptors.Add(gridFilterDescriptor)
                              chartFilterDescriptorCol.LogicalOperator = FilterCompositionLogicalOperator.Or
                        Next filter
                  End If
                        Me.RadChart1.FilterDescriptors.Add(chartFilterDescriptorCol)
            End Sub
      }
      Public Class MyDateObject
            Public Property Value1() As Double
            Public Property Value2() As Double
            Public Property Value3() As Double
            Public Property [Date]() As Date
      End Class
      Public Class MyDataContext
            Public Const min As Integer = 21
            Public Const max As Integer = 79
            Public Property List() As ObservableCollection(Of MyDateObject)
            Private r As New Random()
            Private baseDate As Date = Date.Today
            Public Sub New()
                  Me.CreateChartData()
            End Sub
            Private Sub CreateChartData()
                  List = New ObservableCollection(Of MyDateObject)()
                  For i As Integer = 0 To 14
                        List.Add(New MyDateObject() With {.Value1 = r.Next(min, max), .Value2 = r.Next(min, max), .Value3 = r.Next(min, max), .Date = baseDate.AddDays(i)})
                  Next i
            End Sub
      End Class
' #endregion
End Class
