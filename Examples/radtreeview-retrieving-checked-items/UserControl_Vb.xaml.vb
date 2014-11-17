Public Class Default_Vb


' #region radtreeview-retrieving-checked-items_1
Public Class Family
 Public Sub New()
  Me.Members = New ObservableCollection(Of Member)()
 End Sub
 Public Property Name() As String
  Get
  End Get
  Set
  End Set
 End Property
 Public Property Members() As ObservableCollection(Of Member)
  Get
  End Get
  Set
  End Set
 End Property
End Class
....
Public Class Member
 Public Sub New(name As String)
  Me.Name = name
 End Sub
 Public Property Name() As String
  Get
  End Get
  Set
  End Set
 End Property
End Class
' #endregion

' #region radtreeview-retrieving-checked-items_4
Dim dataSource As New List(Of Family)()
Dim family As New Family()
family.Name = "Simpson"
family.Members.Add(New Member("Homer"))
family.Members.Add(New Member("Marge"))
family.Members.Add(New Member("Bart"))
family.Members.Add(New Member("Lisa"))
family.Members.Add(New Member("Maggie"))
dataSource.Add(family)
family = New Family()
family.Name = "Flanders"
family.Members.Add(New Member("Ned"))
family.Members.Add(New Member("Maude"))
family.Members.Add(New Member("Todd"))
family.Members.Add(New Member("Rod"))
dataSource.Add(family)
Me.radTreeView.ItemsSource = dataSource
' #endregion

' #region radtreeview-retrieving-checked-items_6
For Each checkedItem As Object In radTreeView.CheckedItems
 ' Get the container(RadTreeViewItem) of the checked item
  ' Add your logic for handling the checked item scenario here
 Dim container As RadTreeViewItem = radTreeView.ContainerFromItemRecursive(checkedItem)
Next
' #endregion

' #region radtreeview-retrieving-checked-items_8
Public Interface IPath
 Property Parent() As IPath
 Function GetFullPath() As String
End Interface
' #endregion

' #region radtreeview-retrieving-checked-items_10
Public Class Member
 Implements IPath
 Public Sub New(name As String)
  Me.Name = name
 End Sub
 Public Property Name() As String
  Get
  End Get
  Set
  End Set
 End Property
 Public Property Parent() As IPath
  Get
  End Get
  Set
  End Set
 End Property
 Public Function GetFullPath() As String
  If Me.Parent <> Nothing Then
   Return Me.Parent.GetFullPath() + "|" + Me.ToString()
  End If
  Return Me.ToString()
 End Function
 Public Overloads Overrides Function ToString() As String
  Return Me.Name
 End Function
End Class
' #endregion

' #region radtreeview-retrieving-checked-items_12
Public Class Family
 Implements IPath
 Public Sub New()
  Me.Members = New ObservableCollection(Of Member)()
  Me.Members.CollectionChanged += New System.Collections.Specialized.NotifyCollectionChangedEventHandler(Members_CollectionChanged)
 End Sub
 Private Sub Members_CollectionChanged(sender As Object, e As NotifyCollectionChangedEventArgs)
  If e.Action = NotifyCollectionChangedAction.Add Then
   (TryCast(e.NewItems(0), IPath)).Parent = Me
  End If
 End Sub
 Public Property Name() As String
  Get
  End Get
  Set
  End Set
 End Property
 Public Property Members() As ObservableCollection(Of Member)
  Get
  End Get
  Set
  End Set
 End Property
 Public Property Parent() As IPath
  Get
  End Get
  Set
  End Set
 End Property
 Public Function GetFullPath() As String
  If Me.Parent <> Nothing Then
   Return Me.Parent.GetFullPath() + "|" + Me.ToString()
  End If
  Return Me.ToString()
 End Function
 Public Overloads Overrides Function ToString() As String
  Return Me.Name
 End Function
End Class
' #endregion

' #region radtreeview-retrieving-checked-items_14
Dim dataSource As ObservableCollection(Of Family) = TryCast(radTreeView.ItemsSource, ObservableCollection(Of Family))
For Each family As Family In dataSource
 Dim familyContainer As RadTreeViewItem = radTreeView.GetItemByPath(family.GetFullPath(), "|")
   ' add your logic for handling checked item scenario here.
 If familyContainer <> Nothing AndAlso familyContainer.CheckState = ToggleState.[On] Then
 End If
 For Each member As Member In family.Members
  Dim memberContainer As RadTreeViewItem = radTreeView.GetItemByPath(member.GetFullPath(), "|")
    ' add your logic for handling checked item scenario here.
  If memberContainer <> Nothing AndAlso memberContainer.CheckState = ToggleState.[On] Then
  End If
 Next
Next
' #endregion

' #region radtreeview-retrieving-checked-items_18
Public Class CheckStateConverter
 Implements IValueConverter
 Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
  Dim result As Boolean = DirectCast(value, Boolean)
  Return If(result, ToggleState.[On], ToggleState.Off)
 End Function
 Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
  Dim state As ToggleState = DirectCast(value, ToggleState)
  Return If(state = ToggleState.[On], True, False)
 End Function
End Class
' #endregion

' #region radtreeview-retrieving-checked-items_21
Public Class Member
 Public Sub New(name As String)
  Me.Name = name
 End Sub
 Public Property Name() As String
  Get
  End Get
  Set
  End Set
 End Property
 Public Property IsChecked() As Boolean
  Get
  End Get
  Set
  End Set
 End Property
End Class
....
Public Class Family
 Public Sub New()
  Me.Members = New ObservableCollection(Of Member)()
 End Sub
 Public Property Name() As String
  Get
  End Get
  Set
  End Set
 End Property
 Public Property IsChecked() As Boolean
  Get
  End Get
  Set
  End Set
 End Property
 Public Property Members() As ObservableCollection(Of Member)
  Get
  End Get
  Set
  End Set
 End Property
End Class
' #endregion
End Class
