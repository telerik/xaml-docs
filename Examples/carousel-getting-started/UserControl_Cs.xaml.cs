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

#region carousel-getting-started_2
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
  public string Position
  {
   get;
   set;
  }
 }
#endregion

#region carousel-getting-started_4
public class EmployeeService
 {
  public static ObservableCollection<Employee> GetEmployees()
  {
   ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
   Employee employee = new Employee();
   employee.FirstName = "Margaret";
   employee.LastName = "Peacock";
   employee.Position = "Sales Representative";
   employee.Age = 24;
   employees.Add(employee);
   employee = new Employee();
   employee.FirstName = "Steven";
   employee.LastName = "Buchanan";
   employee.Position = "Sales Manager";
   employee.Age = 44;
   employees.Add(employee);
   employee = new Employee();
   employee.FirstName = "Michael";
   employee.LastName = "Suyama";
   employee.Position = "Sales Representative";
   employee.Age = 33;
   employees.Add(employee);
   employee = new Employee();
   employee.FirstName = "Robert";
   employee.LastName = "King";
   employee.Position = "Sales Representative";
   employee.Age = 28;
   employees.Add(employee);
   employee = new Employee();
   employee.FirstName = "Laura";
   employee.LastName = "Callahan";
   employee.Position = "Inside Sales Coordinator";
   employee.Age = 26;
   employees.Add(employee);
   employee = new Employee();
   employee.FirstName = "Anne";
   employee.LastName = "Dodsworth";
   employee.Position = "Sales Representative";
   employee.Age = 30;
   employees.Add(employee);
   return employees;
  }
 }
#endregion

#region carousel-getting-started_6
public MainWindow()
  {
   InitializeComponent();
   this.MyCarousel.ItemsSource = EmployeeService.GetEmployees();
  }
#endregion

#region carousel-getting-started_8
public MainWindow()
  {
   InitializeComponent();
   List<Image> myImages = new List<Image>();
   Image myImage = new Image();
   myImage.Source = new BitmapImage(new Uri("/Images/nature1.jpg", UriKind.Relative));
   myImage.Height = 200;
   myImage.Width = 200;
   myImages.Add(myImage);
   Image myImage1 = new Image();
   myImage1.Source = new BitmapImage(new Uri("/Images/nature2.jpg", UriKind.Relative));
   myImage1.Height = 200;
   myImage1.Height = 200;
   myImages.Add(myImage1);
   Image myImage2 = new Image();
   myImage2.Source = new BitmapImage(new Uri("/Images/nature15.jpg", UriKind.Relative));
   myImage2.Width = 200;
   myImage.Height = 200;
   myImages.Add(myImage2);
   Image myImage3 = new Image();
   myImage3.Source = new BitmapImage(new Uri("/Images/nature19.jpg", UriKind.Relative));
   myImage3.Height = 200;
   myImage3.Width = 200;
   myImages.Add(myImage3);
   Image myImage4 = new Image();
   myImage4.Source = new BitmapImage(new Uri("/Images/nature26.jpg", UriKind.Relative));
   myImage4.Height = 200;
   myImage4.Width = 200;
   myImages.Add(myImage4);
   this.MyCarousel.ItemsSource = myImages;   
  }
#endregion
}
