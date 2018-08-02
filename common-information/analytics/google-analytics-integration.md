---
title: Google Analytics Integration
page_title: Google Analytics Integration
description: Google Analytics Integration
slug: google-analytics-integration
tags: google,analytics,integration
published: True
position: 2
---

# Google Analytics Integration

If you wish to analyze the usage data of the application using **Google Analytics**, you can go ahead to the [Windows SDK for Google Analytics GitHub repository](https://github.com/dotnet/windows-sdk-for-google-analytics) and build the project located in **GoogleAnalytics.Core**. You then need to add a reference to the generated assembly (**GoogleAnalytics.Core.dll**) to your custom project.

**Example 1** demonstrates a simple implementation of the **IPlatformInfoProvider** interface that is needed by the **TrackerManager** class.

#### __[C#] Example 1: IPlatformInfoProvider implementation__

{{region cs-google-analytics-integration_1}}
	internal class PlatformInfoProvider : IPlatformInfoProvider
    {
        public string AnonymousClientId { get; set; }

        public int? ScreenColors { get; set; }

        public Dimensions ScreenResolution { get; set; }
        public string UserAgent { get; set; }
        public string UserLanguage { get; set; }
        public Dimensions ViewPortResolution { get; set; }

        Dimensions? IPlatformInfoProvider.ScreenResolution { get; }

        Dimensions? IPlatformInfoProvider.ViewPortResolution { get; }

        public event EventHandler ScreenResolutionChanged;
        public event EventHandler ViewPortResolutionChanged;

        public void OnTracking()
        {
            throw new NotImplementedException();
        }
    }
{{endregion}}

#### __[VB.NET] Example 1: IPlatformInfoProvider implementation__

{{region vb-google-analytics-integration_1}}
	Friend Class PlatformInfoProvider
	Implements IPlatformInfoProvider

		Public Property AnonymousClientId() As String

		Public Property ScreenColors() As Integer?

		Public Property ScreenResolution() As Dimensions
		Public Property UserAgent() As String
		Public Property UserLanguage() As String
		Public Property ViewPortResolution() As Dimensions

		Private ReadOnly Property IPlatformInfoProvider_ScreenResolution() As Dimensions? Implements IPlatformInfoProvider.ScreenResolution

		Private ReadOnly Property IPlatformInfoProvider_ViewPortResolution() As Dimensions? Implements IPlatformInfoProvider.ViewPortResolution

		Public Event ScreenResolutionChanged As EventHandler
		Public Event ViewPortResolutionChanged As EventHandler

		Public Sub OnTracking()
			Throw New NotImplementedException()
		End Sub
	End Class
{{endregion}}

You can then use this provider in your custom implementation of the **ITraceMonitor** interface. Please note that you have to pass your own **Google Analytics tracking ID** in the **CreateTracker** method of the **TrackerManager**.

#### __[C#] Example 2: Custom ITraceMonitor implementation__

{{region cs-google-analytics-integration_2}}
	public class CustomAnalitycsMonitor : ITraceMonitor
    {
        private Tracker tracker;

        public CustomAnalitycsMonitor()
        {
            this.CreateGoogleTracker();
        }

        public void CreateGoogleTracker()
        {
            var trackerManager = new TrackerManager(new PlatformInfoProvider()
            {
                AnonymousClientId = "b597d28a-0d6c-42ed-9dcb-f89e98006b37", // Random UUID
                ScreenResolution = new Dimensions(1920, 1080),
                UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko",
                UserLanguage = "en-us",
                ViewPortResolution = new Dimensions(1920, 1080)
            });

            tracker = trackerManager.CreateTracker("YOUR_PROPERTY_ID"); // your GoogleAnalytics property ID goes here
            tracker.AppName = "wpf app";
        }

        public void TrackAtomicFeature(string feature)
        {
            // The value of the "feature" string consists of the whole name of the tracked feature,
            // for example : "MyGridView.Sorted.Name.Ascending", if we have performed a sorting operation in RadGridView.
            // So, we can split this string in order to pass friendlier names to the parameters of the CreateCustomEvent method which will be used in your reports.
            string category;
            string eventAction;
            this.SplitFeatureName(feature, out category, out eventAction);

            var data = HitBuilder.CreateCustomEvent(category, eventAction + " event", feature.ToString(), 1).Build();
            tracker.Send(data);
        }

        public void TrackError(string feature, Exception exception)
        {
            var data = HitBuilder.CreateException(feature + ":" + exception.ToString(), true).Build();
            tracker.Send(data);
        }

        public void TrackFeatureCancel(string feature)
        {
            string category;
            string eventAction;
            this.SplitFeatureName(feature, out category, out eventAction);

            var data = HitBuilder.CreateCustomEvent(category, eventAction + " event.Cancelled", feature.ToString(), 1).Build();
            tracker.Send(data);
        }

        public void TrackFeatureStart(string feature)
        {
            // Measuring timings provides a native way to measure a period of time in Google Analytics. 
            // This can be useful to measure resource load times, for example.
            TimeSpan ts = TimeSpan.FromSeconds(2.2);
            var loadTiming = HitBuilder.CreateTiming("Loaded", "MainWindow", ts).Build();
            tracker.Send(loadTiming);
        }

        public void TrackFeatureEnd(string feature)
        {
            TimeSpan ts = TimeSpan.FromSeconds(2.2);
            var unLoadTiming = HitBuilder.CreateTiming("Loaded", "MainWindow", ts).Build();
            tracker.Send(unLoadTiming);
        }

        public void TrackValue(string feature, long value)
        {
            string category;
            string eventAction;
            this.SplitFeatureName(feature, out category, out eventAction);

            var data = HitBuilder.CreateCustomEvent(category, eventAction + " event", feature.ToString(), value).Build();
            tracker.Send(data);
        }

        private void SplitFeatureName(string feature, out string category, out string eventAction)
        {
            string[] parameters = feature.Split('.');
            category = parameters[0];
            eventAction = parameters[1];
        }
    }
{{endregion}}

#### __[VB.NET] Example 2: Custom ITraceMonitor implementation__

{{region vb-google-analytics-integration_2}}
	Public Class CustomAnalitycsMonitor
	Implements ITraceMonitor

		Private tracker As Tracker

		Public Sub New()
			Me.CreateGoogleTracker()
		End Sub

		Public Sub CreateGoogleTracker()
			Dim trackerManager = New TrackerManager(New PlatformInfoProvider() With {
				.AnonymousClientId = "b597d28a-0d6c-42ed-9dcb-f89e98006b37",
				.ScreenResolution = New Dimensions(1920, 1080),
				.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko",
				.UserLanguage = "en-us",
				.ViewPortResolution = New Dimensions(1920, 1080)
			})

			tracker = trackerManager.CreateTracker("YOUR_PROPERTY_ID") ' your GoogleAnalytics property ID goes here
			tracker.AppName = "wpf app"
		End Sub

		Public Sub TrackAtomicFeature(ByVal feature As String)
			' The value of the "feature" string consists of the whole name of the tracked feature,
			' for example : "MyGridView.Sorted.Name.Ascending", if we have performed a sorting operation in RadGridView.
			' So, we can split this string in order to pass friendlier names to the parameters of the CreateCustomEvent method which will be used in your reports.
			Dim category As String = Nothing
			Dim eventAction As String = Nothing
			Me.SplitFeatureName(feature, category, eventAction)

			Dim data = HitBuilder.CreateCustomEvent(category, eventAction & " event", feature.ToString(), 1).Build()
			tracker.Send(data)
		End Sub

		Public Sub TrackError(ByVal feature As String, ByVal exception As Exception)
			Dim data = HitBuilder.CreateException(feature & ":" & exception.ToString(), True).Build()
			tracker.Send(data)
		End Sub

		Public Sub TrackFeatureCancel(ByVal feature As String)
			Dim category As String = Nothing
			Dim eventAction As String = Nothing
			Me.SplitFeatureName(feature, category, eventAction)

			Dim data = HitBuilder.CreateCustomEvent(category, eventAction & " event.Cancelled", feature.ToString(), 1).Build()
			tracker.Send(data)
		End Sub

		Public Sub TrackFeatureStart(ByVal feature As String)
			' Measuring timings provides a native way to measure a period of time in Google Analytics. 
			' This can be useful to measure resource load times, for example.
			Dim ts As TimeSpan = TimeSpan.FromSeconds(2.2)
			Dim loadTiming = HitBuilder.CreateTiming("Loaded", "MainWindow", ts).Build()
			tracker.Send(loadTiming)
		End Sub

		Public Sub TrackFeatureEnd(ByVal feature As String)
			Dim ts As TimeSpan = TimeSpan.FromSeconds(2.2)
			Dim unLoadTiming = HitBuilder.CreateTiming("Loaded", "MainWindow", ts).Build()
			tracker.Send(unLoadTiming)
		End Sub

		Public Sub TrackValue(ByVal feature As String, ByVal value As Long)
			Dim category As String = Nothing
			Dim eventAction As String = Nothing
			Me.SplitFeatureName(feature, category, eventAction)

			Dim data = HitBuilder.CreateCustomEvent(category, eventAction & " event", feature.ToString(), value).Build()
			tracker.Send(data)
		End Sub

		Private Sub SplitFeatureName(ByVal feature As String, ByRef category As String, ByRef eventAction As String)
			Dim parameters() As String = feature.Split("."c)
			category = parameters(0)
			eventAction = parameters(1)
		End Sub
	End Class
{{endregion}}

All that is left is to set the static **TraceMonitor.AnalyticsMonitor** property, possibly in the constructor of your application.

#### __[C#] Example 3: Set TraceMonitor.AnalyticsMonitor__

{{region cs-google-analytics-integration_3}}
	public App()
	{
		InitializeComponent();
		TraceMonitor.AnalyticsMonitor = new CustomAnalitycsMonitor();
	}
{{endregion}}

#### __[VB.NET] Example 3: Set TraceMonitor.AnalyticsMonitor__

{{region vb-google-analytics-integration_3}}
	Public Sub New()
		InitializeComponent()
		TraceMonitor.AnalyticsMonitor = New CustomAnalitycsMonitor()
	End Sub
{{endregion}}

If you then go to the Google Analytics dashboard after some user interaction has took place, you will find information and statistics for the registered features as shown in **Figure 1**.

#### __Figure 1: Google Analytics Dashboard__

![Google Analytics Dashboard](images/google-analytics-dashboard.png)

## See Also

* [Analytics Support]({%slug analytics-support%})