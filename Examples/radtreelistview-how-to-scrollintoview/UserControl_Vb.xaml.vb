Public Class Default_Vb


' #region radtreelistview-how-to-scrollintoview-0
Public Class DataItem
	Inherits ViewModelBase

		Private name_Renamed As String
		Public Property Name() As String
			Get
				Return Me.name_Renamed
			End Get
			Set(ByVal value As String)
				If Me.name_Renamed <> value Then
					Me.name_Renamed = value
					Me.OnPropertyChanged("Name")
				End If
			End Set
		End Property

		Private children_Renamed As ObservableCollection(Of DataItem)
		Public ReadOnly Property Children() As ObservableCollection(Of DataItem)
			Get
				If children_Renamed Is Nothing Then
					children_Renamed = New ObservableCollection(Of DataItem)()
					For i As Integer = 0 To 99
						Dim item As New DataItem() With {.Name = Me.Name & "." & i}
						children_Renamed.Add(item)
					Next i
				End If
				Return children_Renamed
			End Get
		End Property

		Public ReadOnly Property IsExpandable() As Boolean
			Get
				Return True
			End Get
		End Property
End Class
' #endregion

' #region radtreelistview-how-to-scrollintoview-1
Partial Public Class Example
	Inherits UserControl

	Private listBringStart As Date
	Private list As ObservableCollection(Of DataItem)

	Public Sub New()
		InitializeComponent()
		Me.LoadData()
	End Sub

	Private Sub LoadData()
		list = New ObservableCollection(Of DataItem)()
		For i As Integer = 0 To 99
			Dim root As New DataItem() With {.Name = "Item " & i}
			list.Add(root)
		Next i
		Me.treeList.ItemsSource = list
	End Sub
End Class
' #endregion

' #region radtreelistview-how-to-scrollintoview-2
Private Sub RadButton_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
	Me.listBringStart = Date.Now
	Me.ScrollIntoViewRecursive(0, list(85))
End Sub

Private Sub ScrollIntoViewRecursive(ByVal level As Integer, ByVal item As DataItem)
	If level >= 20 Then
		MessageBox.Show(Date.Now.Subtract(Me.listBringStart).TotalSeconds.ToString() & " sec.")
		Return
	End If
	Dim newItem = item.Children(85)
	Me.treeList.ScrollIntoViewAsync(item, Sub(f)
		level += 1
		ScrollIntoViewRecursive(level, newItem)
	End Sub, True)
End Sub
' #endregion

' #region radtreelistview-how-to-scrollintoview-3
Private Sub RadButton_Click_2(ByVal sender As Object, ByVal e As RoutedEventArgs)
	Dim startTime As Date = Date.Now

	Dim start As DataItem = Me.list(85)
	For i As Integer = 0 To 19
		Me.treeList.ExpandHierarchyItem(start)
		start = start.Children(85)
	Next i
	Me.treeList.ScrollIntoView(start, False)
	Me.treeList.SelectedItems.Add(start)
	Dim [end] As Date = Date.Now
	MessageBox.Show([end].Subtract(startTime).TotalSeconds.ToString() & " sec.")
End Sub
' #endregion
End Class
