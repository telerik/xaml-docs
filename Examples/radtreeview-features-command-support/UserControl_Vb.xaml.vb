Public Class Default_Vb
	' #region radtreeview-features-command-support_1
	Public Class ItemModel
		Inherits ViewModelBase
		Private inInEditMode As Boolean
		Public Property IsInEditMode() As Boolean
			Get
				Return Me.inInEditMode
			End Get
			Set(value As Boolean)
				If Me.inInEditMode <> value Then
					Me.inInEditMode = value
					Me.OnPropertyChanged("IsInEditMode")
				End If
			End Set
		End Property

		Private m_header As String
		Public Property Header() As String
			Get
				Return Me.m_header
			End Get
			Set(value As String)
				If Me.m_header <> value Then
					Me.m_header = value
					Me.OnPropertyChanged("Header")
				End If
			End Set
		End Property

		Public Property EditCommand() As DelegateCommand
			Get
				Return m_EditCommand
			End Get
			Set(value As DelegateCommand)
				m_EditCommand = Value
			End Set
		End Property
		Private m_EditCommand As DelegateCommand

		Public Property Children() As ObservableCollection(Of ItemModel)
			Get
				Return m_Children
			End Get
			Set(value As ObservableCollection(Of ItemModel))
				m_Children = Value
			End Set
		End Property
		Private m_Children As ObservableCollection(Of ItemModel)
	End Class
	' #endregion
	' #region radtreeview-features-command-support_3
	Public Class ViewModel
		Public Sub New()
			Me.Items = New ObservableCollection(Of ItemModel)()
			Me.GenerateItems()
		End Sub

		Public Property Items() As ObservableCollection(Of ItemModel)
			Get
				Return m_Items
			End Get
			Set(value As ObservableCollection(Of ItemModel))
				m_Items = Value
			End Set
		End Property
		Private m_Items As ObservableCollection(Of ItemModel)

		Private Sub GenerateItems()
			Dim children As ObservableCollection(Of ItemModel)
			For j As Byte = 1 To 4
				children = New ObservableCollection(Of ItemModel)()
				For i As Byte = 1 To 3
					children.Add(New ItemModel() With {
						.Header = String.Format("Child {0} of root {1}", i, j),
						.EditCommand = New DelegateCommand(Function(x) Me.OnEditCommandExecute(x))
					})
				Next
				Me.Items.Add(New ItemModel() With {
					.Header = String.Format("Root Item {0}", j),
					.Children = children,
					.EditCommand = New DelegateCommand(Function(x) Me.OnEditCommandExecute(x))
				})
			Next
		End Sub

		Private Sub OnEditCommandExecute(sender As Object)
			Dim item = TryCast(sender, ItemModel)
			If item IsNot Nothing Then
				item.IsInEditMode = True
			End If
		End Sub
	End Class
	' #endregion
End Class
