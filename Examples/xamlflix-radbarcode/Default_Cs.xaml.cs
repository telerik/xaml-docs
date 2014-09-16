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

#region xamlflix_radbarcode_10
    private void Button_Click(object sender, RoutedEventArgs e)
 {
     PrintDocument document = new PrintDocument();
     document.PrintPage += (s, args) =>
     {
         args.PageVisual = this.radBookItem1;
     };
     document.Print("Silverlight Printing Demo");

 }
#endregion


}