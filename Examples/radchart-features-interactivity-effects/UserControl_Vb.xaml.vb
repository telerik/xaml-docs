Public Class Default_Vb


' #region radchart-features-interactivity-effects_4
Public Class DataObject
 Private Shared rand As New Random(Environment.TickCount)
 Private Shared adjrand As New Random(Environment.TickCount + rand.[Next]())
 Private _y1 As Double
 Private _y2 As Double
 Private _y3 As Double
 Private _y4 As Double
 Private _y5 As Double
 Public Property Y1() As Double
  Get
   Return _y1
  End Get
  Set
   _y1 = value
  End Set
 End Property
 Public Property Y2() As Double
  Get
   Return _y2
  End Get
  Set
   _y2 = value
  End Set
 End Property
 Public Property Y3() As Double
  Get
   Return _y3
  End Get
  Set
   _y3 = value
  End Set
 End Property
 Public Property Y4() As Double
  Get
   Return _y4
  End Get
  Set
   _y4 = value
  End Set
 End Property
 Public Property Y5() As Double
  Get
   Return _y5
  End Get
  Set
   _y5 = value
  End Set
 End Property
 Public Sub New(y1 As Double, y2 As Double, y3 As Double, y4 As Double, y5 As Double)
  Me.Y1 = y1
  Me.Y2 = y2
  Me.Y3 = y3
  Me.Y4 = y4
  Me.Y5 = y5
 End Sub
 Public Shared Function GetData() As List(Of DataObject)
  Dim list As New List(Of DataObject)()
  For i As Integer = 0 To 16
   Dim y1 As Double = rand.[Next](10, 100)
   list.Add(New DataObject(y1, y1 + adjrand.[Next](-10, 10), y1 + adjrand.[Next](-5, 5), y1 + adjrand.[Next](40, 75), y1 + adjrand.[Next](20, 50)))
  Next
  Return list
 End Function
End Class
' #endregion

' #region radchart-features-interactivity-effects_6
Me.RadChart.ItemsSource = DataObject.GetData()
' #endregion
End Class
