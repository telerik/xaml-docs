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

#### __[XAML] Adding an element that will display the OpenStreetMap copyright label__
{{region kb-map-copyright-label-1}}
    <Grid>
        <telerik:RadMap x:Name="map">
            <telerik:RadMap.Provider>
                <telerik:OpenStreetMapProvider APIKey="Your API key" StandardModeUserAgent="Your custom user agent string"/>
            </telerik:RadMap.Provider>
        </telerik:RadMap>
        <TextBlock x:Name="copyrightBlock" 
                   VerticalAlignment="Bottom" 
                   FontWeight="Bold"
                   Margin="0 0 2 2"
                   HorizontalAlignment="Right"/>
    </Grid>
{{endregion}}

The [OpenStreetMap Attribution Guideline](https://osmfoundation.org/wiki/Licence/Attribution_Guidelines) states that the attribution text needs to note that the data is available under the Open DataBase License. This can be done by making the added element open their [copyright article](https://openstreetmap.org/copyright). 

#### __[XAML] Adding a hyperlink for the copyright article of OpenStreetMap services__
{{region kb-map-copyright-label-2}}
    <Grid>
        <telerik:RadMap x:Name="map">
            <telerik:RadMap.Provider>
                <telerik:OpenStreetMapProvider APIKey="Your API key" StandardModeUserAgent="Your custom user agent string"/>
            </telerik:RadMap.Provider>
        </telerik:RadMap>
        <TextBlock x:Name="copyrightBlock" 
                   VerticalAlignment="Bottom" 
                   FontWeight="Bold"
                   Margin="0 0 2 2"
                   HorizontalAlignment="Right">
            <Hyperlink NavigateUri="https://openstreetmap.org/copyright" RequestNavigate="Hyperlink_RequestNavigate">
                © OpenStreetMap contributors
            </Hyperlink>
        </TextBlock>
    </Grid>
{{endregion}}

#### __[C#] Handling the RequestNavigate event of the Hyperlink class__
{{region kb-map-copyright-label-3}}
    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
        e.Handled = true;
    }
{{endregion}}

#### __[VB.NET] Handling the RequestNavigate event of the Hyperlink class__
{{region kb-map-copyright-label-4}}
    Private Sub Hyperlink_RequestNavigate(ByVal sender As Object, ByVal e As RequestNavigateEventArgs)
        Process.Start(New ProcessStartInfo(e.Uri.AbsoluteUri) With {
            .UseShellExecute = True
        })
        e.Handled = True
    End Sub
{{endregion}}

__RadMap with displayed copyright attribution label__

![RadMap with displayed copyright attribution label](images/kb-map-copyright-label-0.png)