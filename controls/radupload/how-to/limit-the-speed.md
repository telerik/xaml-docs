---
title: Limit the Upload Speed
page_title: Limit the Upload Speed
description: Check our &quot;Limit the Upload Speed&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-how-to-limit-the-upload-speed
tags: limit,the,upload,speed
published: True
position: 4
site_name: Silverlight
---

# Limit the Upload Speed

To limit the upload speed you have to use the __BufferSize__ property of the __RadUpload__, the __UploadStarted__, __ProgressChanged__ and __UploadFinished__ events and a __DispatcherTimer__.

The concept behind limiting the speed is to pause the upload whenever the desired bandwidth is exceeded and to resume it after the difference has been compensated. For example, if you want the __RadUpload__ to upload the files with a speed of 1024 b/sec, you have to check every time the progress has changed, whether the uploaded bytes are greater than the maximum bytes limitation (in this case speed * elapsed time). If yes, you have to pause the upload and meanwhile, as the time increases, the maximum bytes limitation will also increase. After it has become greater than the uploaded bytes you can resume the upload. To implement this concept you have to do the following:

* [Prepare the Fields and Properties](#Prepare_the_Fields_and_Properties)

* [Set up the DispatcherTimer](#Set_up_the_DispatcherTimer)

* [Handle the UploadStarted event](#Handle_the_UploadStarted_event)

* [Handle the ProgressChanged event](#Handle_the_ProgressChanged_event)

* [Handle the timer's Tick event](#Handle_the_timer's_Tick_event)

* [Handle the UploadFinished event](#Handle_the_UploadFinished_event)

## Prepare the Fields and Properties

To set the initial speed limitation use the __BufferSize__ property of the __RadUpload__. Also set the __IsPauseEnabled__ to __False__ in order to hide the UI that regards the pausing information. This is needed as you will pause and resume the upload programmatically and this will reflect the UI controls, too.

#### __[XAML] Example 1: Limiting the speed__
{{region xaml-radupload-how-to-limit-the-upload-speed_0}}
	<telerik:RadUpload x:Name="radUpload"
	                   BufferSize="1024"
	                   IsPauseEnabled="False" />
{{endregion}}

In order to implement the speed limitation you have to define some fields and properties, that will help you control the upload process.

* __timer__ - a field that will represent the __DispatcherTimer__.

* __startTime__ - a field that will store the start __DateTime__ of the upload process.

* __UploadLimit__ - a property that returns the maximum bytes limit.

#### __[C#] Example 2: Defining the example fields and properties__  
{{region cs-radupload-how-to-limit-the-upload-speed_1}}
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
{{endregion}}

#### __[VB.NET] Example 2: Defining the example fields and properties__  
{{region vb-radupload-how-to-limit-the-upload-speed_2}}
	Private timer As DispatcherTimer
	Private speedLimit As Integer
	Private startTime As DateTime
	Public ReadOnly Property UploadLimit() As Integer
	 Get
	  Dim elapsedSeconds As Integer = DirectCast(TimeSpan.FromTicks(DateTime.Now.Ticks - Me.startTime.Ticks).TotalSeconds, Integer)
	  Return Me.radUpload.BufferSize * elapsedSeconds
	 End Get
	End Property
{{endregion}}

## Set up the DispatcherTimer

The next step is to configure the __DispatcherTimer__ so it suits your needs. Set its __Interval__ property and attach an event handler to the __Tick__ event.

#### __[C#] Example 3: Set up the timer__  
{{region cs-radupload-how-to-limit-the-upload-speed_3}}
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
{{endregion}}

#### __[VB.NET] Example 3: Set up the timer__  
{{region vb-radupload-how-to-limit-the-upload-speed_4}}
	Public Sub New()
	 InitializeComponent()
	 Me.timer = New DispatcherTimer()
	 Me.timer.Interval = New TimeSpan(0, 0, 0, 0, 500)
	 timer.Tick += Me.timer_Tick
	End Sub
	Private Sub timer_Tick(sender As Object, e As EventArgs)
	End Sub
{{endregion}}

## Handle the UploadStarted event

Next you have to attach an event handler to the __UploadStarted__ event of the __RadUpload__.

#### __[XAML] Example 4: Attaching the UploadStarted event handler__
{{region xaml-radupload-how-to-limit-the-upload-speed_5}}
	<telerik:RadUpload x:Name="radUpload"
	                   UploadStarted="radUpload_UploadStarted"
	                   BufferSize="1024"
	                   IsPauseEnabled="True" />
{{endregion}}

In it you have to set the __startTime__ field and start the __timer__.

#### __[C#] Example 5: Setting the start time and start the timer__
{{region cs-radupload-how-to-limit-the-upload-speed_6}}
	private void radUpload_UploadStarted( object sender, UploadStartedEventArgs e )
	{
	    this.startTime = DateTime.Now;
	    this.timer.Start();
	}
{{endregion}}

#### __[VB.NET] Example 5: Setting the start time and start the timer__
{{region vb-radupload-how-to-limit-the-upload-speed_7}}
	Private Sub radUpload_UploadStarted(sender As Object, e As UploadStartedEventArgs)
	 Me.startTime = DateTime.Now
	 Me.timer.Start()
	End Sub
{{endregion}}

## Handle the ProgressChanged event

Attach an event handler to the __ProgressChanged__ event of the __RadUpload__.

#### __[XAML] Example 6: Attaching ProgressChanged the event handler__  
{{region xaml-radupload-how-to-limit-the-upload-speed_8}}
	<telerik:RadUpload x:Name="radUpload"
	                   UploadStarted="radUpload_UploadStarted"
	                   ProgressChanged="radUpload_ProgressChanged"
	                   BufferSize="1024"
	                   IsPauseEnabled="True" />
{{endregion}}

This event notifies you whenever the progress of the upload process has changed. Use it to compare the uploaded bytes against the maximum bytes limitation and pause the upload process if needed.

#### __[C#] Example 7: Implement the upload limitation logic__  
{{region cs-radupload-how-to-limit-the-upload-speed_9}}
	private void radUpload_ProgressChanged(object sender, RoutedEventArgs e)
	{
	 if (this.radUpload.CurrentSession.UploadedBytes > this.UploadLimit)
	 {
	  this.radUpload.PauseUpload();
	  if (!this.timer.IsEnabled)
	   this.timer.Start();
	 }
	}
{{endregion}}

#### __[VB.NET] Example 7: Implement the upload limitation logic__   
{{region vb-radupload-how-to-limit-the-upload-speed_10}}
	Private Sub radUpload_ProgressChanged(sender As Object, e As RoutedEventArgs)
	 If Me.radUpload.CurrentSession.UploadedBytes > Me.UploadLimit Then
	  Me.radUpload.PauseUpload()
	  If Not Me.timer.IsEnabled Then
	   Me.timer.Start()
	  End If
	 End If
	End Sub
{{endregion}}

## Handle the timer's Tick event

In the handler for the times's Tick event you check whether the upload process should be resumed or not. If you resume it you also have to stop the timer.

#### __[C#] Example 8: Implement the upload limitation logic__  
{{region cs-radupload-how-to-limit-the-upload-speed_11}}
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
{{endregion}}

#### __[VB.NET] Example 8: Implement the upload limitation logic__  
{{region vb-radupload-how-to-limit-the-upload-speed_12}}
	Private Sub timer_Tick(sender As Object, e As EventArgs)
	 If Me.radUpload.CurrentSession.UploadedBytes < Me.UploadLimit Then
	  If Me.timer.IsEnabled Then
	   Me.radUpload.ResumeUpload()
	   Me.timer.[Stop]()
	  End If
	 End If
	End Sub
{{endregion}}

## Handle the UploadFinished event

And last, you have to attach an event handler to the __UploadFinished__ event of the __RadUpload__.

#### __[XAML] Example 9: Attaching the UploadFinished event handler__  
{{region xaml-radupload-how-to-limit-the-upload-speed_13}}
	<telerik:RadUpload x:Name="radUpload"
	                   UploadStarted="radUpload_UploadStarted"
	                   ProgressChanged="radUpload_ProgressChanged"
	                   UploadFinished="radUpload_UploadFinished"
	                   BufferSize="1024"
	                   IsPauseEnabled="True" />
{{endregion}}

In it you have to stop the __timer__.

#### __[C#] Example 10: Stoping the timer__  
{{region cs-radupload-how-to-limit-the-upload-speed_14}}
	private void radUpload_UploadFinished(object sender, RoutedEventArgs e)
	{
	 this.timer.Stop();
	}
{{endregion}}

#### __[VB.NET] Example 10: Stoping the timer__  
{{region vb-radupload-how-to-limit-the-upload-speed_15}}
	    Private Sub radUpload_UploadFinished(sender As Object, e As RoutedEventArgs)
	        Me.startTime = DateTime.Now
	        Me.timer.[Stop]()
	    End Sub
{{endregion}}

## See Also  
 * [Create Custom Upload Handler]({%slug radupload-how-to-create-custom-upload-handler%})
 * [Buffering]({%slug radupload-features-buffering%})