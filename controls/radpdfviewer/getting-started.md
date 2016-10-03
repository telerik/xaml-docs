---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radpdfviewer-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started



__RadPdfViewer__ is a control that allows you to display PDF files natively in {% if site.site_name == 'Silverlight' %} Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}. This topic helps you to quickly get started using the control. It focuses on the following:
      

* [Adding the Required Assembly References](#assembly-references)
* [Declaring RadPdfViewer in XAML](#adding-radpdfviewer-to-the-page)
* [Wiring UI with the Commands of RadPdfViewer](#wiring-ui-with-the-commands-of-radpdfviewer)

## Assembly References

The minimal set of assembly references you need to add to your {% if site.site_name == 'Silverlight' %} Silverlight {% endif %}{% if site.site_name == 'WPF' %} WPF {% endif %} project in order to use RadPdfViewer are listed below:
        

* **Telerik.Windows.Controls.dll**
* **Telerik.Windows.Controls.FixedDocumentViewers.dll**
* **Telerik.Windows.Documents.Core.dll**
* **Telerik.Windows.Documents.Fixed.dll**
* **Telerik.Windows.Zip.dll**

If you would like to include a RadToolBar, you will also need to reference:

* **Telerik.Windows.Controls.Input.dll**
* **Telerik.Windows.Controls.Navigation.dll**

You can also take advantage of some RadPdfViewer-specific controls such as FindDialog and PercentComboBox. In order to use them, you need to add the following references to your project:
        

* **Telerik.Windows.Controls.Input.dll**
* **Telerik.Windows.Controls.Navigation.dll**        
* **Telerik.Windows.Controls.FixedDocumentViewersUI**
            

## Adding RadPdfViewer to the Page

The first thing you need to do is to declare the Telerik namespace.
        

#### __[XAML] Example 1: Declare the Telerik namespace__

{{region radpdfviewer-getting-started_0}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"     
{{endregion}}



After that, you can add a RadPdfViewer like shown in **Example 2**.

#### __[XAML] Example 2: Create a PdfViewer__

{{region radpdfviewer-getting-started_1}}
    <telerik:RadPdfViewer x:Name="pdfViewer"/>
{{endregion}}

> When creating RadPdfViewer, you should ensure that the control is **not** placed in a container that measures its children with Infinity as this could lead to an unexpected behavior of the viewer.

## Wiring UI with the Commands of RadPdfViewer

The navigation panel is separated from the control in order to provide better customization options. In order to add a panel in your application, you can use __RadToolBar__, which has the command descriptors of the viewer as a DataContext.
        

#### __[XAML] Example 3: Add a RadToolBar to RadPdfViewer__

{{region radpdfviewer-getting-started_2}}
	<telerik:RadToolBar DataContext="{Binding ElementName=pdfViewer, Path=CommandDescriptors}">
	   …
	</telerik:RadToolBar>
{{endregion}}

>tipYou can download a complete runnable example showing the default RadPdfViewer with RadToolBar configuration from our [SDK repository](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/FirstLook). 

You can then add buttons, comboboxes, etc. bound to the respective command descriptors of the viewer as **Example 4** shows.

#### __[XAML] Example 4: Wire a CommandDescriptor to a RadButton__

{{region radpdfviewer-getting-started_3}}
	        <telerik:RadButton Command="{Binding OpenCommandDescriptor.Command}" Visibility="{Binding OpenCommandDescriptor.IsEnabled, Converter={StaticResource BoolToVisibilityConverter}}" HorizontalAlignment="Left" VerticalAlignment="Stretch" Margin="2" Padding="0" HorizontalContentAlignment="Center" VerticalContentAlignment="Center" IsBackgroundVisible="False">
	            <ToolTipService.ToolTip>
	                <TextBlock Text="Open" />
	            </ToolTipService.ToolTip>
	            <Image Source="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/open.png" Stretch="None" />
	        </telerik:RadButton>
{{endregion}}


>tipFor the whole configuration of a RadToolBar with all commands of the viewer, you can refer to [this article]({%slug radpdfviewer-wiring-ui%}) and more information about the command descriptors is available [here]({%slug radpdfviewer-command-descriptors%}).
          

## 

Having configured __RadPdfViewer__ in this way, the control is ready to use. Additional options, such as showing a PDF document when the viewer is loaded or binding the document, are described in the [Showing a File article]({%slug radpdfviewer-showing-a-file%}).
        

# See Also
* [Showing a File]({%slug radpdfviewer-showing-a-file%})
* [Wiring UI]({%slug radpdfviewer-wiring-ui%})