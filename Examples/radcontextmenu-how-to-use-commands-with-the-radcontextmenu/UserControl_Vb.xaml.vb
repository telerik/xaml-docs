Public Class Default_Vb


' #region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_2
Public Class ExampleViewModel
 Implements INotifyPropertyChanged
 Private selectedItem As DataItem
 Public Sub New()
  Me.InitItems()
 End Sub
 Public Event PropertyChanged As PropertyChangedEventHandler
 Public Property Items() As ObservableCollection(Of DataItem)
  Get
  End Get
  Set
  End Set
 End Property
 Public Property SelectedItem() As DataItem
  Get
   Return Me.selectedItem
  End Get
  Set
   If Me.selectedItem <> value Then
    Me.selectedItem = value
    Me.OnNotifyPropertyChanged("SelectedItem")
   End If
  End Set
 End Property
 Private Sub OnNotifyPropertyChanged(propertyName As String)
  If Me.PropertyChanged <> Nothing Then
   Me.PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
  End If
 End Sub
 Private Sub InitItems()
  Dim items As New ObservableCollection(Of DataItem)()
  items.Add(New DataItem("Item 1"))
  items.Add(New DataItem("Item 2"))
  items.Add(New DataItem("Item 3"))
  Me.Items = items
 End Sub
End Class
' #endregion

' #region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_4
Private viewModel As ExampleViewModel
Public Sub New()
 InitializeComponent()
 Me.viewModel = New ExampleViewModel()
 Me.DataContext = viewModel
End Sub
' #endregion

' #region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_8
Private Sub RadContextMenu_Opened(sender As Object, e As RoutedEventArgs)
 Dim item As System.Windows.Controls.ListBoxItem = Me.radContextMenu.GetClickedElement(Of System.Windows.Controls.ListBoxItem)()
 If item <> Nothing Then
  Me.listBox.SelectedItem = item.DataContext
 Else
  Me.listBox.SelectedItem = Nothing
 End If
End Sub
' #endregion

' #region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_10
Public Property MoveUpCommand() As RoutedUICommand
 Get
 End Get
 Private Set
 End Set
End Property
Public Property MoveDownCommand() As RoutedUICommand
 Get
 End Get
 Private Set
 End Set
End Property
' #endregion

' #region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_12
Public Sub New()
 Me.MoveUpCommand = New RoutedUICommand("Move Up", "MoveUp", GetType(ExampleViewModel))
 Me.MoveDownCommand = New RoutedUICommand("Move Down", "MoveDown", GetType(ExampleViewModel))
 Me.InitItems()
End Sub
' #endregion

' #region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_15
Public Sub MoveUp(sender As Object, e As ExecutedRoutedEventArgs)
 If Me.SelectedItem = Nothing OrElse Me.Items.IndexOf(TryCast(Me.SelectedItem, DataItem)) = 0 Then
  Return
 End If
 Dim item As DataItem = Me.SelectedItem
 Dim index As Integer = Me.Items.IndexOf(TryCast(item, DataItem))
 Me.Items.Remove(TryCast(item, DataItem))
 Me.Items.Insert(index - 1, TryCast(item, DataItem))
 Me.SelectedItem = item
End Sub
Public Sub MoveDown(sender As Object, e As ExecutedRoutedEventArgs)
 If Me.SelectedItem = Nothing OrElse Me.Items.IndexOf(TryCast(Me.SelectedItem, DataItem)) = Me.Items.Count - 1 Then
  Return
 End If
 Dim item As DataItem = Me.SelectedItem
 Dim index As Integer = Me.Items.IndexOf(TryCast(item, DataItem))
 Me.Items.Remove(TryCast(item, DataItem))
 Me.Items.Insert(index + 1, TryCast(item, DataItem))
 Me.SelectedItem = item
End Sub
' #endregion

' #region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_17
Public Function GetCommandBindings() As CommandBindingCollection
 Dim bindings As New CommandBindingCollection()
 bindings.Add(New CommandBinding(Me.MoveUpCommand, Me.MoveUp))
 bindings.Add(New CommandBinding(Me.MoveDownCommand, Me.MoveDown))
 Return bindings
End Function
' #endregion

' #region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_19
Public Sub New()
 InitializeComponent()
 Me.viewModel = New ExampleViewModel()
 Me.DataContext = viewModel
 CommandManager.SetCommandBindings(Me, Me.viewModel.GetCommandBindings())
End Sub
' #endregion

' #region radcontextmenu-how-to-use-commands-with-the-radcontextmenu_21
Public Sub New()
	InitializeComponent()
	Me.viewModel = New ExampleViewModel()
	Me.DataContext = viewModel

	Dim collection As CommandBindingCollection = Me.viewModel.GetCommandBindings()
	For Each commandBinding As CommandBinding In collection
		CommandManager.RegisterClassCommandBinding(GetType(ListBoxItem), commandBinding)
	Next commandBinding
End Sub
' #endregion
End Class
