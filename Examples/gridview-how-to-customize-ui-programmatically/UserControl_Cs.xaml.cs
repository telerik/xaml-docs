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

#region gridview-how-to-customize-ui-programmatically_0
var rows = RadGridView1.ChildrenOfType<GridViewRow>();
#endregion

#region gridview-how-to-customize-ui-programmatically_1
var cells= RadGridView1.ChildrenOfType<GridViewCell>();
#endregion

#region gridview-how-to-customize-ui-programmatically_2
var headerCells = RadGridView1.ChildrenOfType<GridViewHeaderCell>();
#endregion

#region gridview-how-to-customize-ui-programmatically_3
var newRow = RadGridView1.ChildrenOfType<GridViewNewRow>().First();
newRow.Visibility = Visibility.Visible;
#endregion

#region gridview-how-to-customize-ui-programmatically_4
var verticalScrollBar = RadGridView1.ChildrenOfType<ScrollBar>().Where(s=>s.Orientation == Orientation.Vertical).First();
verticalScrollBar.Value = verticalScrollBar.Maximum;
#endregion

#region gridview-how-to-customize-ui-programmatically_5
var row = RadGridView1.ChildrenOfType<GridViewRow>().Where(r => r.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI").Any()).First();
row.IsSelected = true;
#endregion

#region gridview-how-to-customize-ui-programmatically_6
var cell = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI").First();
cell.Content = "Changed!";
#endregion

#region gridview-how-to-customize-ui-programmatically_7
var cell = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI").First();
cell.IsInEditMode = true;
#endregion

#region gridview-how-to-customize-ui-programmatically_8
void Window1_Loaded(object sender, RoutedEventArgs e)
{
    var verticalScrollBar = RadGridView1.ChildrenOfType<ScrollBar>().Where(s => s.Orientation == Orientation.Vertical).First();
    verticalScrollBar.SizeChanged += new SizeChangedEventHandler(verticalScrollBar_SizeChanged);
    verticalScrollBar.Scroll += new ScrollEventHandler(verticalScrollBar_Scroll);
}
void verticalScrollBar_SizeChanged(object sender, SizeChangedEventArgs e)
{
    var visibleRowsCount = RadGridView1.ChildrenOfType<GridViewRow>().Where(r => r.Visibility == Visibility.Visible).Count();
}
void verticalScrollBar_Scroll(object sender, ScrollEventArgs e)
{
    var visibleRowsCount = RadGridView1.ChildrenOfType<GridViewRow>().Where(r => r.Visibility == Visibility.Visible).Count();
}
#endregion

#region gridview-how-to-customize-ui-programmatically_9
var rows = RadGridView1.ChildrenOfType<GridViewRow>().Where(r => r.ChildrenOfType<GridViewCell>().Where(c => c.Content.ToString() == "ALFKI"|| c.Content.ToString() == "AROUT").Any()).ToList();
rows.ForEach(r => r.Background = Brushes.Red);
#endregion

#region gridview-how-to-customize-ui-programmatically_10
var expandableRow = RadGridView1.ChildrenOfType<GridViewExpandableRow>().First();
expandableRow.IsExpanded = true;
#endregion

#region gridview-how-to-customize-ui-programmatically_11
var groupHeader = RadGridView1.ChildrenOfType<GridViewGroupRow>().First();
groupHeader.ChildrenOfType<Expander>().First().IsExpanded = false;
#endregion

#region gridview-how-to-customize-ui-programmatically_12
var unitPriceCells = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Column.UniqueName == "UnitPrice").ToList();
unitPriceCells.ForEach(c => c.Background = Brushes.Orange);
#endregion

#region gridview-how-to-customize-ui-programmatically_13
var headerRow = RadGridView1.ChildrenOfType<GridViewHeaderRow>().First();
headerRow.Height = 100;
#endregion

#region gridview-how-to-customize-ui-programmatically_14
var cells = RadGridView1.ChildrenOfType<GridViewCell>().Where(c => c.Column.UniqueName == "Test").ToList();
cells.ForEach(c => c.ChildrenOfType<CheckBox>().First().IsChecked = true);
#endregion
}
