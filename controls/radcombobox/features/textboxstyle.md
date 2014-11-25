---
title: TextBoxStyle
page_title: TextBoxStyle
description: TextBoxStyle
slug: radcombobox-features-textboxstyle
tags: textboxstyle
published: True
position: 9
---

# TextBoxStyle
The new __TextBoxStyle__ property, introduced with the Q2 2014 release version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}, makes it really easy to customize the TextBox part of __RadComboBox__ when it is in editable mode. The purpose of this article is to show you how to apply a custom __TextBoxStyle__.

## Applying custom TextBoxStyle

Let's start with the following editable __RadComboBox__ definition with an ItemsSource bound to a collection of custom business objects:

#### __XAML__

{{region radcombobox-features-textboxstyle_1}}
	<telerik:RadComboBox ItemsSource="{Binding Agencies}" DisplayMemberPath="Name" IsEditable="True" />
{{endregion}}

__RadComboBox__ will look as shown on __Figure 1__.

Figure 1: RadComboBox without custom TextBoxStyle applied.
![Rad Combo Box Features Text Box Style 01](images/RadComboBox_Features_TextBoxStyle_01.png)

Now you will have to create a custom Style with TargetType TextBox which customizes the desired properties of the TextBox part of __RadComboBox__:

#### __XAML__

{{region radcombobox-features-textboxstyle_2}}
	<UserControl.Resources>
		<Style TargetType="TextBox" x:Key="CustomComboTextBoxStyle">
			<Setter Property="Foreground" Value="Yellow" />
			<Setter Property="Background" Value="LightBlue" />
			<Setter Property="FontFamily" Value="Calibri" />
			<Setter Property="FontSize" Value="16" />
			<Setter Property="BorderThickness" Value="0" />
			<Setter Property="BorderBrush" Value="Transparent" />
		</Style>
	</UserControl.Resources>
{{endregion}}

If you are using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) to style the controls, you would need to base that Style to the default __TextBoxStyle__ of __RadComboBox__ named _ComboBoxTextBoxStyle_.

#### __XAML__

{{region radcombobox-features-textboxstyle_4}}
	<Style TargetType="TextBox" x:Key="CustomComboTextBoxStyle" BasedOn="{StaticResource ComboBoxTextBoxStyle}">
		...
	</Style>
{{endregion}}

The last step would be to simply set the custom style as __TextBoxStyle__ of __RadComboBox__:

#### __XAML__

{{region radcombobox-features-textboxstyle_3}}
	<telerik:RadComboBox ItemsSource="{Binding Agencies}" DisplayMemberPath="Name" IsEditable="True"
	                     TextBoxStyle="{StaticResource CustomComboTextBoxStyle}" />
{{endregion}}

You can see the final result on __Figure 2__.

Figure 2: RadComboBox with custom TextBoxStyle applied.
![Rad Combo Box Features Text Box Style 02](images/RadComboBox_Features_TextBoxStyle_02.png)

# See Also

 * [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%})

 * [SelectionBoxTemplate]({%slug radcombobox-populating-with-data-selectionbox%})

 * [Binding to Object]({%slug radcombobox-populating-with-data-binding-to-object%})
