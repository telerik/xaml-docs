Public Class Default_Vb


' #region radchart-howto-control-the-series_items-overlapping-via-zIndex-property_1
Public Class UserDataPoint
            Private _y As Double
            Private _bubbleSize As Double
            Private _legendLabel As String
            Public Sub New()
            End Sub
            Public Sub New(ByVal x As Double, ByVal y As Double)
                  Me._y = y
            End Sub
            Public Property Y() As Double
                  Get
                        Return _y
                  End Get
                  Set(ByVal value As Double)
                        Me._y = value
                  End Set
            End Property
            Public Property BubbleSize() As Double
                  Get
                        Return _bubbleSize
                  End Get
                  Set(ByVal value As Double)
                        Me._bubbleSize = value
                  End Set
            End Property
            Public Property LegendLabel() As String
                  Get
                        Return _legendLabel
                  End Get
                  Set(ByVal value As String)
                        Me._legendLabel = value
                  End Set
            End Property
End Class
      Public NotInheritable Class SeriesExtensions
            Private Sub New()
            End Sub
            Public Shared Function GetUserBubbleData() As List(Of UserDataPoint)
                  Dim points As New List(Of UserDataPoint)()
                  points.Add(CreateBubbleUserDataPoint(20, -100))
                  points.Add(CreateBubbleUserDataPoint(40, 100))
                  points.Add(CreateBubbleUserDataPoint(80, -20))
                  points.Add(CreateBubbleUserDataPoint(60, 10))
                  Return points
            End Function
            Private Shared Function CreateBubbleUserDataPoint(ByVal valueY As Double, ByVal bubbleSize As Double) As UserDataPoint
                  Dim dataPnt As New UserDataPoint()
                  dataPnt.Y = valueY
                  dataPnt.BubbleSize = bubbleSize
                  Return dataPnt
            End Function
      End Class
' #endregion

' #region radchart-howto-control-the-series_items-overlapping-via-zIndex-property_3
Public Class BubbleViewModel
Private _bubbleData As List(Of UserDataPoint)
Public ReadOnly Property BubbleData() As List(Of UserDataPoint)
Get
If Me._bubbleData Is Nothing Then
Me._bubbleData = SeriesExtensions.GetUserBubbleData()
End If
Return Me._bubbleData
End Get
End Property
End Class
' #endregion

' #region radchart-howto-control-the-series_items-overlapping-via-zIndex-property_6
Public Sub New()　
InitializeComponent()
AddHandler RadChart1.DefaultView.ChartArea.SelectionChanged, AddressOf ChartArea_SelectionChanged
End Sub　
Private Sub ChartArea_SelectionChanged(ByVal sender As Object, ByVal e As ChartSelectionChangedEventArgs)
If e.AddedItems.Count = 1 Then
SelectItem(e.AddedItems(0))
End If
End Sub
Private Sub SelectItem(ByVal point As DataPoint)
Dim bubbles = Me.RadChart1.DefaultView.ChartArea.ChildrenOfType(Of Bubble)()
For Each item As Bubble In bubbles
item.ClearValue(Canvas.ZIndexProperty)
Next item
Dim selectedBubble As Bubble = bubbles.SingleOrDefault(Function(bubble) bubble.DataContext Is point)
If selectedBubble IsNot Nothing Then
Canvas.SetZIndex(selectedBubble, 2000)
End If
End Sub
' #endregion
End Class
