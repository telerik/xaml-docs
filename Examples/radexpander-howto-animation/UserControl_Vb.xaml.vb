Public Class Default_Vb


	' #region radexpander-howto-animation_2
	Imports Telerik.Windows.Controls.Animation
	Private Sub SetAnimation()
		If Me.radExpander IsNot Nothing Then
			AnimationManager.SetIsAnimationEnabled(Me.radExpander, False)
			' some code...
			AnimationManager.SetIsAnimationEnabled(Me.radExpander, True)
			' some code...
		End If
	End Sub
	' #endregion
End Class
