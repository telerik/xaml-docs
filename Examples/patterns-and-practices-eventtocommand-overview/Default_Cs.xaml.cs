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

#region patterns-and-practices-eventtocommand-overview_2
public class ExampleDataItem : INotifyPropertyChanged
{
	private int _ID;
	public int ID
	{
		get { return _ID; }
		set
		{
			if (_ID != value)
			{
				_ID = value;
				OnPropertyChanged("ID");
			}
		}
	}

	private string _Name;
	public string Name
	{
		get { return _Name; }
		set
		{
			if (_Name != value)
			{
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
	}

	private DateTime _Date;
	public DateTime Date
	{
		get { return _Date; }
		set
		{
			if (_Date != value)
			{
				_Date = value;
				OnPropertyChanged("Date");
			}
		}
	}

	private bool _IsAvailable;
	public bool IsAvailable
	{
		get { return _IsAvailable; }
		set
		{
			if (_IsAvailable != value)
			{
				_IsAvailable = value;
				OnPropertyChanged("IsAvailable");
			}
		}
	}

	public ExampleDataItem()
	{

	}

	#region INotifyPropertyChanged Implementation

	public event PropertyChangedEventHandler PropertyChanged;

	public void OnPropertyChanged(string propName)
	{
		if (string.IsNullOrEmpty(propName))
			throw new ArgumentException("propName");

		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}
	}

	#endregion

}
#endregion

#region patterns-and-practices-eventtocommand-overview_3
public ObservableCollection<ExampleDataItem> GridItems;
public ObservableCollection<string> ListItems;
#endregion


#region patterns-and-practices-eventtocommand-overview_4
public ExampleViewModel()
{
    SetupData();
}
 
public void SetupData()
{
    Random rnd = new Random();
 
    GridItems = new ObservableCollection<ExampleDataItem>();
    ListItems = new ObservableCollection<string>();
 
    for (int i = 0; i < 100; i++)
    {
        ExampleDataItem edi = new ExampleDataItem();
        edi.ID = i;
        edi.Name = "Name " + i.ToString();
        edi.Date = DateTime.Today.AddDays(i);
        edi.IsAvailable = (i % 3 == 0 ? true : false);
 
        GridItems.Add(edi);
    }
}
#endregion
}
