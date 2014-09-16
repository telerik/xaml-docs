Public Class Default_Vb


' #region radbuttons-features-commands_1
Public Class SampleViewModel
 Public Sub New()
 End Sub
 Public Property MyCommand() As ICommand
  Get
  End Get
  Set
  End Set
 End Property
End Class
' #endregion

' #region radbuttons-features-commands_3
Public Sub New()
 InitializeComponent()
 Me.DataContext = New SampleViewModel()
End Sub
' #endregion
End Class
