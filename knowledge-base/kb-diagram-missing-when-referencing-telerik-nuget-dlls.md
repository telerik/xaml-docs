---
title: Control not Showing When Referencing Telerik dlls via NuGet Package
description: RadDiagram control not displayed after using NoXaml NuGet assemblies without referencing theme.
type: troubleshooting
page_title: Missing element if reference UI for WPF dlls from nuget manager
slug: kb-diagram-missing-when-referencing-telerik-nuget-dlls
position: 0
tags: nuget, manager, missing, noxaml
ticketid: 1399337
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.305</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadDiagram for WPF</td>
	</tr>
</table>

## Description

The control (like RadDiagram, RadButton, etc.) is missing when referencing the following NuGet packages in the project.


```XML
	<packages>
	  <package id="Telerik.Windows.Controls.Diagrams.for.Wpf" version="2019.1.220" targetFramework="net45" />
	  <package id="Telerik.Windows.Controls.for.Wpf" version="2019.1.220" targetFramework="net45" />
	  <package id="Telerik.Windows.Diagrams.Core.for.Wpf" version="2019.1.220" targetFramework="net45" />
	</packages>
```

> The *version* and the *targetFramework* are not relevant in this case. 

## Solution

This happens because the referenced packages contain [NoXaml]({%slug xaml-vs-noxaml%}) dlls. To resolve this, reference the Xaml version of the dlls or reference the theme dll and merge the required resources.

### Solution #1

Reference the Xaml version of the dlls.

The NuGet packages with the Xaml dlls are named with ".Xaml" at the end of the package's "id". Example: `Telerik.Windows.Controls.Diagrams.for.Wpf.Xaml`.

### Solution #2

Reference the theme dll package. Below you can find the name of the package for the Fluent theme.


```XML
	<packages>
		<!-- other packages here -->
		<package id="Telerik.Windows.themes.Fluent.for.Wpf" version="2019.1.220" targetFramework="net45" />
	</packages>
```

Merge the corresponding resources as shown in the [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%}) article. For example, to show RadDiagram, merge the following resources:


```XAML
	<ResourceDictionary> 
		<ResourceDictionary.MergedDictionaries> 
			<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/System.Windows.xaml"/> 
			<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.xaml"/> 
			<ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.Diagrams.xaml"/> 			
		</ResourceDictionary.MergedDictionaries> 
	</ResourceDictionary> 
```

## See Also
* [Available Themes]({%slug common-styling-appearance-available-themes%})
