---
title: Styling the Visual Cue
page_title: Styling the Visual Cue
description: Styling the Visual Cue
slug: raddocking-styling-the-visual-cue
tags: styling,the,visual,cue
published: True
position: 7
---

# Styling the Visual Cue



## 

The dropping area that you see, when rearranging the containers in the __RadDocking__ control, is represented by the __VisualCue__ control. Therefore you can't directly create a style for it in Expression Blend and you have to use a dummy control to create the style.

Open your __RadDocking__project in Expression Blend and select the __RadDocking__you want to modify. On the same scene you should place a __VisualCue__ control, that will be used as a dummy. To do so choose the Assets tab. From the 'Controls -> All' section select the __VisualCue__ control:




         
      ![](images/RadDocking_StylingVisualCue_01.png)

With your mouse create a new instance of the control on the scene:




         
      ![](images/RadDocking_StylingVisualCue_02.png)

>After drawing the __VisualCue__, you won't be able to see it on the scene.

Now select the newly created control. Then select Object -> *Edit Style -> Edit a Copy. *You will be prompted for the name of the style and where to be placed within your application.

>tipIf you choose to define the style in Application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

After clicking OK, a style for your __VisualCue__ control will be created and the properties that can be set through it will be loaded in the 'Properties' pane. {% if site.site_name == 'Silverlight' %}

Go to the 'Resources' pane and see the resources generated for your style. {% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadDocking_StylingVisualCue_05.png){% endif %}{% if site.site_name == 'Silverlight' %}

* __Compass_VisualCue_Background__ - is a brush representing the controls's background color.

* __Compass_VisualCue_BorderBrush__ - is the border brush used by the control.

* __Compass_VisualCue_BorderThickness__ - is the thickness of the border brush used by the control.

* __VisualCueStyle__ - represents the control's style. {% endif %}{% if site.site_name == 'Silverlight' %}

Here is an example of the above resources modified:{% endif %}{% if site.site_name == 'Silverlight' %}




         
      ![](images/RadDocking_StylingVisualCue_06.png){% endif %}{% if site.site_name == 'WPF' %}

Select the __Background__ property and change its value. This will change the color of the __VisualCue__.{% endif %}{% if site.site_name == 'WPF' %}




         
      ![](images/RadDocking_StylingVisualCue_05_06_WPF.png){% endif %}{% if site.site_name == 'WPF' %}

Select the __BorderBrush__ property and change its value. This will change the color of the border of the __VisualCue__.{% endif %}{% if site.site_name == 'WPF' %}




         
      ![](images/RadDocking_StylingVisualCue_07_08_WPF.png){% endif %}

After finishing with your modifications, remove the dummy control and set the style to the __RadDocking__'s __VisualCueStyle__ property.

#### __XAML__

{{region raddocking-styling-the-visual-cue_0}}
	<telerik:RadDocking x:Name="radDocking"
	                         VisualCueStyle="{StaticResource VisualCueStyle}">
	    ...
	</telerik:RadDocking>
	{{endregion}}



Here is a snapshot of the final result.




         
      ![](images/RadDocking_StylingVisualCue_09.png)

# See Also

 * [Styling and Appearance - Overview]({%slug raddocking-styling-overview%})

 * [Compass]({%slug raddocking-features-compass%})

 * [Drag and Drop]({%slug raddocking-features-drag-and-drop%})

 * [Styling the Compass]({%slug raddocking-styling-the-compass%})

 * [Styling the RootCompass]({%slug raddocking-styling-the-root-compass%})
