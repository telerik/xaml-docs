---
title: Design-time support
page_title: Design-time support
description: This article demonstrates what options are available for configuring the RadDiagram during design-time.
slug: raddiagram-features-design-time-support
tags: design-time, configuration, toolbox
published: True
position: 19
---

# Design-time Support

The __RadDiagram__ provides the developer with the possibility to enable or disable many of its features when it is added through the Visual Studio [ToolBox](https://docs.microsoft.com/en-us/visualstudio/ide/reference/toolbox?view=vs-2017). This article will show which features of the control can be configured through the design-time wizard.

## RadDiagram Design-time Wizard

When dragging and dropping the __RadDiagram__ from the Visual Studio ToolBox, you will be presented with a wizard which allows you to configure the control before adding it in xaml.

#### __Figure 1: RadDiagram Design-time wizard__
{% if site.site_name == 'WPF' %}![RadDiagram Design-time wizard](images/DiagramDesignWizardGeneralOptions.png){% else %}![RadDiagram Design-time wizard](images/DiagramDesignWizardGeneralOptions_SL.png){% endif %}

## Design-time Wizard Options

The design-time wizard lets you configure the following options: 

* __General options__ (refer to __Figure 1__). They allow you to enable/disable the following features of the RadDiagram:
    * [Rotation]({%slug raddiagrams-features-rotation%}) 
    * [Resizing]({%slug raddiagrams-features-resizing%})
    * [Pan and Zoom]({%slug raddiagrams-features-pan-zoom%})
    * [Items Editing]({%slug raddiagrams-features-edit%})
    * [Snapping]({%slug raddiagrams-features-snap%}#snap-to-grid)
    * [Background surface]({%slug raddiagram-styling-appearance%}#controlling-the-diagramming-surface-appearance)
    * [Selection mode]({%slug raddiagrams-features-selection%}#selection-modes)

* Enabling the [RadDiagram Toolbox]({%slug raddiagram-extensions-toolbox%}) as demonstrated in __Figure 2__.

    #### __Figure 2: Enabling the RadDiagram Toolbox__
    ![Enable the RadDiagram Toolbox](images/DiagramDesignWizardToolBox.png)

* Enabling the [SettingsPane]({%slug raddiagram-extensions-settingspane%}) as demonstrated in __Figure 3__.

    #### __Figure 3: Enabling the RadDiagram SettingsPane__
    ![Enable the RadDiagram SettingsPane](images/DiagramDesignWizardSettingsPane.png)

* Enabling the [DiagramNavigationPane]({%slug raddiagram-extensions-navigationpane%}) as demonstrated in __Figure 4__.

    #### __Figure 4: Enabling the DiagramNavigationPane__
    ![Enable the DiagramNavigationPane](images/DiagramDesignWizardNavigationPane.png)

* Enabling the [RadDiagram rulers]({%slug raddiagram-extensions-ruler%}) as demonstrated in __Figure 5__.

    #### __Figure 5: Enabling the RadDiagram rulers__
    ![Enable the RadDiagram rulers](images/DiagramDesignWizardRulers.png)

{% if site.site_name == 'WPF' %}
* Enabling the [RadDiagramRibbon]({%slug raddiagram-extensions-diagramribbon%}) as demonstrated in __Figure 6__.

    #### __Figure 6: Enabling the RadDiagramRibbon__
    ![Enable the RadDiagramRibbon](images/DiagramDesignWizardRibbon.png)

{% endif %}

## See Also
* [Getting Started]({%slug raddiagram-getting-started%})
* [FAQ]({%slug raddiagrams-faq%})
* [DataBinding]({%slug raddiagram-data-databinding%})
