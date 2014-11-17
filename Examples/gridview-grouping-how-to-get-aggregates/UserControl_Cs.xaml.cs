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

#region gridview-grouping-how-to-get-aggregates_0
    private void Button1_Click(object sender, RoutedEventArgs e)
    {
            foreach(QueryableCollectionViewGroup item in this.radGridView.Items.Groups)
            {
                if(item.Key.Equals("24"))
                {
                    MessageBox.Show(item.AggregateResults[0].FormattedValue.ToString());
                }
            } 
    }	
#endregion
}
