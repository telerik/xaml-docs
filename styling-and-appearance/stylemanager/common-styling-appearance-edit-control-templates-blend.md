---
title: Editing Control Templates in Expression Blend
page_title: Editing Control Templates in Expression Blend
description: Editing Control Templates in Expression Blend
slug: common-styling-appearance-edit-control-templates-blend
tags: editing,control,templates,in,expression,blend
publish: True
position: 2
---

# Editing Control Templates in Expression Blend



This topic contains the following sections:

* [Edit Control Style in Expression Blend](#Edit_Control_Style_in_Expression_Blend)

* [Edit Control Template in Expression Blend](#Edit_Control_Template_in_Expression_Blend)

## Edit Control Style in Expression Blend

The purpose of this section is to show you how to edit a __Style__ in __Expression Blend__. 

In order to edit a control style in Expression Blend you need to perform the following instructions:

* Open your application in Expression Blend.{% if site.site_name == 'Silverlight' %}

>

You can open your application in Expression Blend directly from your Visual Studio. For that purpose do the following things:

1. Open your Solution Explorer (View->Solution Explorer or use the Ctrl+Alt+L shortcut).

1. Select your user controls.

1. Right mouse button click and select "__Open in Expression Blend...__".{% endif %}

* In the "__Objects and Timeline__" pane (Window->Objects and Timeline) select the __Telerik control__ for which you want to create (modify) a style.




         
      ![Common Styling Create Style In Blend 010](images/Common_StylingCreateStyleInBlend_010.png)

* Expand the __Object -> Edit Style__ menu.




         
      ![Common Styling Create Style In Blend 020](images/Common_StylingCreateStyleInBlend_020.png)

* You have three options here:

* __Edit Current__ - if you choose it, this will open the currently applied style for edit.

>

If you don't have an applied style to the control, this option will be disabled.

* __Edit a Copy...__- edit a copy of the __default__ style. When you select this option a new dialog will be opened.




         
      ![Common Styling Create Style In Blend 030](images/Common_StylingCreateStyleInBlend_030.png)

The "Create Style Resource" dialog will prompt you to select a name for your style, as well as to choose the location where your style will be defined in.

* __Create Empty...__- create an empty style for the selected control. When you select this option, the same "Create Style Resource" dialog will be opened. You should select a name for the style, as well as to choose the location where your style will be defined in.




         
      ![Common Styling Create Style In Blend 040](images/Common_StylingCreateStyleInBlend_040.png)

## Edit Control Template in Expression Blend

The purpose of this section is to show you how to __edit/create a Template__ for the Telerik {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} controls.

In order to edit a template in Expression Blend you need to perform the following instructions:

* Open your application in Expression Blend.

>



You can open your application in Expression Blend directly from your Visual Studio. For that purpose do the following things:

1. Open your Solution Explorer (View->Solution Explorer or use the Ctrl+Alt+L shortcut).

1. Select your user controls.

1. Right mouse button click and select "__Open in Expression Blend...__".

* In the "__Objects and Timeline__" pane (Window->Objects and Timeline) select the __RadControl__ for which you want to create (modify) a template.




         
      ![Common Styling Templating Edit Template In Blend 010](images/Common_StylingTemplatingEditTemplateInBlend_010.png)

* Expand the __Object -> Edit Template__menu.




         
      ![Common Styling Templating Edit Template In Blend 020](images/Common_StylingTemplatingEditTemplateInBlend_020.png)

* You have three options here:

* __Edit Current__ - if you choose it, this will open the currently applied template for edit.

>

If you don't have an applied template to the control, this option will be disabled.

* __Edit a Copy...__- edit a copy of the __default__ template. When you select this option a new dialog will be opened.




         
      ![Common Styling Templating Edit Template In Blend 030](images/Common_StylingTemplatingEditTemplateInBlend_030.png)

The "Create Style Resource" dialog will prompt you to select a name for your template, as well as to choose the location where your style will be defined in.

>

Note that __Edit a Copy...__ will not declare you a copy of the default template as a resource in your XAML. Instead, it will create a copy of the default style with a ControlTemplate setter.

* __Create Empty...__ - create an empty template for the selected control. When you select this option, the same "Create Style Resource" dialog will be opened. You should select a name for the template, as well as to choose the location where your template will be defined in.

>

In contrast to the "__Edit a Copy...__" option, the "__Create Empty..."__will create a new ControlTemplate as a resource in your XAML.

>

It is not recommended to choose the "__Create Empty...__" option, unless you are familiar with __TemplatedParts__ for the specific control.
