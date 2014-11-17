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

#region radgridview-columns-column-types-hyperlink-column_1
public class Employee
{
   private string teamUrl = "http://google.com";
   public string TeamUrl
   {
        get { return this.teamUrl; }
        set
        {
            if (value != this.teamUrl)
            {
                this.teamUrl = value;
                this.OnPropertyChanged("TeamUrl");
            }
        }
   }
}
#endregion
}
