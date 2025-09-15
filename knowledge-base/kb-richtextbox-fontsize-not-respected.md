---
title: FontSize of RadRichTextBox not Respected
description: This article explains what you need to do for RadRichTextBox to respect its FontSize setting.
type: troubleshooting
page_title: The Size of the Text of the RadRichTextBox cannot Be Changed
slug: kb-richtextbox-fontsize-not-respected
position: 0
tags: richtextbox, fontsize, setting, not, respected, changed
ticketid: 1494646
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

The **FontSize** property of the **RadRichTextBox** is not applied to its text.

## Solution

To display the proper **FontSize** passed to the RadRichTextBox control, you need to also set its [DocumentInheritsDefaultStyleSettings]({%slug radrichtextbox-frequently-asked-questions%}#setting-default-style-settings-on-the-document) property to **True**.



```XAML
	<Grid>
		<telerik:RadRichTextBox x:Name="radRichTextBox" 
								DocumentInheritsDefaultStyleSettings="True" 
								FontSize="8" />
		<telerik:HtmlDataProvider 
								RichTextBox="{Binding ElementName=radRichTextBox}"  
								Html="{Binding Path=Html, Mode=TwoWay}" />
	</Grid>
```

## See Also

* [Frequently Asked Questions]({%slug radrichtextbox-frequently-asked-questions%})
* [Data Providers]({%slug radrichtextbox-features-data-providers%})