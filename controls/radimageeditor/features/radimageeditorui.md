---
title: RadImageEditorUI
page_title: RadImageEditorUI
description: Check our &quot;RadImageEditorUI&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-features-radimageeditorui
tags: radimageeditorui
published: True
position: 2
---

# RadImageEditorUI

__RadImageEditor__ comes with a predefined UI out of the box – __RadImageEditorUI__. As it uses XAML only, you can easily customize it for your application, by adding or removing tools that can be executed.

The tools and commands that the editor can execute are __ImageToolItems__. They are grouped into sections depending on the modification they perform on the image. In the default template, these __ImageToolSections__ can be minimized and maximized using RadExpander. Moreover, each __ImageToolItem__ specifies:

* __Command__ property: A command which will be executed when you select the ImageToolItem, e.g. CropCommand.
When it comes to image editing tools which have settings and a live preview, they are passed as parameters to the ExecuteToolCommand. The values of the parameters of these tools are obtained from their SettingsUI, which are shown in a SettingsContainer on the right of the image.

* __ImageKey__ property: Sets the image that will be used as an icon in the ImageToolItem. Telerik.Windows.Controls.ImageEditor contains images mapped to the following ImageKeys:

	* Blur
	
	* Contrast
	
	* Crop

	* Draw
 
	* DrawText
	
	* FlipHorizontal
	
	* FlipVertical
	
	* HueShift
	
	* Invert
	
	* Pan
	
	* Resize
	
	* Rotate180CW
	
	* Rotate90CCW
	
	* Rotate90CW
	
	* RoundCorners
	
	* Saturation
	
	* Shape
	
	* Sharpen

**Example 1** shows how a __RadImageEditorUI__ with only a resize tool added looks like.

__Example 1: RadImageEditorUI with a resize tool__

```XAML
	<telerik:RadImageEditorUI x:Name="ImageEditorUI">
	    <telerik:RadImageEditorUI.ImageToolsSections>
	        <telerik:ImageToolsSection Header="Transform">
	            <telerik:ImageToolItem ImageKey="Resize" Text="Resize" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	                <telerik:ImageToolItem.CommandParameter>
	                    <tools:ResizeTool x:Name="resizeTool" />
	                </telerik:ImageToolItem.CommandParameter>
	            </telerik:ImageToolItem>
	        </telerik:ImageToolsSection>
	    </telerik:RadImageEditorUI.ImageToolsSections>
	</telerik:RadImageEditorUI>
```



The namespaces that have to be registered are listed in **Example 2**

__Example 2: Required namespaces__

```XAML

	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	xmlns:tools="clr-namespace:Telerik.Windows.Media.Imaging.Tools;assembly=Telerik.Windows.Controls.ImageEditor"
	xmlns:commands="clr-namespace:Telerik.Windows.Media.Imaging.ImageEditorCommands.RoutedCommands;assembly=Telerik.Windows.Controls.ImageEditor"
```


>The code that defines the default UI and includes all implemented image editing tools is available in the [First Look example](https://github.com/telerik/xaml-sdk/blob/master/ImageEditor/RadImageEditorUIFirstLook/MainPage.xaml) from our SDK repository. 


The image to be used will be chosen depending on the Theme applied to the editor, so that the best look of the editor be ensured. You can also use another image by setting the Image property instead of the ImageKey.

__Example 3: Set the Image property__

```XAML
	<telerik:ImageToolItem Text="Resize" Image="/RadImageEditorApplication;component/Images/resize.png" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	    <telerik:ImageToolItem.CommandParameter>
	        <tools:ResizeTool x:Name="resizeTool1" />
	    </telerik:ImageToolItem.CommandParameter>
	</telerik:ImageToolItem>
```

>You can see how the tools and commands can be declared in code-behind and modified on the fly in the __CustomizingDefaultUI__ demo 
{% if site.site_name == 'WPF' %}in the [WPF demos application](https://demos.telerik.com/wpf/){% endif %}{% if site.site_name == 'Silverlight' %}at [https://demos.telerik.com/silverlight/#ImageEditor/CustomizingDefaultUI](https://demos.telerik.com/silverlight/#ImageEditor/CustomizingDefaultUI){% endif %}

.

>tip A custom UI that is not based on RadImageEditorUI can also be created and used. This approach is illustrated in the demo __CustomUI__, which can be viewed  
{% if site.site_name == 'WPF' %}in the [WPF demos application](https://demos.telerik.com/wpf/){% endif %}{% if site.site_name == 'Silverlight' %}here: [https://demos.telerik.com/silverlight/#ImageEditor/CustomUI](https://demos.telerik.com/silverlight/#ImageEditor/CustomUI){% endif %}
.

## See Also

* [Import and Export]({%slug radimageeditor-features-import-export%})