using System.Collections.ObjectModel;

namespace DragDropManagerExample
{
    // >> dragdropmanager-getting-started-application-info
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
    // << dragdropmanager-getting-started-application-info
}
