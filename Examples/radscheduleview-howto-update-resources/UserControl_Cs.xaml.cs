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

#region radscheduleview-howto-update-resources_2
public class ViewModel : ViewModelBase
{
	private bool _showRoom1 = true;
	private bool _showRoom2 = false;
	private bool _showRoom3 = true;
	private Func<object, bool> groupFilter;

	public bool ShowRoom1
	{
		get
		{
			return this._showRoom1;
		}
		set
		{
			if (this._showRoom1 != value)
			{
				this._showRoom1 = value;
				this.OnPropertyChanged(() => this.ShowRoom1);
				this.UpdateGroupFilter();
			}
		}
	}
	public bool ShowRoom2
	{
		get
		{
			return this._showRoom2;
		}
		set
		{
			if (this._showRoom2 != value)
			{
				this._showRoom2 = value;
				this.OnPropertyChanged(() => this.ShowRoom2);
				this.UpdateGroupFilter();
			}
		}
	}
	public bool ShowRoom3
	{
		get
		{
			return this._showRoom3;
		}
		set
		{
			if (this._showRoom3 != value)
			{
				this._showRoom3 = value;
				this.OnPropertyChanged(() => this.ShowRoom3);
				this.UpdateGroupFilter();
			}
		}
	}

	public Func<object, bool> GroupFilter
	{
		get
		{
			return this.groupFilter;
		}
		private set
		{
			this.groupFilter = value;
			this.OnPropertyChanged(() => this.GroupFilter);
		}
	}
}
#endregion

#region radscheduleview-howto-update-resources_3
private bool GroupFilterFunc(object groupName)
{
	IResource resource = groupName as IResource;
	return resource == null ? true : this.GetEnabledGroups().Contains(resource.ResourceName, StringComparer.OrdinalIgnoreCase);
}

private IEnumerable<string> GetEnabledGroups()
{
	List<string> enabledGroups = new List<string>();

	if (this.ShowRoom1) enabledGroups.Add("Room1");
	if (this.ShowRoom2) enabledGroups.Add("Room2");
	if (this.ShowRoom3) enabledGroups.Add("Room3");
		
	return enabledGroups;
}

private void UpdateGroupFilter()
{
	this.GroupFilter = new Func<object, bool>(this.GroupFilterFunc);
}
#endregion

#region radscheduleview-howto-update-resources_4
locationResType.Resources.Add(new Resource("Room4"));
ResourceTypes.Remove(locationResType);
ResourceTypes.Add(locationResType);
#endregion

}
