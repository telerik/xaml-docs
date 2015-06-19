---
title: Key Properties
page_title: Key Properties
description: Key Properties
slug: raddesktopalert-features-key-properties
tags: key,properties
published: True
position: 5
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

The __Header__ property is used to set the header content of __RadDesktopAlert__ that displays textual information.

#### __[C#]  Setting a header__

{{region raddesktopalert-features-key-properties_0}}
	this.alert.Header = "Mail Notification";
{{endregion}}

#### __[VB]  Setting a header__

{{region raddesktopalert-features-key-properties_0}}
	Me.alert.Header = "Mail Notification"
{{endregion}}

## Content

Using the __Content__ property the inner content of __RadDesktopAlert__ could easily be set.

#### __[C#]  Setting Content__

{{region raddesktopalert-features-key-properties_1}}
	this.alert.Content = "Hello, Here are two things that we noticed today on our front-end meeting";
{{endregion}}

#### __[VB]  Setting Content__

{{region raddesktopalert-features-key-properties_1}}
	Me.alert.Content = "Hello, Here are two things that we noticed today on our front-end meeting"
{{endregion}}

## ShowDuration

The duration of the visualization of __RadDesktopAlert__ is determined by the __Duration__ property. It is of type integer and could be set as follows:

#### __[C#]  Setting ShowDuration__

{{region raddesktopalert-features-key-properties_2}}
	this.alert.ShowDuration = 5000;
{{endregion}}

#### __[VB]  Setting ShowDuration__

{{region raddesktopalert-features-key-properties_2}}
	Me.alert.ShowDuration = 5000
{{endregion}}

## Icon

In order to display an icon inside __RadDesktopAlert__ the __Icon__ property should be set.

#### __[C#]  Setting Icon__
{{region raddesktopalert-features-key-properties_3}}
	 this.alert.Icon = new Image { Source = Application.Current.FindResource("DesktopAlertIcon") as ImageSource, Width = 48, Height = 48 };
{{endregion}}

#### __[VB]  Setting ShowDuration__

{{region raddesktopalert-features-key-properties_3}}
	Me.alert.Icon = New Image() With { _Key .Source = TryCast(Application.Current.FindResource("DesktopAlertIcon"), ImageSource), _Key .Width = 48, _Key .Height = 48 _}
{{endregion}}

## IconColumnWidth

Using the __IconColumnWidth__ property you could easily set the Width of the column that contains the icon.

#### __[C#]  Setting IconColumnWidth__

{{region raddesktopalert-features-key-properties_4}}
	this.alert.IconColumnWidth = 75;
{{endregion}}

#### __[VB]  Setting IconColumnWidth__

{{region raddesktopalert-features-key-properties_4}}
	Me.alert.IconColumnWidth = 75
{{endregion}}

## IconMargin

The __IconMargin__ property is a specific property of __RadDesktopAlert__ that is used to set a Margin around the control's icon.
 
#### __[C#]  Setting IconMargin__

{{region raddesktopalert-features-key-properties_5}}
	this.alert.IconMargin = new Thickness(0, 0 , 10, 10);
{{endregion}}

#### __[VB]  Setting IconMargin__

{{region raddesktopalert-features-key-properties_5}}
	Me.alert.IconMargin = New Thickness(0, 0, 10, 10)
{{endregion}}

## Command

__RadDesktopAlert__ provides you with a command property. This means you can bind the alert to a command that will be executed when it gets clicked.

#### __[C#]  Setting Command__

{{region raddesktopalert-features-key-properties_6}}
	this.alert.Command = new DelegateCommand(OnCommandExecuted);
	
	private void OnCommandExecuted(object obj)
    {
        MessageBox.Show("Command");
    }
{{endregion}}

#### __[VB]  Setting Command__

{{region raddesktopalert-features-key-properties_6}}
	Me.alert.Command = New DelegateCommand(OnCommandExecuted)
	
	Private Sub OnCommandExecuted(obj As Object)
		MessageBox.Show("Command")
	End Sub
{{endregion}}

# See Also

 * [Overview]({%slug raddesktopalert-overview%})

 * [Getting Started]({%slug raddesktopalert-getting-started%})