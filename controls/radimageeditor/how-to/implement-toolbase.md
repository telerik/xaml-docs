---
title: Implement ToolBase Class
page_title: Implement ToolBase Class
description: Implement ToolBase Class
slug: radimageeditor-howto-implement-toolbase
tags: implement,toolbase
published: True
position: 0
---

# Implement ToolBase Class


The __ToolBase__ class is an abstract class which implements the __ITool__ interface and has the following virtual and abstract members:

## Virtual

### Properties:

* __IsResetSettingsSupported__: The base implementation returns true. You can override this property and return false if the tool settings shall not be reset after its commit. 


## Abstract

### Properties:

* __IsPreviewOverlay__: Returns whether the tool has a preview overlay on the main image.

* __IsDirty__: Returns whether the tool has made any changes on the image.

* __AffectsLayout__: Returns whether the tool is changing the image size.

### Methods:

* __GetCommand()__: Returns the tool’s associated command of type __IImageCommand__.

* __GetContext()__: Returns the tool’s command context.

* __ResetSettings()__: Resets the tool’ settings if the tool’s __IsResetSettingsSupported__ property is true.

* __AttachUI()__: Passes a __ToolInitInfo__ object as a parameter whose members can be used by the tool. The method is invoked on tool’s execution. 

* __DettachUI()__: The method is invoked when the tool execution is canceled. For example, this occurs after the executing tool is changed.

* __GetSettingsUI()__: Returns an __UIElement__ which shall be placed as a content of the __RadImageEditor’s ToolSettingsContainer__.


## See Also

* [Create a Custom Tool]({%slug radimageeditor-howto-custom-tool%})
* [Implement DrawToolBase Class]({%slug radimageeditor-howto-implement-drawtoolbase%})