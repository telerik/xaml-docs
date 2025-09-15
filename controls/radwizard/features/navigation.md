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

## Conditional Navigation

__RadWizard__ provides the following events, which enable the implementation of conditional (not linear) navigation.

* __SelectionChanging__
* __SelectionChanged__
* __Previous__
* __Next__
* __Finish__
* __Help__
* __Cancel__

>For the full list of events refer to the [Events]({%slug wizard-events%}) article.

## SelectedPage

The __SelectedPage__ property is of type __WizardPage__ and gets or sets the currently selected page.

Here's an example of handling the **SelectionChanged** event using the __SelectedPage__ property to jump to a particular page when a condition is met.

__Example 1: Jump to particular page__

```C#
    private void RadWizard_SelectionChanged(object sender, SelectedPageChangedEventArgs e)
    {
        if (e.NewPage == this.page2)
        {
            ((RadWizard)sender).SelectedPage = this.page3;
        }
    }
```
```VB.NET
	Private Sub RadWizard_SelectionChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
		If e.NewPage = Me.page2 Then
			DirectCast(sender, RadWizard).SelectedPage = Me.page3
		End If
	End Sub
```

## SelectedPageIndex
The __SelectedPageIndex__ property is of type __int__ and gets or sets the index of the currently selected page.

**Example 2** demonstrates how to use the __SelectedPageIndex__ property in the **Finish** event to return to the starting page once the user clicks **Finish**.

__Example 2: Restart the wizard when the Finish button is clicked__

```C#
    private void RadWizard_Finish(object sender, NavigationButtonsEventArgs e)
    {
        ((RadWizard)sender).SelectedPageIndex = 0;
    }
```
```VB.NET
	Private Sub RadWizard_Finish(ByVal sender As Object, ByVal e As NavigationButtonsEventArgs)
		DirectCast(sender, RadWizard).SelectedPageIndex = 0
	End Sub
```

## See Also

* [Events]({%slug wizard-events%})
* [Wizard Pages]({%slug wizard-pages%})