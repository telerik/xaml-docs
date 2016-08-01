---
title: Disable the MouseWheel
page_title: Disable the MouseWheel
description: Disable the MouseWheel
slug: coverflow-disable-mousewheel
tags: disable,the,mousewheel
published: True
position: 4
---

# Disable the MouseWheel

There is no property that disables the mouse wheel in RadCoverFlow, but you could inherit the control and override the OnMouseWheel method, without calling base:

#### __C#__

{{region cs-coverflow-disable-mousewheel_0}}
	public class CoverFlow : RadCoverFlow
	{
		protected override void OnMouseWheel(System.Windows.Input.MouseWheelEventArgs e)
		{
			//base.OnMouseWheel(e);
		}
	}
{{endregion}}

Then use the new control in XAML:

#### __XAML__

{{region xaml-coverflow-disable-mousewheel_1}}
	<local:CoverFlow>
	       <Rectangle Fill="Red" Width="200" Height="200" />
	       <Rectangle Fill="Green" Width="200" Height="200" />
	       <Rectangle Fill="Blue" Width="200" Height="200" />
	       <Rectangle Fill="Magenta" Width="200" Height="200" />
	</local:CoverFlow>
{{endregion}}


