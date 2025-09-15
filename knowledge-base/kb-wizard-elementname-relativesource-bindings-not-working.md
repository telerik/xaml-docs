---
title: ElementName and RelativeSource Bindings Don't Work in the Content of Not-Selected Wizard Pages
description: This article explains how to set up the bindings in the wizard pages so that they work even if the page is not selected.
type: troubleshooting
page_title: Bindings are not Evaluated When Wizard Page is Changed
slug: kb-wizard-elementname-relativesource-bindings-not-working
position: 0
tags: wizard, pages, elementname, relativesource, binding, not, working
ticketid: 1444863
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2020.2.617</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadWizard for WPF</td>
	</tr>
</table>

## Description

The **ElementName** and **RelativeSource** bindings in the content of the wizard pages don't work if the page is not the first to be loaded.

## Solution

This behavior happens because the content of the unselected pages is not part of the visual tree until it is selected. Therefore, the ElementName and RelativeSource bindings cannot find the corresponding element. As the WPF framework doesn't re-evaluate these bindings when the content is added in the visual tree, this leads to the non-working binding.

#### Solution #1

To achieve the desired result, you can use an **x:Reference** binding instead.


```XAML
    <telerik:WizardPage>
        <telerik:RadButton Content="Submit Password" Command="{Binding SubmitPasswordCommand}" CommandParameter="{x:Reference WizardWindow}" />
    </telerik:WizardPage>
```

#### Solution #2

Alternatively, you can use the **ContentTemplate** property of the page instead of setting its content directly.


```XAML
    <telerik:WizardPage>
        <telerik:WizardPage.ContentTemplate>
            <DataTemplate>
                    <telerik:RadButton Content="Submit Password" Command="{Binding SubmitPasswordCommand}" CommandParameter="{Binding ElementName=WizardWindow}"/>
                </UniformGrid>
            </DataTemplate>
        </telerik:WizardPage.ContentTemplate>
    </telerik:WizardPage>
```

## See Also
* [Wizard Pages]({%slug wizard-pages%})