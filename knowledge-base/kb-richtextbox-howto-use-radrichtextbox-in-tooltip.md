---
title: Use RadRichTextBox in Tooltip
description: Shows how you can bind the content of RadRichTextBox to HTML when the control is defined in a ToolTip.
type: how-to
page_title: Use RadRichTextBox in a tooltip for an item in an ItemTemplate to show HTML content
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
To bind content to a RadRichTextBox, you need to use one of the available [data providers]({%slug radrichtextbox-features-data-providers%}). However, **the ToolTip is not part of the main visual tree** and the binding to a property from the DataContext of the page should be performed in the **ContentTemplate** of the **ToolTip** to ensure that the content and the provider are bound as expected.



## Solution
Ensure the binding is performed in the **ContentTemplate** of the **ToolTip** and the content is transferred to the control by binding its **Content** property. Here is how you can achieve that for a Grid's ToolTip:

#### __[XAML]__
{{region kb-richtextbox-howto-use-radrichtextbox-in-tooltip}}

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
{{endregion}}

## See Also

[Data Providers]({%slug radrichtextbox-features-data-providers%})