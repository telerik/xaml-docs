Public Class Default_Vb


' #region radmenu-how-to-group-checkable-menu-items-into-radio-group_3
Private Sub radMenu_ItemClick(sender As Object, e As RadRoutedEventArgs)
 Dim currentItem As var = TryCast(e.OriginalSource, RadMenuItem)
 If currentItem.IsCheckable AndAlso currentItem.Tag <> Nothing Then  
   'the place for the radio items logic
 End If
End Sub
' #endregion

' #region radmenu-how-to-group-checkable-menu-items-into-radio-group_5
Private Function GetSiblingGroupItems(currentItem As RadMenuItem) As List(Of RadMenuItem)
 Dim parentItem As var = currentItem.ParentOfType(Of RadMenuItem)()
 If parentItem = Nothing Then
  Return Nothing
 End If
 Dim items As New List(Of RadMenuItem)()
 For Each item As var In parentItem.Items
  Dim container As RadMenuItem = TryCast(parentItem.ItemContainerGenerator.ContainerFromItem(item), RadMenuItem)
  If container = Nothing OrElse container.Tag = Nothing Then
   Continue For
  End If
  If container.Tag.Equals(currentItem.Tag) Then
   items.Add(container)
  End If
 Next
 Return items
End Function
' #endregion

' #region radmenu-how-to-group-checkable-menu-items-into-radio-group_7
Private Sub radMenu_ItemClick(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
    Dim currentItem = TryCast(e.OriginalSource, RadMenuItem)
    If currentItem.IsCheckable AndAlso currentItem.Tag IsNot Nothing Then
        Dim siblingItems = Me.GetSiblingGroupItems(currentItem)
        If siblingItems IsNot Nothing Then
            For Each item In siblingItems
                If item IsNot currentItem Then
                    item.IsChecked = False
                End If
            Next item
        End If
    End If
End Sub
' #endregion

' #region radmenu-how-to-group-checkable-menu-items-into-radio-group_9
Public Class MenuItem
    Public Property Header() As String
    Public Property IsCheckable() As Boolean
    Public Property RadioGroup() As String
    Public Property IsSeparator() As Boolean
    Public Property SubMenuItems() As ObservableCollection(Of MenuItem)
End Class
' #endregion

' #region radmenu-how-to-group-checkable-menu-items-into-radio-group_10
Public Class ViewModel
    Public Property MenuItems() As ObservableCollection(Of MenuItem)

    Public Sub New()
        Me.MenuItems = New ObservableCollection(Of MenuItem) From {
            New MenuItem With {.Header = "File", .SubMenuItems = New ObservableCollection(Of MenuItem) From {
                    New MenuItem With {.Header = "Exit", .IsCheckable = True, .RadioGroup = "1"}}},
            New MenuItem With {.Header = "Options", .SubMenuItems = New ObservableCollection(Of MenuItem) From {
                    New MenuItem With {.Header = "Radio Button 1.1", .IsCheckable = True, .RadioGroup = "1"},
                    New MenuItem With {.Header = "Radio Button 1.2", .IsCheckable = True, .RadioGroup = "1"},
                    New MenuItem With {.Header = "Radio Button 1.3", .IsCheckable = True, .RadioGroup = "1"},
                    New MenuItem With {.IsSeparator = True},
                    New MenuItem With {.Header = "Radio Button 2.1", .IsCheckable = True, .RadioGroup = "2"},
                    New MenuItem With {.Header = "Radio Button 2.2", .IsCheckable = True, .RadioGroup = "2"},
                    New MenuItem With {.Header = "Radio Button 2.3", .IsCheckable = True, .RadioGroup = "2"}}}
        }
    End Sub
End Class
' #endregion
End Class
