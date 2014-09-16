Public Class Default_Vb


' #region radcarousel-how-to-change-scroll-buttons_2
Private Sub pageDownButton_Click(sender As Object, e As RoutedEventArgs)
 Me.RadCarousel1.FindCarouselPanel().PageDown()
End Sub
Private Sub pageLeftButton_Click(sender As Object, e As RoutedEventArgs)
 Me.RadCarousel1.FindCarouselPanel().MoveBy(-1)
End Sub
Private Sub pageRightButton_Click(sender As Object, e As RoutedEventArgs)
 Me.RadCarousel1.FindCarouselPanel().MoveBy(1)
End Sub
Private Sub pageUpButton_Click(sender As Object, e As RoutedEventArgs)
 Me.RadCarousel1.FindCarouselPanel().PageUp()
End Sub
' #endregion
End Class
