Public Class Default_Vb


' #region radtreeliestview-getting-started_3
Dim radTreeListView As New RadTreeListView()
' #endregion

' #region radtreeliestview-getting-started_5
Public Class WarehouseItem
 Public Sub New(name As String, count As Integer)
  Me.Name = name
  Me.Count = count
  Me.Items = New ObservableCollection(Of WarehouseItem)()
 End Sub
 Public Property Name() As String
  Get
   Return m_Name
  End Get
  Set
   m_Name = Value
  End Set
 End Property
 Private m_Name As String
 Public Property Items() As ObservableCollection(Of WarehouseItem)
  Get
   Return m_Items
  End Get
  Set
   m_Items = Value
  End Set
 End Property
 Private m_Items As ObservableCollection(Of WarehouseItem)
 Public Property Count() As Integer
  Get
   Return m_Count
  End Get
  Set
   m_Count = Value
  End Set
 End Property
 Private m_Count As Integer
End Class
' #endregion

' #region radtreeliestview-getting-started_7
Public Class WarehouseService
 Public Shared Function GetWarehouseData() As ObservableCollection(Of WarehouseItem)
  Dim data As New ObservableCollection(Of WarehouseItem)()
  Dim drinks As New WarehouseItem("Drinks", 35)
  drinks.Items.Add(New WarehouseItem("Water", 10))
  Dim tea As New WarehouseItem("Tea", 20)
  tea.Items.Add(New WarehouseItem("Black", 10))
  tea.Items.Add(New WarehouseItem("Green", 10))
  drinks.Items.Add(tea)
  drinks.Items.Add(New WarehouseItem("Coffee", 5))
  data.Add(drinks)
  Dim vegetables As New WarehouseItem("Vegeatbles", 75)
  vegetables.Items.Add(New WarehouseItem("Tomato", 40))
  vegetables.Items.Add(New WarehouseItem("Carrot", 25))
  vegetables.Items.Add(New WarehouseItem("Onion", 10))
  data.Add(vegetables)
  Dim fruits As New WarehouseItem("Fruits", 55)
  fruits.Items.Add(New WarehouseItem("Cherry", 30))
  fruits.Items.Add(New WarehouseItem("Apple", 20))
  fruits.Items.Add(New WarehouseItem("Melon", 5))
  data.Add(fruits)
  Return data
 End Function
End Class
' #endregion

' #region radtreeliestview-getting-started_9
Me.radTreeListView.ItemsSource = WarehouseService.GetWarehouseData()
' #endregion
End Class
