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

#region radtreeview-how-to-wpf-windowsexplorer-like-treeview_1
public class File
{
    public File( string fullPath, string name )
    {
        this.FullPath = fullPath;
        this.Name = name;
    }
    public string FullPath
    {
        get;
        set;
    }
    public string Name
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-how-to-wpf-windowsexplorer-like-treeview_3
public class Directory
{
    public Directory( string fullPath, string name )
    {
        this.FullPath = fullPath;
        this.Name = name;
        this.Children = new ObservableCollection<object>();
    }
    public string FullPath
    {
        get;
        set;
    }
    public string Name
    {
        get;
        set;
    }
    public ObservableCollection<object> Children
    {
        get;
        private set;
    }
}
#endregion

#region radtreeview-how-to-wpf-windowsexplorer-like-treeview_5
public class Drive
{
    public Drive( string name, bool isReady )
    {
        this.Name = name;
        this.IsReady = isReady;
        this.Children = new ObservableCollection<object>();
    }
    public string Name
    {
        get;
        set;
    }
    public bool IsReady
    {
        get;
        set;
    }
    public ObservableCollection<object> Children
    {
        get;
        private set;
    }
}
#endregion

#region radtreeview-how-to-wpf-windowsexplorer-like-treeview_7
public sealed class ServiceFacade
{
    private static ServiceFacade instance;
    public static ServiceFacade Instance
    {
        get
        {
            if ( instance == null )
            {
                instance = new ServiceFacade();
                instance.Initialize();
            }
            return instance;
        }
    }
    public ObservableCollection<Drive> Drives
    {
        get;
        private set;
    }
    private void Initialize()
    {
    }
}
#endregion

#region radtreeview-how-to-wpf-windowsexplorer-like-treeview_9
private void Initialize()
{
    this.Drives = new ObservableCollection<Drive>();
    foreach ( DriveInfo driveInfo in System.IO.DriveInfo.GetDrives() )
    {
        this.Drives.Add( new Drive( driveInfo.Name, driveInfo.IsReady ) );
    }
}
#endregion

#region radtreeview-how-to-wpf-windowsexplorer-like-treeview_13
public class ItemStyleSelector : StyleSelector
{
    public override System.Windows.Style SelectStyle( object item, System.Windows.DependencyObject container )
    {
        if ( item is Drive )
            return this.DriveStyle;
        else if ( item is Directory )
            return this.DirectoryStyle;
        else if ( item is File )
            return this.FileStyle; 
        return base.SelectStyle( item, container );
    }
    public Style DirectoryStyle
    {
        get;
        set;
    }
    public Style FileStyle
    {
        get;
        set;
    }
    public Style DriveStyle
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-how-to-wpf-windowsexplorer-like-treeview_16
private void RadTreeView_LoadOnDemand( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
}

private void RadTreeView_ItemPrepared(object sender, RadTreeViewItemPreparedEventArgs e)
{
}
#endregion

#region radtreeview-how-to-wpf-windowsexplorer-like-treeview_19
private void RadTreeView_LoadOnDemand( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
    e.Handled = true;
    RadTreeViewItem expandedItem = e.OriginalSource as RadTreeViewItem;
    if ( expandedItem == null )
        return;
    Drive drive = expandedItem.Item as Drive;
    if ( drive != null )
    {
        ServiceFacade.Instance.LoadChildren( drive );
        return;
    }
    Directory directory = expandedItem.Item as Directory;
    if ( directory != null )
    {
        ServiceFacade.Instance.LoadChildren( directory );
    }
}
#endregion

#region radtreeview-how-to-wpf-windowsexplorer-like-treeview_21
public void LoadChildren( Drive d )
{
    foreach ( string directory in System.IO.Directory.GetDirectories( d.Name ) )
    {
        DirectoryInfo directoryInfo = new DirectoryInfo( directory );
        d.Children.Add( new Directory( directory, directoryInfo.Name ) );
    }
    foreach ( string file in System.IO.Directory.GetFiles( d.Name ) )
    {
        FileInfo fileInfo = new FileInfo( file );
        d.Children.Add( new File( file, fileInfo.Name ) );
    }
}
public void LoadChildren( Directory d )
{
    foreach ( string directory in System.IO.Directory.GetDirectories( d.FullPath ) )
    {
        DirectoryInfo directoryInfo = new DirectoryInfo( directory );
        d.Children.Add( new Directory( directory, directoryInfo.Name ) );
    }
    foreach ( string file in System.IO.Directory.GetFiles( d.FullPath ) )
    {
        FileInfo fileInfo = new FileInfo( file );
        d.Children.Add( new File( file, fileInfo.Name ) );
    }
}
#endregion

#region radtreeview-how-to-wpf-windowsexplorer-like-treeview_22
private void RadTreeView_ItemPrepared(object sender, RadTreeViewItemPreparedEventArgs e)
{
	if (e.PreparedItem.DataContext is File)
	{
		e.PreparedItem.IsLoadOnDemandEnabled = false;
	}
}
#endregion
}
