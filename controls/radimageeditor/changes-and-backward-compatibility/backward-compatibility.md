---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: radimageeditor-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# Backward Compatibility


This article will list the breaking changes and how they can be fixed when upgrading to a specific version of the controls to the next one.

## What's Different in 2015 Q1 - 2015.1.0225

### Changed

* Telerik.Windows.Media.Imaging.Tools.ITool::IsResetSettingsSupported is added. The property specifies whether the settings of a tool can be reset. 


### What to do now

* The common implementation of a tool returns __true__. When the property returns ‘true’, after a tool’s commit, its settings will be reset. Otherwise they won’t.