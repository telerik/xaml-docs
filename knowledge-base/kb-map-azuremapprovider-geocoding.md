---
title: Implement Geocoding with the Azure Maps Services
page_title: Searching Locations Using Azure Maps Services
description: This article showcases how to achieve geocoding (searching) using the Azure Maps services.
type: how-to
slug: kb-map-azuremapprovider-geocoding
tags: map, azure, search, geocoding, Azure Maps, provider
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2025.1.211</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadMap for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Implementing geocoding (searching) functionality using the Azure Maps services.

## Solution

To achieve geocoding functionality using the Azure Maps services, you can create a new helper class. It will create a URL request for the Microsoft's geocoding API and use the response to center the RadMap control. In order to receive a valid response from the geocoding API, you will need to pass a valid location and subscription key to the request URL string.

__Implementing a helper class for retrieving the searched location__
```C#
    internal class AzureGeocodingHelper
    {
        private static HttpClient httpClient = new HttpClient();

        internal async static Task<Location> GetGeoCode(string location)
        {
            //Modify this URL to match your Azure Mapss subscription key and location
            var requestUrl = $"https://atlas.microsoft.com/geocode?api-version=2025-01-01&query={location}&subscription-key={MyAzureMapsSubscriptionKey}";

            var response = await httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();

            var jsonContent = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };

            var featureCollection = JsonSerializer.Deserialize<FeatureCollection>(jsonContent, options);

            var firstCoordinates = featureCollection.Features.First().Geometry.Coordinates;
            return new Location(firstCoordinates[1], firstCoordinates[0]);
        }
    }

    public class FeatureCollection
    {
        public List<Feature> Features { get; set; }
    }

    public class Feature
    {
        public Geometry Geometry { get; set; }
    }

    public class Geometry
    {
        public List<double> Coordinates { get; set; }
    }
```
```VB.NET
    Friend Class AzureGeocodingHelper
        Private Shared httpClient As HttpClient = New HttpClient()

        Friend Async Shared Function GetGeoCode(ByVal location As String) As Task(Of Location)
            Dim requestUrl = $"https://atlas.microsoft.com/geocode?api-version=2025-01-01&query={location}&subscription-key={MyAzureMapsSubscriptionKey}"
            Dim response = Await httpClient.GetAsync(requestUrl)
            response.EnsureSuccessStatusCode()
            Dim jsonContent = Await response.Content.ReadAsStringAsync()
            Dim options = New JsonSerializerOptions With {
                .PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                .PropertyNameCaseInsensitive = True
            }
            Dim featureCollection = JsonSerializer.Deserialize(Of FeatureCollection)(jsonContent, options)
            Dim firstCoordinates = featureCollection.Features.First().Geometry.Coordinates
            Return New Location(firstCoordinates(1), firstCoordinates(0))
        End Function
    End Class

    Public Class FeatureCollection
        Public Property Features As List(Of Feature)
    End Class

    Public Class Feature
        Public Property Geometry As Geometry
    End Class

    Public Class Geometry
        Public Property Coordinates As List(Of Double)
    End Class
```

Additionally, you can follow the next example, which showcases how to utilize the created `AzureGeocodingHelper` class and its `GetGeoCode` method.

__Defining the RadMap and the UI elements for the geocoding logic__
```XAML
    <Grid>
        <Grid.Resources>
            <ResourceDictionary Source="/Telerik.Windows.Controls;component/Themes/FontResources.xaml"/>
        </Grid.Resources>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>
        <StackPanel Orientation="Horizontal" Margin="5" HorizontalAlignment="Center">
            <TextBox x:Name="textBoxSearchAddress" VerticalAlignment="Center" Width="200"/>
            <telerik:RadButton Click="RadButton_Click" VerticalAlignment="Center" Margin="4 0 0 0">
                <telerik:RadButton.Content>
                    <telerik:RadGlyph Glyph="{StaticResource GlyphZoom}"/>
                </telerik:RadButton.Content>
            </telerik:RadButton>
        </StackPanel>
        <telerik:RadMap x:Name="map" Grid.Row="1">
            <telerik:RadMap.Provider>
                <telerik:AzureMapProvider SubscriptionKey="Your Subscription Key"/>
            </telerik:RadMap.Provider>
            <telerik:VisualizationLayer x:Name="visualizationLayer"/>
        </telerik:RadMap>
    </Grid>
```

__Utilizing the AzureGeocodingHelper class's GetGeoCode method__
```C#
    private async void RadButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            Location location = await AzureGeocodingHelper.GetGeoCode(this.textBoxSearchAddress.Text);

            this.visualizationLayer.Items.Clear();
            this.visualizationLayer.Items.Add(location);
            this.map.Center = location;
        }
        catch (Exception exception)
        {
            MessageBox.Show("Please, enter a another location");
        }
    }
```
```VB.NET
    Private Async Sub RadButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Try
            Dim location As Location = Await AzureGeocodingHelper.GetGeoCode(Me.textBoxSearchAddress.Text)
            Me.visualizationLayer.Items.Clear()
            Me.visualizationLayer.Items.Add(location)
            Me.map.Center = location
        Catch exception As Exception
            MessageBox.Show("Please, enter a another location")
        End Try
    End Sub
```

__RadMap with AzureMapProvider and geocoding functionality__

![RadMap with AzureMapProvider and geocoding functionality](images/kb-map-azuremapprovider-geocoding.png)

>tip For a more in-depth example of an Azure Maps services geocoding, check the __Geocoding__ demo from our [Demos application]({%slug installing-wpf-demos%}).