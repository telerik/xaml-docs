---
title: Style The Application Button
page_title: Style The Application Button
description: Style The Application Button
slug: radribbonview-howto-style-app-button
tags: style,the,application,button
published: True
position: 11
---

# Style The Application Button

The default look of the application button is an empty rectangular button similar to the one on the next snapshot:
![Rad Ribbon View How To Style The Application Button 02](images/RadRibbonView_HowTo_StyleTheApplicationButton_02.png)

When you want to set a picture in this button you can use the __ApplicationButtonImageSource__ property. The result may look like this		

#### __XAML__

{{region radribbonview-howto-style-app-button_0}}
	<telerik:RadRibbonView x:Name="xRibbonView" ApplicationButtonImageSource="Images/3dRedButton.png">
		...
	</telerik:RadRibbonView>
{{endregion}}

![Rad Ribbon View How To Style The Application Button](images/RadRibbonView_HowTo_StyleTheApplicationButton.png)

Also for further customization you can set the following properties:		
* ApplicationButtonContent
* ApplicationButtonStyle
* ApplicationButtonVisibility
* IsApplicationButtonEnabled