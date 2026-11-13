---
title: RadDiagram Not Showing After Installing NuGet Packages
description: Restore a missing RadDiagram in Telerik UI for WPF by using Xaml NuGet packages or adding the required NoXaml theme resources.
components: ["diagram"]
type: troubleshooting
page_title: RadDiagram Not Showing After NuGet Installation - WPF
slug: kb-diagram-missing-when-referencing-telerik-nuget-dlls
position: 0
tags: raddiagram, nuget, manager, missing, noxaml
ticketid: 1399337
res_type: kb
---

## Environment
<table>
	<tr>
		<th scope="row">Product Version</th>
		<td>2019.1.305</td>
	</tr>
	<tr>
		<th scope="row">Product</th>
		<td>RadDiagram for WPF</td>
	</tr>
</table>

## Description

`RadDiagram` does not appear after you install Telerik UI for WPF NuGet packages without embedded styles. This can also affect other controls, such as `RadButton`.

The following historical `packages.config` example shows the NoXaml packages for `RadDiagram`:

```XML
<packages>
    <package id="Telerik.Windows.Controls.Diagrams.for.Wpf" version="2019.1.305" targetFramework="net45" />
    <package id="Telerik.Windows.Controls.for.Wpf" version="2019.1.305" targetFramework="net45" />
    <package id="Telerik.Windows.Diagrams.Core.for.Wpf" version="2019.1.305" targetFramework="net45" />
</packages>
```

>note The package versions and target framework in these examples describe the historical setup, not requirements for the solution. Use the release and target framework supported by your project. See the [available NuGet packages]({%slug nuget-available-packages%}) for current package options.

## Solution

The packages shown contain [NoXaml assemblies]({%slug xaml-vs-noxaml%}), which do not include control styles and templates. Without the required theme resources, the controls cannot display their default appearance.

Choose one of the following solutions. Use Xaml packages for embedded styles, or keep NoXaml packages and configure implicit styles.

>important Do not mix Xaml and NoXaml control assemblies. Keep all Telerik UI for WPF control and theme packages on the same release version.

### Solution #1: Using Xaml Packages

Xaml control packages include styles and templates, so you do not need to merge NoXaml theme dictionaries to display the control.

Replace the NoXaml control packages with their `.Xaml` equivalents:

1. Remove the NoXaml control package references, including those for other Telerik controls in the project.
2. Install `Telerik.Windows.Controls.Diagrams.for.Wpf.Xaml` and use the `.Xaml` equivalents for any other Telerik control packages. NuGet installs the required dependencies automatically.
3. Rebuild and run the application. `RadDiagram` should display with its embedded default styles.

### Solution #2: Using NoXaml Packages with a Theme

Keep the NoXaml control packages and add a theme using implicit styles:

1. Install `Telerik.Windows.Themes.Fluent.for.Wpf` at the same release version as your Telerik UI for WPF control packages. For the historical `packages.config` setup, the theme package entry is:

   ```XML
   <packages>
       <!-- other packages here -->
       <package id="Telerik.Windows.Themes.Fluent.for.Wpf" version="2019.1.305" targetFramework="net45" />
   </packages>
   ```

2. In `App.xaml`, place the following XAML fragment inside `Application.Resources`. If an explicit `ResourceDictionary` already exists, add these entries to its `MergedDictionaries` collection instead of replacing existing resources. If resources are declared directly inside `Application.Resources`, move them inside the new `ResourceDictionary`, after `ResourceDictionary.MergedDictionaries`, preserving their keys and relative order. Preserve the theme dictionary order shown:

   ```XAML
   <ResourceDictionary>
       <ResourceDictionary.MergedDictionaries>
           <ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/System.Windows.xaml"/>
           <ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.xaml"/>
           <ResourceDictionary Source="/Telerik.Windows.Themes.Fluent;component/Themes/Telerik.Windows.Controls.Diagrams.xaml"/>
       </ResourceDictionary.MergedDictionaries>
   </ResourceDictionary>
   ```

3. Rebuild and run the application. `RadDiagram` should display with the Fluent theme.

These dictionaries cover the basic `RadDiagram` control. If you use additional controls or diagram extensions, merge the dictionaries for their control assemblies too. See the [RadDiagram assembly requirements]({%slug raddiagram-getting-started%}) and the [implicit-styles theme setup]({%slug styling-apperance-implicit-styles-overview%}).

If a control still does not appear and you use custom styles, verify that each custom style is based on the corresponding default control style. See [styling controls with NoXaml assemblies]({%slug implicit-styles-styling-the-controls%}).

## See Also
* [Available Themes]({%slug common-styling-appearance-available-themes%})
* [Installing Telerik UI for WPF from NuGet]({%slug nuget-installation%})
