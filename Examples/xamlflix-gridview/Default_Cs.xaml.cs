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

#region xamlflix_gridview_16
public class DemoClass
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Company { get; set; }
    public bool IsComplete { get; set; }
    public DateTime DueDate { get; set; }
}

#endregion


#region xamlflix_gridview_17
var myDemoClasses = new ObservableCollection<DemoClass>();
#endregion

#region xamlflix_gridview_18
for ( int x = 1; x <= 2000; x++)
{
    var dc = new DemoClass();
    dc.ID = x;
    dc.Name = "Person " + x.ToString();
    dc.Company = x % 2 == 0 ? 
        "Super Company " + x.ToString() : "Sub-par company " + x.ToString();
    dc.IsComplete = x % 4 == 0 ? true : false;
    dc.DueDate = DateTime.Today.AddDays(x);
    myDemoClasses.Add(dc);
}
#endregion


#region xamlflix_gridview_19
radGridView1.ItemsSource = myDemoClasses;
#endregion

#region xamlflix_gridview_20
public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool Married { get; set; }
}

#endregion


#region xamlflix_gridview_21
public MainPage()
{
    InitializeComponent();
    Loaded += new RoutedEventHandler(MainPage_Loaded);
}

void MainPage_Loaded(object sender, RoutedEventArgs e)
{
    this.radGridView1.ItemsSource = EmployeeService.GetEmployees();
}
#endregion

#region xamlflix_gridview_22
private void button1_Click(object sender, RoutedEventArgs e)
{
    string extension = "xls";
    SaveFileDialog dialog = new SaveFileDialog()
    {
        DefaultExt = extension,
        Filter = String.Format("{1} files (*.{0})|*.{0}|All files(*.*)|*.*", extension, "Excel"),
        FilterIndex = 1
    };

    if ( dialog.ShowDialog() == true)
    {
    	using (Stream stream = dialog.OpenFile())
        {
            radGridView1.Export(stream,
                new GridViewExportOptions()
                {
                    Format = ExportFormat.ExcelML,
                    ShowColumnHeaders = true,
                    ShowColumnFooters = true,
                    ShowGroupFooters = false,

                });
        }
    }
}
#endregion


#region xamlflix_gridview_23
string extension = "htm";
SaveFileDialog dialog = new SaveFileDialog()
{
    DefaultExt = extension,
    Filter = String.Format("{1} files (*.{0})|*.{0}|All files(*.*)|*.*", 
          extension, "HTML"),
    FilterIndex = 1
};

if ( dialog.ShowDialog() == true)
{
	using (Stream stream = dialog.OpenFile())
    {
        radGridView1.Export(stream,
            new GridViewExportOptions()
            {
                Format = ExportFormat.Html,
                ShowColumnHeaders = true,
                ShowColumnFooters = true,
                ShowGroupFooters = false,

            });
#endregion

#region xamlflix_gridview_24
private void Application_Startup(object sender, StartupEventArgs e)
{
    this.RootVisual = new MainPage();
}

#endregion


#region xamlflix_gridview_25
Thread.CurrentThread.CurrentCulture = new CultureInfo("es");
Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");

#endregion

#region xamlflix_gridview_26
private void radGridView1_CellValidating(
    object sender, GridViewCellValidatingEventArgs e)
 {
 }

#endregion


#region xamlflix_gridview_27
if ( e.Cell.Column.UniqueName == "Age" )
#endregion

#region xamlflix_gridview_28
private void radGridView1_CellValidating(
     object sender, GridViewCellValidatingEventArgs e)
 {
     if ( e.Cell.Column.UniqueName == "Age" )
     {
         var newValue = Int32.Parse(e.NewValue.ToString());
         if (newValue < 0 || newValue > 130)
         {
             e.IsValid = false;
             e.ErrorMessage = "The entered value for age must be between 0 and 130.";
         }
     }
 }
#endregion

#region xamlflix_gridview_29
private void radGridView1_RowValidating(
    object sender, GridViewRowValidatingEventArgs e)
{
    MessageBox.Show("Row Validating");
}

#endregion


}