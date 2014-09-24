Imports System
Imports RadControlsSilverlightApp2.ViewModel

Namespace RadControlsSilverlightApp2
	Partial Public Class MainPage
		Inherits System.Windows.Controls.UserControl
		Public Sub New()
			InitializeComponent()
			Me.DataContext = New MainViewModel()
		End Sub
	End Class

	'#region radtabcontrol-how-to-add-close-button-mvvm-0
	Public Class MainViewModel
		Public Sub New()
			Me.Tabs = New ObservableCollection(Of TabViewModel)()
			Me.AddItem(Nothing)
		End Sub

		''' <summary>
		''' Gets the collection of tabs.
		''' </summary>
		Public Property Tabs() As ObservableCollection(Of TabViewModel)
			Get
				Return _tabs
			End Get
			Private Set(value As ObservableCollection(Of TabViewModel))
				_tabs = Value
			End Set
		End Property
		Private _tabs As ObservableCollection(Of TabViewModel)

		''' <summary>
		''' Adds new tab item to the Tabs collection.
		''' </summary>
		Public Sub AddItem(sender As TabViewModel)
			Dim newTabItem As New TabViewModel(Me)
			newTabItem.Header = "New Tab"
			newTabItem.IsSelected = True
			If sender IsNot Nothing Then
				Dim insertIndex As Integer = Me.Tabs.IndexOf(sender) + 1
				Me.Tabs.Insert(insertIndex, newTabItem)
			Else
				Me.Tabs.Add(newTabItem)
			End If
		End Sub

		''' <summary>
		''' Removes an item from the Tabs collection.
		''' </summary>
		''' <param name="tabItem">The tab item.</param>
		Public Sub RemoveItem(tabItem As TabViewModel)
			Me.Tabs.Remove(tabItem)
			tabItem.Dispose()
		End Sub
	End Class
	'#endregion
	'#region radtabcontrol-how-to-add-close-button-mvvm-1
	Public Class TabViewModel
		Implements INotifyPropertyChanged
		Implements IDisposable
		Private _isSelected As Boolean
		Private ReadOnly mainViewModel As MainViewModel

		Public Sub New(mainViewModel As MainViewModel)
			Me.mainViewModel = mainViewModel
			Me.mainViewModel.Tabs.CollectionChanged += Me.Tabs_CollectionChanged

			Me.AddItemCommand = New DelegateCommand(Function() Do
			Me.mainViewModel.AddItem(Me)
			End Function, Function() Me.mainViewModel.Tabs.Count < 5)

			Me.RemoveItemCommand = New DelegateCommand(Function() Do
				Me.mainViewModel.RemoveItem(Me)
			End Function, Function() Me.mainViewModel.Tabs.Count > 1)
		End Sub

		Public Sub Dispose()
			Me.mainViewModel.Tabs.CollectionChanged -= Me.Tabs_CollectionChanged
		End Sub

		Private Sub Tabs_CollectionChanged(sender As Object, e As System.Collections.Specialized.NotifyCollectionChangedEventArgs)
			Me.AddItemCommand.InvalidateCanExecute()
			Me.RemoveItemCommand.InvalidateCanExecute()
		End Sub

		Public Property Header() As String
			Get
				Return _header
			End Get
			Set(value As String)
				_header = Value
			End Set
		End Property
		Private _header As String

		Public Property IsSelected() As Boolean
			Get
				Return Me._isSelected
			End Get
			Set(value As Boolean)
				If Me._isSelected <> value Then
					Me._isSelected = value
					Me.OnPropertyChanged("IsSelected")
				End If
			End Set
		End Property

		Public Property AddItemCommand() As DelegateCommand
			Get
				Return _addItemCommand
			End Get
			Set(value As DelegateCommand)
				_addItemCommand = Value
			End Set
		End Property
		Private _addItemCommand As DelegateCommand
		Public Property RemoveItemCommand() As DelegateCommand
			Get
				Return _removeItemCommand
			End Get
			Set(value As DelegateCommand)
				_removeItemCommand = Value
			End Set
		End Property
		Private _removeItemCommand As DelegateCommand

#Region "INotifyPropertyChanged"
		Public Event PropertyChanged As PropertyChangedEventHandler

		Private Sub OnPropertyChanged(propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
#End Region
	End Class
	'#endregion

End Namespace
