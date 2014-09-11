'#region "radpivotgrid-features-contextmenubehavior_1"
Public Class CustomContextMenuBehavior
    Inherits FieldListContextMenuBehavior

    Protected Overrides Function CreateContextMenu(ByVal dataContext As Object) As RadContextMenu
        Dim contextMenu = MyBase.CreateContextMenu(dataContext)
    End Function
End Class
'#endregion

'#region "radpivotgrid-features-contextmenubehavior_2"
Protected Overrides Function CreateContextMenu(ByVal dataContext As Object) As RadContextMenu
    Dim contextMenu = MyBase.CreateContextMenu(dataContext)
    If TypeOf dataContext Is PropertyGroupDescription Then
        Dim itemToRemove = contextMenu.Items.FirstOrDefault(Function(i) (TryCast(i, RadMenuItem)).Header IsNot Nothing AndAlso (TryCast(i, RadMenuItem)).Header.Equals("Label Filter"))

        If itemToRemove IsNot Nothing Then
            contextMenu.Items.Remove(itemToRemove)
        End If

        contextMenu.Items.Add(New RadMenuItem With {.Header = "Custom Menu Item", .Command = New DelegateCommand(AddressOf OnCustomMenuItemClickExecute)})
    End If
End Function

Private Sub OnCustomMenuItemClickExecute(ByVal obj As Object)
    MessageBox.Show("Clicked")
End Sub
'#endregion

'#region "radpivotgrid-features-contextmenubehavior_3"
Public Sub MainPage()
    InitializeComponent()

    Dim customContextMenuBehavior = New CustomContextMenuBehavior()
    FieldListContextMenuBehavior.SetBehavior(Me.radPivotFieldList, customContextMenuBehavior)
End Sub
'#endregion