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

#region radmap-features-sql-geospatial-data_3
public class DomainServiceContext : INotifyPropertyChanged
{
  private DomainService1 domainService1Context = new DomainService1();
  private IEnumerable locationsWKTs;
  public new IEnumerable LocationsWKTs
  {
   get
  {
    if (this.locationsWKTs == null)
  {
    var loadOp = this.domainService1Context.Load(this.domainService1Context.GetLocationsWKTsQuery());
    loadOp.Completed += new EventHandler(loadOp_Completed);
  }
return this.locationsWKTs;
}
　set
  {
   this.locationsWKTs = value;
   this.OnPropertyChanged("LocationsWKTs");
   }
}　
private void loadOp_Completed(object sender, EventArgs e)
   {
    var loadOp = sender as LoadOperation;
    if (loadOp != null)
     {
      this.LocationsWKTs = loadOp.Entities;
     }
  }
　public event PropertyChangedEventHandler PropertyChanged;
private void OnPropertyChanged(string name)
 {
   PropertyChangedEventHandler handler = PropertyChanged;
  if (handler != null)
   {
     handler(this, new PropertyChangedEventArgs(name));
    }
  }
}
#endregion
}
