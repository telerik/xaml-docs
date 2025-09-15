---
title: Viewer Modes
page_title: Viewer Modes
description: Check our &quot;Viewer Modes&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-viewer-modes
tags: viewer,modes
published: True
position: 3
---

# Viewer Modes



There are three __FixedDocumentViewerModes__ which specify the behavior of __RadPdfViewer__ when you left-click in the document and move the mouse around (without releasing the left button of the mouse):
      

* None – the control does nothing;

* Pan – the document is scrolled in the respective direction;

* TextSelection – selection is initiated, which stops when you release the button of the mouse.

## Specify the Viewer Mode Using UI

The viewer mode can be changed using the "default" UI that RadPdfViewer uses (as shown in the picture).

![Rad Pdf Viewer Viewer Modes 02](images/RadPdfViewer_ViewerModes_02.png)

The code of the buttons can be declared as follows:

{% if site.site_name == 'Silverlight' %}
#### __XAML__

```XAML
	<telerik:RadToolBar DataContext="{Binding ElementName=pdfViewer, Path=CommandDescriptors}">
	  <telerik:RadToolBar.Resources>
	    <converters:FixedDocumentViewerModeConverter x:Key="ModeConverter" />
	  </telerik:RadToolBar.Resources>
	<telerik:RadToggleButton IsChecked="{Binding FixedDocumentViewer.Mode, Mode=TwoWay, Converter={StaticResource ModeConverter}, ConverterParameter=Pan}" Margin="2" Padding="0" IsBackgroundVisible="False" HorizontalAlignment="Left" VerticalAlignment="Stretch">
		<ToolTipService.ToolTip>
			<TextBlock Text="Pan" />
		</ToolTipService.ToolTip>
		<Image Source="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/hand-free.png" Stretch="None" />
	</telerik:RadToggleButton>
	
	<telerik:RadToggleButton IsChecked="{Binding FixedDocumentViewer.Mode, Mode=TwoWay, Converter={StaticResource ModeConverter}, ConverterParameter=TextSelection}" Margin="2" Padding="0" IsBackgroundVisible="False" HorizontalAlignment="Left" VerticalAlignment="Stretch">
		<ToolTipService.ToolTip>
			<TextBlock Text="Text Selection" />
		</ToolTipService.ToolTip>
		<Image Source="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/text-selection.png" Stretch="None" />
	</telerik:RadToggleButton>
	</telerik:RadToolBar>
	
	<telerik:RadPdfViewer Grid.Row="1" x:Name="pdfViewer" DefaultFormatProviderSettings="ReadAllAtOnce" DocumentSource="/PdfViewerDemo;component/SampleData/test.pdf" />
```
{% endif %}
{% if site.site_name == 'WPF' %}
#### __XAML__

```XAML
	<telerik:RadToolBar DataContext="{Binding ElementName=pdfViewer, Path=CommandDescriptors}">
	  <telerik:RadToolBar.Resources>
	    <converters:FixedDocumentViewerModeConverter x:Key="ModeConverter" />
	  </telerik:RadToolBar.Resources>
	<telerik:RadToggleButton IsChecked="{Binding FixedDocumentViewer.Mode, Mode=TwoWay, Converter={StaticResource ModeConverter}, ConverterParameter=Pan}" Margin="2" Padding="0" IsBackgroundVisible="False" HorizontalAlignment="Left" VerticalAlignment="Stretch">
		<ToolTipService.ToolTip>
			<TextBlock Text="Pan" />
		</ToolTipService.ToolTip>
		<Image Source="pack://application:,,,/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/hand-free.png" Stretch="None" />
	</telerik:RadToggleButton>
	
	<telerik:RadToggleButton IsChecked="{Binding FixedDocumentViewer.Mode, Mode=TwoWay, Converter={StaticResource ModeConverter}, ConverterParameter=TextSelection}" Margin="2" Padding="0" IsBackgroundVisible="False" HorizontalAlignment="Left" VerticalAlignment="Stretch">
		<ToolTipService.ToolTip>
			<TextBlock Text="Text Selection" />
		</ToolTipService.ToolTip>
		<Image Source="pack://application:,,,/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/text-selection.png" Stretch="None" />
	</telerik:RadToggleButton>
	</telerik:RadToolBar>
	
	<telerik:RadPdfViewer Grid.Row="1" x:Name="pdfViewer" DefaultFormatProviderSettings="ReadAllAtOnce" DocumentSource="/PdfViewerDemo;component/SampleData/test.pdf" />
```
{% endif %}

Note that the RadToolBar control is bound to the CommandDescriptorss property of the PDF viewer.

The declarations of the namespaces used in the snippet above are:

#### __XAML__

```XAML
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	xmlns:converters="clr-namespace:Telerik.Windows.Documents.Converters;assembly=Telerik.Windows.Controls.FixedDocumentViewers"
```



## Specify Viewer Mode in Code

The mode of the viewer is set using the Mode property, e.g.:

#### __C#__

```C#
	  this.pdfViewer.Mode = Telerik.Windows.Documents.Fixed.UI.FixedDocumentViewerMode.TextSelection;
```



As the Mode property is a DependencyProperty, you could also bound it to different properties, depending on the logic of your application.

