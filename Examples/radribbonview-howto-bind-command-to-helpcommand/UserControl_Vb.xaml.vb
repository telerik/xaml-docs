Public Class Default_Vb
    ' #region radribbonview-howto-bind-command-to-helpcommand-01
    Public Property OpenHelpPageCommand() As DelegateCommand
        Get
            Return m_OpenHelpPageCommand
        End Get
        Set(value As DelegateCommand)
            m_OpenHelpPageCommand = Value
        End Set
    End Property
    Private m_OpenHelpPageCommand As DelegateCommand

    Public Sub New()
        InitializeComponent()
        OpenHelpPageCommand = New DelegateCommand(ExecuteCommandHandler, CanExecuteCommandHandler)
        Me.DataContext = OpenHelpPageCommand
    End Sub
    ' #endregion

    ' #region radribbonview-howto-bind-command-to-helpcommand-02
    Private Function CanExecuteCommandHandler(obj As Object) As Boolean
        ' Implement logic that checks if the button command can be executed
        Return True
    End Function

    Private Sub ExecuteCommandHandler(obj As Object)
        ' Implement the logic that should be executed when the button is clicked
        MessageBox.Show("Help Command Executed")
    End Sub
    ' #endregion

    ' #region radribbonview-howto-bind-command-to-helpcommand-03
    Public Property OpenHelpPageCommand() As DelegateCommand
        Get
            Return m_OpenHelpPageCommand
        End Get
        Set(value As DelegateCommand)
            m_OpenHelpPageCommand = Value
        End Set
    End Property
    Private m_OpenHelpPageCommand As DelegateCommand
    Public Sub New()
        InitializeComponent()

        OpenHelpPageCommand = New DelegateCommand(ExecuteOpenHelpPage)
        Me.DataContext = OpenHelpPageCommand
        Dim inputBindCollection As New InputBindingCollection()
        inputBindCollection.Add(New KeyBinding(Me.OpenHelpPageCommand, New KeyGesture(Key.F1)))
        CommandManager.SetInputBindings(Me, inputBindCollection)
    End Sub
    ' #endregion
End Class
