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

#region radupload-how-to-limit-the-upload-speed_1
private DispatcherTimer timer;
private DateTime startTime;
public int UploadLimit
{
    get
    {
        int elapsedSeconds = ( int )TimeSpan.FromTicks( DateTime.Now.Ticks - this.startTime.Ticks ).TotalSeconds;
        return this.radUpload.BufferSize * elapsedSeconds;
    }
}
#endregion

#region radupload-how-to-limit-the-upload-speed_3
public LimitUploadSpeed()
{
    InitializeComponent();
    this.timer = new DispatcherTimer();
    this.timer.Interval = new TimeSpan( 0, 0, 0, 0, 500 );
    timer.Tick += this.timer_Tick;
}
private void timer_Tick( object sender, EventArgs e )
{
}
#endregion

#region radupload-how-to-limit-the-upload-speed_6
private void radUpload_UploadStarted( object sender, UploadStartedEventArgs e )
{
    this.startTime = DateTime.Now;
    this.timer.Start();
}
#endregion

#region radupload-how-to-limit-the-upload-speed_9
private void radUpload_ProgressChanged(object sender, RoutedEventArgs e)
{
 if (this.radUpload.CurrentSession.UploadedBytes > this.UploadLimit)
 {
  this.radUpload.PauseUpload();
  if (!this.timer.IsEnabled)
   this.timer.Start();
 }
}
#endregion

#region radupload-how-to-limit-the-upload-speed_11
private void timer_Tick( object sender, EventArgs e )
{
    if ( this.radUpload.CurrentSession.UploadedBytes < this.UploadLimit )
    {
        if ( this.timer.IsEnabled )
        {
            this.radUpload.ResumeUpload();
            this.timer.Stop();
        }
    }
}
#endregion

#region radupload-how-to-limit-the-upload-speed_14
private void radUpload_UploadFinished(object sender, RoutedEventArgs e)
{
 this.timer.Stop();
}
#endregion
}
