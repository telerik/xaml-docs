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

#region radbreadcrumb-getting-started_1
RadBreadcrumb breadcrumb = new RadBreadcrumb();
breadcrumb.Header = "Breadcrumb Header";
breadcrumb.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
breadcrumb.VerticalAlignment = System.Windows.VerticalAlignment.Top;
#endregion

#region radbreadcrumb-getting-started_4
RadBreadcrumbItem item1 = new RadBreadcrumbItem() { Header = "BreadcrumbItem 1", DropDownHeader = "DropDownItem 1" };
item1.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 1.1", DropDownHeader = "DropDownItem 1.1" });
item1.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 1.2", DropDownHeader = "DropDownItem 1.2" });
item1.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 1.3", DropDownHeader = "DropDownItem 1.3" });
breadcrumb.Items.Add(item1);
RadBreadcrumbItem item2 = new RadBreadcrumbItem() { Header = "BreadcrumbItem 2", DropDownHeader = "DropDownItem 2" };
item2.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 2.1", DropDownHeader = "DropDownItem 2.1" });
item2.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 2.2", DropDownHeader = "DropDownItem 2.2" });
item2.Items.Add(new RadBreadcrumbItem() { Header = "BreadcrumbItem 2.3", DropDownHeader = "DropDownItem 2.3" });
breadcrumb.Items.Add(item2);
RadBreadcrumbItem item3 = new RadBreadcrumbItem() { Header = "BreadcrumbItem 3", DropDownHeader = "DropDownItem 3" };
breadcrumb.Items.Add(item3);
#endregion

#region radbreadcrumb-getting-started_6
breadcrumb.Items.Remove(item2);
#endregion

#region radbreadcrumb-getting-started_9
breadcrumb.IsLinearMode = true;
#endregion

#region radbreadcrumb-getting-started_12
breadcrumb.HistorySize = 15;
#endregion

#region radbreadcrumb-getting-started_15
StyleManager.SetTheme(breadcrumb, new VistaTheme());
#endregion
}
