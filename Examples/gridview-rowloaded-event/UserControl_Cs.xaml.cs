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

#region gridview-rowloaded-event_1
this.RadGridView1.RowLoaded += new EventHandler<RowLoadedEventArgs>(RadGridView1_RowLoaded);
this.RadGridView1.RowUnloaded += new EventHandler<RowUnloadedEventArgs>(RadGridView1_RowUnloaded);
#endregion

#region gridview-rowloaded-event_3
void RadGridView1_RowLoaded(object sender, RowLoadedEventArgs e)  
 {  
      if (e.Row is GridViewRow &&!(e.Row is GridViewNewRow) )  
      {  
           Person person = e.DataElement as Person;  
           if ( person.Age < 30 )  
             ((GridViewRow) e.Row).IsEnabled = false;  
      }  
 }
#endregion
}
