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

#region radBusyIndicator-how-to-integrate-with-services-and-radwindow_1
public class Employee
{
    public string FirstName
    {
        get;
        set;
    }
    public string LastName
    {
        get;
        set;
    }
    public int Age
    {
        get;
        set;
    }
    public bool Married
    {
        get;
        set;
    }
}
#endregion

#region radBusyIndicator-how-to-integrate-with-services-and-radwindow_2
public class EmployeeService
{
    public static ObservableCollection<Employee> GetEmployees()
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        Employee employee = new Employee();
        employee.FirstName = "Maria";
        employee.LastName = "Anders";
        employee.Married = true;
        employee.Age = 24;
        employees.Add( employee );        //...
        Thread.Sleep( employees.Count * 100 );
        return employees;
    }
}
#endregion

#region radBusyIndicator-how-to-integrate-with-services-and-radwindow_5
public partial class RadWindow1
{      
	private BackgroundWorker worker = new BackgroundWorker();
	public RadBusyIndicatorExample()
	{
		InitializeComponent();
		this.radWindow.Show();
		worker.DoWork += this.WorkerDoWork;
		worker.RunWorkerCompleted += WorkerRunWorkerCompleted;            
	}
	private void WorkerDoWork( object sender, DoWorkEventArgs e )
	{
		e.Result = EmployeeService.GetEmployees();            
	}
	private void UpdateGridDataSource( ObservableCollection<Employee> employees )
	{
		this.radGridView.ItemsSource = employees;
		this.radBusyIndicator.IsBusy = false;
	}

	void WorkerRunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
	{
		Dispatcher.BeginInvoke( new Action<ObservableCollection<Employee>>( this.UpdateGridDataSource ), e.Result );
	}

	private void LoadDataButton_Click( object sender, RoutedEventArgs e )
	{
		if ( !worker.IsBusy )
		{
			this.radBusyIndicator.IsBusy = true;
			worker.RunWorkerAsync();
		}
	}
}
#endregion


#region radBusyIndicator-how-to-integrate-with-services-and-radwindow_7
var radWindow = new RadWindow1();
radWindow.Show();
#endregion
}
