---
title: Telerik License Not Found Dialog Shown in the Main Project When Telerik UI for WPF is Installed in a Class Library
description: The invalid or missing Telerik license key overlay is displayed when Telerik is installed in a class library that is referenced in the main project.
page_title: License Key Invalid or Missing Message Box and Watermark Displayed When Telerik is Installed in a Controls Class Library Referenced in the Main Project
type: troubleshooting
slug: kb-installation-missing-license-in-class-library-setup
position: 0
tags: installation, telerik, licensing, license, key, not, found, addin, class, library
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

The invalid or missing Telerik license key dialog and watermark are displayed when the Telerik assmeblies are referenced, even when a valid license is installed. This happens when Telerik UI for WPF is installed in a class library that is referenced in the main project, where the main project doesn't explicitly reference the Telerik assemblies. 

This behavior occurs in .NET projects and .NET Framework projects using the SDK-Style template.

## Solution

This is an expected behavior that comes from the nature of the Telerik licensing mechanism. To resolve it, use one of the following two approaches:

* (recommended) Make sure to install the [Telerik.Licensing](https://www.nuget.org/packages/Telerik.Licensing) NuGet package also in the main project.

	```xml
		<!-- this is in the main project's .csproj file -->
		<ItemGroup>
			<PackageReference Include="Telerik.Licensing" Version="1.6.*" />
		</ItemGroup>
	```

* Or alternatively, add the `IncludeAssets` and `PrivateAssets` attributes to the `PackageReference` tag in the `.csproj` file of the class library.

	```xml
		<!-- this is in the class library project's .csproj file -->
		<ItemGroup>
			<PackageReference Include="Telerik.Windows.Controls.for.Wpf.Xaml" IncludeAssets="all" PrivateAssets="none" Version="2025.2.521" />
		</ItemGroup>
	```


