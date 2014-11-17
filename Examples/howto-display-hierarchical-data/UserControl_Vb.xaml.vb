Public Class Default_Vb


' #region howto-display-hierarchical-data_1
Public Class MyViewModel
 Public Sub New()
  Me.RelatedItems = New ObservableCollection(Of Object)()
 End Sub
 Public Property Title() As String
  Get
   Return _Title
  End Get
  Set(ByVal value As String)
   _Title = value
  End Set
 End Property
 Private _Title As String
 Public Property DateCreated() As DateTime
  Get
   Return _DateCreated
  End Get
  Set(ByVal value As DateTime)
   _DateCreated = value
  End Set
 End Property
 Private _DateCreated As DateTime
 Public Property Price() As Double
  Get
   Return _Price
  End Get
  Set(ByVal value As Double)
   _Price = value
  End Set
 End Property
 Private _Price As Double
 Public Property RelatedItems() As IList(Of Object)
  Get
   Return _RelatedItems
  End Get
  Set(ByVal value As IList(Of Object))
   _RelatedItems = value
  End Set
 End Property
 Private _RelatedItems As IList(Of Object)
End Class
' #endregion

' #region howto-display-hierarchical-data_3
Public Shared Function GenerateItems() As IList(Of Object)
 Dim result = New ObservableCollection(Of Object)()
 For Each num In Enumerable.Range(1, 5)
  Dim item = New MyViewModel()
  item.DateCreated = DateTime.Today.AddDays(-num Mod 15)
  item.Price = num * 100 + Convert.ToDouble(num) / 100
  item.Title = [String].Format("Item {0}", num)
  For i As Integer = 0 To 4
   Dim child = New MyViewModel()
   child.DateCreated = DateTime.Today.AddDays(-num Mod 5 - i)
   child.Price = num * 100 + Convert.ToDouble(num + i) / 100
   child.Title = [String].Format("Item {0}.{1}", num, i)
   item.RelatedItems.Add(child)
  Next
  result.Add(item)
 Next
 Return result
End Function
' #endregion
End Class
