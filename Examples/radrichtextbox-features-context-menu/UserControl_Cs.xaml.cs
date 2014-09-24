using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radrichtextbox-features-context-menu_0
public ContextMenuSample()
{
    InitializeComponent();
    ContextMenu contextMenu = (ContextMenu)this.radRichTextBox.ContextMenu;
    contextMenu.Showing += this.ContextMenu_Showing;
}
//In the event handler you can check the context relevant items and add some RadMenuItems if needed.
private void ContextMenu_Showing(object sender, ContextMenuEventArgs e)
{
    // First check the context - if caret is in table, add our item
    if (this.radRichTextBox.Document.CaretPosition.IsPositionInsideTable)
    {
        RadMenuItem makeCellYellowMenuItem = new RadMenuItem()
        {
            Header = "Make Cell Yellow"
        };
        makeCellYellowMenuItem.Click += this.MakeCellYellowMenuItem_Click;
        ContextMenuGroup customContextMenuGroup = new ContextMenuGroup();
        customContextMenuGroup.Add(makeCellYellowMenuItem);
        e.ContextMenuGroupCollection.Add(customContextMenuGroup);
    }
}
private void MakeCellYellowMenuItem_Click(object sender, RadRoutedEventArgs e)
{
    TableCell currentCell = this.radRichTextBox.Document.CaretPosition.GetCurrentTableCellBox().AssociatedTableCell;
    currentCell.Background = Colors.Yellow;
    this.radRichTextBox.UpdateEditorLayout();
}
#endregion

#region radrichtextbox-features-context-menu_2
ContextMenu contextMenu = (ContextMenu)this.radRichTextBox.ContextMenu;
contextMenu.ContentBuilder = new CustomContextMenuContentBuilder(this.radRichTextBox);
#endregion
}
