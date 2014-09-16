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

#region gridview-selection-events_0
public BasicSelection()
{
    InitializeComponent();
    this.radGridView.SelectionChanging += this.SelectionChanging;
}
private void SelectionChanging(object sender, SelectionChangingEventArgs e )
{ 
}
#endregion

#region gridview-selection-events_2
public BasicSelection()
{
    InitializeComponent();
    this.radGridView.SelectionChanged += this.SelectionChanged;
}
private void SelectionChanged(object sender, SelectionChangeEventArgs e )
{
}
#endregion

#region gridview-selection-events_4
public BasicSelection()
{
    InitializeComponent();
    this.radGridView.CurrentCellChanged += this.CurrentCellChanged;
}
private void CurrentCellChanged( object sender, GridViewCurrentCellChangedEventArgs e )
{
}
#endregion

#region gridview-selection-events_6
public BasicSelection()
{
  InitializeComponent();
  this.radGridView.SelectedCellsChanging += this.SelectedCellsChanging;
}
private void SelectedCellsChanging(object sender, GridViewSelectedCellsChangingEventArgse )
{ 
}
#endregion

#region gridview-selection-events_8
public MainPage()
{
 InitializeComponent();
 this.gridView.SelectedCellsChanged += new EventHandler<GridViewSelectedCellsChangedEventArgs>(gridView_SelectedCellsChanged);
}
private void gridView_SelectedCellsChanged(object sender, GridViewSelectedCellsChangedEventArgs e)
{
}
#endregion
}
