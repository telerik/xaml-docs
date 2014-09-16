Public Class Default_Vb


' #region radribbonview-ribbon-gallery_7
Private Sub QuickStyles_ActivatePreview(sender As Object, e As Telerik.Windows.RadRoutedEventArgs)
	' Grab the RadRibbonGallery object
	Dim gallery As RadRibbonGallery = TryCast(sender, RadRibbonGallery)
	' Get the selected item
	Dim selectedItem As RadGalleryItem = TryCast(gallery.SelectedItem, RadGalleryItem)
End Sub
Private Sub QuickStyles_DeactivatePreview(sender As Object, e As Telerik.Windows.RadRoutedEventArgs)
	' Grab the RadRibbonGallery object
	Dim gallery As RadRibbonGallery = TryCast(sender, RadRibbonGallery)
	' Get the selected item
	Dim selectedItem As RadGalleryItem = TryCast(gallery.SelectedItem, RadGalleryItem)
End Sub
' #endregion
End Class
