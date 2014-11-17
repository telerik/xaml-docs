Public Class Default_Vb


' #region GridView-Commands-KeyboardCommandProvider_1
Class CustomKeyboardCommandProvider
 Inherits DefaultKeyboardCommandProvider
 Private parentGrid As GridViewDataControl
 Private defaultKeyboardProvider As DefaultKeyboardCommandProvider
 Private customKeyboardProvider As CustomKeyboardCommandProvider
 Public Sub New(grid As GridViewDataControl)
  MyBase.New(grid)
  Me.parentGrid = grid
 End Sub
 Public Overrides Function ProvideCommandsForKey(key__1 As Key) As IEnumerable(Of ICommand)
  Dim commandsToExecute As List(Of ICommand) = MyBase.ProvideCommandsForKey(key__1).ToList()
   If key = Key.Enter Then
	commandsToExecute.Clear()
	commandsToExecute.Add(RadGridViewCommands.CommitEdit)
	commandsToExecute.Add(RadGridViewCommands.MoveNext)
	commandsToExecute.Add(RadGridViewCommands.BeginEdit)
   End If
  Return commandsToExecute
 End Function
End Class
' #endregion

' #region GridView-Commands-KeyboardCommandProvider_3
Me.RadGridView1.KeyboardCommandProvider = New CustomKeyboardCommandProvider(Me.RadGridView1)
' #endregion
End Class
