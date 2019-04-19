---
title: Commands
page_title: Commands
description: 
slug: radwebcam-features-commands
tags: commands, radwebcamcommands
published: True
position: 0
---

# Commands

The actions in the UI of RadWebCam control are executed via commands. To access them use the __RadWebCamCommands__ static class. 

The following commands are available:

* __TakeSnapshot__: Takes a snapshot of the video feed. 
* __SaveSnapshot__: Fires the SnapshotTaken event where you can save the BitmapSource object.
* __DiscardSnapshot__: Discargs the snapshot.
* __ToggleRecording__: Toggles the video recording.

You can use the commands outside of the RadWebCam control or modify their default behavior.

## Using Commands Manually

The RadWebCamCommands can be attached to a button or another element supporting commands which is defined outside of the RadWebCam control.

#### __[XAML] Example 1: Use RadWebCamCommands__
{{region radwebcam-features-commands-0}}
	<telerik:RadWebCam x:Name="radWebCam" />
	<telerik:RadButton Command="telerik:RadWebCamCommands.TakeSnapshot"  CommandTarget="{Binding ElementName=radWebCam}"/>
{{endregion}}

## Modify Command Behavior

The RadWebCamCommands uses RoutedUICommands, which means that you can override their behavior as any other [RoutedUICommand](https://docs.microsoft.com/en-us/dotnet/api/system.windows.input.routeduicommand?view=netframework-4.7.2).

#### __[C#] Example 1: Override the ToggleRecording command__
{{region radwebcam-features-commands-1}}
	public void RegisterCommand()
	{
		CommandBinding commandBinding = new CommandBinding(RadWebCamCommands.ToggleRecording, OnToggleRecordingExecuted, OnToggleRecordingCanExecute);
		CommandManager.RegisterClassCommandBinding(typeof(RadWebCam), commandBinding);
	}
	
	private static void OnToggleRecordingCanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
		RadWebCam webCam = sender as RadWebCam;
		e.CanExecute = webCam != null && !string.IsNullOrEmpty(webCam.RecordingFilePath);
	}

	private static void OnToggleRecordingExecuted(object sender, ExecutedRoutedEventArgs e)
	{
		RadWebCam webCam = (RadWebCam)sender;
				
		// Note that in order to use RadWindow you will need to add a reference to "Telerik.Windows.Controls.Navigation.dll" and "Telerik.Windows.Data.dll"
		RadWindow.Confirm("Are you sure?", (s, args) => {
			if (args.DialogResult == true) 
			{
				webCam.IsRecording ^= true;
			}
		}); 
		webCam.IsRecording ^= true;
	}
{{endregion}}

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Snapshots]({%slug radwebcam-features-snapshots%})