Public Class Default_Vb


	' #region radribbonview-howto-use-commands-with-radribbonview-buttons_2
	Public Class ButtonViewModel
		Public Sub New()
			Me.MyCommand = New DelegateCommand(Function(p) Execute(p), Function(p) CanExecute(p))
		End Sub

		Public Property MyCommand() As DelegateCommand
			Get
				Return m_MyCommand
			End Get
			Set(value As DelegateCommand)
				m_MyCommand = Value
			End Set
		End Property
		Private m_MyCommand As DelegateCommand

		Private Function CanExecute(p As Object) As Boolean
			If p IsNot Nothing Then
				Return True
			Else
				Return False
			End If
		End Function

		Private Sub Execute(p As Object)
			MessageBox.Show("Executed: " & vbLf + p.ToString())
		End Sub
	End Class
' #endregion

	' #region radribbonview-howto-use-commands-with-radribbonview-buttons_4
	Public Sub New()
		InitializeComponent()
		Me.DataContext = New ButtonViewModel()
	End Sub
' #endregion
End Class
