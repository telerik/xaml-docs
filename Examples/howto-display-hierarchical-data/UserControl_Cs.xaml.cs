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

#region howto-display-hierarchical-data_0
public class MyViewModel
 {
  public MyViewModel()
  {
   this.RelatedItems = new ObservableCollection<object>();
  }
  public string Title { get; set; }
  public DateTime DateCreated { get; set; }
  public double Price { get; set; }
  public IList<object> RelatedItems { get; set; }
 }
#endregion

#region howto-display-hierarchical-data_2
public static IList<object> GenerateItems()
{
 var result = new ObservableCollection<object>();
 foreach (var num in Enumerable.Range(1, 5))
 {
  var item = new MyViewModel();
  item.DateCreated = DateTime.Today.AddDays(-num % 15);
  item.Price = num * 100 + Convert.ToDouble(num) / 100;
  item.Title = String.Format("Item {0}", num);
  for (int i = 0; i < 5; i++)
  {
   var child = new MyViewModel();
   child.DateCreated = DateTime.Today.AddDays(-num % 5 - i);
   child.Price = num * 100 + Convert.ToDouble(num + i) / 100;
   child.Title = String.Format("Item {0}.{1}", num, i);
   item.RelatedItems.Add(child);
  }
  result.Add(item);
 }
 return result;
}
#endregion

#region howto-display-hierarchical-data_7
this.radPanelBar.ItemsSource = MyViewModel.GenerateItems();
#endregion
}
