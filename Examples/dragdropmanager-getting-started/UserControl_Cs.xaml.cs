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

#region dragdropmanager-getting-started_0
public class ApplicationInfo
    {
        public Double Price
        {
            get;
            set;
        }
        public String IconPath
        {
            get;
            set;
        }
        public String Name
        {
            get;
            set;
        }
        public String Author
        {
            get;
            set;
        }
        public static ObservableCollection<ApplicationInfo> GenerateApplicationInfos()
        {
            ObservableCollection<ApplicationInfo> result = new ObservableCollection<ApplicationInfo>();
            ApplicationInfo info1 = new ApplicationInfo();
            info1.Name = "Large Collider";
            info1.Author = "C.E.R.N.";
            info1.IconPath = @"img/Atom.png";
            result.Add(info1);
            ApplicationInfo info2 = new ApplicationInfo();
            info2.Name = "Paintbrush";
            info2.Author = "Imagine Inc.";
            info2.IconPath = @"img/Brush.png";
            result.Add(info2);
            ApplicationInfo info3 = new ApplicationInfo();
            info3.Name = "Lively Calendar";
            info3.Author = "Control AG";
            info3.IconPath = @"img/CalendarEvents.png";
            result.Add(info3);
            ApplicationInfo info4 = new ApplicationInfo();
            info4.Name = "Fire Burning ROM";
            info4.Author = "The CD Factory";
            info4.IconPath = @"img/CDBurn.png";
            result.Add(info4);
            ApplicationInfo info5 = new ApplicationInfo();
            info5.Name = "Fav Explorer";
            info5.Author = "Star Factory";
            info5.IconPath = @"img/favorites.png";
            result.Add(info5);
            ApplicationInfo info6 = new ApplicationInfo();
            info6.Name = "IE Fox";
            info6.Author = "Open Org";
            info6.IconPath = @"img/Connected.png";
            result.Add(info6);
            ApplicationInfo info7 = new ApplicationInfo();
            info7.Name = "Charting";
            info7.Author = "AA-AZ inc";
            info7.IconPath = @"img/ChartDot.png";
            result.Add(info7);
            ApplicationInfo info8 = new ApplicationInfo();
            info8.Name = "SuperPlay";
            info8.Author = "EB Games";
            info8.IconPath = @"img/Games.png";
            result.Add(info8);
            return result;
        }
    }
#endregion

#region dragdropmanager-getting-started_3
ApplicationList.ItemsSource = ApplicationInfo.GenerateApplicationInfos();
MyAppList.ItemsSource = new ObservableCollection<ApplicationInfo>();
#endregion

#region dragdropmanager-getting-started_5
DragDropManager.AddDragInitializeHandler(ApplicationList, OnDragInitialize);
DragDropManager.AddDragInitializeHandler(MyAppList, OnDragInitialize);

DragDropManager.AddGiveFeedbackHandler(ApplicationList, OnGiveFeedback);
DragDropManager.AddGiveFeedbackHandler(MyAppList, OnGiveFeedback);

DragDropManager.AddDragDropCompletedHandler(ApplicationList, OnDragCompleted);
DragDropManager.AddDragDropCompletedHandler(MyAppList, OnDragCompleted);

DragDropManager.AddDropHandler(ApplicationList, OnDrop);
DragDropManager.AddDropHandler(MyAppList, OnDrop);

#endregion

#region dragdropmanager-getting-started_7
private void OnDragInitialize(object sender, DragInitializeEventArgs args)
{
    args.AllowedEffects = DragDropEffects.All;
    var payload = DragDropPayloadManager.GeneratePayload(null);
    var data = ((FrameworkElement)args.OriginalSource).DataContext;
    payload.SetData("DragData", data);
    args.Data = payload;
    args.DragVisual = new ContentControl { Content = data, ContentTemplate = LayoutRoot.Resources["ApplicationTemplate"] as DataTemplate };
}
#endregion

#region dragdropmanager-getting-started_9
private void OnGiveFeedback(object sender, Telerik.Windows.DragDrop.GiveFeedbackEventArgs args)
{
    args.SetCursor(Cursors.Arrow);
    args.Handled = true;
}
#endregion

#region dragdropmanager-getting-started_11
private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs args)
{
    var data = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData");
    ((IList)(sender as ListBox).ItemsSource).Add(data);
}

public void OnDragCompleted(object sender, Telerik.Windows.DragDrop.DragDropCompletedEventArgs args)
{
    var data = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData");
    ((IList)(sender as ListBox).ItemsSource).Remove(data);
}
#endregion

#region dragdropmanager-getting-started_13
private void OnDrop(object sender, Telerik.Windows.DragDrop.DragEventArgs args)
{
    var data = ((DataObject)args.Data).GetData("DragData");
    ((IList)(sender as ListBox).ItemsSource).Add(data);
}

public void OnDragCompleted(object sender, Telerik.Windows.DragDrop.DragDropCompletedEventArgs args)
{
    var data = DragDropPayloadManager.GetDataFromObject(args.Data, "DragData");
    ((IList)(sender as ListBox).ItemsSource).Remove(data);
}
#endregion

}
