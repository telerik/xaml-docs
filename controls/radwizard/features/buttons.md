---
title: Wizard Buttons
page_title: Wizard Buttons
description: Check our &quot;Wizard Buttons&quot; documentation article for the RadWizard {{ site.framework_name }} control.
slug: wizard-buttons
tags: wizard, buttons
published: True
position: 0
---

# Wizard Buttons

The wizard control provides the following buttons out of the box:
*	__Next__ – will trigger the __Next__ event and will navigate to the next wizard page
*	__Previous__ – will trigger the __Previous__ event and will navigate to the previous wizard page
*	__Cancel__ – will trigger the __Cancel__ event
*	__Finish__ – will trigger the __Finish__ event
*	__Help__ – will trigger the __Help__ event

It is possible to change the default content of each button by using the __NextButtonContent, PreviousButtonContent, CancelButtonContent, FinishButtonContent and HelpButtonContent__ properties of the wizard page.

## Control which buttons to be visible per page

In order to control which buttons to be visible on a specific page you can use the __ButtonsVisibilityMode__ flag enumeration property of the wizard page.  The enumeration provides the following values: 
 * ___None___ – no buttons are visible
 * ___Previous___ – shows the __Previous__ button
 * ___Next___ – shows the __Next__ button
 * ___Cancel___ – shows the __Cancel__ button
 * ___Finish___ – shows the __Finish__ button
 * ___Help___ – shows the __Help__ button
 * ___All___ – shows all available buttons

Here is an example of setting the __ButtonsVisibilityMode__ property of the __WizardPage__ to show several buttons (__Example 1__). 

__Example 1: Setting the ButtonsVisibilityMode property of the WizardPage manually in XAML__
```XAML
	<telerik:RadWizard x:Name="radWizard" >
		<telerik:RadWizard.WizardPages>
			<telerik:WizardPage ButtonsVisibilityMode="Help,Next,Cancel"/>
		</telerik:RadWizard.WizardPages>
	</telerik:RadWizard>
```

## Control which buttons to be active per page 

In order to control which buttons to be active on a specific page you can use the following boolean properties:  
* __AllowNext__ - indicates whether the __Next__ button is enabled.
* __AllowPrevious__ - indicates whether the __Previous__ button is enabled.
* __AllowCancel__ - indicates whether the __Cancel__ button is enabled.
* __AllowFinish__ - indicates whether the __Finish__ button is enabled.
* __AllowHelp__ - indicates whether the __Help__ button is enabled.

Here is an example of setting the __AllowHelp__ property to a __WizardPage__ (__Example 2__):

__Example 2: Setting the AllowHelp property of the WizardPage__ 
```XAML
	<telerik:RadWizard x:Name="radWizard" >
		<telerik:RadWizard.WizardPages>
			<telerik:WizardPage AllowHelp="True" />
		</telerik:RadWizard.WizardPages>
	</telerik:RadWizard>
```

For more information on the default values of these properties for the different pages you can refer to the [Wizard Pages]({%slug wizard-pages%}) article.

## Commands

The button actions are implemented via commands. To customize an action, override the corresponding command. Read more about the commands in the [corresponding help article]({%slug wizard-features-commands%}).
