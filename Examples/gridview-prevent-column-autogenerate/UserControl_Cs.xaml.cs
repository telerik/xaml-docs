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

#region gridview-prevent-column-autogenerate_0
[Display(AutoGenerateField = false)] 
public ObservableCollection<Player> Players
{
 get
 {
  if (null == this.players)
  {
   this.players = new ObservableCollection<Player>();
  }
  return this.players;
 }
}
#endregion

#region gridview-prevent-column-autogenerate_1
private void clubsGrid_AutoGeneratingColumn(object sender, GridViewAutoGeneratingColumnEventArgs e)
{
   if (e.Column.UniqueName == "Players")
   {
      e.Cancel = true;
   }
}
#endregion
}
