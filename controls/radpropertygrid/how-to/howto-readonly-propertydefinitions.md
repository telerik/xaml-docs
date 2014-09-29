---
title: Read Only PropertyDefinition
page_title: Read Only PropertyDefinition
description: Read Only PropertyDefinition
slug: radpropertygrid-howto-readonly-propertydefinitions
tags: read,only,propertydefinition
published: True
position: 0
---

# Read Only PropertyDefinition



This article shows how to control which property definitions to be read only.

If you want to control the read-only state of a PropertyDefinition, you can use the IsReadOnly property. You can bind it to a boolean property of your business object. Note that you need to specify the Source of the binding explicitly.

Here is a simple PropertyDefinition declaration:

#### __XAML__

{{region radpropertygrid-howto-readonly-propertydefinitions_0}}
	                <telerik:PropertyDefinition 
	                            Binding="{Binding FirstName}" 
	                            DisplayName="First Name"
	                            IsReadOnly="{Binding  Path=IsActive, Source={StaticResource MyViewModel}}">                  
	                </telerik:PropertyDefinition>        
	{{endregion}}


