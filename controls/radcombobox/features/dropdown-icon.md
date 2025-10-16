---
title: Drop-Down Button Icon
page_title: Drop-Down Button Icon
description: Modifying the drop-down button icon of the RadComboBox control.
slug: radcombobox-features-dropdown-icon
tags: dropdown button icon, combobox button icon
published: True
position: 10
---

# Drop-Down Button Icon

The __DropDownButtonIconContent__ and the __DropDownButtonIconContentTemplate__ properties allow you to customize the drop-down button icon of the __RadComboBox__ control.

* __DropDownButtonIconContent__: Gets or sets the content of the show dialog button.

* __DropDownButtonIconContentTemplate__: Gets or sets the content template of the show dialog button.

{% if site.site_name == 'WPF' %}
## Using RadGlyphs

The __DropDownButtonIconContent__ and __DropDownButtonIconContentTemplate__ properties are fully compatible with our [RadGlyph]({%slug common-styling-appearance-radglyph%}) control. The following example shows how to set a RadGlyph as a drop-down button icon. 

__Example 1: Setting a RadGlyph as Drop-Down Button Icon__
```XAML
        <telerik:RadComboBox DropDownButtonIconContent="&#xe010;">
            <telerik:RadComboBox.DropDownButtonIconTemplate>
                <DataTemplate>
                    <telerik:RadGlyph Glyph="{Binding}" />
                </DataTemplate>
            </telerik:RadComboBox.DropDownButtonIconTemplate>
            <telerik:RadComboBoxItem Content="Item 1" />
            <telerik:RadComboBoxItem Content="Item 2" />
        </telerik:RadComboBox>
```

{% else %}
## Using Images

The __DropDownButtonIconContent__ and __DropDownButtonIconContentTemplate__ properties are fully compatible with the Image control. The following example shows how to set an Image as a drop-down button icon. 

__Example 1: Setting a Image as Drop-Down Button Icon__
```XAML
        <telerik:RadComboBox DropDownButtonIconContent="myImage.png">
            <telerik:RadComboBox.DropDownButtonIconTemplate>
                <DataTemplate>
                    <Image Source="{Binding}" />
                </DataTemplate>
            </telerik:RadComboBox.DropDownButtonIconTemplate>
            <telerik:RadComboBoxItem Content="Item 1" />
            <telerik:RadComboBoxItem Content="Item 2" />
        </telerik:RadComboBox>
```
{% endif %}

#### Figure 1: RadComboBox with customized dropdown icon
![RadComboBox with RadGlyph as dropdown icon](images/radcombobox-features-dropdown-button-icon-0.PNG)

## See Also
 * [Selection Box Template]({%slug radcombobox-populating-with-data-selectionbox%})
