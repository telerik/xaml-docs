'#region raddiagram-extensions-toolbox-0
Public Class MainViewModel
	Public Property GalleryItems() As HierarchicalGalleryItemsCollection
		Get
			Return _GalleryItems
		End Get
		Set
			_GalleryItems = Value
		End Set
	End Property
	Private _GalleryItems As HierarchicalGalleryItemsCollection

	Public Sub New()
		Me.GalleryItems = New HierarchicalGalleryItemsCollection()
	End Sub
End Class	
' #endregion
'#region raddiagram-extensions-toolbox-1
Public Class MainViewModel
	Public Property GalleryItems() As ObservableCollection(Of Gallery)
		Get
			Return _GalleryItems
		End Get
		Set
			_GalleryItems = Value
		End Set
	End Property
	Private _GalleryItems As ObservableCollection(Of Gallery)

	Public Sub New()
		Me.GalleryItems = New ObservableCollection(Of Gallery)()
		LoadData("Basic", "Flowchart", "Arrow","Container")
	End Sub

	Private Sub LoadData(ParamArray galleryNames As String())
		Dim allItems = New GalleryItemsCollection()

		For Each galleryName As var In galleryNames
			Dim gallery = New Gallery() With { .Header = galleryName }
			For Each item As var In allItems.GetItemsByType(galleryName).ToArray()
				gallery.Items.Add(item)
			Next
			Me.GalleryItems.Add(gallery)
		Next
	End Sub
End Class	
' #endregion
'#region raddiagram-extensions-toolbox-2
Public Class MainViewModel
	Public Property GalleryItems() As ObservableCollection(Of Gallery)
		Get
			Return _GalleryItems
		End Get
		Set
			_GalleryItems = Value
		End Set
	End Property
	Private _GalleryItems As ObservableCollection(Of Gallery)

	Public Sub New()
		Me.GalleryItems = New ObservableCollection(Of Gallery)()
		LoadData("Basic")
	End Sub

	Private Sub LoadData(ParamArray galleryNames As String())
		Dim allItems = New GalleryItemsCollection()

		For Each galleryName As var In galleryNames
			Dim gallery = New Gallery() With { .Header = galleryName}
			For Each item As var In allItems.GetItemsByType(galleryName).ToArray()
				gallery.Items.Add(item)
			Next
			Me.GalleryItems.Add(gallery)
		Next
	End Sub
End Class
' #endregion
'#region raddiagram-extensions-toolbox-3
Public Class MyShape
	Public Property Geometry() As Geometry
	Public Property Header() As String
End Class
Public Class MyGallery
	Public Property Header() As String
	Public Property Shapes() As ObservableCollection(Of MyShape)
	Public Sub New()
		Me.Shapes = New ObservableCollection(Of MyShape)()
	End Sub
End Class
Public Class MainViewModel
	Public Property Items() As ObservableCollection(Of MyGallery)
	Public Sub New()
		Me.Items = New ObservableCollection(Of MyGallery)()
		'create and populate the first custom gallery
		Dim firstGallery As MyGallery = New MyGallery With {.Header = "First Gallery"}
		firstGallery.Shapes.Add(New MyShape With {.Header = "Shape 1.1", .Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.CloudShape)})
		firstGallery.Shapes.Add(New MyShape With {.Header = "Shape 1.2", .Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.EllipseShape)})
		firstGallery.Shapes.Add(New MyShape With {.Header = "Shape 1.3", .Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.HexagonShape)})
		firstGallery.Shapes.Add(New MyShape With {.Header = "Shape 1.4", .Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.PentagonShape)})
		firstGallery.Shapes.Add(New MyShape With {.Header = "Shape 1.5", .Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.RightTriangleShape)})
		Me.Items.Add(firstGallery)

		'create and populate the second custom gallery
		Dim secondGallery As MyGallery = New MyGallery With {.Header = "Second Gallery"}
		secondGallery.Shapes.Add(New MyShape With {.Header = "Shape 2.1", .Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.CardShape)})
		secondGallery.Shapes.Add(New MyShape With {.Header = "Shape 2.2", .Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.Database1Shape)})
		secondGallery.Shapes.Add(New MyShape With {.Header = "Shape 2.3", .Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.CollateShape)})
		secondGallery.Shapes.Add(New MyShape With {.Header = "Shape 2.4", .Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.DataShape)})
		secondGallery.Shapes.Add(New MyShape With {.Header = "Shape 2.5", .Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.DisplayShape)})
		Me.Items.Add(secondGallery)
	End Sub
End Class
' #endregion

'#region raddiagram-extensions-toolbox-4
' #endregion