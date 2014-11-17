Public Class Default_Vb


' #region dragdropmanager-getting-started_1
Public Class ApplicationInfo
 Public Property Price() As [Double]
  Get
   Return m_Price
  End Get
  Set
   m_Price = Value
  End Set
 End Property
 Private m_Price As [Double]
 Public Property IconPath() As [String]
  Get
   Return m_IconPath
  End Get
  Set
   m_IconPath = Value
  End Set
 End Property
 Private m_IconPath As [String]
 Public Property Name() As [String]
  Get
   Return m_Name
  End Get
  Set
   m_Name = Value
  End Set
 End Property
 Private m_Name As [String]
 Public Property Author() As [String]
  Get
   Return m_Author
  End Get
  Set
   m_Author = Value
  End Set
 End Property
 Private m_Author As [String]
 Public Shared Function GenerateApplicationInfos() As ObservableCollection(Of ApplicationInfo)
  Dim result As New ObservableCollection(Of ApplicationInfo)()
  Dim info1 As New ApplicationInfo()
  info1.Name = "Large Collider"
  info1.Author = "C.E.R.N."
  info1.IconPath = "img/Atom.png"
  result.Add(info1)
  Dim info2 As New ApplicationInfo()
  info2.Name = "Paintbrush"
  info2.Author = "Imagine Inc."
  info2.IconPath = "img/Brush.png"
  result.Add(info2)
  Dim info3 As New ApplicationInfo()
  info3.Name = "Lively Calendar"
  info3.Author = "Control AG"
  info3.IconPath = "img/CalendarEvents.png"
  result.Add(info3)
  Dim info4 As New ApplicationInfo()
  info4.Name = "Fire Burning ROM"
  info4.Author = "The CD Factory"
  info4.IconPath = "img/CDBurn.png"
  result.Add(info4)
  Dim info5 As New ApplicationInfo()
  info5.Name = "Fav Explorer"
  info5.Author = "Star Factory"
  info5.IconPath = "img/favorites.png"
  result.Add(info5)
  Dim info6 As New ApplicationInfo()
  info6.Name = "IE Fox"
  info6.Author = "Open Org"
  info6.IconPath = "img/Connected.png"
  result.Add(info6)
  Dim info7 As New ApplicationInfo()
  info7.Name = "Charting"
  info7.Author = "AA-AZ inc"
  info7.IconPath = "img/ChartDot.png"
  result.Add(info7)
  Dim info8 As New ApplicationInfo()
  info8.Name = "SuperPlay"
  info8.Author = "EB Games"
  info8.IconPath = "img/Games.png"
  result.Add(info8)
  Return result
 End Function
End Class
' #endregion

' #region dragdropmanager-getting-started_4
ApplicationList.ItemsSource = ApplicationInfo.GenerateApplicationInfos()
MyAppList.ItemsSource = New ObservableCollection(Of ApplicationInfo)()
' #endregion

' #region dragdropmanager-getting-started_6
DragDropManager.AddDragInitializeHandler(ApplicationList, New DragInitializeEventHandler(AddressOf OnDragInitialize))
DragDropManager.AddDragInitializeHandler(MyAppList, New DragInitializeEventHandler(AddressOf OnDragInitialize))
DragDropManager.AddGiveFeedbackHandler(ApplicationList, New GiveFeedbackEventHandler(AddressOf OnGiveFeedback))
DragDropManager.AddGiveFeedbackHandler(MyAppList, New GiveFeedbackEventHandler(AddressOf OnGiveFeedback))
DragDropManager.AddDragDropCompletedHandler(ApplicationList, New DragDropCompletedEventHandler(AddressOf OnDragDropCompleted))
DragDropManager.AddDragDropCompletedHandler(MyAppList, New DragDropCompletedEventHandler(AddressOf OnDragDropCompleted))
DragDropManager.AddDropHandler(ApplicationList, New DropEventHandler(AddressOf OnDrop))
DragDropManager.AddDropHandler(MyAppList, New DropEventHandler(AddressOf OnDrop))

' #endregion

' #region dragdropmanager-getting-started_8
Private Sub OnDragInitialize(ByVal sender As Object, ByVal args As DragInitializeEventArgs)
	args.AllowedEffects = DragDropEffects.All
	Dim payload = DragDropPayloadManager.GeneratePayload(Nothing)
	Dim data = CType(args.OriginalSource, FrameworkElement).DataContext
	payload.SetData("DragData", data)
	args.Data = payload
	args.DragVisual = New ContentControl With {.Content = data, .ContentTemplate = TryCast(LayoutRoot.Resources("ApplicationTemplate"), DataTemplate)}
End Sub
' #endregion

' #region dragdropmanager-getting-started_10
Private Sub OnGiveFeedback(sender As Object, args As Telerik.Windows.DragDrop.GiveFeedbackEventArgs)
 args.SetCursor(Cursors.Arrow)
 args.Handled = True
End Sub
' #endregion

' #region dragdropmanager-getting-started_12
Private Sub OnDrop(ByVal sender As Object, ByVal args As Telerik.Windows.DragDrop.DragEventArgs)
	Dim data = CType(args.Data, DataObject).GetData("DragData")
	CType((TryCast(sender, ListBox)).ItemsSource, IList).Add(data)
End Sub

Public Sub OnDragDropCompleted(ByVal sender As Object, ByVal args As Telerik.Windows.DragDrop.DragDropCompletedEventArgs)
	Dim data = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData")
	CType((TryCast(sender, ListBox)).ItemsSource, IList).Remove(data)
End Sub
    ' #endregion

    ' #region dragdropmanager-getting-started_14
Private Sub OnDrop(ByVal sender As Object, ByVal args As Telerik.Windows.DragDrop.DragEventArgs)
	Dim data = CType(args.Data, DataObject).GetData("DragData")
	CType((TryCast(sender, ListBox)).ItemsSource, IList).Add(data)
End Sub

Public Sub OnDragCompleted(ByVal sender As Object, ByVal args As Telerik.Windows.DragDrop.DragDropCompletedEventArgs)
	Dim data = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData")
	CType((TryCast(sender, ListBox)).ItemsSource, IList).Remove(data)
End Sub
    ' #endregion
End Class
