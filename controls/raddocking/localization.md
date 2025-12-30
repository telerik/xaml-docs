---
title: Localization
page_title: Localization
description: Check our &quot;Localization&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-localization
tags: localization
published: True
position: 5
---

# Localization

The built-in localization mechanism in Silverlight and WPF allows you to localize any string resource used by the RadDocking control. Once translated, you might use your resources in both Silverlight and WPF projects without changing anything.

>tip To learn more about the ways to localize UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} please read the common topic about {% if site.site_name == 'Silverlight' %}[Localization]({%slug common-localization%}){% endif %}{% if site.site_name == 'WPF' %}[Localization]({%slug common-localization%}){% endif %}.

In __RadDocking__ you can localize the context menu:

![Rad Docking localization en](images/RadDocking_localization_en.png)

The next image shows the context menu localized in German: 

![Rad Docking localization de](images/RadDocking_localization_de.png)

## Supported Languages

__RadDocking__ can be translated in one of the following supported languages using the framework’s localization mechanism:

* English
* German
* Spanish
* French
* Italian
* Dutch
* Turkish

More information on how to achieve this you can find in the [Localization Using Built-in Resources] ({%slug common-localization%}) article.

## Resource Keys

The resources of the control can be localized by using an unique identifier called resource key that is assigned to each localizable string. Below you may find a list of the Resources available and their default values:

Key	|	Value
---	|	---
Hide	|	Hide
Auto_hide	|	Auto hide
Floating	|	Floating
Dockable	|	Dockable
Tabbed_document	|	Tabbed document
Docking_ActivePanes | Active Panes
Docking_ActiveDocuments | Active Documents
Docking_PreviewHeader | Preview

## See Also

 * [How to Add Buttons to the Pane Header]({%slug raddocking-how-to-add-buttons-to-the-pane-headers%})

 * [How to Add Icon to the RadPane's Header]({%slug raddocking-how-to-add-icon-pane-header%})
