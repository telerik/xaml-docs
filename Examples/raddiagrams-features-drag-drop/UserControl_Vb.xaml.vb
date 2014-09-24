'#region  raddiagrams-features-drag-drop-0
xDiagram.AllowDrop = True	
'#endregion
'#region  raddiagrams-features-drag-drop-1
Public Sub New()
	InitializeComponent()
	DragDropManager.AddDragInitializeHandler(xListBox, AddressOf OnDragInitialize)
End Sub

'ListBox OnDragInitialize method implementation
Private Sub OnDragInitialize(sender As Object, args As DragInitializeEventArgs)
	args.AllowedEffects = DragDropEffects.All
	Dim draggedShape As RadDiagramShape = TryCast(TryCast(args.OriginalSource, ListBoxItem).Content, RadDiagramShape)
	Dim shapes As New List(Of RadDiagramShape)()
	shapes.Add(draggedShape)
	Dim serializaedInfo As SerializationInfo = SerializationService.[Default].SerializeItems(shapes)
	args.Data = serializaedInfo
End Sub
'#endregion
'#region  raddiagrams-features-drag-drop-2
Public Sub New()
	InitializeComponent()
	DragDropManager.AddDragInitializeHandler(xListBox, AddressOf OnDragInitialize)
End Sub

'ListBox OnDragInitialize method implementation
Private Sub OnDragInitialize(sender As Object, args As DragInitializeEventArgs)
	args.AllowedEffects = DragDropEffects.All
	Dim draggedShape As RadDiagramShape = TryCast(args.OriginalSource, RadDiagramShape)
	Dim shapes As New List(Of RadDiagramShape)()
	shapes.Add(draggedShape)
	Dim serializaedInfo As SerializationInfo = SerializationService.[Default].SerializeItems(shapes)
	args.Data = serializaedInfo
End Sub
'#endregion
'#region  raddiagrams-features-drag-drop-3
Public Class ApplicationInfo
	Public Property Price() As Double

	Public Property IconPath() As String

	Public Property Name() As String

	Public Property Author() As String
End Class
Public Class MainViewModel
	Private _allApplications As ObservableCollection(Of ApplicationInfo) = GenerateApplicationInfos()

	Public Property AllApplications() As ObservableCollection(Of ApplicationInfo)
		Get
			Return Me._allApplications
		End Get
		Set(ByVal value As ObservableCollection(Of ApplicationInfo))
			Me._allApplications = value
		End Set
	End Property

	Public Shared Function GenerateApplicationInfos() As ObservableCollection(Of ApplicationInfo)
		Dim result As New ObservableCollection(Of ApplicationInfo)()

		Dim info1 As New ApplicationInfo()
		info1.Name = "Large Collider"
		info1.Author = "C.E.R.N."
		info1.IconPath = "Images/Atom.png"
		result.Add(info1)

		Dim info2 As New ApplicationInfo()
		info2.Name = "Paintbrush"
		info2.Author = "Imagine Inc."
		info2.IconPath = "Images/Brush.png"
		result.Add(info2)

		Dim info3 As New ApplicationInfo()
		info3.Name = "Lively Calendar"
		info3.Author = "Control AG"
		info3.IconPath = "Images/CalendarEvents.png"
		result.Add(info3)

		Dim info4 As New ApplicationInfo()
		info4.Name = "Fire Burning ROM"
		info4.Author = "The CD Factory"
		info4.IconPath = "Images/CDBurn.png"
		result.Add(info4)

		Dim info5 As New ApplicationInfo()
		info5.Name = "Fav Explorer"
		info5.Author = "Star Factory"
		info5.IconPath = "Images/favorites.png"
		result.Add(info5)

		Return result
	End Function
End Class
'#endregion
'#region  raddiagrams-features-drag-drop-4
Public Sub New()
	InitializeComponent()
	DragDropManager.AddDragInitializeHandler(xListBox, AddressOf OnDragInitialize)
End Sub
'ListBox OnDragInitialize method implementation
Private Sub OnDragInitialize(ByVal sender As Object, ByVal args As DragInitializeEventArgs)
	args.AllowedEffects = DragDropEffects.All
	args.Data = (CType(args.OriginalSource, FrameworkElement)).DataContext
	args.DragVisual = New ContentControl With {.Content = args.Data, .ContentTemplate = TryCast(Me.Resources("ApplicationTemplate"), DataTemplate)}
End Sub
'#endregion
'Silverlight
'#region  raddiagrams-features-drag-drop-5
Public Sub New()
	InitializeComponent()
	DragDropManager.AddDropHandler(Me.xDiagram, OnDiagramDrop)
End Sub

Private Sub OnDiagramDrop(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
	e.Handled = True
	Dim shape As New RadDiagramShape()
	shape.Content = If(TypeOf e.Data Is ApplicationInfo, TryCast(e.Data, ApplicationInfo).Name, e.Data.ToString())
	Dim currentPosition = xDiagram.GetTransformedPoint(e.GetPosition(xDiagram))
	shape.Position = New Point(currentPosition.X, currentPosition.Y)

	Me.xDiagram.AddShape(shape)
End Sub
'#endregion
'WPF
'#region  raddiagrams-features-drag-drop-6
Public Sub New()
	InitializeComponent()
	DragDropManager.AddDropHandler(Me.xDiagram, OnDiagramDrop)
End Sub

Private Sub OnDiagramDrop(sender As Object, e As Telerik.Windows.DragDrop.DragEventArgs)
	e.Handled = True
	Dim shape As New RadDiagramShape()
	Dim draggedData As ApplicationInfo = TryCast(TryCast(e.Data, DataObject).GetData(GetType(ApplicationInfo)), ApplicationInfo)
	shape.Content = If(draggedData IsNot Nothing, draggedData.Name, e.Data.ToString())
	Dim currentPosition = xDiagram.GetTransformedPoint(e.GetPosition(xDiagram))
	shape.Position = New Point(currentPosition.X, currentPosition.Y)

	Me.xDiagram.AddShape(shape)
End Sub
'#endregion