---
title: ArcGIS Online Map Provider
page_title: ArcGIS Online Map Provider
description: Check our &quot;ArcGIS Online Map Provider&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-providers-arcgis
tags: arcgis,online,map,provider
published: True
position: 1
---

# ArcGIS Online Map Provider

## ArcGisMapProvider

The [ArcGIS online services](http://www.esri.com/software/arcgis/arcgisonline/maps/maps-and-map-layers) can be used via the __ArcGisMapProvider__ class.

Currently the ArcGIS map provider support six modes which specify the type of appearance of the map can and be set using the __Mode__ property:        

1. Aerial
2. Physical
3. Shaded Relief
4. Street
5. Terrain
6. Topographic

The following example of the __ArcGisMapProvider__ definition uses the __Physical__ mode:

#### __XAML__
{{region xaml-radmap-features-providers-arcgis-0}}
	<telerik:RadMap x:Name="radMap" ZoomLevel="1">
		<telerik:RadMap.Provider>
			<telerik:ArcGisMapProvider Mode="Physical" />
		</telerik:RadMap.Provider>
	</telerik:RadMap>
{{endregion}}

#### __C#__
{{region cs-radmap-features-providers-arcgis-1}}
	ArcGisMapProvider provider = new ArcGisMapProvider();
	provider.Mode = ArcGisMapMode.Physical;
	this.radMap.Provider = provider;
{{endregion}}

#### __VB.NET__	
{{region vb-radmap-features-providers-arcgis-2}}
	Dim provider As New ArcGisMapProvider ()
	provider.Mode = ArcGisMapMode.Physical
	Me.radMap.Provider = provider
{{endregion}}

>important As of **April 16, 2019**, ArcGIS Online services only accept connections using [TLS 1.2](https://docs.microsoft.com/en-us/mem/configmgr/core/plan-design/security/enable-tls-1-2). Thus, you need to explicitly set the **ServicePointManager.SecurityProtocol** property if you're using a .NET Framework version prior to **4.7**.

#### __C#__
{{region cs-radmap-features-providers-arcgis-3}}
	public App()
	{
		// ArcGis rest services require TLS 1.2 protocol.
		ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
	}
{{endregion}}

#### __VB.NET__	
{{region vb-radmap-features-providers-arcgis-4}}
	Partial Public Class App
		Inherits Application

		Public Sub New()
			' ArcGis rest services require TLS 1.2 protocol.
			ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)
		End Sub
	End Class
{{endregion}}

Here is a snapshot of the map that appears when using the `Physical` mode:

![Rad Map Features Providers ArcGIS](images/RadMap_Features_Providers_ArcGIS.png)

For comparison, the following snapshot demonstrates the appearance of the map for the __Street__ mode:

![Rad Map Features Providers ArcGIS Street](images/RadMap_Features_Providers_ArcGIS_Street.png)

The __ArcGisMapProvider__ also allows the user to change the map mode using the **Map View** button of the toolbar.

![Rad Map Features Providers ArcGIS Config](images/RadMap_Features_Providers_ArcGIS_Config.png)

## See Also
 * [BingRestMapProvider]({%slug radmap-features-providers-bing-rest-map%})