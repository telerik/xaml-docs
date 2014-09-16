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

#region raddocking-features-panes-panesource-1
public class ViewModel : ViewModelBase
{
    private ObservableCollection<RadPane> panes;

    public ViewModel()
    {
            
    }

    public ObservableCollection<RadPane> Panes
    {
        get
        {
            return this.panes;
        }

        set
        {
            if (this.panes != value)
            {
                this.panes = value;
                this.OnPropertyChanged(() => this.Panes);
            }
        }
    }
}
#endregion

#region raddocking-features-panes-panesource-2
public class ViewModel : ViewModelBase
{
    private ObservableCollection<RadPane> panes;

    public ViewModel()
    {
        this.Panes = new ObservableCollection<RadPane>()
        {
            new RadPane() { Header = "Pane 1" },
            new RadPane() { Header = "Pane 2" },
            new RadPane() { Header = "Pane 3" }
        };
    }

    public ObservableCollection<RadPane> Panes
    {
        get
        {
            return this.panes;
        }

        set
        {
            if (this.panes != value)
            {
                this.panes = value;
                this.OnPropertyChanged(() => this.Panes);
            }
        }
    }
}
#endregion

#region raddocking-features-panes-panesource-3
public class ViewModel : ViewModelBase
{
    private ObservableCollection<RadPane> panes;

    public ViewModel()
    {
        this.Panes = new ObservableCollection<RadPane>()
        {
            new RadPane() { Header = "Bottom Pane 1", Tag = "Bottom" },
            new RadPane() { Header = "Bottom Pane 2", Tag = "Bottom" },
            new RadPane() { Header = "Left Pane", Tag = "Left" }
        };
    }

    public ObservableCollection<RadPane> Panes
    {
        get
        {
            return this.panes;
        }

        set
        {
            if (this.panes != value)
            {
                this.panes = value;
                this.OnPropertyChanged(() => this.Panes);
            }
        }
    }
}
#endregion

#region raddocking-features-panes-panesource-4
public class CustomDockingPanesFactory : DockingPanesFactory
{
        
}
#endregion

#region raddocking-features-panes-panesource-5
public class CustomDockingPanesFactory : DockingPanesFactory
{
    protected override void AddPane(Telerik.Windows.Controls.RadDocking radDocking, Telerik.Windows.Controls.RadPane pane)
    {
        var tag = pane.Tag.ToString();
        var paneGroup = radDocking.SplitItems.ToList().FirstOrDefault(i => i.Control.Name.Contains(tag)) as RadPaneGroup;

        if (paneGroup != null)
        {
            paneGroup.Items.Add(pane);
        }
        else
        {
            base.AddPane(radDocking, pane);
        }
    }
}
#endregion

#region raddocking-features-panes-panesource-6

#endregion
}
