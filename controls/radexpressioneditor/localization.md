---
title: Localization
page_title: Localization
description: Check our &quot;Localization&quot; documentation article for the RadExpressionEditor {{ site.framework_name }} control.
slug: radexpressioneditor-localization
tags: expressioneditor, localization
published: True
position: 3
---

# Localization

The built-in localization mechanism in {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} allows you to localize  the __RadExpressionEditor__ control.

Here is a list of the supported languages:

* English            
* German          
* Spanish           
* French
* Italian              
* Dutch             
* Turkish      

__: Some of RadExpressionEditor`s localized resources:__

![RadExpressionEditor Localization](images/RadExpressionEditor_Localization.png)

>tipTo learn more about the ways to localize the RadControls please read the common topic on [Localization]({%slug common-localization%}).

>__In order to dynamically localize the RadExpressionEditor at runtime, you should recreate it.__


## Resource Keys

In order to be able to distinguish the resources within __RadExpressionEditor__, an unique identifier, called __resource key__, is assigned to each localizable string. 

Below you can find a list of all of the __Resources__ available and their default values:


Key	| Value
-----------------------------------------------	| -----------------------------------------------		
ExpressionEditor_Aggregate | Aggregate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
ExpressionEditor_Constants | Constants
ExpressionEditor_DateTime | Date-time
ExpressionEditor_Fields | Fields
ExpressionEditor_Functions | Functions
ExpressionEditor_InsertTextCommand_Description | Insert text
ExpressionEditor_Logical | Logical
ExpressionEditor_Math | Math
ExpressionEditor_Operators | Operators
ExpressionEditor_Other | Other
ExpressionEditor_Text | Text
 

## See Also

 * [Getting Started]({%slug radexpressioneditor-getting-started%})

 * [Localization]({%slug common-localization%})
