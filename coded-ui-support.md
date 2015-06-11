---
title: Coded UI support
page_title: Coded UI support
description: Coded UI support
slug: coded-ui-support
tags: coded,ui,support
published: True
position: 13
site_name: WPF
---

# Coded UI support

The purpose of this section is to show you how to create a simple CodedUI test. 

>tipFor more information about Creating, Editing and Maintaining a Coded UI Test check out the official page in MSDN [here](http://msdn.microsoft.com/en-us/library/ff977233.aspx).        

In order to create a CodedUI test, you need to perform the following steps:

* Add the __Telerik.VisualStudio.TestTools.UITest.Extension.ExtensionsCore__ assembly into the following directory:          

	* For Microsoft Visual Studio 2010 - "%CommonProgramFiles%\Microsoft Shared\VSTT\\__10.0__\UITestExtensionPackages".              

	* For Microsoft Visual Studio 2012 - "%CommonProgramFiles%\Microsoft Shared\VSTT\\__11.0__\UITestExtensionPackages".      

	* For Microsoft Visual Studio 2013 - "%CommonProgramFiles%\Microsoft Shared\VSTT\\__12.0__\UITestExtensionPackages".   	

* You will find the following folders in your UI for WPF installation folder - (usually C:\Program Files\Telerik\UI for WPF [version]\Binaries\WPF40\\__TestTools__\VS[version]\).          

* The __Telerik.VisualStudio.TestTools.UITest.Extension.ExtensionsCore__ assembly must be installed into the global assembly cache (GAC). You can achieve this using the [Global Assembly Cache Tool (Gacutil.exe)](http://msdn.microsoft.com/en-us/library/ex0ss12c(v=vs.80).aspx).          

* Create WPF Project with the control you want to test.

* Add a new TestProject.

* Add new item to TestProject - Coded UI Test. The __Generate Code for Coded UI Test__ dialog box appears.          

* Select the __Record actions, edit UI map or add assertions__ option and choose __OK__. For more information about the options in the dialog box, you could check [this](http://msdn.microsoft.com/en-us/library/dd286726.aspx) article.          

* Record a sequence of actions.

* Verify the values in UI properties.

* Run the test.

Below you can find information about the supported level of CodedUI tests throughout our controls.      

## Q2 2014

With __Q2 2014__ release of UI for WPF we have included [Level 4 Coded UI test support](http://blogs.msdn.com/b/visualstudioalm/archive/2011/10/28/coded-ui-test-extension-for-3rd-party-controls-the-basics-explained.aspx) for two of our controls. The following table gives more details on the controls as well as the supported actions:

Control	|	Action	|	Occurs	|	Action Property
---	|	---	|	---	|	---
RadComboBox	|	SetValueAction	|	On selection	|	SelectedItem
RadDateTimePicker	|	SetValueAction	|	On SelectedValue changed	|	DateTimeText

## Q3 2013

With our __Q3 2013__ official release we have included [Level 2 and Level 3 Coded UI test support](            http://blogs.msdn.com/b/visualstudioalm/archive/2011/10/28/coded-ui-test-extension-for-3rd-party-controls-the-basics-explained.aspx) across our controls.
        
The controls that currently do __not__ support Level 2 and Level 3 Coded UI tests are listed bellow:
        
Control	|	Level 1	|	Level 2	|	Level 3
---	|	---	|	---	|	---
RadCalculator	|	Yes	|	No	|	No
RadChart	|	No	|	No	|	No
RadExpressionEditor	|	Yes	|	No	|	No
RadGanttView	|	Yes	|	No	|	No
RadMaskedTextBox	|	Yes	|	No	|	No
RadPivotGrid	|	Yes	|	No	|	No
RadScheduleView	|	Yes	|	No	|	No
RadTreeListView	|	Yes	|	No	|	No


## Q2 2013

With our __Q2 2013__ official release we have included [Level 2 and Level 3 Coded UI test support](             http://blogs.msdn.com/b/visualstudioalm/archive/2011/10/28/coded-ui-test-extension-for-3rd-party-controls-the-basics-explained.aspx) across the following controls:
        
* RadGridView

* RadTreeListView

* RadPropertyGrid

* RadDataForm

* RadDataPager

* RadCarousel

* RadDataFilter

* RadCollectionNavigator

## Q3 2012

With our __Q3 2012__ official release we have included [Level 1 Coded UI test support](              http://blogs.msdn.com/b/visualstudioalm/archive/2011/10/28/coded-ui-test-extension-for-3rd-party-controls-the-basics-explained.aspx) across our controls, except the __RadChart__ control.
        
# See Also
 
* [UI Automation Support]({%slug common-ui-automation%})
