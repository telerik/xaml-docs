---
title: Telerik License Not Found Dialog Shown When UI for WPF Used in Addin Project
description: The invalid or missing Telerik license key warning is displayed in an addin project, like Excel/Word VSTO, Revit, AutoCAD and others.
components: ["installerandvsextensions"]
page_title: Telerik License Key Invalid or Missing Message Box and Watermark Displayed in a Excel VSTO, Revit, AutoCAD and other Add-in/Plugin Projects
type: troubleshooting
slug: kb-installation-missing-license-addin-project
position: 0
tags: licensing, telerik, licensing, license, key, not, found, addin
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<th scope="row">Product Version</th>
			<td>2025.2.521</td>
		</tr>
		<tr>
			<th scope="row">Product</th>
			<td>UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The invalid/missing Telerik license key dialog is shown in addin (like Excel VSTO Add-in, Adobe and AutoCAD application addins and others) projects even when a valid license is installed.

## Solution

This happens because there is no proper main window and application context, which means that the licensing mechanism cannot get evaluated as expected. To resolve this, use the `TelerikLicensing.Register` static method with your license script key, which can be downloaded from the [License Keys](https://www.telerik.com/account/your-licenses/license-keys) page.

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
  		var evidenceAttributes = typeof(MainWindow).Assembly.GetCustomAttributes().OfType<EvidenceAttribute>();
		foreach (var attribute in evidenceAttributes)
		{                
    		TelerikLicensing.Register(attribute.Value);
		}

		InitializeComponent();
	}
```

In version __1.6.7__ of [TelerikLicensing](https://www.nuget.org/packages/Telerik.Licensing) a parameterless overload of the `TelerikLicensing.Register` was introduced. This will allow you to use the [approach with the TelerikLicense.cs file]({%slug installing-license-key%}) and call the register method without passing the script key in the C# code. Note that for this to work you will still need to add the [TelerikLicense.cs file]({%slug installing-license-key%}). Also, this approach should be used even if you install Telerik using the associated NuGet packages.

```csharp
	public MyWPFUserControl()
	{
		TelerikLicensing.Register();
		InitializeComponent();
	}
```

### Checking the Product and License Evidence

Call `TelerikLicensing.Register("<your-script-key>")` to submit script-key evidence to the licensing runtime. This call does not confirm that the license covers Telerik UI for WPF or the installed product version.

Compare the product code, product version, and license date in the runtime diagnostics with the product code, type, and expiration of each license evidence entry. A nonzero `LicenseEvidences` count alone does not confirm that the runtime found an applicable license. The top-level `products` list in the license file also does not identify which evidence the runtime used.

For common missing-product, expiration, and version-coverage errors, see [License Activation Errors and Warnings]({%slug license-activation-errors-and-warnings%}).

### Collecting Runtime Diagnostics

Call `TelerikLicensing.EnableDiagnostics()` before registering the key and initializing Telerik controls. After the licensing check runs, inspect `TelerikLicensing.Diagnostics` or the console output. Compare the product metadata and license evidence details to confirm which product and version the runtime evaluated.

The `TelerikLicensingVerbosity` property and `TELERIK_LICENSING_DEBUG` environment variable control build-task output. They do not enable runtime diagnostics.


