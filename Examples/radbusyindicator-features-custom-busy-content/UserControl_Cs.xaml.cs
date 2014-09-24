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

#region radbusyindicator-features-custom-busy-content_2
public partial class BusyContentTemplateSample : UserControl, INotifyPropertyChanged
{
    private int progressValue;
    private DispatcherTimer progressTimer;
    public event PropertyChangedEventHandler PropertyChanged;
    public BusyContentTemplateSample()
    {
        InitializeComponent();
        this.DataContext = this;
        this.progressTimer = new DispatcherTimer();
        this.progressTimer.Interval = TimeSpan.FromSeconds( 1 );
        this.progressTimer.Tick += new EventHandler( this.progressTimer_Tick );
    }
    public int ProgressValue
    {
        get
        {
            return this.progressValue;
        }
        set
        {
            if ( this.progressValue == value )
                return;
            this.progressValue = value;
            if ( this.PropertyChanged != null )
                this.PropertyChanged( this, new PropertyChangedEventArgs( "ProgressValue" ) );
        }
    }
    private void showIndicatorButton_Click( object sender, RoutedEventArgs e )
    {
        this.progressTimer.Start();
        this.ProgressValue = 100;
        this.radBusyIndicator.IsBusy = true;
    }
    private void progressTimer_Tick( object sender, EventArgs e )
    {
        this.ProgressValue--;
        if ( this.ProgressValue == 0 )
        {
            this.progressTimer.Stop();
            this.radBusyIndicator.IsBusy = false;
        }
    }
}
#endregion
}
