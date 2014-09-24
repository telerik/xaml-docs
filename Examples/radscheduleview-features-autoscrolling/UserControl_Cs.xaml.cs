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

#region radscheduleview-features-categories_1
public class MyViewModel : ViewModelBase
{
	public ObservableCollection<Appointment> Appointments { get; set; }
	public ObservableCollection<Category> Categories { get; set; }

	public MyViewModel()
	{
		this.Appointments = new ObservableCollection<Appointment>();
		this.Categories = new ObservableCollection<Category>() {
			new Category( "Red Category", new SolidColorBrush( Colors.Red ) ),
			new Category( "Orange Category", new SolidColorBrush( Colors.Orange ) ),
			new Category( "Green Category", new SolidColorBrush( Colors.Green ) )
		};
	}
}
#endregion


#region radscheduleview-features-categories_2
newApp.Category = (scheduleView.CategoriesSource as CategoryCollection).Where(p => p.CategoryName == "Red Category").First();
#endregion

#region radscheduleview-features-categories_4
this.DataContext = new MyViewModel();
#endregion

	}
}
