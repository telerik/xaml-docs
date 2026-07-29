---
title: Read Only PropertyDefinition
page_title: Read Only PropertyDefinition
description: Check our &quot;Read Only PropertyDefinition&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-howto-readonly-propertydefinitions
tags: read,only,propertydefinition
published: True
position: 0
---

# Read Only PropertyDefinition

This article shows how to control which property definitions to be read only.

If you want to control the read-only state of a PropertyDefinition, you can use the IsReadOnly property. You can bind it to a boolean property of your business object. Note that you need to specify the Source of the binding explicitly.

Here is a simple PropertyDefinition declaration:

__Example 1: Binding IsReadOnly property__

<snippet id='radpropertygrid-how-to-howto-readonly-propertydefinitions-block_1-xaml' />

> For an extended example, check out the [ReadOnlyPropertyDefinition](https://github.com/telerik/xaml-sdk/tree/master/PropertyGrid/ReadOnlyPropertyDefinition) demo from our [SDK Samples Browser](https://demos.telerik.com/xaml-sdkbrowser/).