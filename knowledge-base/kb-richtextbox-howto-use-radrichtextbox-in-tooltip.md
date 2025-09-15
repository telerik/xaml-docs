---
title: Use RadRichTextBox in Tooltip
description: Shows how you can bind the content of RadRichTextBox to HTML when the control is defined in a ToolTip.
type: how-to
page_title: Use RadRichTextBox in a tooltip to show HTML content
slug: kb-richtextbox-howto-use-radrichtextbox-in-tooltip
position: 0
tags: bind, binding, tooltip, richtextbox, datatemplate, html
ticketid: 1419423
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2.618</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadRichTextBox for WPF</td>
	    </tr>
    </tbody>
</table>


## Description
To bind content to a RadRichTextBox, you need to use one of the available [data providers]({%slug radrichtextbox-features-data-providers%}). However, popups have their separate visual tree and name scope, so binding outside of it is not possible with ElementName/RelativeSource, due to a limitation in the framework. 


## Solution

To have this binding work, you can pass the data through the **Content** property, the value of which will serve as a **DataContext** to the controls that are placed in the **ContentTemplate**. Here is how you can achieve that for a Grid's ToolTip:

>The *Name* is a property of the object used as a DataContext for the ToolTip.


```XAML

    <Grid.ToolTip>
        <ToolTip Content="{Binding}">
            <ToolTip.ContentTemplate>
                <DataTemplate>
                    <Grid>
                        <telerik:HtmlDataProvider RichTextBox="{Binding Path=., ElementName=radRichTextBox}" Html="{Binding Path=Name}}" />
                        <telerik:RadRichTextBox Name="radRichTextBox"  Height="400" Width="1000" />
                    </Grid>
                </DataTemplate>
            </ToolTip.ContentTemplate>
        </ToolTip>
    </Grid.ToolTip>
```

## See Also

[Data Providers]({%slug radrichtextbox-features-data-providers%})
