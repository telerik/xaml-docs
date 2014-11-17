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

#region radtreeview-retrieving-checked-items_0
public class Family
{
    public Family()
    {
        this.Members = new ObservableCollection<Member>();
    }
    public string Name
    {
        get;
        set;
    }
    public ObservableCollection<Member> Members
    {
        get;
        set;
    }
}
....
public class Member
{
    public Member( string name )
    {
        this.Name = name;
    }
    public string Name
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-retrieving-checked-items_3
List<Family> dataSource = new List<Family>();
Family family = new Family();
family.Name = "Simpson";
family.Members.Add( new Member( "Homer" ) );
family.Members.Add( new Member( "Marge" ) );
family.Members.Add( new Member( "Bart" ) );
family.Members.Add( new Member( "Lisa" ) );
family.Members.Add( new Member( "Maggie" ) );
dataSource.Add( family );
family = new Family();
family.Name = "Flanders";
family.Members.Add( new Member( "Ned" ) );
family.Members.Add( new Member( "Maude" ) );
family.Members.Add( new Member( "Todd" ) );
family.Members.Add( new Member( "Rod" ) );
dataSource.Add( family );
this.radTreeView.ItemsSource = dataSource;
#endregion

#region radtreeview-retrieving-checked-items_5
foreach ( object checkedItem in radTreeView.CheckedItems )
{
    // Get the container(RadTreeViewItem) of the checked item
    RadTreeViewItem container = radTreeView.ContainerFromItemRecursive( checkedItem );
    // Add your logic for handling the checked item scenario here
}
#endregion

#region radtreeview-retrieving-checked-items_7
public interface IPath
{
    IPath Parent
    {
        get;
        set;
    }
    string GetFullPath();
}
#endregion

#region radtreeview-retrieving-checked-items_9
public class Member : IPath
{
    public Member( string name )
    {
        this.Name = name;
    }
    public string Name
    {
        get;
        set;
    }
    public IPath Parent
    {
        get;
        set;
    }
    public string GetFullPath()
    {
        if ( this.Parent != null )
            return this.Parent.GetFullPath() + "|" + this.ToString();
        return this.ToString();
    }
    public override string ToString()
    {
        return this.Name;
    }
}
#endregion

#region radtreeview-retrieving-checked-items_11
public class Family : IPath
{
    public Family()
    {
        this.Members = new ObservableCollection<Member>();
        this.Members.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler( Members_CollectionChanged );
    }
    private void Members_CollectionChanged( object sender, NotifyCollectionChangedEventArgs e )
    {
        if ( e.Action == NotifyCollectionChangedAction.Add )
            ( e.NewItems[ 0 ] as IPath ).Parent = this;
    }
    public string Name
    {
        get;
        set;
    }
    public ObservableCollection<Member> Members
    {
        get;
        set;
    }
    public IPath Parent
    {
        get;
        set;
    }
    public string GetFullPath()
    {
        if ( this.Parent != null )
            return this.Parent.GetFullPath() + "|" + this.ToString();
        return this.ToString();
    }
    public override string ToString()
    {
        return this.Name;
    }
}
#endregion

#region radtreeview-retrieving-checked-items_13
ObservableCollection<Family> dataSource = radTreeView.ItemsSource as ObservableCollection<Family>;
foreach ( Family family in dataSource )
{
    RadTreeViewItem familyContainer = radTreeView.GetItemByPath( family.GetFullPath(), "|" );
    if ( familyContainer != null && familyContainer.CheckState == ToggleState.On )
    {
        // add your logic for handling checked item scenario here.
    }
    foreach ( Member member in family.Members )
    {
        RadTreeViewItem memberContainer = radTreeView.GetItemByPath( member.GetFullPath(), "|" );
        if ( memberContainer != null && memberContainer.CheckState == ToggleState.On )
        {
            // add your logic for handling checked item scenario here.
        }
    }
}
#endregion

#region radtreeview-retrieving-checked-items_17
public class CheckStateConverter : IValueConverter
{
    public object Convert( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
    {
        bool result = ( bool )value;
        return result ? ToggleState.On : ToggleState.Off;
    }
    public object ConvertBack( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
    {
        ToggleState state = ( ToggleState )value;
        return state == ToggleState.On ? true : false;
    }
}
#endregion

#region radtreeview-retrieving-checked-items_20
public class Member
{
    public Member( string name )
    {
        this.Name = name;
    }
    public string Name
    {
        get;
        set;
    }
    public bool IsChecked
    {
        get;
        set;
    }
}
....
public class Family
{
    public Family()
    {
        this.Members = new ObservableCollection<Member>();
    }
    public string Name
    {
        get;
        set;
    }
    public bool IsChecked
    {
        get;
        set;
    }
    public ObservableCollection<Member> Members
    {
        get;
        set;
    }
}
#endregion
}
