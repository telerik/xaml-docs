---
title: RadImageEditorUI
page_title: RadImageEditorUI
description: RadImageEditorUI
slug: radimageeditor-features-radimageeditorui
tags: radimageeditorui
published: True
position: 1
---

# RadImageEditorUI



## 

__RadImageEditor__ comes with a predefined UI out of the box – __RadImageEditorUI__. As it uses XAML only, you can easily customize it for your application, by adding or removing tools that can be executed.

The tools and commands that the editor can execute are __ImageToolItems__. They are grouped into sections depending on the modification they perform on the image. In the default template, these __ImageToolSections__ can be minimized and maximized using RadExpander. Moreover, each __ImageToolItem__ specifies:

* __Command__property – a command which will be executed when you select the ImageToolItem, e.g. CropCommand.
When it comes to image editing tools which have settings and a live preview, they are passed as parameters to the ExecuteToolCommand. The values of the parameters of these tools are obtained from their SettingsUI, which are shown in a SettingsContainer on the right of the image.

* __ImageKey__property - sets the image that will be used as an icon in the ImageToolItem. Telerik.Windows.Controls.ImageEditor contains images mapped to the following ImageKeys:

* Blur

* Contrast

* Crop

* FlipHorizontal

* FlipVertical

* HueShift

* Invert

* Resize

* Rotate180CW

* Rotate90CCW

* Rotate90CW

* RoundCorners

* Saturation

* Sharpen

This is how a __RadImageEditorUI__ with only a resize tool added looks like:

#### __XAML__

{{region radimageeditor-features-radimageeditorui_0}}
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
	{{endregion}}



The namespaces that have to be registered are:

#### __XAML__

{{region radimageeditor-features-radimageeditorui_1}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	xmlns:tools="clr-namespace:Telerik.Windows.Media.Imaging.Tools;assembly=Telerik.Windows.Controls.ImageEditor"
	xmlns:commands="clr-namespace:Telerik.Windows.Media.Imaging.ImageEditorCommands.RoutedCommands;assembly=Telerik.Windows.Controls.ImageEditor"
	{{endregion}}



The image to be used will be chosen depending on the Theme applied to the editor, so that the best look of the editor be ensured. You can also use another image by setting the Image property instead of the ImageKey like this:

#### __XAML__

{{region radimageeditor-features-radimageeditorui_2}}
	<telerik:ImageToolItem Text="Resize" Image="/RadImageEditorApplication;component/Images/resize.png" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	   <telerik:ImageToolItem.CommandParameter>
	      <tools:ResizeTool x:Name="resizeTool" />
	   </telerik:ImageToolItem.CommandParameter>
	</telerik:ImageToolItem>
	{{endregion}}



You can see how the tools and commands can be declared in code-behind and modified on the fly in the CustomizingDefaultUI demo at [http://demos.telerik.com/silverlight/#ImageEditor/CustomizingDefaultUI](http://demos.telerik.com/silverlight/#ImageEditor/CustomizingDefaultUI)

A custom UI that is not based on RadImageEditorUI can also be created and used. This approach is illustrated in the demo CustomUI, which can be viewed here: [http://demos.telerik.com/silverlight/#ImageEditor/CustomUI](http://demos.telerik.com/silverlight/#ImageEditor/CustomUI)

The code that defines the default UI and includes all implemented image editing tools is as follows:

#### __XAML__

{{region radimageeditor-features-radimageeditorui_3}}
	<telerik:RadImageEditorUI x:Name="ImageEditorUI">
	  <telerik:RadImageEditorUI.ImageToolsSections>
	    <telerik:ImageToolsSection Header="Transform">
	      <telerik:ImageToolItem ImageKey="Resize" Text="Resize" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	        <telerik:ImageToolItem.CommandParameter>
	          <tools:ResizeTool x:Name="resizeTool" />
	        </telerik:ImageToolItem.CommandParameter>
	      </telerik:ImageToolItem>
	      <telerik:ImageToolItem ImageKey="Resize" Text="Canvas Resize" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	        <telerik:ImageToolItem.CommandParameter>
	          <tools:CanvasResizeTool />
	        </telerik:ImageToolItem.CommandParameter>
	      </telerik:ImageToolItem>
	      <telerik:ImageToolItem ImageKey="Rotate90CW" Text="Rotate90" Command="commands:ImageEditorRoutedCommands.Rotate90Clockwise" />
	      <telerik:ImageToolItem ImageKey="Rotate180CW" Text="Rotate180" Command="commands:ImageEditorRoutedCommands.Rotate180" />
	      <telerik:ImageToolItem ImageKey="Rotate90CCW" Text="Rotate270" Command="commands:ImageEditorRoutedCommands.Rotate90Counterclockwise" />
	      <telerik:ImageToolItem ImageKey="RoundCorners" Text="Round Corners" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	        <telerik:ImageToolItem.CommandParameter>
	          <tools:RoundCornersTool />
	        </telerik:ImageToolItem.CommandParameter>
	      </telerik:ImageToolItem>
	      <telerik:ImageToolItem ImageKey="FlipHorizontal" Text="FlipH" Command="commands:ImageEditorRoutedCommands.FlipHorizontal" />
	      <telerik:ImageToolItem ImageKey="FlipVertical" Text="FlipV" Command="commands:ImageEditorRoutedCommands.FlipVertical" />
	      <telerik:ImageToolItem ImageKey="Crop" Text="Crop" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	        <telerik:ImageToolItem.CommandParameter>
	          <tools:CropTool />
	        </telerik:ImageToolItem.CommandParameter>
	      </telerik:ImageToolItem>
	    </telerik:ImageToolsSection>
	    <telerik:ImageToolsSection Header="Adjust">
	      <telerik:ImageToolItem ImageKey="HueShift" Text="HueShift" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	        <telerik:ImageToolItem.CommandParameter>
	          <tools:HueShiftTool />
	        </telerik:ImageToolItem.CommandParameter>
	      </telerik:ImageToolItem>
	      <telerik:ImageToolItem ImageKey="Saturation" Text="Saturation" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	        <telerik:ImageToolItem.CommandParameter>
	          <tools:SaturationTool />
	        </telerik:ImageToolItem.CommandParameter>
	      </telerik:ImageToolItem>
	      <telerik:ImageToolItem ImageKey="Contrast" Text="Contrast" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	        <telerik:ImageToolItem.CommandParameter>
	          <tools:ContrastTool />
	        </telerik:ImageToolItem.CommandParameter>
	      </telerik:ImageToolItem>
	      <telerik:ImageToolItem ImageKey="Invert" Text="InvertColors" Command="commands:ImageEditorRoutedCommands.InvertColors" />
	    </telerik:ImageToolsSection>
	    <telerik:ImageToolsSection Header="Effects">
	      <telerik:ImageToolItem ImageKey="Sharpen" Text="Sharpen" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	        <telerik:ImageToolItem.CommandParameter>
	          <tools:SharpenTool />
	        </telerik:ImageToolItem.CommandParameter>
	      </telerik:ImageToolItem>
	      <telerik:ImageToolItem ImageKey="Blur" Text="Blur" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
	        <telerik:ImageToolItem.CommandParameter>
	          <tools:BlurTool />
	        </telerik:ImageToolItem.CommandParameter>
	      </telerik:ImageToolItem>
	    </telerik:ImageToolsSection>
	  </telerik:RadImageEditorUI.ImageToolsSections>
	</telerik:RadImageEditorUI>
	{{endregion}}




