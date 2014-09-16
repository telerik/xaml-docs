Public Class Default_Vb


' #region radmap-features-colorizer_11
Private Sub ColorMeasureScale_PrepareCompleted(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.Map.ShapeColorizerEventArgs)
 Dim scale As ColorMeasureScale = TryCast(sender, ColorMeasureScale)
 If scale IsNot Nothing Then
  'this lines of code modify the second last item and remove the last item.
  scale.RangeCollection(scale.RangeCollection.Count - 2).MaxValue = scale.RangeCollection.Last().MaxValue
  scale.RangeCollection.Remove(scale.RangeCollection.Last())
 End If
End Sub
' #endregion
End Class
