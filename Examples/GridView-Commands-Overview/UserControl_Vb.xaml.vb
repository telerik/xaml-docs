Public Class Default_Vb


' #region GridView-Commands-Overview_1
Private Sub Button1_Click(sender As Object, e As RoutedEventArgs)
 Dim moveDownCommand = TryCast(RadGridViewCommands.MoveDown, RoutedUICommand)
 Dim selectCommand = TryCast(RadGridViewCommands.SelectCurrentUnit, RoutedUICommand)
 Dim deleteCommand = TryCast(RadGridViewCommands.Delete, RoutedUICommand)
 moveDownCommand.Execute(Nothing, Me.clubsGrid)
 selectCommand.Execute(Nothing, Me.clubsGrid)
 deleteCommand.Execute(Nothing, Me.clubsGrid)
End Sub
' #endregion
End Class
