---
title: Disable scrolling in the RadPdfViewer
description: Create a template and use it to disable scrolling in a RadPdfViewer.
type: how-to
page_title: How to disable scrolling in the RadPdfViewer
slug: kb-pdfviewer-disable-scrolling
position: 0
tags: pdf, pdfviewer, disable, scrolling
ticketid: 1075562
res_type: kb
---

## Environment

<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2020.2.820</td>
	    </tr>
	    <tr>
            <td>Product</td>
            <td>RadPDFViewer for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to disable scrolling in the [RadPdfViewer]({%slug radpdfviewer-overview%}).

## Solution

This functionality can be achieved by creating and using a template where the **ScrollBar**'s (both horizontal and vertical) **Visibility** is set to _Collapsed_. Then in the code behind setting all command descriptors related to scrolling to false and handle all the related events. Check the following code snippets:

 Creating a template and setting it to the RadPdfViewer
```XAML

	<Window.Resources>
        <ControlTemplate x:Key="FixedDocumentViewerBaseTemplate" TargetType="controlViewers:FixedDocumentViewerBase">
            <telerik:RadBusyIndicator x:Name="PART_BusyIndicator">
                <Grid Background="{TemplateBinding Background}">
                    <Grid.RowDefinitions>
                        <RowDefinition/>
                        <RowDefinition Height="0"/>
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition/>
                        <ColumnDefinition Width="0"/>
                    </Grid.ColumnDefinitions>
                    <ContentPresenter x:Name="PART_ContentPresenter" HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}" VerticalAlignment="{TemplateBinding VerticalContentAlignment}"/>
                    <ScrollBar Grid.Column="1" x:Name="PART_VerticalScrollBar" Orientation="Vertical" Visibility="Collapsed"/>
                    <ScrollBar Grid.Row="1" x:Name="PART_HorizontalScrollBar" Orientation="Horizontal" Visibility="Collapsed"/>
                </Grid>
            </telerik:RadBusyIndicator>
        </ControlTemplate>
        <Style x:Key="RadPdfViewerStyle" TargetType="controlViewers:RadPdfViewer">
            <Setter Property="VerticalContentAlignment" Value="Stretch"/>
            <Setter Property="HorizontalContentAlignment" Value="Stretch"/>
            <Setter Property="VerticalAlignment" Value="Stretch"/>
            <Setter Property="HorizontalAlignment" Value="Stretch"/>
            <Setter Property="Template" Value="{StaticResource FixedDocumentViewerBaseTemplate}"/>
            <Setter Property="UseLayoutRounding" Value="True"/>
            <Setter Property="SnapsToDevicePixels" Value="True"/>
        </Style>
    </Window.Resources>

    <Grid PreviewMouseWheel="Grid_PreviewMouseWheel" PreviewMouseMove="Grid_PreviewMouseMove">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <telerik:RadToolBar DataContext="{Binding ElementName=pdfViewer, Path=CommandDescriptors}">
            <telerik:RadButton Content="Open File" Command="{Binding OpenCommandDescriptor.Command}" HorizontalAlignment="Left" VerticalAlignment="Stretch" Margin="2" Padding="0" HorizontalContentAlignment="Center" VerticalContentAlignment="Center" IsBackgroundVisible="False">
                <ToolTipService.ToolTip>
                    <TextBlock Text="Open" />
                </ToolTipService.ToolTip>
            </telerik:RadButton>
        </telerik:RadToolBar>

        <telerik:RadPdfViewer Grid.Row="1" x:Name="pdfViewer" DataContext="{Binding ElementName=pdfViewer, Path=CommandDescriptors}" Style="{StaticResource RadPdfViewerStyle}" />
    </Grid>
```

 Disable commands related to scrolling and handle the related events
```C#

    public MainWindow()
    {
        InitializeComponent();
        
        this.pdfViewer.CommandDescriptors.MoveDownCommandDescriptor.IsEnabled = false;
        this.pdfViewer.CommandDescriptors.MoveUpCommandDescriptor.IsEnabled = false;
        this.pdfViewer.CommandDescriptors.MoveRightCommandDescriptor.IsEnabled = false;
        this.pdfViewer.CommandDescriptors.MoveLeftCommandDescriptor.IsEnabled = false;
        this.pdfViewer.CommandDescriptors.PageDownCommandDescriptor.IsEnabled = false;
        this.pdfViewer.CommandDescriptors.PageUpCommandDescriptor.IsEnabled = false;
    }

    private void Grid_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
    {
        e.Handled = true;

    }

    private void Grid_PreviewMouseMove(object sender, System.Windows.Input.MouseEventArgs e)
    {
        if (this.pdfViewer.Mode == Telerik.Windows.Documents.Fixed.UI.FixedDocumentViewerMode.Pan)
        {
            e.Handled = true;
        }
    }
```

## Notes

There is a request to expose an API that allows users to control this functionality easier. Make sure to cast your vote for it as this directly affects its priority: [PdfViewer: Introduce an easy way to disable the scrolling](https://feedback.telerik.com/wpf/1353861-pdfviewer-introduce-an-easy-way-to-disable-the-scrolling).
