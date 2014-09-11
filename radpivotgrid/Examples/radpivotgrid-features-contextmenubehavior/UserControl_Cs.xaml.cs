#region radpivotgrid-features-contextmenubehavior_1
public class CustomContextMenuBehavior : FieldListContextMenuBehavior
{
    protected override RadContextMenu CreateContextMenu(object dataContext)
    {
        var contextMenu = base.CreateContextMenu(dataContext);
    }
}
#endregion
#region radpivotgrid-features-contextmenubehavior_2
protected override RadContextMenu CreateContextMenu(object dataContext)
{
    var contextMenu = base.CreateContextMenu(dataContext);
    if (dataContext is PropertyGroupDescription)
    {
        var itemToRemove = contextMenu.Items.FirstOrDefault(i => (i as RadMenuItem).Header != null && (i as RadMenuItem).Header.Equals("Label Filter"));

        if (itemToRemove != null)
        {
            contextMenu.Items.Remove(itemToRemove);
        }

        contextMenu.Items.Add(new RadMenuItem { Header = "Custom Menu Item", Command = new DelegateCommand(OnCustomMenuItemClickExecute) });
    }
}

private void OnCustomMenuItemClickExecute(object obj)
{
    MessageBox.Show("Clicked");
}
#endregion
#region radpivotgrid-features-contextmenubehavior_3
public MainPage()
{
    InitializeComponent();  

    var customContextMenuBehavior = new CustomContextMenuBehavior();
    FieldListContextMenuBehavior.SetBehavior(this.radPivotFieldList, customContextMenuBehavior);
}
#endregion