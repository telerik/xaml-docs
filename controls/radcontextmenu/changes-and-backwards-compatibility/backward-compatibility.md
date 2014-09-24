---
title: Backwards Compatibility
page_title: Backwards Compatibility
description: Backwards Compatibility
slug: radcontextmenu-backward-compatibility
tags: backwards,compatibility
published: True
position: 1
---

# Backwards Compatibility



This article lists the breaking changes of the control.

## Q1 2012

* UIElement property now returns null when RadContextMenu is closed. When opened returns the element that caused RadContextMenu to open

* If RadContextMenu is closed then GetClickedElement will return default(T) 

* MousePoint property will return new Point(double.NaN, double.NaN) when RadContextMenu is closed
