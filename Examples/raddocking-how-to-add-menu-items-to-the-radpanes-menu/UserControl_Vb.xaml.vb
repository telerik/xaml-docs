Public Class Default_Vb


' #region raddocking-how-to-add-menu-items-to-the-radpanes-menu_1
Public Class MyMenuCommand
 Inherits Telerik.Windows.Controls.RoutedUICommand
 Public Sub New()
  MyBase.New("MyCommand", "MyCommand", GetType(MyMenuCommand))
 End Sub
End Class
' #endregion

' #region raddocking-how-to-add-menu-items-to-the-radpanes-menu_4
Public Partial Class AddPaneMenuItems
 Inherits UserControl
 Public Sub New()
  InitializeComponent()
  Telerik.Windows.Controls.CommandManager.SetCommandBindings(Me, Me.GetCommandBindings())
 End Sub
 Public Function GetCommandBindings() As CommandBindingCollection
  Dim bindings As New Telerik.Windows.Controls.CommandBindingCollection()
  bindings.Add(New Telerik.Windows.Controls.CommandBinding(TryCast(Me.Resources("MyMenuCommand"), MyMenuCommand), Me.OnMyMenuCommandExecute))
  Return bindings
 End Function
 Public Sub OnMyMenuCommandExecute(sender As Object, e As ExecutedRoutedEventArgs)
 End Sub
End Class
' #endregion

' #region raddocking-how-to-add-menu-items-to-the-radpanes-menu_7
radPane.ContextMenuTemplate = Nothing
' #endregion
End Class
