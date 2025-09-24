---
title: Data Binding
page_title: Data Binding
description: Check our &quot;Data Binding&quot; documentation article for the RadGauge {{ site.framework_name }} control.
slug: radgauge-features-data-binding
tags: data,binding
published: True
position: 9
---

# Data Binding

The __RadGauge__ control allows you to bind it to a set of values, which to be displayed consecutive one after another. This feature is implemented via the indicator of the scale and its __ValueSource__ property. It is of type __IEnumerable__ and accepts the set of values you want to display.      

Additionally the indicators expose an API which allows you to control the display of the values in the __ValueSource__ collection. Via this API you can do the following:      

* [Start Playback](#start-playback)

* [Stop Playback](#stop-playback)

* [Move Next](#move-next)

* [Move Previous](#move-previous)

Here is the __RadGauge__ instance and the sample value collection, which will be used throughout the examples in this topic:      


```XAML
	<telerik:RadRadialGauge telerik:StyleManager.Theme="Windows8">
	    <telerik:RadialScale Min="0"
	                         Max="100"
	                         IsInteractive="True">
	        <telerik:RadialScale.Indicators>
	            <telerik:BarIndicator x:Name="radialBar"
	                                  Value="6" />
	        </telerik:RadialScale.Indicators>
	    </telerik:RadialScale>
	</telerik:RadRadialGauge>
```


```C#
	public DataBindingSample()
	{
	    InitializeComponent();
	    ObservableCollection<double> values = new ObservableCollection<double>()
	    { 
	        10,15,25,17,40,50,60,70,25,15,5,10,12,18,29,37,92
	    };
	    this.radialBar.ValueSource = values;
	}
```
```VB.NET
	Public Sub New()
	 InitializeComponent()
	 Dim values As New ObservableCollection(Of Double)() From {10, 15, 25, 17, 40, 50, 60, 70, 25, 15, 5, 10, 12, 18, 29, 37, 92}
	 Me.radialBar.ValueSource = values
	End Sub
```

## Start Playback

If you want to automatically display the values one after another with some predefined interval between them, you can use the __StartPlayback()__ method of the indicator.         

>Whenever called, this method will start displaying the values form the beginning of the collection. In that case it will resume.
   
Here is an example:   


```C#
	private void StartPlayback()
	{
	    this.radialBar.StartPlayback();
	}
```
```VB.NET
	Private Sub StartPlayback()
	 Me.radialBar.StartPlayback()
	End Sub
```

## Stop Playback

To stop the automatic playback of the values you have simply to call the __StopPlayback()__ method.         

>Starting and stopping and than starting again the playback won't make it to contiunue from tha value it has stopped on. Instead, it will start from the beginning again.
			
Here is an example:          


```C#
	private void StopPlayback()
	{
	    this.radialBar.StopPlayback();
	}
```
```VB.NET
	Private Sub StopPlayback()
	 Me.radialBar.StopPlayback()
	End Sub
```

## Move Next

The indicator's API also allows you to manually navigate through the values collection. On of the methods exposed is the __MoveNext()__ one. It changes the displayed value to the next value in the collection, if present. Here is an example.        


```C#
	private void MoveNext()
	{
	    this.radialBar.MoveNext();
	}
```
```VB.NET
	Private Sub MoveNext()
	 Me.radialBar.MoveNext()
	End Sub
```

## Move Previous

The __MovePrevious()__ method is the other one used for manual navigation through the values collection. It displays the value previous to the current one. Here is an example.        


```C#
	private void MovePrevious()
	{
	    this.radialBar.MovePrevious();
	}
```
```VB.NET
	Private Sub MovePrevious()
	 Me.radialBar.MovePrevious()
	End Sub
```

## Specifying the duration for each value

If you want every one of the values to be displayed a specific period of time you can use a colleciton PlaybackData objects as the ValueSource for the indicator. Every PlaybackData can specify own interval between values using __Duration__ property.        

Here is an example (a slight modification of the previous one):        


```C#
	public DataBindingSample()
	{
	    InitializeComponent();
	    List<PlaybackData> values = new List<PlaybackData>
	    {
	        new PlaybackData() {Value= 10, Duration=TimeSpan.FromMilliseconds(500.0)},
	        new PlaybackData() {Value= 15, Duration=TimeSpan.FromMilliseconds(1000.0)},
	        new PlaybackData() {Value= 25, Duration=TimeSpan.FromMilliseconds(250.0)},
	        new PlaybackData() {Value= 17, Duration=TimeSpan.FromMilliseconds(250.0)},
	        new PlaybackData() {Value= 40, Duration=TimeSpan.FromMilliseconds(250.0)},
	        new PlaybackData() {Value= 50, Duration=TimeSpan.FromMilliseconds(250.0)},
	        new PlaybackData() {Value= 60, Duration=TimeSpan.FromMilliseconds(500.0)},
	        new PlaybackData() {Value= 70, Duration=TimeSpan.FromMilliseconds(125.0)},
	        new PlaybackData() {Value= 25, Duration=TimeSpan.FromMilliseconds(125.0)},
	        new PlaybackData() {Value= 15, Duration=TimeSpan.FromMilliseconds(500.0)},
	        new PlaybackData() {Value= 5, Duration=TimeSpan.FromMilliseconds(1000.0)},
	        new PlaybackData() {Value= 10, Duration=TimeSpan.FromMilliseconds(500.0)},
	        new PlaybackData() {Value= 12, Duration=TimeSpan.FromMilliseconds(500.0)},
	        new PlaybackData() {Value= 18, Duration=TimeSpan.FromMilliseconds(250.0)},
	        new PlaybackData() {Value= 93, Duration=TimeSpan.FromMilliseconds(250.0)},
	        new PlaybackData() {Value= 66, Duration=TimeSpan.FromMilliseconds(500.0)},
	        new PlaybackData() {Value= 30, Duration=TimeSpan.FromMilliseconds(500.0)},
	    };
	    this.radialBar.ValueSource = values;
	}
```
```VB.NET
	Public Sub New()
		InitializeComponent()
		Dim values As New List(Of PlaybackData)() From { _
			New PlaybackData() With { _
				Key .Value = 10, _
				Key .Duration = TimeSpan.FromMilliseconds(500.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 15, _
				Key .Duration = TimeSpan.FromMilliseconds(1000.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 25, _
				Key .Duration = TimeSpan.FromMilliseconds(250.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 17, _
				Key .Duration = TimeSpan.FromMilliseconds(250.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 40, _
				Key .Duration = TimeSpan.FromMilliseconds(250.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 50, _
				Key .Duration = TimeSpan.FromMilliseconds(250.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 60, _
				Key .Duration = TimeSpan.FromMilliseconds(500.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 70, _
				Key .Duration = TimeSpan.FromMilliseconds(125.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 25, _
				Key .Duration = TimeSpan.FromMilliseconds(125.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 15, _
				Key .Duration = TimeSpan.FromMilliseconds(500.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 5, _
				Key .Duration = TimeSpan.FromMilliseconds(1000.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 10, _
				Key .Duration = TimeSpan.FromMilliseconds(500.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 12, _
				Key .Duration = TimeSpan.FromMilliseconds(500.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 18, _
				Key .Duration = TimeSpan.FromMilliseconds(250.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 93, _
				Key .Duration = TimeSpan.FromMilliseconds(250.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 66, _
				Key .Duration = TimeSpan.FromMilliseconds(500.0) _
			}, _
			New PlaybackData() With { _
				Key .Value = 30, _
				Key .Duration = TimeSpan.FromMilliseconds(500.0) _
			} _
		}
		Me.radialBar.ValueSource = values
	End Sub
```