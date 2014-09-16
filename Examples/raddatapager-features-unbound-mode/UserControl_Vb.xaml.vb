Public Class Default_Vb


' #region raddatapager-features-unbound-mode_2
Public Partial Class UnboundModeSample
 Inherits UserControl
 Implements IView
 Private data As List(Of Integer)
 Public Sub New()
  InitializeComponent()
  Me.data = Enumerable.Range(0, 100).ToList()
  Me.radDataPager.ItemCount = data.Count
  Me.listBox.ItemsSource = Me.data.Take(Me.radDataPager.PageSize).ToList()
 End Sub
 Private Sub radDataPager_PageIndexChanged(sender As Object, e As PageIndexChangedEventArgs)
  If Me.data IsNot Nothing Then
   Me.listBox.ItemsSource = Me.data.Skip(e.NewPageIndex * Me.radDataPager.PageSize).Take(Me.radDataPager.PageSize).ToList()
  End If
 End Sub
End Class
' #endregion
End Class
