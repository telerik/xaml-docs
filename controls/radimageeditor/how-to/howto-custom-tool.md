---
title: Create a Custom Tool
page_title: Create a Custom Tool
description: Check our &quot;Create a Custom Tool&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-howto-custom-tool
tags: create,a,custom,tool
published: True
position: 2
---

# Create a Custom Tool

You can create your own custom tool for __RadImageEditor__ quite easily. You have to implement the __ITool__ interface, which will give you the ability to setup your own preview, settings UI and attach to any events of __RadImageEditor__ that are relevant to your tool.

This allows you to implement virtually any behavior you want within your tool and is the highlight of an SDK example: [Custom Watermark Tool](https://github.com/telerik/xaml-sdk/tree/master/ImageEditor/CustomWatermarkTool), where a custom tool for watermarking is available. The next tutorial will get you through the steps you need to execute to create one yourself.
        

1. __Create your tool.__<br/>Create a WatermarkTool class which implements the __ITool__ interface. The interface contains four properties and six methods which you need to implement.

	__Example 1: Create a tool__
	
	<snippet id='radimageeditor-how-to-howto-custom-tool-example_1_create_a_tool-cs' />



1. __Create a command.__<br/>The public IImageCommand GetCommand() method requires you to return a command linked with the tool. Create a custom command which implements the __IImageCommand__ interface and a field of the command's type in the WatermarkTool class.
            

	__Example 2: Create Command__
	
	<snippet id='radimageeditor-how-to-howto-custom-tool-example_2_create_command-cs' />




	>tip Do not forget to initialize the command in the constructor of the tool.

1. __Create command context.__<br/>Create context for your custom command. In this case we will take into account the Opacity, Rotation, Scale and Image properties.
            
	
	__Example 3: Create Command Context__
	
	<snippet id='radimageeditor-how-to-howto-custom-tool-example_3_create_command_context-cs' />

	
	The context is also used in the public object GetContext() method in your tool.
	            

1. __Create UI settings for the tool.__
	
	>tip __ToolSettingsHeader__ is a content control located in the Telerik.Windows.Controls.ImageEditor assembly.
	              
	
	__Example 4: Create Custom Tool Settings__
	
	<snippet id='radimageeditor-how-to-howto-custom-tool-example_4_create_custom_tool_settings-xaml' />

	
	
	
	__Example 5: Interaction logic for tool settings__
	
	<snippet id='radimageeditor-how-to-howto-custom-tool-example_5_interaction_logic_for_tool_settings-cs' />




1. Implement the __AttachUI()__, __DetachUI()__ and __ResetSettings()__ methods.
	            
	
	__Example 6: Implement UI settings related methods__
	
	<snippet id='radimageeditor-how-to-howto-custom-tool-example_6_implement_ui_settings_related_methods-cs' />

	
	
	
	>The __IsDirty__ property is used in the commiting logic of tools. Make sure to set it to true when a change in the settings has occured and to false when the settings are reset.
	              
	
	>tip The complete code is available in the XAML SDK repository: [Custom Watermark Tool](https://github.com/telerik/xaml-sdk/tree/master/ImageEditor/CustomWatermarkTool).
	          

## See Also

* [Implement ToolBase Class]({%slug radimageeditor-howto-implement-toolbase%})
* [Implement DrawToolBase Class]({%slug radimageeditor-howto-implement-drawtoolbase%})