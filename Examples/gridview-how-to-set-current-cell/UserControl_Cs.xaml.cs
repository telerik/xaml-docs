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

#region gridview-how-to-set-current-cell_0
public MainPage()
{
   InitializeComponent(); 
   gridView.DataLoaded += new EventHandler<EventArgs>(gridView_DataLoaded);  
}
void gridView_DataLoaded(object sender, EventArgs e)
{
  Dispatcher.BeginInvoke(new Action(() =>
  {
     gridView.CurrentCellInfo = new GridViewCellInfo(gridView.Items[5], gridView.Columns["Text"]);
     gridView.Focus();  
  }))
}
#endregion
}
