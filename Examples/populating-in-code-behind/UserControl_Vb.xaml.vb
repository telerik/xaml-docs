Public Class Default_Vb


' #region populating-in-code-behind_2
Dim ratingItem As New RadRatingItem()
Me.radRating.Items.Add(ratingItem)
' #endregion

' #region populating-in-code-behind_4
Me.radRating.Items.Clear() 
Dim ratingItem As New RadRatingItem()
ratingItem.Content = "1"
Me.radRating.Items.Add(ratingItem)
ratingItem As New RadRatingItem()
ratingItem.Content = "2"
Me.radRating.Items.Add(ratingItem)
' #endregion

' #region populating-in-code-behind_6
Private Sub RemoveRatingItem(ByVal itemToRemove As RadRatingItem)
    Me.radRating.Items.Remove(itemToRemove)
End Sub
' #endregion
End Class
