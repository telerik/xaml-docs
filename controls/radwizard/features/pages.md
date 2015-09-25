---
title: Wizard Pages
page_title: Wizard Pages
description: Wizard Pages
slug: wizard-pages
tags: wizard, pages
published: True
position: 0
---

# Wizard Pages

In order to add pages to RadWizard you have to use its __WizardPages__ collection. It can consists of the following page types:
* __WizardPage__ - represents a wizard's page and by default its __ButtonsVisibilityMode property is set to “Previous”, ”Next” and “Cancel”__.
* __WelcomeWizardPage__ – represents a welcome page. It derives directly from __WizardPage__ and the only difference is that the __ButtonsVisibilityMode property is set to “Next” and “Cancel”__ by default. 
* __CompletionWizardPage__ - represents a completion page. It derives directly from __WizardPage__ and the only difference is that the __ButtonsVisibilityMode property is set to “Previous”, “Cancel” and “Finish”__ by default. 


For each wizard page you are able to define a header, title, side header and change the default footer by setting the following properties:
* __Header__ – enables you to define anything as a header.
* __Title__ – provides a way to define a title for the page.
* __SideHeader__ – enables you to define anything as a side header on the left side of the page. 
* __Content__ – contains the page content (__WizardPage__ derives directly from __ContentControl__). 

### Setting __HeaderTemplate, SideHeaderTemplate__ and __FooterTemplate__ 
All these properties can be used to get or set the data template respectfully for the __header, side header__ and __footer__. So, if you want to change those default elements for a particular wizard page, you may define them as in __Example 1__.

#### __[XAML]Example 1: Setting the HeaderTemplate, SideHeaderTemplate__ and __FooterTemplate  properties in XAML__
	<telerik:RadWizard x:Name="radWizard" >
		<telerik:RadWizard.WizardPages>
			<telerik:WizardPage Content="My Wizard Page Content" SideHeaderWidth="100" HeaderHeight="100">					
				<telerik:WizardPage.HeaderTemplate>
					<DataTemplate>
						<Image Source="Images/BrandMark_Telerik_Black.png" Width="200" Height="100" />
					</DataTemplate>
				</telerik:WizardPage.HeaderTemplate>
				<telerik:WizardPage.SideHeaderTemplate>
					<DataTemplate>
						<TextBlock Text="My Side Header" />
					</DataTemplate>
				</telerik:WizardPage.SideHeaderTemplate>
				<telerik:WizardPage.FooterTemplate>
					<DataTemplate>
						<StackPanel Orientation="Horizontal">
							<telerik:RadButton Content="Back" 
												   Width="70" Height="25"
												   Command="wizard:RadWizardCommands.MoveCurrentToPrevious"  
												   CommandParameter="{Binding}" />
							<telerik:RadButton Content="Next" Width="70" Height="25"
												   Command="wizard:RadWizardCommands.MoveCurrentToNext" 
												   CommandParameter="{Binding}" />
						</StackPanel>
					</DataTemplate>
				</telerik:WizardPage.FooterTemplate>
			</telerik:WizardPage>				
		</telerik:RadWizard.WizardPages>			
	</telerik:RadWizard>

>In order to use the built-in commands you should define the following namespace:
__xmlns:wizard="clr-namespace:Telerik.Windows.Controls.Wizard;assembly=Telerik.Windows.Controls.Navigation"__

__Figure 1:__ The wizard page defined in __Example 1__ will be displayed as follows:
![Pages SettingTemplates](images/pages-settingtemplates.png)

### Preserve __WizardPage__ content
By default, __RadWizard__ reuses a single __ContentPresenter__ for holding the currently selected page. Each time the selection is changed, the content of the last active page is unloaded in order to load the content of the newly selected page, thus the content of the pages is not persisted. As of __Q3 2015 RadWizard__ exposes a new property - __IsContentPreserved__.  Its default value is __"False"__, meaning that the content of the selected pages would not be persisted. In order to save the content of each page, you need to set the property to __"True"__.

#### __[XAML] Example 2: Setting IsContentPreserved property to "True"__

	<telerik:RadWizard x:Name="radWizard" IsContentPreserved="True">
	    <telerik:RadWizard.WizardPages>
	        <telerik:WizardPage Content="My First Wizard Page Content" />
	        <telerik:WizardPage Content="My Second Wizard Page Content" />
	    </telerik:RadWizard.WizardPages>
	</telerik:RadWizard>

