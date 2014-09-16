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

#region gridview-scroll-item_0
this.gridView.ScrollIntoViewAsync(this.gridView.Items[this.gridView.Items.Count - 1], //the row
                                  this.gridView.Columns[this.gridView.Columns.Count - 1], //the column
                                  new Action<FrameworkElement>((f) => 
                                  {
                                     (f as GridViewRow).IsSelected = true; // the callback method; if it is not necessary, you may set that parameter to null;
                                  }));
#endregion

#region gridview-scroll-item_2
this.gridView.ScrollIndexIntoViewAsync(this.gridView.Items.Count - 1, //the row
                                  this.gridView.Columns[this.gridView.Columns.Count - 1], //the column
                                  new Action<FrameworkElement>((f) => 
                                  {
                                     (f as GridViewRow).IsSelected = true; // the callback method; if it is not necessary, you may set that parameter to null;
                                  }), null);
#endregion
}
