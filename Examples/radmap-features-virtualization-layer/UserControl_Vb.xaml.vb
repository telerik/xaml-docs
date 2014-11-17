Public Class Default_Vb


' #region radmap-features-virtualization-layer_2
Public Class MapVirtualizationSource Implements IMapVirtualizationSource
	Shared ReadOnly bulgariaLocation As New Location(42.7669999748468, 25.2819999307394)
	Shared ReadOnly sofiaLocation As New Location(42.6957539183824, 23.3327663758679)

	Private Property BulgariaEllipse() As Ellipse
		Get
			Return m_BulgariaEllipse
		End Get
		Set
			m_BulgariaEllipse = Value
		End Set
	End Property
	Private m_BulgariaEllipse As Ellipse
	Private Property SofiaEllipse() As Ellipse
		Get
			Return m_SofiaEllipse
		End Get
		Set
			m_SofiaEllipse = Value
		End Set
	End Property
	Private m_SofiaEllipse As Ellipse

	Public Sub New()
		'Exectued ot UI thread
		BulgariaEllipse = New Ellipse()
		BulgariaEllipse.Width = 15
		BulgariaEllipse.Height = 15
		BulgariaEllipse.Fill = New SolidColorBrush(Colors.Red)
		BulgariaEllipse.SetValue(MapLayer.LocationProperty, bulgariaLocation)
		MapLayer.SetHotSpot(BulgariaEllipse, New HotSpot() With { .X = 0.5,  .Y = 0.5 })
		ToolTipService.SetToolTip(BulgariaEllipse, "Bulgaria")

		SofiaEllipse = New Ellipse()
		SofiaEllipse.Width = 20
		SofiaEllipse.Height = 20
		SofiaEllipse.Stroke = New SolidColorBrush(Colors.Red)
		SofiaEllipse.Fill = New SolidColorBrush(Colors.Transparent)
		SofiaEllipse.StrokeThickness = 3
		SofiaEllipse.SetValue(MapLayer.LocationProperty, sofiaLocation)
		MapLayer.SetHotSpot(SofiaEllipse, New HotSpot() With { .X = 0.5, .Y = 0.5 })
		ToolTipService.SetToolTip(SofiaEllipse, "Sofia")
	End Sub

	Public Sub BackgroundItemsRequest(sender As Object, e As BackgroundItemsRequestEventArgs)
		Dim currentRegion As New LocationRect(e.UpperLeft, e.LowerRight)

		Dim visibleItems As New List(Of Object)()

		If currentRegion.Contains(bulgariaLocation) Then
			If e.MinZoom = 3 Then
				visibleItems.Add(Me.BulgariaEllipse)
			ElseIf e.MinZoom = 6 Then
				visibleItems.Add(Me.SofiaEllipse)
			End If
		End If
		e.CompleteItemsRequest(visibleItems)
	End Sub
End Class

' #endregion

' #region radmap-features-virtualization-layer_4
Public Sub New()
	InitializeComponent()
	Me.radMap.Provider = New OpenStreetMapProvider()
	Me.virtualizationLayer.VirtualizationSource = New MapVirtualizationSource()
End Sub
' #endregion
End Class
