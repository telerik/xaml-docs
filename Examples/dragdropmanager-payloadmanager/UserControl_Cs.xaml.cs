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

#region dragdropmanager-payloadmanager_01
public class ViewModel : ViewModelBase
{
    public ObservableCollection<Customer> ItemsSource1 { get; set; }
    public ObservableCollection<string> ItemsSource2 { get; set; }

    public ViewModel()
    {
        this.ItemsSource1 = new ObservableCollection<Customer>
        {
            new Customer { FirstName= "John", LastName = "Smith", Age = 24},
            new Customer { FirstName= "George", LastName = "Lucas", Age = 35},
            new Customer { FirstName= "Justin", LastName = "Marks", Age = 16},
            new Customer { FirstName= "Emily", LastName = "Rose", Age = 40},
            new Customer { FirstName= "Mike", LastName = "Jones", Age = 20},
        };

        this.ItemsSource2 = new ObservableCollection<string>();
    }
}
#endregion

#region dragdropmanager-payloadmanager_02
public class CustomerToStringConverter : DataConverter
{
    public override object ConvertTo(object data, string format)
    {
        if (format == typeof(string).FullName && DataObjectHelper.GetDataPresent(data, "DragData", false))
        {
            var customer = DataObjectHelper.GetData(data, "DragData", false) as Customer;
            var fullInfoString = "Name: " + customer.FirstName + " " + customer.LastName + ", Age: " + customer.Age;
            return fullInfoString;
        }

        return null;
    }

    public override string[] GetConvertToFormats()
    {
        return new string[] { typeof(string).FullName };
    }
}
#endregion

#region dragdropmanager-payloadmanager_03
DragDropManager.AddDragInitializeHandler(this.ListBox1, OnDragInitialize);            
#endregion

#region dragdropmanager-payloadmanager_04
private void OnDragInitialize(object sender, DragInitializeEventArgs e)
{
    e.AllowedEffects = DragDropEffects.All;
    var payload = DragDropPayloadManager.GeneratePayload(new CustomerToStringConverter());            
    var data = ((FrameworkElement)e.OriginalSource).DataContext;
    payload.SetData("DragData", data);
    e.Data = payload;
    e.Handled = true;
}            
#endregion

#region dragdropmanager-payloadmanager_05
DragDropManager.AddDragOverHandler(this.ListBox2, OnDragOver);         
#endregion

#region dragdropmanager-payloadmanager_06
private void OnDragOver(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var formats = DragDropPayloadManager.GetFormats(e.Data, true);

    if (formats.Contains(typeof(string).FullName))
    {
        e.Effects = DragDropEffects.Move;
    }
    else
    {
        e.Effects = DragDropEffects.None;
    }

    e.Handled = true;
}      
#endregion

#region dragdropmanager-payloadmanager_07
DragDropManager.AddDropHandler(this.ListBox2, OnDrop);
#endregion

#region dragdropmanager-payloadmanager_08
private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs e)
{
    var data = DragDropPayloadManager.GetDataFromObject(e.Data, typeof(string).FullName);
    ((IList)(sender as RadListBox).ItemsSource).Add(data);          
    DragDropPayloadManager.SetData(e.Data, "IsDropSuccessful", true);        
    e.Handled = true;
}
#endregion

#region dragdropmanager-payloadmanager_09
DragDropManager.AddDragOverHandler(this.ListBox2, OnDragOver);
#endregion

#region dragdropmanager-payloadmanager_10
private void OnDragDropCompleted(object sender, DragDropCompletedEventArgs e)
{
    var isDropSuccessful = DragDropPayloadManager.GetDataFromObject(e.Data, "IsDropSuccessful");

    if (isDropSuccessful != null && (bool)isDropSuccessful)
    {
        var data = DragDropPayloadManager.GetDataFromObject(e.Data, "DragData");
        ((IList)(sender as RadListBox).ItemsSource).Remove(data);
    }

    e.Handled = true;
}
#endregion

}
