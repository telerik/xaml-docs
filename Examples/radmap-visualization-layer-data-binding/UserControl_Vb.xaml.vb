Public Class Default_Vb

' #region radmap_visualization_layer_data_binding_0
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

' #region radmap_visualization_layer_data_binding_1
Public Partial Class Example
	Inherits Window
	Public Sub New()
		InitializeComponent()

		Me.visualizationLayer.ItemsSource = Me.GetMapData()
	End Sub

	Private Function GetMapData() As ObservableCollection(Of MapItem)
	
		Dim data As New ObservableCollection(Of MapItem)()
	
		data.Add( _
			New MapItem( _
				"Sofia", _
				New Location(42.6957539183824, 23.3327663758679), _
				8, _
				New ZoomRange(5, 12)))
	
		data.Add( _
			New MapItem( _
				"Plovdiv", _
				New Location(42.1429369264591, 24.7498095849434), _
				8, _
				New ZoomRange(5, 12)))
	
		data.Add( _
			New MapItem( _
				"Burgas", _
				New Location(42.5131732087098, 27.4611884843576), _
				8, _
				New ZoomRange(5, 12)))
	
		data.Add( _
			New MapItem( _
				"Varna", _
				New Location(43.2073941930888, 27.9275176988258), _
				8, _
				New ZoomRange(5, 12)))
	
		Return data
	End Function
End Class
' #endregion

End Class
