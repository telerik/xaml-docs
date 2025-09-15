---
title: Camera Settings Control
page_title: Camera Settings Control
description: This article describes the settings dialog and the CameraSettingsControl of RadWebCam.
slug: radwebcam-features-camera-settings-control
tags: camerasettingscontrol,dialog
published: True
position: 7
---

# Camera Settings Control

The RadWebCam component allows you to control the settings of the connected camera. You can do this using the settings dialog which opens when you press the [Open settings dialog]({%slug radwebcam-visual-structure%}) button.

__Settings dialog__

![{{ site.framework_name }} RadWebCam Settings Dialog](images/radwebcam-features-camera-settings-control-0.png)

>important The changes applied via the settings controls reflect the settings of the camera device. This means that when you close the application, the setting will still apply to the device.

You can also use the `CameraSettingsControl` as a stand alone element.

__Using CameraSettingsControl__
```XAML
	<Grid>
		<Grid.ColumnDefinitions>
			<ColumnDefinition />
			<ColumnDefinition />
		</Grid.ColumnDefinitions>
		<telerik:RadWebCam x:Name="radWebCam" />
		<telerik:CameraSettingsControl WebCam="{Binding ElementName=radWebCam}" Grid.Column="1"/>
	</Grid>
```

## Showing Audio Settings

The `ShowAudioSettings` property allows you to control the addition of the Audio tab inside the settings dialog. Through the included tab you can control the microphone's settings.

>important The Audio tab will automatically appear if a microphone is provided during the initialization of the camera.

__Adding the Audio Tab__
```XAML
	<telerik:CameraSettingsControl WebCam="{Binding ElementName=radWebCam}" ShowAudioSettings="True"/>
```

__Audio Tab__

![{{ site.framework_name }} RadWebCam Audio Tab](images/radwebcam-features-camera-settings-control-1.png)

## See Also  
* [Getting Started]({%slug radwebcam-getting-started%})
* [SnapshotTaken]({%slug radwebcam-events%})
* [Recording Video]({%slug radwebcam-features-recording-video%})
