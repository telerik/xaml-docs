Public Class Default_Vb


' #region radtreeview-feautres-treeviewitem-item-images_3
Private Sub radTreeView_ItemPrepared(sender As Object, e As RadTreeViewItemPreparedEventArgs)
	e.PreparedItem.DefaultImageSrc = "/Examples/Common/Images/Vista Icons/Icon1.png"
	e.PreparedItem.ExpandedImageSrc = "/Examples/Common/Images/Vista Icons/Icon2.png"
	e.PreparedItem.SelectedImageSrc = "/Examples/Common/Images/Vista Icons/Icon3.png"
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-item-images_5
Private Sub radTreeView_ItemPrepared(sender As Object, e As RadTreeViewItemPreparedEventArgs)
	Dim defaultImage As New BitmapImage(New Uri("Icon1.png", UriKind.Relative))
	e.PreparedItem.DefaultImageSrc = defaultImage
	Dim expandedImage As New BitmapImage(New Uri("Icon2.png", UriKind.Relative))
	e.PreparedItem.ExpandedImageSrc = expandedImage
	Dim selectedImage As New BitmapImage(New Uri("Icon3.png", UriKind.Relative))
	e.PreparedItem.SelectedImageSrc = selectedImage
End Sub
' #endregion
End Class
