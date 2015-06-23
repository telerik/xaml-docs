---
title: Key Properties
page_title: Key Properties
description: Key Properties
slug: raddesktopalert-features-key-properties
tags: properties,features,key,properties
published: True
position: 3
---

# Key Properties

The purpose of this help article is to show you the key properties of __RadDesktopAlert__ control. The topic includes the following properties:

* [Header](#header)

* [Content](#content)

* [ShowDuration](#showduration)

* [Icon](#icon)

* [IconColumnWidth](#iconcolumnwidth)

* [IconMargin](#iconmargin)

* [Command](#command)

## Header

The __Header__ property is used to set the header content of __RadDesktopAlert__. The __Header__ is of type object, so by applying a custom __HeaderTemplate__ as well any desired content can be visualized.

#### __[C#]  Setting Header__

{{region raddesktopalert-features-key-properties_0}}
	var alert = new RadDesktopAlert();
	alert.Header = "Mail Notification";
{{endregion}}

#### __[VB]  Setting Header__

{{region raddesktopalert-features-key-properties_0}}
	Dim alert = New RadDesktopAlert()
	alert.Header = "Mail Notification"
{{endregion}}

## Content

Using the __Content__ property the inner content of __RadDesktopAlert__ could easily be set. The __Content__ property is of type object, so any content can be visualized by applying a custom __ContentTemplate__. 

#### __[C#]  Setting Content__

{{region raddesktopalert-features-key-properties_1}}
	alert.Content = "Hello, Here are two things that we noticed today on our front-end meeting";
{{endregion}}

#### __[VB]  Setting Content__

{{region raddesktopalert-features-key-properties_1}}
	alert.Content = "Hello, Here are two things that we noticed today on our front-end meeting"
{{endregion}}

## ShowDuration

The duration of the visualization of __RadDesktopAlert__ is determined by the __ShowDuration__ property of the control. It is of type integer and represents the amount of milliseconds after which the alert automatically closes. The default value of the property is 5000.

#### __[C#]  Setting ShowDuration__

{{region raddesktopalert-features-key-properties_2}}
	alert.ShowDuration = 3000;
{{endregion}}

#### __[VB]  Setting ShowDuration__

{{region raddesktopalert-features-key-properties_2}}
	alert.ShowDuration = 3000
{{endregion}}

## Icon

In order to display an icon inside __RadDesktopAlert__ the __Icon__ property should be set. It is of type object, so any content can be visualized by applying a custom __IconTemplate__ as well. The following example demonstrates how to show the built in icon image of the currently used theme:

#### __[C#]  Setting Icon__
{{region raddesktopalert-features-key-properties_3}}
	alert.Icon = new Image { Source = Application.Current.FindResource("DesktopAlertIcon") as ImageSource, Width = 48, Height = 48 };
{{endregion}}

#### __[VB]  Setting Icon__

{{region raddesktopalert-features-key-properties_3}}
	alert.Icon = New Image() With { _Key .Source = TryCast(Application.Current.FindResource("DesktopAlertIcon"), ImageSource), _Key .Width = 48, _Key .Height = 48 _}
{{endregion}}

## IconColumnWidth

Using the __IconColumnWidth__ property you could easily set the Width of the column that contains the icon. The default value is double.NaN, so the property needs to be set always to the needed value if an icon is used.

#### __[C#]  Setting IconColumnWidth__

{{region raddesktopalert-features-key-properties_4}}
	alert.IconColumnWidth = 75;
{{endregion}}

#### __[VB]  Setting IconColumnWidth__

{{region raddesktopalert-features-key-properties_4}}
	alert.IconColumnWidth = 75
{{endregion}}

## IconMargin

The __IconMargin__ property is a specific property of __RadDesktopAlert__ that is used to set a Margin around the control's icon. By default there aren't any margins applied.
 
#### __[C#]  Setting IconMargin__

{{region raddesktopalert-features-key-properties_5}}
	alert.IconMargin = new Thickness(0, 0 , 10, 10);
{{endregion}}

#### __[VB]  Setting IconMargin__

{{region raddesktopalert-features-key-properties_5}}
	alert.IconMargin = New Thickness(0, 0, 10, 10)
{{endregion}}

## Command

__RadDesktopAlert__ provides you with a command property. This means you can bind the alert to a command that will be executed when it gets clicked.

#### __[C#]  Setting Command__

{{region raddesktopalert-features-key-properties_6}}
	alert.Command = new DelegateCommand(OnCommandExecuted);
	
	private void OnCommandExecuted(object obj)
    {
        MessageBox.Show("Command");
    }
{{endregion}}

#### __[VB]  Setting Command__

{{region raddesktopalert-features-key-properties_6}}
	alert.Command = New DelegateCommand(OnCommandExecuted)
	
	Private Sub OnCommandExecuted(obj As Object)
		MessageBox.Show("Command")
	End Sub
{{endregion}}

# See Also

 * [Overview]({%slug raddesktopalert-overview%})

 * [Getting Started]({%slug raddesktopalert-getting-started%})