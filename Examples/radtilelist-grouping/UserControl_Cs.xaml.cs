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

#region radtilelist-grouping_3
     TileGroup tileGroupA = new TileGroup() { Header = "Married" };
     private void RadTileList_AutoGeneratingTile(object sender, AutoGeneratingTileEventArgs e)
        {
            Employee employee = e.Tile.Content as Employee;            
            if (employee.FirstName == "Jane")
                {
                    e.Tile.Group = this.tileGroupA;
                }
        } 
#endregion

   
  
  

}
