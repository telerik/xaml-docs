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

#region raddatafor-edit-lookup-values-with-radcombobox_0
public class Person
 {
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public int CountryID { get; set; }
 }
public class Country
 {
  public int ID { get; set; }
  public string Name { get; set; }
 }
#endregion

#region raddatafor-edit-lookup-values-with-radcombobox_2
public MainPage()
  {
   InitializeComponent();
   List<Person> persons = new List<Person>();
   // A sample list of source objects for the RadDataForm. 
   persons.Add(new Person() { FirstName = "John", LastName = "Smith", CountryID = 1 });
   persons.Add(new Person() { FirstName = "Angelo", LastName = "Romano", CountryID = 2 });
   persons.Add(new Person() { FirstName = "Jean", LastName = "Michel", CountryID = 3 });
   this.RadDataForm1.ItemsSource = persons;
  }
#endregion

#region raddatafor-edit-lookup-values-with-radcombobox_3
public MainWindow()
  {
   InitializeComponent();
   List<Person> persons = new List<Person>();
   // A sample list of source objects for the RadDataForm. 
   persons.Add(new Person() { FirstName = "John", LastName = "Smith", CountryID = 1 });
   persons.Add(new Person() { FirstName = "Angelo", LastName = "Romano", CountryID = 2 });
   persons.Add(new Person() { FirstName = "Jean", LastName = "Michel", CountryID = 3 });
   this.RadDataForm1.ItemsSource = persons;
  }
#endregion

#region raddatafor-edit-lookup-values-with-radcombobox_5
private List<Country> GetCountries()
  {
   List<Country> countries = new List<Country>();
   countries.Add(new Country() { ID = 1, Name = "USA" });
   countries.Add(new Country() { ID = 2, Name = "Italy" });
   countries.Add(new Country() { ID = 3, Name = "France" });
   countries.Add(new Country() { ID = 4, Name = "Canada" });
   return countries;
  }
#endregion

#region raddatafor-edit-lookup-values-with-radcombobox_7
private void RadDataForm_AutoGeneratingField(object sender, Telerik.Windows.Controls.Data.DataForm.AutoGeneratingFieldEventArgs e)
  {
   if (e.PropertyName == "CountryID")
   {
    e.DataField = new DataFormComboBoxField()
    {
     ItemsSource = this.GetCountries(),
     SelectedValuePath = "ID",
     DisplayMemberPath = "Name",
     DataMemberBinding = new Binding("CountryID") { Mode = BindingMode.TwoWay }
    };
   }
  }
#endregion
}
