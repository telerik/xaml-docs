---
title: Telerik License Not Found Dialog Shown When UI for WPF Used in Addin Project
description: The invalid or missing Telerik license key warning is displayed in an addin project, like Excel/Word VSTO, Revit and others.
page_title: Telerik License Key Invalid or Missing Message Box and Watermark Displayed in a Excel VSTO Add-in/Plugin Project
type: troubleshooting
slug: kb-installation-missing-license-addin-project
position: 0
tags: installation, telerik, licensing, license, key, not, found, addin
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2025.2.521</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The invalid/missing Telerik license key dialog is shown in addin projects even when a valid license is installed.

## Solution

This happens because there is no proper main window and application context, which means that the licensing mechanism cannot get evaluated as epxected. To resolve this, use the `TelerikLicensing.Register` static method with your license script key, which can be downloaded from the [License Keys](https://www.telerik.com/account/your-licenses/license-keys) page.

```csharp
	public MyWPFUserControl()
	{
		TelerikLicensing.Register("your-script-key");
		InitializeComponent();
	}
```

