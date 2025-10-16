---
title: Create Telerik RadMessageBox
description: This article shows how to utilize the RadWindow predefined dialogs to show a themed Telerik MessageBox dialog.
type: how-to
page_title: Display Custom RadMessageBox Dialog
slug: kb-window-radmessagebox
tags: messagebox,dialog,radwindow
res_type: kb
---
## Environment

| Key            | Value                   |
|----------------|-------------------------|
| Product        |  RadWindow for WPF      |
| Version        | 2024.1.130             |

## Description

How to implement a RadMessageBox that mimics the WPF `MessageBox` behavior, using the `RadWindow` [predefined dialogs]({%slug radwindow-features-predefined-dialogs%}).

This is useful when you want to style the message boxes in your application using the same styles as the applied Telerik theme.

## Solution

You can use the [predefined RadWindow dialogs]({%slug radwindow-features-predefined-dialogs%}) along with their customization APIs in order to mimic the MessageBox behavior.

The following example shows how to create a custom class and display different `RadWindow` dialog based on the given parameters.

__Implementing RadMessageBox class__
```C#
	public sealed class RadMessageBox
	{
		private static readonly Dictionary<MessageBoxImage, string> messageBoxImageToGlyphDictionary = new Dictionary<MessageBoxImage, string>()
		{
			{ MessageBoxImage.Question, "&#xe402;" },
			{ MessageBoxImage.Exclamation, "&#xe403;" },            
			{ MessageBoxImage.Asterisk, "&#xe401;" },
			{ MessageBoxImage.Stop, "&#xe11d;" },            
		};

		public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
		{
			var dialogSettings = new DialogParameters();
			dialogSettings.Content = messageBoxText;
			dialogSettings.Header = caption;
			dialogSettings.Owner = owner;

			string iconGlyph = messageBoxImageToGlyphDictionary[icon];
			dialogSettings.IconTemplate = CreateIconTemplate(iconGlyph);

			bool extraCancelButtonClicked = false;
			bool? dialogResult = null;            
			dialogSettings.Closed += (s, args) => { dialogResult = args.DialogResult; };            

			if (button == MessageBoxButton.OK)
			{
				RadWindow.Alert(dialogSettings);
			}
			else if (button == MessageBoxButton.OKCancel)
			{   
				RadWindow.Confirm(dialogSettings);                
			}
			else if (button == MessageBoxButton.YesNo)
			{
				dialogSettings.CancelButtonContent = "No";
				dialogSettings.OkButtonContent = "Yes";
				dialogSettings.Opened += (s, args) => { ((RadWindow)s).CanClose = false; };                
				RadWindow.Confirm(dialogSettings);
			}
			else if (button == MessageBoxButton.YesNoCancel)
			{
				dialogSettings.CancelButtonContent = "No";
				dialogSettings.OkButtonContent = "Yes";                
				var confirm = new RadConfirm();
				confirm.Loaded += (s, e) =>
				{
					RadButton cancelButton = AddExtraCancelButton(confirm);
					cancelButton.Click += (bS, bArgs) => { extraCancelButtonClicked = true; };
				};

				RadWindow.ConfigureModal(confirm, dialogSettings);
			}

			if (extraCancelButtonClicked)
			{
				dialogResult = null;
			}

			return GetMessageBoxResult(dialogResult, button);
		}

		private static DataTemplate CreateIconTemplate(string iconGlyph)
		{
			var context = new ParserContext();
			context.XmlnsDictionary.Add("telerik", "http://schemas.telerik.com/2008/xaml/presentation");
			context.XmlnsDictionary.Add("x", "http://schemas.microsoft.com/winfx/2006/xaml");
			context.XmlnsDictionary.Add(string.Empty, "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
			var iconTemplate = (DataTemplate)XamlReader.Parse(
				"<DataTemplate><telerik:RadGlyph FontSize=\"28\" Glyph=\"" + iconGlyph + "\" /></DataTemplate>", context);
			return iconTemplate;
		}

		private static MessageBoxResult GetMessageBoxResult(bool? dialogResult, MessageBoxButton button)
		{
			if (button == MessageBoxButton.OK)
			{
				return MessageBoxResult.OK;
			}
			if (!dialogResult.HasValue)
			{
				return MessageBoxResult.Cancel;
			}
			if (button == MessageBoxButton.OKCancel)
			{
				return dialogResult == true ? MessageBoxResult.OK : MessageBoxResult.Cancel;
			}
			if (button == MessageBoxButton.YesNo || button == MessageBoxButton.YesNoCancel)
			{
				return dialogResult == true ? MessageBoxResult.Yes : MessageBoxResult.No;
			}
			return MessageBoxResult.None;
		}

		private static RadButton AddExtraCancelButton(RadConfirm confirm)
		{
			var cancelButton = new RadButton();
			var buttonsHost = confirm.ChildrenOfType<Panel>().FirstOrDefault(x => x.Name == "DialogButtons");
			if (buttonsHost != null)
			{
				var okButton = (RadButton)buttonsHost.Children[0];
				var noButton = (RadButton)buttonsHost.Children[1];
				okButton.Margin = new Thickness(10, okButton.Margin.Top, 0, okButton.Margin.Bottom);
				noButton.Margin = new Thickness(10, noButton.Margin.Top, 0, noButton.Margin.Bottom);
								
				cancelButton.Command = WindowCommands.Cancel;
				cancelButton.Content = "Cancel";
				cancelButton.Margin = new Thickness(10, okButton.Margin.Top, 10, okButton.Margin.Bottom);
				cancelButton.MinWidth = okButton.MinWidth;                
				buttonsHost.Children.Add(cancelButton);

				if (buttonsHost is Grid gridPanel)
				{
					gridPanel.ColumnDefinitions.Add(new ColumnDefinition());
					Grid.SetColumn(cancelButton, 2);
				}
			}
			return cancelButton;
		}
	}
```

__Using the custom RadMessageBox class__
```C#
	MessageBoxResult result = RadMessageBox.Show(ownerWindow, "Message Content", "Message Header", MessageBoxButton.OKCancel, MessageBoxImage.Question);
```
