---
title: Https Support
page_title: Https Support
description: Use ProtocolHelper.UseHttps in order to enable HTTPS requests to tile image providers.
slug: radmap-providers-https-support
tags: providers,overview,cache,caching,https
published: True
position: 8
---

# Https Support

All built-in providers like Bing and ArcGIS are using the HTTP protocol when constructing the web URLs used to download the map tile images.

The protocol can be changed to HTTPS by setting the static `ProtocolHelper.UseHttpsScheme` property to `true`. This will redirect the built-in provider's tile downloading links to use HTTPS.

#### __[C#] Enable HTTPS__
{{region radmap-providers-https-support-0}}
	public MainWindow()
	{
		ProtocolHelper.UseHttpsScheme = true;		
		InitializeComponent();
	}
{{endregion}}

Enabling the HTTPS protocol will also redirect the Bing logging service to use HTTPS. Additionally, all providers, except Bing, will require you to change also the default security protocol. This is done via the `ServicePointManager.SecurityProtocol` property. 

#### __[C#] Set the security protocol__
{{region radmap-providers-https-support-1}}
	public MainWindow()
	{
		ProtocolHelper.UseHttpsScheme = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		 
		InitializeComponent();
	}
{{endregion}}

In case you are using an older version of Telerik UI for WPF that targets .NET 4.0, use the following setting:

#### __[C#] Set the security protocol in .NET 4__
{{region radmap-providers-https-support-0}}
	public MainWindow()
	{
		ProtocolHelper.UseHttpsScheme = true;
		ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
		
		InitializeComponent();
	}
{{endregion}}

If HTTPS is enabled, but the security protocol is not changed, a SLL network error ("A SSLv3-compatible ClientHello handshake was found.") will appear and no tile images will be downloaded.

## See Also  
 * [Empty provider]({%slug radmap-features-empty-provider%})
 * [BingRestMapProvider]({%slug radmap-features-providers-bing-rest-map%}) 
 * [UriImageProvider]({%slug radmap-features-uriimageprovider%})
