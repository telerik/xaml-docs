---
title: Installing Telerik UI from ZIP File
page_title: Installing Telerik UI from ZIP File
description: The article describes how to install the Telerik WPF product using the zip archive file.
slug: installation-installing-from-zip-wpf
tags: installing,ui,for,from,zip,file
published: True
position: 4
---

# Installing UI for {{ site.framework_name }} from ZIP File

This article describes how to install Telerik UI for {{ site.framework_name }} manually from a ZIP file. 

## Downloading ZIP Package

1. __Open the UI for {{ site.framework_name }} download page__ following the instructions in the {% if site.framework_name == 'WPF' %}[Download Product Files]({%slug download-product-files-wpf%}){% else %}[Download Product Files]({%slug download-product-files%}){% endif %} article.

2. __Download the ZIP file__ and extract it in the desired location. This will give you the UI for {{ site.framework_name }} dlls along with some additional files.

## ZIP Content

When you download and unzip the archive you will get the following folders.

* __Binaries__: Contains the XAML version of the Telerik dlls.

* __Binaries.NoXaml__: Contains the the NoXaml verison of the Telerik dlls.

	Read more about this in the [Xaml vs. NoXaml]({%slug xaml-vs-noxaml%}) article.

* __LicenseAgreements__: Contains the UI for {{ site.framework_name }} EULA, and the license agreements of any third party libraries used by UI for {{ site.framework_name }}.

* __Themes.Implicit__: Contains .xaml resource files (ResourceDictionaries) holding all the styles and templates of the Telerik controls.

## Installing

The manual installing using the files from the .ZIP is actually simply referencing the Telerik dlls in a {{ site.framework_name }} Visual Studio project. You can follow the instructions on the topic in [MSDN](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-add-or-remove-references-by-using-the-reference-manager?view=vs-2017) and reference the Telerik assemblies.

## See Also
{% if site.framework_name == 'WPF' %}* [System Requirements]({%slug installation-system-requirements-wpf%}){% else %}* [System Requirements]({%slug installation-system-requirements%}){% endif %}
 * [Which File Do I Need to Install?]({%slug installation-installing-which-file-do-i-need%})
 
 * [Latest Internal Build]({%slug installation-installing-lib%})
{% if site.framework_name == 'WPF' %}* [Trial License Limitations]({%slug installation-installing-license-limitations-wpf%}){% else %}* [Trial License Limitations]({%slug installation-installing-license-limitations%}){% endif %}
 * [Adding UI for WPF to the Visual Studio Toolbox]({%slug installation-adding-to-vs-2015-toolbox-wpf%})
