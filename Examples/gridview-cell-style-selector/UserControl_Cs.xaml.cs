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

#region gridview-cell-style-selector_0
public class StadiumCapacityStyle : StyleSelector
{
 public override Style SelectStyle(object item, DependencyObject container)
 {
  if (item is Club)
  {
   Club club = item as Club;
   if (club.StadiumCapacity > 50000)
   {
    return BigStadiumStyle;
   }
   else
   {
    return SmallStadiumStyle;
   }
  }
  return null;
 }
 public Style BigStadiumStyle { get; set; }
 public Style SmallStadiumStyle { get; set; }
}
#endregion
}
