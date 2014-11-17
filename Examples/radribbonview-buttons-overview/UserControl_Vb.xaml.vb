Public Class Default_Vb


' #region radribbonview-buttons-overview_3
Private Sub RadRibbonButton_Click(sender As Object, e As RoutedEventArgs)
	'place your custom logic here.
End Sub
' #endregion

' #region radribbonview-buttons-overview_5
Public Partial Class RibbonButtonsSample
	Inherits UserControl
		Public Shared ReadOnly EquationCommand As New RoutedUICommand("Equation", "EquationCommand", GetType(RibbonButtonsSample))

		Public Sub New()
			InitializeComponent()
			CommandManager.AddExecutedHandler(Me, AddressOf Me.OnExecuted)
			CommandManager.AddCanExecuteHandler(Me, AddressOf Me.OnCanExecute)
		End Sub
		Private Sub OnExecuted(sender As Object, e As ExecutedRoutedEventArgs)
			Me.LayoutRoot.Background = New SolidColorBrush(Colors.Blue)
		End Sub
		Private Sub OnCanExecute(sender As Object, e As CanExecuteRoutedEventArgs)
			e.CanExecute = True
		End Sub

End Class
' #endregion
End Class
