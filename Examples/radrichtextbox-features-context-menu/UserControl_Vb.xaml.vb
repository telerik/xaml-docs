Public Class Default_Vb


' #region radrichtextbox-features-context-menu_1
Public Sub New()
 InitializeComponent()
 Dim _contextMenu As ContextMenu = CType(Me.radRichTextBox.ContextMenu, ContextMenu)
 AddHandler _contextMenu.Showing, AddressOf ContextMenu_Showing
End Sub
'In the event handler you can check the context relevant items and add some RadMenuItems if needed.
Private Sub ContextMenu_Showing(ByVal sender As Object, ByVal e As ContextMenuEventArgs)
 ' First check the context - if caret is in table, add our item
 If Me.radRichTextBox.Document.CaretPosition.IsPositionInsideTable Then
  Dim makeCellYellowMenuItem As New RadMenuItem() With {.Header = "Make Cell Yellow"}
  AddHandler makeCellYellowMenuItem.Click, AddressOf MakeCellYellowMenuItem_Click
  Dim customContextMenuGroup As New ContextMenuGroup()
  customContextMenuGroup.Add(makeCellYellowMenuItem)
  e.ContextMenuGroupCollection.Add(customContextMenuGroup)
 End If
End Sub
Private Sub MakeCellYellowMenuItem_Click(ByVal sender As Object, ByVal e As RadRoutedEventArgs)
 Dim currentCell As TableCell = Me.radRichTextBox.Document.CaretPosition.GetCurrentTableCellBox().AssociatedTableCell
 currentCell.Background = Colors.Yellow
 Me.radRichTextBox.UpdateEditorLayout()
End Sub
' #endregion

' #region radrichtextbox-features-context-menu_3
Dim _contextMenu As ContextMenu = CType(Me.radRichTextBox.ContextMenu, ContextMenu)
_contextMenu.ContentBuilder = New CustomContextMenuContentBuilder(Me.radRichTextBox)
' #endregion
End Class
