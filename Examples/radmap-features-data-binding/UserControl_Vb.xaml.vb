Public Class Default_Vb


' #region radmap-features-data-binding_2
Public Sub New()
 InitializeComponent()
 Me.radMap.InitializeCompleted += radMap_InitializeCompleted
End Sub
Private Sub radMap_InitializeCompleted(sender As Object, e As EventArgs)
 Me.informationLayer.ItemsSource = Me.GetMapData()
End Sub
' #endregion

' #region radmap-features-data-binding_5
Public Class MapItem
 Public Sub New(caption As String, location As Location, baseZoomLevel As Double, zoomRange As ZoomRange)
  Me.Caption = caption
  Me.Location = location
  Me.BaseZoomLevel = baseZoomLevel
  Me.ZoomRange = zoomRange
 End Sub
 Public Property Caption() As String
  Get
   Return m_Caption
  End Get
  Set
   m_Caption = Value
  End Set
 End Property
 Private m_Caption As String
 Public Property Location() As Location
  Get
   Return m_Location
  End Get
  Set
   m_Location = Value
  End Set
 End Property
 Private m_Location As Location
 Public Property BaseZoomLevel() As Double
  Get
   Return m_BaseZoomLevel
  End Get
  Set
   m_BaseZoomLevel = Value
  End Set
 End Property
 Private m_BaseZoomLevel As Double
 Public Property ZoomRange() As ZoomRange
  Get
   Return m_ZoomRange
  End Get
  Set
   m_ZoomRange = Value
  End Set
 End Property
 Private m_ZoomRange As ZoomRange
End Class
' #endregion

' #region radmap-features-data-binding_7
Private Function GetMapData() As ObservableCollection(Of MapItem)
 Dim data As New ObservableCollection(Of MapItem)()
 data.Add(New MapItem("Sofia", New Location(42.6957539183824, 23.3327663758679), 5, New ZoomRange(5, 12)))
 data.Add(New MapItem("Plovdiv", New Location(42.1429369264591, 24.7498095849434), 5, New ZoomRange(5, 12)))
 data.Add(New MapItem("Burgas", New Location(42.5131732087098, 27.4611884843576), 5, New ZoomRange(5, 12)))
 data.Add(New MapItem("Varna", New Location(43.2073941930888, 27.9275176988258), 5, New ZoomRange(5, 12)))
 Return data
End Function
' #endregion
End Class
