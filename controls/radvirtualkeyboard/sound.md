---
title: Click Sound
page_title: Key Press Sound | RadVirtualKeyboard WPF
description: Check our &quot;Click Sound&quot; documentation article for the on-screen RadVirtualKeyboard WPF control.
slug: radvirtualkeyboard-sound
tags: sound,click
published: True
position: 5
---

# Click Sound

The keyboard comes with a click sound on key press.

To disable the click sound, set the `IsKeyPressSoundEnabled` property to `False`.

#### __[XAML] Disabling click sound__
{{region radvirtualkeyboard-sound-0}}
	<telerik:RadVirtualKeyboard IsKeyPressSoundEnabled="False" />
{{endregion}}

The sound player that plays the sounds can be accessed or replaced using the `KeySoundPlayer` property of `RadVirtualKeyboard`.

## Using Custom Sound File

To replace the default click sound, initialize a new `DefaultKeySoundPlayer` and provide it with a `Stream` containing a sound file information.

#### __[XAML] Setting custom sound file__
{{region radvirtualkeyboard-sound-1}}
	StreamResourceInfo info = Application.GetResourceStream(new Uri(@"/WpfApplication;component/myClickSoundFile.wav", UriKind.Relative));
	virtualKeyboard.KeySoundPlayer = new DefaultKeySoundPlayer(info.Stream);
{{endregion}}

The `DefaultKeySoundPlayer` uses the .NET native [SoundPlayer](https://docs.microsoft.com/en-us/dotnet/api/system.media.soundplayer?view=dotnet-plat-ext-6.0) class to playback .wav files. 

## Creating Custom Sound Player

The sound playback implementation can be fully replaced by implementing the sound player from scratch. To do so, implement the `IKeySoundPlayer` interface. The following example shows how to implement a very basic key sound player that uses the `SystemSounds.Beep` sound.

#### __[XAML] Implementing custom key sound player__
{{region radvirtualkeyboard-sound-2}}
	public class CustomKeySoundPlayer : IKeySoundPlayer
    {
        public bool IsSoundEnabled { get; set; }
		
        public void Play(BaseKeyViewModel viewModel)
        {
            if (IsSoundEnabled)
            {
                SystemSounds.Beep.Play();
            }
        }
    }
{{endregion}}

#### __[XAML] Assigning the custom key sound player__
{{region radvirtualkeyboard-sound-3}}
	public Example()
	{
		InitializeComponent();
		this.virtualKeyboard.KeySoundPlayer = new CustomKeySoundPlayer();
	}
{{endregion}}

## See Also
* [Getting Started]({%slug radvirtualkeyboard-getting-started%})
* [Customize Keys]({%slug radvirtualkeyboard-customize-keys%})
