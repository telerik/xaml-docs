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

#region radtreeview-features-treeviewitem-bring-into-view-support_1
public class MyViewModel 
{
    private static int idCounter;
    private string title;
    public MyViewModel()
    {
        this.Id = idCounter++;
    }
    public int Id
    {
        get;
        protected set;
    }
    public String Title
    {
        get
        {
            return this.title;
        }
        set
        {
            if ( this.title != value )
            {
                this.title = value;
            }
        }
    }
}
//.....
RadTreeViewItem.ItemsSource = Enumerable.Range( 1, 40 ).Select( i => new MyViewModel()
{
    Title = "Item " + i
} ).ToList();
#endregion

#region radtreeview-features-treeviewitem-bring-into-view-support_3
private void BringItemIntoView()
{
    this.RadTreeViewItem.BringIndexIntoView( 20 );
}
#endregion
}
