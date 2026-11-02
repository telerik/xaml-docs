---
title: SDK Samples Browser 
page_title: SDK Samples Browser 
description: Check our &quot;SDK Samples Browser&quot; application, which allows for exploring the examples from the XAML SDK repository. 
slug: sdk-samples-browser
tags: sdk,samples,browser,
published: True
position: 1
---

# SDK Samples Browser 

![SDK Browser application logo.](images/sdk-samples-browser-1.png)

The Software Development Kit (SDK) Samples Browser downloads the [XAML SDK repository](https://github.com/telerik/xaml-sdk/) from GitHub to a local folder you choose. It lets you browse examples and search by control name, example name, or description.
            
Download the [SDK Samples Browser application](https://demos.telerik.com/xaml-sdkbrowser/).
           
Some of its __key features__ are:            

* Automatic repository download functionality                    

* Manual and automatic checking for new and updated SDK examples                    

* Search functionality through the controls names, example's titles and example's descriptions
                    
* One click examples running

* One click examples opening in Visual Studio                    

## Getting Started with SDK Samples Browser
           
To run the examples, meet one of these requirements:
                
* Install the latest {% if site.site_name == 'WPF' %}[Telerik UI for WPF](http://www.telerik.com/products/wpf/download.aspx){% else %}[Telerik UI for Silverlight](http://www.telerik.com/products/silverlight/download.aspx){% endif %}.
                
* If it is already installed, provide a valid path to the {% if site.site_name == 'WPF' %}Telerik WPF{% else %}Telerik Silverlight{% endif %} assemblies.

## Browsing the Available Controls
            
The main screen lists controls as tiles in a RadTileList. Each tile displays the number of available examples.

{% if site.site_name == 'WPF' %}![WPF control tiles, including GanttView, Gauge, and ImageEditor, with example counts.](images/sdk-samples-browser-3.jpg){% else %}![Silverlight control tiles, including GanttView, Gauge, and ImageEditor, with example counts.](images/sdk-samples-browser-3-sl.png){% endif %}

## Browsing Through Control Examples
            
Select a control to open its examples screen. Choose an example from the list to read its description. Use __Open Folder__ to locate its files, __Open in VS__ to open it in Visual Studio, or __Run__ to build and run it.

{% if site.site_name == 'WPF' %}![WPF GanttView examples screen with the custom cell template example selected.](images/sdk-samples-browser-4.jpg){% else %}![Silverlight GanttView examples screen with the custom cell template example selected.](images/sdk-samples-browser-4-sl.png){% endif %}

## Building/Running an Example
            
By clicking the __Run__ button the application will show an indicator that says “Building example’s project”. After a few seconds it will disappear and a new Window will open of the built example.
                
## Changing the Settings
            
After the repository download completes, select the __Settings__ (gear) button in the navigation bar. The Settings screen lets you change:
                
* __Platform__&mdash;The platform for which the SDK examples should be loaded
                        
* __Binaries Source__&mdash;The location that contains all {% if site.site_name == 'WPF' %}__Telerik WPF__{% else %}__Telerik Silverlight__{% endif %} assemblies
                        
* __No.XAML Binaries Source__&mdash;The location that contains all {% if site.site_name == 'WPF' %}__No.XAML Telerik WPF__{% else %}__No.XAML Telerik Silverlight__{% endif %} assemblies
                        
* __Local Repository Path__&mdash;The location where the examples are locally placed by the automatic download                        

* __Check for Updates at Startup__&mdash;Determines if the application should automatically check for available SDK example updates                        

* __Open Projects with__&mdash;Determines which installed Visual Studio should be used to open SDK example projects with the "Open in VS" button                        

To check for updates while the application is running, select __Check for Updates__ in the navigation bar.

{% if site.site_name == 'WPF' %}![Settings screen with WPF selected, assembly and repository paths, update preference, and Visual Studio selection.](images/sdk-samples-browser-5.png){% else %}![Settings screen with Silverlight selected, assembly and repository paths, update preference, and Visual Studio selection.](images/sdk-samples-browser-5-sl.png){% endif %}
