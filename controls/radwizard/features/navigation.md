---
title: Navigation
page_title: Navigation
description: This article describes how you can navigate through different pages of RadWizard control.
slug: wizard-navigation
tags: wizard, navigation
published: True
position: 0
---

# Navigation

__RadWizard__ provides out of the box a basic sequential page navigation, which allows you to navigate through the pages linearly. With the help of __RadWizard's__ events you can follow the state of the control at run time and implement custom pages sequence and page processing validation if necessary.

## Linear Navigation 

__RadWizard’s__ navigation is enabled by default and it allows you navigating through the pages in linear order. By default, pages will be visited in the order that they are defined in its __WizardPages__ collection.	

## Conditional Navigation ##

__RadWizard__ provides the following events, which enable the implementation of conditional (not linear) navigation.

* SelectionChanging
* SelectionChanged
* Previous
* Next
* Finish 
* Help 
* Cancel

>For the full list of events refer to the [Events]({%slug wizard-events%}) article.

Here's an example of handling the **SelectionChanged** event to jump to a particular page when a condition is met.

#### __[C#] Example 1: Jump to particular page__

{{region cs-wizard-navigation_0}}
    private void RadWizard_SelectionChanged(object sender, SelectedPageChangedEventArgs e)
    {
        if (e.NewPage == this.page2)
        {
            ((RadWizard)sender).SelectedPage = this.page3;
        }
    }
{{endregion}}

#### __[VB.NET] Example 1: Jump to particular page__

{{region vb-wizard-navigation_0}}
	Private Sub RadWizard_SelectionChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
		If e.NewPage = Me.page2 Then
			DirectCast(sender, RadWizard).SelectedPage = Me.page3
		End If
	End Sub
{{endregion}}

>tipThe __SelectedPage__ property is of type __WizardPage__ and gets the page from which it was invoked.
The __SelectedPageIndex__ property is of type __int__ and gets the page with the corresponding index.

**Example 2** in turn demonstrates how to use the **Finish** event to return to the starting page once the user clicks **Finish**.

#### __[C#] Example 2: Restart the wizard when the Finish button is clicked__

{{region cs-wizard-navigation_1}}
    private void RadWizard_Finish(object sender, NavigationButtonsEventArgs e)
    {
        ((RadWizard)sender).SelectedPage = this.page1;
    }
{{endregion}}

#### __[VB.NET] Example 2: Restart the wizard when the Finish button is clicked__

{{region vb-wizard-navigation_1}}
	Private Sub RadWizard_Finish(ByVal sender As Object, ByVal e As NavigationButtonsEventArgs)
		DirectCast(sender, RadWizard).SelectedPage = Me.page1
	End Sub
{{endregion}}

## See Also

* [Events]({%slug wizard-events%})
* [Wizard Pages]({%slug wizard-pages%})
