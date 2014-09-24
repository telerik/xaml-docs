Public Class Default_Vb
	' #region radtileview-howto-change-headers-background_6
	Public Class ItemViewModel
		Inherits ViewModelBase
		Private ReadOnly maximizedHeaderBackground As SolidColorBrush
		Private ReadOnly minimizedHeaderBackground As SolidColorBrush
		Private ReadOnly restoredHeaderBackground As SolidColorBrush
		Private m_headerColor As SolidColorBrush
		Private m_currentState As TileViewItemState = TileViewItemState.Minimized

		Public Sub New(maximizedHeaderBackground As SolidColorBrush, restoredHeaderBackground As SolidColorBrush, minimizedHeaderBackground As SolidColorBrush)
			Me.maximizedHeaderBackground = maximizedHeaderBackground
			Me.restoredHeaderBackground = restoredHeaderBackground
			Me.minimizedHeaderBackground = minimizedHeaderBackground

			Me.SetColor()
		End Sub

		Public Property Header() As String
			Get
				Return m_Header
			End Get
			Set(value As String)
				m_Header = Value
			End Set
		End Property
		Private m_Header As String

		Public Property HeaderColor() As SolidColorBrush
			Get
				Return Me.m_headerColor
			End Get
			Set(value As SolidColorBrush)
				If Me.m_headerColor <> value Then
					Me.m_headerColor = value
					Me.OnPropertyChanged("HeaderColor")
				End If
			End Set
		End Property

		Public Property CurrentState() As TileViewItemState
			Get
				Return Me.m_currentState
			End Get
			Set(value As TileViewItemState)
				If Me.m_currentState <> value Then
					Me.m_currentState = value
					Me.OnPropertyChanged("CurrentState")
					Me.SetColor()
				End If
			End Set
		End Property

		Private Sub SetColor()
			If Me.CurrentState = TileViewItemState.Maximized Then
				Me.HeaderColor = Me.maximizedHeaderBackground
			ElseIf Me.CurrentState = TileViewItemState.Minimized Then
				Me.HeaderColor = Me.minimizedHeaderBackground
			ElseIf Me.CurrentState = TileViewItemState.Restored Then
				Me.HeaderColor = Me.restoredHeaderBackground
			End If
		End Sub
	End Class
	' #endregion

	' #region radtileview-howto-change-headers-background_8
	Public Class MainViewModel
		Public Sub New()
			Me.Items = New ObservableCollection(Of ItemViewModel)()
			Me.GenerateItems()
		End Sub

		Public Property Items() As ObservableCollection(Of ItemViewModel)
			Get
				Return m_Items
			End Get
			Set(value As ObservableCollection(Of ItemViewModel))
				m_Items = Value
			End Set
		End Property
		Private m_Items As ObservableCollection(Of ItemViewModel)

		Private Sub GenerateItems()
			Dim blue = New SolidColorBrush(Colors.Blue)
			Dim green = New SolidColorBrush(Colors.Green)
			Dim purple = New SolidColorBrush(Colors.Purple)

			Me.Items.Add(New ItemViewModel(blue, green, purple) With {
				.Header = "Item 1",
				.CurrentState = TileViewItemState.Maximized
			})
			Me.Items.Add(New ItemViewModel(blue, green, purple) With {
				.Header = "Item 2"
			})
			Me.Items.Add(New ItemViewModel(blue, green, purple) With {
				.Header = "Item 3"
			})
			Me.Items.Add(New ItemViewModel(blue, green, purple) With {
				.Header = "Item 4"
			})
			Me.Items.Add(New ItemViewModel(blue, green, purple) With {
				.Header = "Item 5"
			})
		End Sub
	End Class
	' #endregion

	' #region radtileview-howto-change-headers-background_10
	Me.DataContext = New MainViewModel()
	' #endregion

End Class
