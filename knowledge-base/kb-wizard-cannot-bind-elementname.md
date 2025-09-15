---
title: Cannot Find Source for Data Binding with ElementName Reference
description: Data binding two elements in RadWizardPage's Content using ElementName doesn't work.
page_title: Binding with ElementName in RadWizardPage Content doesn't work
type: troubleshooting
slug: kb-wizard-cannot-bind-elementname
position: 0
tags: databind, cannot, elementname
ticketid: 1453025
res_type: kb
---

## Environment

<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.3.917</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadWizard for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

Cannot find the source of data binding with ElementName reference when the elements are in the RadWizardPage's Content.

The following code snippet shows the setup that reproduces the issue.


```XAML
	<telerik:WizardPage.Content>
		<DataTemplate>
			<StackPanel>
				<Label Target="{Binding ElementName=txt_Code2}" Content="_code." />
				<TextBox Name="txt_Code2" />
			</StackPanel>
		</DataTemplate>
	</telerik:WizardPage.Content>
```

## Solution

This behavior comes from an optimization in the RadWizard control. To resolve it, you can use __ContentTemplate__, instead of Content.


```XAML
	<telerik:WizardPage.ContentTemplate>
		<DataTemplate>
			<StackPanel>
				<Label Target="{Binding ElementName=txt_Code2}" Content="_code." />
				<TextBox Name="txt_Code2" />
			</StackPanel>
		</DataTemplate>
	</telerik:WizardPage.ContentTemplate>
```

Or you can use the __x:Reference__ keyword.


```XAML
	<telerik:WizardPage.Content>
		<StackPanel>
			<Label Target="{Binding Source={x:Reference txt_Code2}}" Content="_code." />
			<TextBox Name="txt_Code2" />
		</StackPanel>
	</telerik:WizardPage.Content>
```
