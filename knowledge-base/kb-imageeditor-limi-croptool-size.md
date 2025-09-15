---
title: How to Set the Min and Max Crop Size for the Image in RadImageEditor
description: How to define the minimum and maximum size for the CropTool.
type: how-to
page_title: How to Limit the crop tool size in RadImageEditor
slug: kb-imageeditor-limi-croptool-size
position: 0
tags: imagetoolitem,maxcropsize,mincropsize, imageeditorui
ticketid: 1176511
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2018.2.620</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadImageEditor for WPF</td>
	</tr>
</table>

## Description

How to define the minimum and maximum size for the CropTool in RadImageEditor.

## Solution 

1. Create a custom tool deriving from `CropTool`.
2. Create a parameterless constructor and use reflection to get the `CropAdorner` control.
3. Susbcribe to the `CropRectChanged` event of CropAdorner.
4. In the event handler limit the size of the adorner, by setting its `CropRect` property. You can expose additional properties on the custom crop tool class which can hold the min and max sizes.


```C#
	public class CustomCropTool : CropTool
	{
		public Size MaxCropSize { get; set; }
		public Size MinCropSize { get; set; }
	 
		private CropAdorner cropAdorner;
	 
		public CustomCropTool() : base()
		{
			var fieldInfo = typeof(CropTool).GetField("cropAdorner", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
			this.cropAdorner = fieldInfo.GetValue(this) as CropAdorner;
			this.cropAdorner.CropRectChanged += CropAdorner_CropRectChanged;
		}
	 
		private void CropAdorner_CropRectChanged(object sender, EventArgs e)
		{
			var currentRect = this.cropAdorner.CropRect;
			var w = Math.Max(this.MinCropSize.Width, Math.Min(this.MaxCropSize.Width, currentRect.Size.Width));
			var h = Math.Max(this.MinCropSize.Height, Math.Min(this.MaxCropSize.Height, currentRect.Size.Height));                       
			this.cropAdorner.CropRect = new Rect(currentRect.Location, new Size(w, h));
		}
	}
```


```XAML
	<telerik:ImageToolItem ImageKey="Crop" Text="Crop" Command="commands:ImageEditorRoutedCommands.ExecuteTool">
		<telerik:ImageToolItem.CommandParameter>
			<local:CustomCropTool x:Name="cropTool" MaxCropSize="300, 300" MinCropSize="100, 100" InitialSize="200, 200"   />
		</telerik:ImageToolItem.CommandParameter>
	</telerik:ImageToolItem>
```

## See Also
* [CropTool]({%slug radimageeditor-tools-crop%})
* [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%})
* [Create Custom Tool]({%slug radimageeditor-howto-custom-tool%})
