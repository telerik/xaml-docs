Public Class Default_Vb


' #region radtreeview-how-to-bind-to-self-referencing-data_1
Public Class DataItem
Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
		End Property

		Private _ParentId As Integer
		Public Property ParentId() As Integer
			Get
				Return _ParentId
			End Get
			Set(ByVal value As Integer)
				_ParentId = value
			End Set
		End Property

		Private _Text As String
		Public Property Text() As String
			Get
				Return _Text
			End Get
			Set(ByVal value As String)
				_Text = value
			End Set
		End Property

		Private _Owner As DataItemCollection
		Public Property Owner() As DataItemCollection
			Get
				Return _Owner
			End Get
			Protected Set(ByVal value As DataItemCollection)
				_Owner = value
			End Set
		End Property

		Friend Sub SetOwner(ByVal collection As DataItemCollection)
			Me.Owner = collection
		End Sub
	End Class
	' #endregion

	' #region radtreeview-how-to-bind-to-self-referencing-data_3
	Public Class DataItemCollection
		Inherits ObservableCollection(Of DataItem)
		Protected Overloads Overrides Sub InsertItem(ByVal index As Integer, ByVal item As DataItem)
			Me.AdoptItem(item)
			MyBase.InsertItem(index, item)
		End Sub

		Protected Overloads Overrides Sub RemoveItem(ByVal index As Integer)
			Me.DiscardItem(Me(index))
			MyBase.RemoveItem(index)
		End Sub

		Protected Overloads Overrides Sub SetItem(ByVal index As Integer, ByVal item As DataItem)
			Me.AdoptItem(item)
			MyBase.SetItem(index, item)
		End Sub

		Protected Overloads Overrides Sub ClearItems()
			For Each item As DataItem In Me
				Me.DiscardItem(item)
			Next
			MyBase.ClearItems()
		End Sub

		Private Sub AdoptItem(ByVal item As DataItem)
			item.SetOwner(Me)
		End Sub

		Private Sub DiscardItem(ByVal item As DataItem)
			item.SetOwner(Nothing)
		End Sub
	End Class
	' #endregion

	' #region radtreeview-how-to-bind-to-self-referencing-data_7
	Public Class HierarchyConverter
		Implements IValueConverter

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			' We are binding an item
			Dim item As DataItem = TryCast(value, DataItem)
			If item IsNot Nothing Then
				Return item.Owner.Where(Function(i) i.ParentId = item.Id)
			End If

			' We are binding the treeview
			Dim items As DataItemCollection = TryCast(value, DataItemCollection)
			If items IsNot Nothing Then
				Return items.Where(Function(i) i.ParentId = 0)
			End If

			Return Nothing
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function

	End Class
' #endregion

' #region radtreeview-how-to-bind-to-self-referencing-data_9
Me.DataContext = New DataItemCollection() From { 
	New DataItem () With {.Text = "Item 1", .Id = 1, .ParentId = 0}, 
	New DataItem () With {.Text = "Item 2", .Id = 2, .ParentId = 0}, 
	New DataItem () With {.Text = "Item 3", .Id = 3, .ParentId = 0}, 
	New DataItem () With {.Text = "Item 1.1", .Id = 5, .ParentId = 1}, 
	New DataItem () With {.Text = "Item 1.2", .Id = 6, .ParentId = 1}, 
	New DataItem () With {.Text = "Item 1.3", .Id = 7, .ParentId = 1}, 
	New DataItem () With {.Text = "Item 2.1", .Id = 8, .ParentId = 2}, 
	New DataItem () With {.Text = "Item 2.2", .Id = 9, .ParentId = 2}, 
	New DataItem () With {.Text = "Item 2.3", .Id = 10, .ParentId = 2}, 
	New DataItem () With {.Text = "Item 3.1", .Id = 11, .ParentId = 3}, 
	New DataItem () With {.Text = "Item 3.2", .Id = 12, .ParentId = 3}, 
	New DataItem () With {.Text = "Item 3.3", .Id = 13, .ParentId = 3} 
												}
' #endregion
End Class
