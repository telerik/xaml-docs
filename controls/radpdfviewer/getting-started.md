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



__RadPdfViewer__ is a control that allows you to display PDF files natively in
        {% if site.site_name == 'Silverlight' %}
          Silverlight
        {% endif %}{% if site.site_name == 'WPF' %}
          WPF
        {% endif %}.
        This topic will help you to quickly get started using the control. It will focus on the following:
      

* [Adding the Required Assembly References](#assembly-references)

* [Declaring RadPdfViewer in XAML](#adding-radpdfviewer-to-the-page)

* [Wiring UI with the Commands of RadPdfViewer](#wiring-ui-with-the-commands-of-radpdfviewer)

## Assembly References

The assembly references you need to have in your
          {% if site.site_name == 'Silverlight' %}
            Silverlight
          {% endif %}{% if site.site_name == 'WPF' %}
            WPF
          {% endif %}
          project are as follows:
        

* Telerik.Windows.Controls.dll

* Telerik.Windows.Controls.FixedDocumentViewers.dll

* Telerik.Windows.Documents.Core.dll

* Telerik.Windows.Documents.Fixed.dll

* Telerik.Windows.Zip.dll

If you would like to include a RadToolBar, similar to the NavigationPanel in the beta version you would also need to reference:

* Telerik.Windows.Controls.Input.dll

* Telerik.Windows.Controls.Navigation.dll

As of Q3 2013 you can also take advantage of some RadPdfViewer-specific controls such as FindDialog and PercentComboBox. In order to use them you
          need to the following references to your project:
        

* Telerik.Windows.Controls.Input.dll
            

* Telerik.Windows.Controls.Navigation.dll
            

* Telerik.Windows.Controls.FixedDocumentViewersUI
            

## Adding RadPdfViewer to the Page

The first thing you need to do is declare the Telerik namespace.
        

#### __XAML__

{{region radpdfviewer-getting-started_0}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"     
	{{endregion}}



After that you can add a bare-bone RadPdfViewer like this:

#### __XAML__

{{region radpdfviewer-getting-started_1}}
	<Grid>
	    <telerik:RadPdfViewer x:Name="pdfViewer"/>
	</Grid>
	{{endregion}}



## Wiring UI with the Commands of RadPdfViewer

The navigation panel that the PdfViewer had in its template in the beta version is now separated from the control in order to provide
          better customization options. In order to achieve the same look, you can use __RadToolBar__ which has the command descriptors
          of the viewer as a DataContext.
        

#### __XAML__

{{region radpdfviewer-getting-started_2}}
	        <telerik:RadToolBar DataContext="{Binding ElementName=pdfViewer, Path=CommandDescriptors}">
	   …
	</telerik:RadToolBar>
	{{endregion}}



You can then add buttons, comboboxes, etc. bound to the respective command descriptors of the viewer:

#### __XAML__

{{region radpdfviewer-getting-started_3}}
	        <telerik:RadButton Command="{Binding OpenCommandDescriptor.Command}" Visibility="{Binding OpenCommandDescriptor.IsEnabled, Converter={StaticResource BoolToVisibilityConverter}}" HorizontalAlignment="Left" VerticalAlignment="Stretch" Margin="2" Padding="0" HorizontalContentAlignment="Center" VerticalContentAlignment="Center" IsBackgroundVisible="False">
	            <ToolTipService.ToolTip>
	                <TextBlock Text="Open" />
	            </ToolTipService.ToolTip>
	            <Image Source="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/open.png" Stretch="None" />
	        </telerik:RadButton>
	{{endregion}}



>tipFor the whole configuration of a RadToolBar with all commands of the viewer, you can refer to
            [this article]({%slug radpdfviewer-wiring-ui%}) and you can find more information about the command descriptors 
            [here]({%slug radpdfviewer-command-descriptors%}).
          

## 

Having configured __RadPdfViewer__ in this way, it is ready to use.
          Additional options, such as showing a PDF document when the viewer is loaded or binding the document,
          are described in the article
          [Showing a File]({%slug radpdfviewer-showing-a-file%}).
        
