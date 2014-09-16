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
#region radtimeline-mvvm-support_1
public class Product
{
	public TimeSpan Duration { get; set; }
	public DateTime Date { get; set; }

	public static ObservableCollection<Product> GetData(int count)
	{
		var startDate = new DateTime(2010, 1, 1);
		var endDate = new DateTime(2012, 2, 1);
		Random r = new Random();
		ObservableCollection<Product> result = new ObservableCollection<Product>();

		for (DateTime i = startDate; i < endDate; i = i.AddMonths(1))
		{
			result.Add(new Product() { Date = i, Duration = TimeSpan.FromDays(r.Next(50, 100))} );
		}

		for (int i = 0; i < 15; i++)
		{
			result.Add(new Product()
			{
				Date = startDate.AddMonths(r.Next(0, 25)).AddDays(15)
			});
		}

		return result;
	}
}
#endregion
	
#region radtimeline-mvvm-support_2
public class ExampleViewModel : ViewModelBase
{
	private ObservableCollection<Product> _data;
	public ObservableCollection<Product> Data
	{
		get
		{
			return this._data;
		}
		set
		{
			if (this._data != value)
			{
				this._data = value;
				this.OnPropertyChanged("Data");
			}
		}
	}

	public ExampleViewModel()
	{
		this.Data = Product.GetData(15);
	}
}
#endregion
	}
}
