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

The invalid/missing Telerik license key dialog is shown in addin (like Excel VSTO Add-in) projects even when a valid license is installed.

## Solution

This happens because there is no proper main window and application context, which means that the licensing mechanism cannot get evaluated as epxected. To resolve this, use the `TelerikLicensing.Register` static method with your license script key, which can be downloaded from the [License Keys](https://www.telerik.com/account/your-licenses/license-keys) page.

```csharp
	public MyWPFUserControl()
	{
		TelerikLicensing.Register("your-script-key");
		InitializeComponent();
	}
```

If you prefer to avoid setting your script key in the C# code, you can use the [approach with the TelerikLicense.cs file]({%slug installing-license-key%}) where the `EvidenceAttribute` is added and then manually fetch the key from it. 

```csharp
	public MyWPFUserControl()
	{		
  		var evidenceAttr = typeof(MainWindow).Assembly.GetCustomAttribute<Telerik.Licensing.EvidenceAttribute>();
  		var key = evidenceAttr?.Value ?? "";
   		TelerikLicensing.Register(key);

		InitializeComponent();
	}
```

In version __1.6.7__ of [TelerikLicensing](https://www.nuget.org/packages/Telerik.Licensing) a parameterless overload of the `TelerikLicensing.Register` was introduced. This will allow you to use the [approach with the TelerikLicense.cs file]({%slug installing-license-key%}) and call the register method without passing the script key in the C# code. Note that for this to work you will still need to add the [TelerikLicense.cs file]({%slug installing-license-key%}).

```csharp
	public MyWPFUserControl()
	{
		TelerikLicensing.Register();
		InitializeComponent();
	}
```

