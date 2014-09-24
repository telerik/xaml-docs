Public Class Default_Vb


' #region radmenu-populating-with-data-binding-to-dynamic-data_1
Public Class MenuItem
 Public Sub New(text As String, iconUrl As Uri, subItems As ObservableCollection(Of MenuItem))
  Me.Text = text
  Me.IconUrl = iconUrl
  Me.SubItems = subItems
 End Sub
 Public Property Text() As String
  Get
  End Get
  Set
  End Set
 End Property
 Public Property IconUrl() As Uri
  Get
  End Get
  Set
  End Set
 End Property
 Public Property SubItems() As ObservableCollection(Of MenuItem)
  Get
  End Get
  Set
  End Set
 End Property
End Class
' #endregion

' #region radmenu-populating-with-data-binding-to-dynamic-data_3
Public Function GetMenuItems() As ObservableCollection(Of MenuItem)
 Dim items As New ObservableCollection(Of MenuItem)()
 Dim fileSubItems As New ObservableCollection(Of MenuItem)()
 Dim newItem As New MenuItem("New File", New Uri("/Images/newFile.png", UriKind.Relative), Nothing)
 fileSubItems.Add(newItem)
 Dim openItem As New MenuItem("Open File", New Uri("/Images/open.png", UriKind.Relative), Nothing)
 fileSubItems.Add(openItem)
 Dim saveItem As New MenuItem("Save", New Uri("/Images/save.png", UriKind.Relative), Nothing)
 fileSubItems.Add(saveItem)
 Dim fileItem As New MenuItem("File", Nothing, fileSubItems)
 items.Add(fileItem)
 Dim editItem As New MenuItem("Edit", Nothing, Nothing)
 items.Add(editItem)
 Dim viewItem As New MenuItem("View", Nothing, Nothing)
 items.Add(viewItem)
 Return items
End Function
' #endregion

' #region radmenu-populating-with-data-binding-to-dynamic-data_5
Public Sub New()
 InitializeComponent()
 Me.radMenu.ItemsSource = Me.GetMenuItems()
End Sub
' #endregion
End Class
