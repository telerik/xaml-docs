---
title: Show a Copyright Attribution Label in RadMap
page_title: Display a Copyright Attribution Label
description: This article showcases how to add a copyright attribution label
type: how-to
slug: kb-map-copyright-label
position: 0
tags: map, attribution, label
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

The RadMap control provides the ability to display tiles from different map services via its [providers]({%slug radmap-features-providers%}). These map services require displaying copyright attribution label.

## Solution

This article showcases how to display copyright attribution label for the OpenStreetMap and Azure Maps services when using the `OpenStreetMapProvider` and `AzureMapProvider`.

1. OpenStreetMap services and OpenStreetMapProvider

    The following example showcases how to display a copyright attribution label for the OpenStreetMap services when using the `OpenStreetMapProvider`.

    #### __[XAML] Defining the RadMap control with an OpenStreetMapProvider__
    {{region kb-map-copyright-label-0}}
        <Grid>
            <telerik:RadMap x:Name="map">
                <telerik:RadMap.Provider>
                    <telerik:OpenStreetMapProvider APIKey="Your API key" StandardModeUserAgent="Your custom user agent string"/>
                </telerik:RadMap.Provider>
            </telerik:RadMap>
        </Grid>
    {{endregion}}
    
    The [OpenStreetMap Attribution Guideline](https://osmfoundation.org/wiki/Licence/Attribution_Guidelines) states that the attribution text needs to note that the data is available under the Open DataBase License. This can be done by making the added element open their [copyright article](https://openstreetmap.org/copyright). 

    #### __[XAML] Defining an element to display the attribution copyright label__
    {{region kb-map-copyright-label-1}}
        <Grid>
            <Grid.Resources>
                <Style TargetType="telerik:MapScale">
                    <Setter Property="Margin" Value="0 8 20 40" />
                </Style>
            </Grid.Resources>
            <telerik:RadMap x:Name="map"
                            ZoomLevel="7" 
                            MinZoomLevel="4">
                <telerik:RadMap.Provider>
                    <telerik:OpenStreetMapProvider APIKey="Your API key" StandardModeUserAgent="Your custom user agent string"/>
                </telerik:RadMap.Provider>
            </telerik:RadMap>
            <Grid x:Name="CopyrightContainer" VerticalAlignment="Bottom" HorizontalAlignment="Right">
                <telerik:RadHyperlinkButton NavigateUri="https://openstreetmap.org/copyright"
                                            FontSize="10"
                                            Padding="5 2 20 4"
                                            Content="© OpenStreetMap contributors" 
                                            FontWeight="Bold"
                                            HorizontalAlignment="Right"/>
            </Grid>
        </Grid>
    {{endregion}}

    __RadMap with displayed copyright attribution label when using OpenStreetMapProvider__

    ![RadMap with displayed copyright attribution label](images/kb-map-copyright-label-0.png)

2. Azure Maps services and AzureMapProvider

    The following example showcases how to display a copyright attribution label for the Azure Maps services when using the `AzureMapProvider`.

    #### __[XAML] Defining the RadMap control with an AzureMapProvider__
    {{region kb-map-copyright-label-2}}
        <Grid>
            <Grid.Resources>
                <Style TargetType="telerik:MapScale">
                    <Setter Property="Margin" Value="0 8 20 22" />
                </Style>
            </Grid.Resources>
            <telerik:RadMap x:Name="map"
                                ZoomLevel="7" 
                                MinZoomLevel="4">
                <telerik:RadMap.Provider>
                    <telerik:AzureMapProvider SubscriptionKey="Your API key"/>
                </telerik:RadMap.Provider>
            </telerik:RadMap>
            <Grid x:Name="CopyrightContainer" VerticalAlignment="Bottom" HorizontalAlignment="Right">
                <telerik:Label Content="©2025 OSM ©2025 Microsoft Azure Maps" 
                               FontSize="10"
                               Padding="5 2 20 4"
                               FontWeight="Bold"
                               HorizontalAlignment="Right"/>
            </Grid>
        </Grid>
    {{endregion}}

    __RadMap with displayed copyright attribution label when using AzureMapProvider__

    ![RadMap with displayed copyright attribution label when using AzureMapProvider](images/kb-map-copyright-label-1.png)

>important The text used for the copyright attribution label is exemplary. For an accurate copyright attribution label, refer to the appropriate service copyright article of the provider that you are using.