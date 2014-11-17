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

#region raddatapager-features-unbound-mode_1
public partial class UnboundModeSample : UserControl
{
    private List<int> data;
    public UnboundModeSample()
    {
        InitializeComponent();
        this.data = Enumerable.Range( 0, 100 ).ToList();
        this.radDataPager.ItemCount = data.Count;
        this.listBox.ItemsSource = this.data.Take( this.radDataPager.PageSize ).ToList();
    }
    private void radDataPager_PageIndexChanged( object sender, PageIndexChangedEventArgs e )
    {
        if ( this.data != null )
        {
            this.listBox.ItemsSource = this.data.Skip( e.NewPageIndex * this.radDataPager.PageSize ).Take( this.radDataPager.PageSize ).ToList();
        }
    }
}
#endregion
}
