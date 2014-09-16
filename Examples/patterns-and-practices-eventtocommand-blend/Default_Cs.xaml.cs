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

#region patterns-and-practices-eventtocommand-blend_5
public ObservableCollection<ExampleDataItem> GridItems { get; set; }
public ObservableCollection<string> ListItems { get; set; }
#endregion

#region patterns-and-practices-eventtocommand-blend_8
public DelegateCommand TestCommand { get; set; }
 
public ExampleViewModel()
{
    SetupData();
 
    TestCommand = new DelegateCommand(<something needed here>);
}
#endregion

#region patterns-and-practices-eventtocommand-blend_9
public void RunEdit(object obj)
{
     ListItems.Add("Row Edited!");
}
#endregion

#region patterns-and-practices-eventtocommand-blend_10
TestCommand = new DelegateCommand(RunEdit);
#endregion

#region patterns-and-practices-eventtocommand-blend_13
private void xGridBlend_Click(object sender, RoutedEventArgs e)
{
     xContentBorder.Child = new GridBlendInteraction();
}
#endregion


}