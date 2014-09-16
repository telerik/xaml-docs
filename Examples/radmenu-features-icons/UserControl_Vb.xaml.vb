Public Class Default_Vb


' #region radmenu-features-icons_2
Public Class MenuItem
 ...
 Public Property IconUrl() As Uri
  Get
  End Get
  Set
  End Set
 End Property
 Public ReadOnly Property Icon() As Image
  Get
   Dim img As New Image()
   img.Source = New BitmapImage(Me.IconUrl)
   Return img
  End Get
 End Property
 ...
End Class
' #endregion
End Class
