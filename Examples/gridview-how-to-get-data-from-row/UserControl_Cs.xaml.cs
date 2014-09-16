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

#region gridview-how-to-get-data-from-row_0
private void Button2_Click(object sender, RoutedEventArgs e)
{
 Club club = this.clubsGrid.SelectedItem as Club;
 string message = string.Format("Name: {0} \n Established: {1} \n Capacity: {2}", club.Name, 
                      club.Established, 
                      club.StadiumCapacity);
 MessageBox.Show(message);
}
#endregion

#region gridview-how-to-get-data-from-row_2
void clubsGrid_RowActivated(object sender, Telerik.Windows.Controls.GridView.RowEventArgs e)
{
 var row = e.Row as GridViewRow;
 Club club = row.Item as Club;
 string message = string.Format("Name: {0} \n Established: {1} \n Capacity: {2}", club.Name,
                      club.Established,
                      club.StadiumCapacity);
 MessageBox.Show(message);
}
#endregion
}
