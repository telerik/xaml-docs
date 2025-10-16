---
title: Sound
page_title: Sound
description: Check our &quot;Sound&quot; documentation article for the RadDesktopAlert {{ site.framework_name }} control.
slug: raddesktopalert-sound
tags: play, sound
published: True
position: 9
---

# Sound

RadDesktopAlert allows you to play a sound when the alert is shown.

To enable this, set the __Sound__ property of RadDesktopAlert. The property of type [SystemSound](https://docs.microsoft.com/en-us/dotnet/api/system.media.systemsound?view=netframework-4.5) and expects one of the default sounds coming from the [SystemSounds](https://docs.microsoft.com/en-us/dotnet/api/system.media.systemsounds?view=netframework-4.5) class.

__Example 1: Show desktop alert with sound__
```C#
	void ShowAlert()
	{
		var alert = new RadDesktopAlert();
		alert.Header = "MAIL NOTIFICATION";
		alert.ShowDuration = 3000;
		alert.Sound = System.Media.SystemSounds.Beep;

		RadDesktopAlertManager manager = new RadDesktopAlertManager();
		manager.ShowAlert(alert);
	}
```

Additionally, you can implement logic that plays a custom sound by overridding the __PlaySound__ method of RadDesktopAlert.

__Example 2: Play custom sound__
```C#
	public class CustomDesktopAlert : RadDesktopAlert
    {
        protected override void PlaySound()
        {
            string soundFilePath = "../../mySound.wav";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundFilePath);
            player.Load();
            player.Play();
        }
    }
```

## See Also  
 * [Overview]({%slug raddesktopalert-overview%}) 
 * [Getting Started]({%slug raddesktopalert-getting-started%})
