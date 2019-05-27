---
title: How to an Create Implicit Style in Code
description: How to Add Implicit Style in code-behind
type: how-to
page_title: How to Define Implicit Style in Code
slug: kb-common-create-implicit-style-in-code
position: 0
tags: resources,typeof,xkey
ticketid: 1404933
res_type: kb
---

## Environment

This is common information applicable to the WPF framework in general.

## Description

How to an create implicit style in code.

## Solution

Call the `Add` method of the corresponding `Resources` collection with the target type as first argument and the Style object as second.

#### __[C#]__
{{region kb-common-create-implicit-style-in-code}}
	Style style = new Style(typeof(Button));
	style.Setters.Add(new Setter(Button.ForegroundProperty, Brushes.Red));
	
	uiElement.Resources.Add(typeof(Button), style);
{{endregion}}