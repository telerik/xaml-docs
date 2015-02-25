---
title: Wizard Buttons
page_title: Wizard Buttons
description: Wizard Buttons
slug: wizard-buttons
tags: wizard, buttons
published: True
position: 0
---

# Wizard Buttons

The wizard control provides the following buttons out of the box:
*	Next – clicking it will trigger the Next event and will navigate to the next wizard page
*	Previous – clicking it will trigger the Previous event and will navigate to the previous wizard page
*	Cancel – clicking it will trigger the Cancel event
*	Finish – clicking it will trigger the Finish event
*	Help – clicking it will trigger the Help event

It is possible to change the default content of each button by using the __NextButtonContent, PreviousButtonContent, CancelButtonContent, FinishButtonContent and HelpButtonContent__ properties of the wizard page.

## Control which buttons to be visible per page

In order to control which buttons to be visible on a specific page you can use the __ButtonsVisibilityMode__ flag enumeration property of the wizard page.  The enumeration provides the following values: 
 * None – no buttons are visible
 * Previous – shows the Previous button
 * Next – shows the Next button
 * Cancel – shows the Cancel button
 * Finish – shows the Finish button
 * Help – shows the Help button
 * All – shows all available buttons

Here is an example of setting the ButtonsVisibilityMode property of the WizardPage to show several buttons (Example 1): 

__Example 1__: Setting the ButtonsVisibilityMode property of the WizardPage manually in XAML.

#### __XAML__
	<telerik:RadWizard x:Name="radWizard" >
		<telerik:RadWizard.WizardPages>
			<telerik:WizardPage ButtonsVisibilityMode="Help,Next,Cancel"/>
		</telerik:RadWizard.WizardPages>
	</telerik:RadWizard>

## Control which buttons to be active per page 

In order to control which buttons to be active on a specific page you can use the following boolean properties:  
* AllowNext - indicates whether the Next button is enabled.
* AllowPrevious - indicates whether the Previous button is enabled.
* AllowCancel - indicates whether the Cancel button is enabled.
* AllowFinish - indicates whether the Finish button is enabled.
* AllowHelp - indicates whether the Help button is enabled.

Here is an example of setting the AllowHelp property to a WizardPage (__Example 2__):

__Example 2__ : Setting the AllowHelp property of the WizardPage. 

#### __XAML__
	<telerik:RadWizard x:Name="radWizard" >
		<telerik:RadWizard.WizardPages>
			<telerik:WizardPage AllowHelp="True" />
		</telerik:RadWizard.WizardPages>
	</telerik:RadWizard>

For more information on the default values of these properties for the different pages you can refer to the [Wizard Pages]({%slug wizard-pages%}) article.
