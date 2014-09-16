Public Class Default_Vb

' #region radmap_visualization_layer_property_accessor_0
Public Class MapItem
	Implements INotifyPropertyChanged
	Private m_baseZoomLevel As Double = Double.NaN
	Private m_caption As String = String.Empty
	Private m_location As Location = Location.Empty
	Private m_zoomRange As ZoomRange = ZoomRange.Empty

	Public Sub New( _
	  caption As String, _
	  location As Location, _
	  baseZoomLevel As Double, _
	  zoomRange As ZoomRange)
		Me.Caption = caption
		Me.Location = location
		Me.BaseZoomLevel = baseZoomLevel
		Me.ZoomRange = zoomRange
	End Sub

	Public Event PropertyChanged As PropertyChangedEventHandler _
		Implements INotifyPropertyChanged.PropertyChanged

	Public Property BaseZoomLevel() As Double
		Get
			Return Me.m_baseZoomLevel
		End Get

		Set(value As Double)
			Me.m_baseZoomLevel = value
			Me.OnPropertyChanged("BaseZoomLevel")
		End Set
	End Property

	Public Property Caption() As String
		Get
			Return Me.m_caption
		End Get

		Set(value As String)
			Me.m_caption = value
			Me.OnPropertyChanged("Caption")
		End Set
	End Property

	Public Property Location() As Location
		Get
			Return Me.m_location
		End Get

		Set(value As Location)
			Me.m_location = value
			Me.OnPropertyChanged("Location")
		End Set
	End Property
	
	Public Function GetZIndex(item As Object) As Integer _
		Implements IMapPropertyAccessor.GetZIndex
		Dim value As Integer = Integer.MinValue

		Return value
	End Function

	Public Property ZoomRange() As ZoomRange
		Get
			Return Me.m_zoomRange
		End Get

		Set(value As ZoomRange)
			Me.m_zoomRange = value
			Me.OnPropertyChanged("ZoomRange")
		End Set
	End Property

	Private Sub OnPropertyChanged(propertyName As String)
		RaiseEvent PropertyChanged(Me, _
		  New PropertyChangedEventArgs(propertyName))
	End Sub
End Class
' #endregion

' #region radmap_visualization_layer_property_accessor_1
Public Class CustomPropertyAccessor
	Implements IMapPropertyAccessor
	Public Function GetDouble(item As Object, member As DataMember) As Double _
		Implements IMapPropertyAccessor.GetDouble
		Dim value As Double = Double.NaN

		Dim mapItem As MapItem = TryCast(item, MapItem)
		If mapItem IsNot Nothing Then
			Select Case member
				Case DataMember.MaxScale
					Exit Select

				Case DataMember.MinScale
					Exit Select

				Case DataMember.ZoomLevel
					' Base zoom level
					value = mapItem.BaseZoomLevel
					Exit Select
			End Select
		End If

		Return value
	End Function

	Public Function GetHotspot(item As Object) As HotSpot _
		Implements IMapPropertyAccessor.GetHotspot
		Return Nothing
	End Function

	Public Function GetLocation(item As Object) As Location _
		Implements IMapPropertyAccessor.GetLocation
		Dim loc As Location = Location.Empty

		Dim mapItem As MapItem = TryCast(item, MapItem)
		If mapItem IsNot Nothing Then
			loc = mapItem.Location
		End If

		Return loc
	End Function

	Public Function GetZoomRange(item As Object) As ZoomRange _
		Implements IMapPropertyAccessor.GetZoomRange
		Dim range As ZoomRange = ZoomRange.Empty

		Dim mapItem As MapItem = TryCast(item, MapItem)
		If mapItem IsNot Nothing Then
			range = mapItem.ZoomRange
		End If

		Return range
	End Function
End Class
' #endregion

' #region radmap_visualization_layer_property_accessor_2
Public Sub New()
	InitializeComponent()

	Me.visualizationLayer.PropertyAccessor = New CustomPropertyAccessor()
	Me.visualizationLayer.UseDefaultPropertyAccessor = False
	Me.visualizationLayer.ItemsSource = Me.GetMapData()
End Sub
' #endregion

End Class
