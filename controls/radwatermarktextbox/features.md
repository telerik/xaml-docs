---
title: Features
page_title: Features
description: This article lists the most important features of the RadWatermarkTextBox.
slug: radwatermarktextbox-features
tags: features
published: True
position: 2
---

# Features

The most important properties of the __RadWatermarkTextBox__ control are:      

* __WatermarkContent:__ Gets or sets the content to be shown when the TextBox is empty and not focused.

* __WatermarkTemplate:__ Gets or sets the template for presenting the content, shown when the TextBox is empty and not focused.

* __CurrentText:__ Gets or sets the text of the TextBox. This property is meant to be used for TwoWay binding in order to be updated on each change of the text and not when the focus is lost.

* __IsWatermarkVisible:__ A read-only property indicating whether the Watermark is visible or not.

* __SelectionOnFocus:__ Specifies the modification over the selection when the control receives focus. The values for this properties are predefined in the __SelectionOnFocus__ enumeration, which exposes the following fields:

	* __Unchanged:__ Selection will not be modified.

	* __SelectAll:__ The whole text will be selected.

	* __CaretToBeginning:__ The caret will be moved at the start of the text.

	* __CaretToEnd:__ The caret will be moved at the end of the text.

* __AdditionalContent:__ Gets or sets an object which is rendered in ContentPresenter in the right part of the control. Implemented in __R3 2019__.

* __AdditionalContentTemplate:__ Gets or sets the System.Windows.DataTemplate used for the AdditionalContent object. Implemented in __R3 2019__.

>tipThe __RadWatermarkTextBox__ control is part of the __Telerik.Windows.Controls.dll__ assembly.

## Using the WatermarkContent Property

In scenarios, where you want to show custom content, when an empty string is entered, you need to use the __WatermarkContent__ property.

In the following example, the user is asked to enter four digits:

#### __[XAML] Example 1: Setting the WatermarkContent property__

{{region xaml-radwatermarktextbox-features_0}}
	<telerik:RadWatermarkTextBox x:Name="radWatermarkTextBox" WatermarkContent="Please Enter Four Digits:" />
{{endregion}}

{% figure 1, "RadWatermarkTextBox with watermark text", "radwatermarktextbox_overview_010.png" %}

The __WatermarkContent__ property is of type object. Which means that you can set anything you want. For example:

#### __[XAML] Example 2: Defining custom content for the WatermarkContent property__

{{region xaml-radwatermarktextbox-features_1}}
	<telerik:RadWatermarkTextBox x:Name="radWatermarkTextBox1">
	    <telerik:RadWatermarkTextBox.WatermarkContent>
	        <StackPanel Orientation="Horizontal">
	            <Image Source="/Silverlight.Help.RadMaskedTextBox;component/Images/EURFlag.png" />
	            <TextBlock Margin="3,0,0,0" Text="Please Enter Four Digits" />
	        </StackPanel>
	    </telerik:RadWatermarkTextBox.WatermarkContent>
	</telerik:RadWatermarkTextBox>
{{endregion}}

{% figure 2, "RadWatermarkTextBox with custom watermark content", "radwatermarktextbox_overview_020.png" %}

## Using WatermarkTemplate Property

Similarly, you can use the __WatermarkTemplate__ property for the same sort of scenarios. Note that in this case you should define a new __DataTemplate__ for the __WatermarkTemplate__ property.

#### __[XAML] Example 3: Defining the WatermarkTemplate__

{{region xaml-radwatermarktextbox-features_2}}
	<telerik:RadWatermarkTextBox x:Name="radWatermarkTextBox2">
	    <telerik:RadWatermarkTextBox.WatermarkTemplate>
	        <DataTemplate>
	            <StackPanel Orientation="Horizontal">
	                <Image Source="/Silverlight.Help.RadMaskedTextBox;component/Images/EURFlag.png" />
	                <TextBlock Margin="3,0,0,0" Text="Please Enter Four Digits" />
	            </StackPanel>
	        </DataTemplate>
	    </telerik:RadWatermarkTextBox.WatermarkTemplate>
	</telerik:RadWatermarkTextBox>
{{endregion}}

{% figure 3, "RadWatermarkTextBox with custom WatermarkTemplate", "radwatermarktextbox_overview_030.png" %}

## Setting the SelectionOnFocus Property

The __SelectionOnFocus__ property of __RadWatermarkTextBox__ allows you to specify what will happen with the cursor when the control gets focus. In the following example the __SelectionOnFocus__ property is set to __SelectAll__. Once the __RadWatermarkTextBox__ gets focused, it will select its whole text.

#### __[XAML] Example 4: Setting the SelectionOnFocus property__

{{region xaml-radwatermarktextbox-features_3}}
	<telerik:RadWatermarkTextBox x:Name="radWatermarkTextBox3" 
	                             SelectionOnFocus="SelectAll"
	                             WatermarkContent="Please Enter Four Digits:" />
{{endregion}}

## WatermarkBehavior

__WatermarkBehavior__ is an enumeration property which specifies when the watermark content of __RadWatermarkTextBox__ will be hidden.  It could receive the following values:

* __HiddenWhenFocused__ - The watermark will be hidden when the RadWatermarkTextBox receives focus
* __HideOnClick__ - The watermark will be hidden when the the user clicks on the RadWatermarkTextBox
* __HideOnTextEntered__ - The watermark will be hidden when the the user writes text into the RadWatermarkTextBox

The default value is __HiddenWhenFocused__.

## ReadOnlyBackground and DisabledBackground

As of R1 2019, the __RadWatermarkTextBox__ control exposes two new properties to set its background when it is disabled or read-only, namely **DisabledBackground** and **ReadOnlyBackground** respectively.

Examples 5 and 6 demonstrate how to set these properties in XAML and figures 4 and 5 illustrate the respective results in the **Office2016** theme.

#### __[XAML] Example 5: Setting the DisabledBackground property__

{{region xaml-radwatermarktextbox-features_4}}
        <telerik:RadWatermarkTextBox WatermarkContent="Please Enter Four Digits:" IsEnabled="False" DisabledBackground="DarkGray" />
{{endregion}}

{% figure 4, "Disabled RadWatermarkTextBox with and without DisabledBackground", "DisabledBackground.png" %}

#### __[XAML] Example 6: Setting the ReadOnlyBackground property__

{{region xaml-radwatermarktextbox-features_5}}
        <telerik:RadWatermarkTextBox WatermarkContent="Please Enter Four Digits:" IsReadOnly="True" ReadOnlyBackground="DarkGray" />
{{endregion}}

{% figure 5, "Read-only RadWatermarkTextBox with and without ReadOnlyBackground", "ReadOnlyBackground.png" %}

>Please note that the read-only visual is drawn over the disabled visual so the ReadOnlyBackground will take precedence over the DisabledBackground if the control is in both the disabled and read-only states.

## Clear Command

As of R3 2019, a __Clear__ command was introduced in the __RadWatermarkTextBoxCommands__ class, which clears the content of the textbox. 

#### __[XAML] Example 7: Using the Clear Command__
{{region xaml-radwatermarktextbox-features_6}}
	<StackPanel>
        <telerik:RadWatermarkTextBox x:Name="watermarkTextBox" />

        <telerik:RadButton Command="telerik:RadWatermarkTextBoxCommands.Clear"
                           CommandTarget="{Binding ElementName=watermarkTextBox}">
            <telerik:RadGlyph Glyph="&#xe11b;"  />
        </telerik:RadButton>
    </StackPanel>
{{endregion}}

## AdditionalContent and AdditionalContentTemplate

As of R3 2019, the __RadWatermarkTextBox__ control exposes two new properties, which allow for displaying additional content on its right side. Those are __AdditionalContent__ and __AdditionalContentTemplate__. __Example 8__ demonstrates the __AdditionalContent__ property along with the __Clear__ command.

#### __[XAML] Example 8: Setting the AdditionalContent property__
{{region xaml-radwatermarktextbox-features_7}}
	<telerik:RadWatermarkTextBox>
		<telerik:RadWatermarkTextBox.AdditionalContent>
			<telerik:RadButton Focusable="False"
							   IsBackgroundVisible="False"
							   Command="telerik:RadWatermarkTextBoxCommands.Clear"
							   CommandTarget="{Binding ElementName=watermarkTextBox}">
				<telerik:RadGlyph Glyph="&#xe11b;"  />
			</telerik:RadButton>
		</telerik:RadWatermarkTextBox.AdditionalContent>
	</telerik:RadWatermarkTextBox>
{{endregion}}

## See also

* [Overview]({%slug radwatermarktextbox-overview%})
