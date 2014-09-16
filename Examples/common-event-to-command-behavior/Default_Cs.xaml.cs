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

#region common-event-to-command-behavior_01
public class ViewModel: ViewModelBase
{
    public ObservableCollection<string> ListBoxItems { get; set; }

    public ViewModel()
    {
        this.ListBoxItems = new ObservableCollection<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
    }
}
#endregion

#region common-event-to-command-behavior_02
public ICommand CustomCommand { get; set; }
    ...
public ViewModel()
{
    ...
    this.CustomCommand = new DelegateCommand(OnCustomCommandExecuted);
}

private void OnCustomCommandExecuted(object obj)
{
    MessageBox.Show("Command Executed!");
}
#endregion

#region common-event-to-command-behavior_03
private void OnCustomCommandExecuted(object obj)
{
    MessageBox.Show(obj.ToString());
}
#endregion

#region common-event-to-command-behavior_04
private void OnCustomCommandExecuted(object obj)
{
    var clickedItem = (obj as MouseButtonEventArgs).OriginalSource as TextBlock;
    if (clickedItem != null)
    {
        MessageBox.Show("Clicked Item: " + clickedItem.Text);
    }
}
#endregion


}
