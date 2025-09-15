---
title: Commands
page_title: Commands
description: The actions in the UI of RadWebCam control are executed via commands from the RadWebCamCommands static class. 
slug: radwebcam-features-commands
tags: commands, radwebcamcommands
published: True
position: 6
---

# Commands

The actions in the UI of the `RadWebCam` control are executed via commands. To access them use the `RadWebCamCommands` static class. 

The following commands are available:

* `TakeSnapshot`&mdash;Takes a snapshot of the video feed. 
* `SaveSnapshot`&mdash;Fires the SnapshotTaken event where you can save the BitmapSource object.
* `DiscardSnapshot`&mdash;Discards the snapshot.
* `ToggleRecording`&mdash;Toggles the video recording.
* `ShowSettingsDialog`&mdash;Shows the settings dialog that allows you to adjust the camera options.
* `Start`&mdash;Starts displaying the video feed from the camera.
* `Stop`&mdash;Stops displaying the video feed from the camera.

You can use the commands outside of the RadWebCam control or modify their default behavior.

## Using Commands Manually

The RadWebCamCommands can be attached to a button or another element supporting commands which is defined outside of the RadWebCam control.

__Use RadWebCamCommands__
```XAML
	<telerik:RadWebCam x:Name="radWebCam" />
	<telerik:RadButton Command="telerik:RadWebCamCommands.TakeSnapshot"  CommandTarget="{Binding ElementName=radWebCam}"/>
```

## Modifying Command Behavior

The RadWebCamCommands uses RoutedUICommands, which means that you can override their behavior as any other [RoutedUICommand](https://docs.microsoft.com/en-us/dotnet/api/system.windows.input.routeduicommand?view=netframework-4.7.2).

__Override the ToggleRecording command__
```C#
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
```

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [Events]({%slug radwebcam-events%})
* [Recording Video]({%slug radwebcam-features-recording-video%})