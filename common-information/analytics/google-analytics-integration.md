---
title: Google Analytics Integration
page_title: Google Analytics Integration
description: This article demonstrates how you can use Telerik Analytics API to implement a custom Google Analytics provider.
slug: google-analytics-integration
tags: google,analytics,integration
published: True
position: 2
---

# Google Analytics Integration

This article shows how to use the Telerik Analytics API to implement a custom Google Analytics provider and send information to it.

## Setting up Google Analytics Dashboard

>tip This information is relevant at the time of writing of this article (July 2023) and it may not be up-to-date at the moment you read the article.

1. [Create a new Google Analytics 4 Property](https://support.google.com/analytics/answer/9744165?hl=en#upgrade&zippy=%2Cin-this-article) in your google.com account.

2. Go to the __Admin__ menu and [create a new web data stream](https://support.google.com/analytics/answer/9304153?hl=en). It can point to a dummy website address.

3. Open the data stream details and copy its [MEASUREMENT ID](https://support.google.com/analytics/answer/12270356?hl=en).

4. [Create a Measurement Protocol API secret](https://support.google.com/analytics/thread/78848659/ga4-how-create-api-secret-for-measurement-protocol?hl=en) and copy the secret value.

5. In order to test the data you send, disable the __Internal Traffic__ filter from the following menu, __Admin &mdash;> Data Settings &mdash;> Data Filters__. Also, event sending can be tested with the [Google Analytics Event Builder](https://ga-dev-tools.google/ga4/event-builder/).

The Measurement Id and API secret copied in setps 3 and 4 will be used in the .NET API shown in the [Implementing the Analytics Provider](#implementing-the-analytics-provider) section of this article.

## Setting up the Project

To send information to the Google Analytics dashboard manually, use the [Measurement Protocol (Google Analytics 4)](https://developers.google.com/analytics/devguides/collection/protocol/ga4) API provided by Google. The API allows you to send http requests with the required event information. The following example uses the [GoogleAnalytics.Ga4-Dotnet.Sdk](https://github.com/DAIMTO/GoogleAnalytics.Ga4.Dotnet.Sdk) unofficial GA4 SDK to send information to the dashboard.

>important The __GoogleAnalytics.Ga4.DotNet.Sdk__ is build against __.NET 6__, which means the example in this article is relevant to projects targeting __.NET 6__ and later.

1. Download the source code of the [GoogleAnalytics.Ga4-Dotnet.Sdk](https://github.com/DAIMTO/GoogleAnalytics.Ga4.Dotnet.Sdk).

2. Open the solution and build the __GoogleAnalytics.Ga4.DotNet.Sdk__ project. This will produce the __GoogleAnalytics.Ga4.DotNet.Sdk.dll__.

3. Create a new WPF project (or use an existing one). Then reference __GoogleAnalytics.Ga4.DotNet.Sdk.dll__.

4. Add a reference to __Telerik.Windows.Controls.dll__.

5. Install the __Microsoft.Extensions.Http__ nuget package.

## Implementing the Analytics Provider

To implement analytics provider that sends data to the Google dashboard, create a trace monitor class that implements the `ITraceMonitor` interface. To apply the new monitor use the `TrackerManager` class.

The following example demonstrates a simple implementation of the `ITraceMonitor` interface that uses the `MeasurementService` class from the __GoogleAnalytics.Ga4-Dotnet.Sdk__ project to send events to the Google Analytics 4 property.

__IHttpClientFactory implementation needed by the MeasurementService__  
```C#
	public class HttpClientFactory : IHttpClientFactory
    {
        private readonly string _baseAddress = "https://www.google-analytics.com";
        public HttpClient CreateClient(string name)
        {
            return new HttpClient()
            {
                BaseAddress = new Uri(_baseAddress),
                DefaultRequestHeaders =
                {
                    { "Accept", "application/json" },
                    { "User-Agent", "My Project Name" }
                }
            };
        }
    }
```

__ITraceMonitor implementation__  
```C#
	public class GoogleAnalyticsMonitor : ITraceMonitor
    {
        private MeasurementService service;
        private string uniqueClienId;

        public GoogleAnalyticsMonitor(string measurementId, string appSecret)
        {
            var options = Options.Create(new GoogleAnalyticsClientSettings()
            {
                MeasurementId = measurementId,
                AppSecret = appSecret
            });
            var client = new BasicHttpClient(new HttpClientFactory(), options);
            service = new MeasurementService(client);
            uniqueClienId = "UniqueClientIdHere";
        }
               
        public async void TrackAtomicFeature(string feature)
        {
            // "atomic_feature" is a custom event name that will be send to Google Analytics
            // "tracked_atomic_feature" is a custom parameter name that will be send to Google Anlaytics
            var gaEvent = EventBuilders.BuildCustomEvent("atomic_feature", new Dictionary<string, object>());
            gaEvent.AddParameters("tracked_atomic_feature", feature);
            var request = new EventRequest(uniqueClienId);
            request.AddEvent(gaEvent);
            EventResponse result = await service.CreateEventRequest(request).Execute(false);            
        }

        public async void TrackError(string feature, Exception exception)
        {
            var gaEvent = EventBuilders.BuildCustomEvent("exception", new Dictionary<string, object>());
            gaEvent.AddParameters("tracked_exception", exception.Message);
            var request = new EventRequest(uniqueClienId);
            request.AddEvent(gaEvent);
            EventResponse result = await service.CreateEventRequest(request).Execute(false);
        }

        public async void TrackFeatureCancel(string feature)
        {
            var gaEvent = EventBuilders.BuildCustomEvent("feature_cancel", new Dictionary<string, object>());
            gaEvent.AddParameters("tracked_feature_cancel", feature);
            var request = new EventRequest(uniqueClienId);
            request.AddEvent(gaEvent);
            EventResponse result = await service.CreateEventRequest(request).Execute(false);
        }

        public async void TrackFeatureEnd(string feature)
        {
            var gaEvent = EventBuilders.BuildCustomEvent("feature_end", new Dictionary<string, object>());
            gaEvent.AddParameters("tracked_feature_end", feature);
            var request = new EventRequest(uniqueClienId);
            request.AddEvent(gaEvent);
            EventResponse result = await service.CreateEventRequest(request).Execute(false);
        }

        public async void TrackFeatureStart(string feature)
        {
            var gaEvent = EventBuilders.BuildCustomEvent("feature_start", new Dictionary<string, object>());
            gaEvent.AddParameters("tracked_feature_start", feature);
            var request = new EventRequest(uniqueClienId);
            request.AddEvent(gaEvent);
            EventResponse result = await service.CreateEventRequest(request).Execute(false);
        }

        public async void TrackValue(string feature, long value)
        {
            var gaEvent = EventBuilders.BuildCustomEvent("value_event", new Dictionary<string, object>());
            gaEvent.AddParameters("tracked_value", feature);
            var request = new EventRequest(uniqueClienId);
            request.AddEvent(gaEvent);
            EventResponse result = await service.CreateEventRequest(request).Execute(false);
        }
    }
```

To apply the custom monitor, set the static `TraceMonitor.AnalyticsMonitor` property, possibly in the constructor of your application.

__Set the TraceMonitor.AnalyticsMonitor__  
```C#
	public App()
	{
		InitializeComponent();
		TraceMonitor.AnalyticsMonitor = new GoogleAnalyticsMonitor("MeasurementId", "AppSecret");
	}
```

>tip Read in details how to setup the Google Analytics dashboards in its [documentation](https://support.google.com/analytics/).

## See Also  
* [Analytics Support]({%slug analytics-support%})
