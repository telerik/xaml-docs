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

#region radganttview-features-items-expand-collapse-1
public class CustomInitialExpandBehavior : IInitialExpandBehavior
{

}
#endregion

#region radganttview-features-items-expand-collapse-2
public class CustomInitialExpandBehavior : IInitialExpandBehavior
{
    public bool ShouldExpandItemByDefault(Telerik.Windows.Core.HierarchicalItem item)
    {
        var shouldExpand = item.Level > 0;

        return shouldExpand;
    }
}
#endregion
    
#region radganttview-features-items-expand-collapse-3
private void ExpandButton_Click(object sender, RoutedEventArgs e)
{
    var firstTask = (this.GanttView.TasksSource as IList<GanttTask>)[0];
    this.GanttView.ExpandCollapseService.ExpandItem(firstTask);
}

private void CollapseButton_Click(object sender, RoutedEventArgs e)
{
    var firstTask = (this.GanttView.TasksSource as IList<GanttTask>)[0];
    this.GanttView.ExpandCollapseService.CollapseItem(firstTask);
}
#endregion
}
