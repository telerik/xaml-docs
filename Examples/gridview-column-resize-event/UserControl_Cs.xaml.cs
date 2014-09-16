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

#region gridview-column-resize-event_1
gridView.ColumnWidthChanging += new EventHandler<ColumnWidthChangingEventArgs>(gridView_ColumnWidthChanging);
gridView.ColumnWidthChanged += new EventHandler<ColumnWidthChangedEventArgs>(gridView_ColumnWidthChanged);
#endregion

#region gridview-column-resize-event_3
public MainPage()
{
   InitializeComponent();
   gridView.ColumnWidthChanging += new EventHandler<ColumnWidthChangingEventArgs>(gridView_ColumnWidthChanging); 
}
void gridView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
{ 
   //if we shrink the column
   if (e.HorizontalChangeWidth < 0)
   {
      //cancel the event
      e.Cancel = true;
   }
}
#endregion
}
