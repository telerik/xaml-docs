---
title: Scenario Templates
page_title: Scenario Templates
description: Scenario Templates
slug: radcontrols-vs-extensions-scenario-templates
tags: scenario,templates
published: True
position: 5
---

# Scenario Templates



## 

The Scenario templates’ purpose is to let you quickly start using UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} in your existing projects. You can use the following steps to use our Scenario templates.

1. Open the __Add New Item dialog__, just as you usually do when adding a new Item to your project and select the __Telerik Scenario__ Item template or use the __Add Telerik Scenario__ menu item
	
	{% if site.site_name == 'Silverlight' %}![VSExtentions SL Scenario Wizard Menu 2](images/VSExtentions_SL_ScenarioWizardMenu2.png){% endif %}
	
	{% if site.site_name == 'WPF' %}![VSExtentions WPF Scenario Wizard Menu 2](images/VSExtentions_WPF_ScenarioWizardMenu2.png){% endif %}

1. Click __Add__

	{% if site.site_name == 'Silverlight' %}![VSExtentions SL Scenario Wizard Add New Item](images/VSExtentions_SL_ScenarioWizardAddNewItem.png){% endif %}
	
	{% if site.site_name == 'WPF' %}![VSExtentions WPF Scenario Wizard Add Item](images/VSExtentions_WPF_ScenarioWizardAddItem.png){% endif %}

1. Select a scenario in the __Telerik Scenario Wizard__ and click __Finish__

	{% if site.site_name == 'Silverlight' %}![VSExtentions SL Scenario Wizard](images/VSExtentions_SL_ScenarioWizard.png){% endif %}
	
	{% if site.site_name == 'WPF' %}![VSExtentions WPF Scenario Wizard](images/VSExtentions_WPF_ScenarioWizard.png){% endif %}

	>Currently there are three predefined scenarios: 
	
	* __Page__ – Creates a basic Page, ready to use with UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}
	
	* __RadWindow__ – Creates a new __RadWindow__ item. __RadWindow__ lets you create __Child__ and __Dialogs Windows__, which can have their appearance and content customized. 
	
	* __RadPane__ – Creates a new __RadPane__ item. __RadPane__ is the main content unit of the __RadDocking__ control.

	The result will be:
	
	{% if site.site_name == 'Silverlight' %}![VSExtentions SL Scenario Wizard Result](images/VSExtentions_SL_ScenarioWizardResult.png){% endif %}
	
	{% if site.site_name == 'WPF' %}![VSExtentions WPF Scenario Wizard Result](images/VSExtentions_WPF_ScenarioWizardResult.png){% endif %}
	
	* A new item will be added to your project, depending on your choice in the Scenario Wizard
	
	* All necessary references will be added to your project
