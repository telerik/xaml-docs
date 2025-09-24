---
title: How to Save Uncropped Image While CropTool is Active
page_title: Save Image Without Clipping it When Crop Tool is Enabled
description: How to save an image without cropping it when the RadImageEditor CropTool is still Activated.
type: how-to
slug: kb-imageeditor-save-uncropped-image-when-croptool-active
position: 0
tags: crop,clip,image,picture
ticketid: 1419225
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2 715</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>Progress® Telerik® UI for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to save an image without cropping it while the CropTool is active.

## Solution

1. Create a custom SaveImage command and override its ExecuteOverride method. If the executing tool is CropTool avoid commiting the tool, thus cropping the picture.

	```C#
		public class CustomSaveImageCommand : SaveImageCommand
		{
			public CustomSaveImageCommand(RadImageEditor owner) : base(owner)
			{
			}

			protected override void ExecuteOverride(object parameter)
			{
				SaveFileDialog dialog = new SaveFileDialog();

				string stringParameter = parameter as string;
				if (stringParameter != null && stringParameter.Contains("|"))
				{
					dialog.Filter = stringParameter;
				}
				else
				{
					dialog.Filter = FormatProviderToFilterConverter.GetFilter(ImageFormatProviderManager.RegisteredFormatProviders, false, false, stringParameter);
				}

				bool? dialogResult = dialog.ShowDialog();
				if (dialogResult == true)
				{
					if (!(this.Owner.ExecutingTool is CropTool))
					{
						this.Owner.CommitTool();
					}                

					string extension = System.IO.Path.GetExtension(dialog.SafeFileName);
					IImageFormatProvider formatProvider = ImageFormatProviderManager.GetFormatProviderByExtension(extension);
					using (Stream output = dialog.OpenFile())
					{
						formatProvider.Export(this.Owner.Image, output);
					}
				}
			}
		}
		
		public static class FormatProviderToFilterConverter
		{
			public static string GetFilter(IEnumerable<IImageFormatProvider> formatProviders, bool isImport, bool addAllFiles, string filter)
			{
				if (!string.IsNullOrEmpty(filter))
				{
					string[] extensions = filter.Split(',', ';').Select(e => e.Trim('.').ToLower()).ToArray();
					formatProviders = formatProviders.Where(fp => fp.SupportedExtensions.Any(ext => extensions.Contains(ext.Trim('.').ToLower())));
				}

				if (isImport)
				{
					formatProviders = formatProviders.Where(fp => fp.CanImport);
				}
				else
				{
					formatProviders = formatProviders.Where(fp => fp.CanExport);
				}

				return
					string.Join("|", formatProviders.Select(fp => GetFilter(fp)).ToArray()) +
					(addAllFiles ? "|All Files|*.*" : "");
			}

			public static string GetFilter(IImageFormatProvider formatProvider)
			{
				return
					formatProvider.FilesDescription +
					" (" +
					string.Join(", ", formatProvider.SupportedExtensions.Select(ext => "*" + ext).ToArray()) +
					")|" +
					string.Join(";", formatProvider.SupportedExtensions.Select(ext => "*" + ext).ToArray());
			}
		}
	```

2. Set the custom command to the RadImageEditorUI via its SaveCommand property.
	
	```C#
		this.radImageEditorUI.SaveCommand = new CustomSaveImageCommand(this.ImageEditorUI.ImageEditor);
	```