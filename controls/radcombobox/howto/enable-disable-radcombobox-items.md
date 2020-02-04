---
title: Enable\Disable RadComboBoxItems
page_title: Enable\Disable RadComboBoxItems
description: Check our "Enable\Disable RadComboBoxItems" documentation article for the RadComboBox WPF control.
slug: radcombobox-howto-enable-disable-radcombobox-items
tags: enable\disable,radcomboboxitems
published: True
position: 6
---

# Enable\Disable RadComboBoxItems

The purpose of this tutorial is to show you how to enable and disable __RadComboBoxItems__. The following sections are included:

* [Enable\disable RadComboBox with static data](#enabledisable-radcombobox-with-static-data)

* [Enable\disable items using ItemContainerStyle](#enabledisable-items-using-itemcontainerstyle)

* [Enable\disable items using ItemContainerStyleSelector](#enabledisable-items-using-itemcontainerstyleselector)

* [Using style binding](#using-style-binding)

## Enable\Disable RadComboBox with Static Data

In the simplest scenario you will have a __RadComboBox__ populated with static data in XAML.

#### __[XAML] Example 1: Populate with static data__

{{region radcombobox-howto-enable-disable-radcombobox-items_0}}
	<telerik:RadComboBox x:Name="radComboBox" Width="200">
	    <telerik:RadComboBoxItem Content="Alapattah"/>
	    <telerik:RadComboBoxItem Content="Brickell Avenue" />
	    <telerik:RadComboBoxItem Content="Downtown Miami" />
	</telerik:RadComboBox>
{{endregion}}

The __RadComboBox__ and __RadComboBoxItem__ classes expose a property named __IsEnabled__. Set this property to __False__, when you want to disable either the whole __RadComboBox__ or specific __RadComboBoxItems__. The next code-snippet shows you how to do that.

#### __[XAML] Example 2: Disabling specific RadComboBoxItems using the IsEnabled property__

{{region radcombobox-howto-enable-disable-radcombobox-items_1}}
	<telerik:RadComboBox x:Name="radComboBox" Width="200">
	    <telerik:RadComboBoxItem Content="Alapattah" IsEnabled="False"/>
	    <telerik:RadComboBoxItem Content="Brickell Avenue" />
	    <telerik:RadComboBoxItem Content="Downtown Miami" IsEnabled="False"/>
	</telerik:RadComboBox>
{{endregion}}

#### __Figure 1: Result of Example 2__
![](images/RadComboBox_HowTo_EnableDisableItems_010.png)

## Enable\Disable Items Using ItemContainerStyle

Using __RadComboBox__ with static data is the simplest scenario. However, in most of the cases you will have a __RadComboBox__ [populated with a collection of business objects]({%slug radcombobox-populating-with-data-binding-to-object%}). In this case you have no other options except for using either the __ItemContainerStyle__ or the __ItemContainerStyleSelector__.

#### __[C#] Example 3: Create a collection of objects__

{{region radcombobox-howto-enable-disable-radcombobox-items_2}}
	public class Item : ViewModelBase
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
{{endregion}}

#### __[C#] Example 4: Create the ViewModel__

{{region radcombobox-howto-enable-disable-radcombobox-items_3}}
	public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Item> items;

        public ObservableCollection<Item> Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = new ObservableCollection<Item>();
                    for (int i = 0; i < 20; i++)
                    {
                        this.items.Add(new Item() { Id = i, Text = "Item " + i });
                    }
                }
                return this.items;
            }
        }
    }
{{endregion}}

#### __[XAML] Example 5: Set the ItemContainerStyle of a RadComboBox__

{{region radcombobox-howto-enable-disable-radcombobox-items_4}}
	<Window.DataContext>
        <local:MainViewModel/>
    </Window.DataContext>
	<UserControl.Resources>
	    <Style x:Key="ItemContainerStyle" TargetType="telerik:RadComboBoxItem">
	        <Setter Property="IsEnabled" Value="False"/>
	    </Style>
	</UserControl.Resources>

	<telerik:RadComboBox x:Name="radComboBox"
		Width="200"
	    ItemsSource="{Binding Items}"
	    DisplayMemberPath="Text"
	    ItemContainerStyle="{StaticResource ItemContainerStyle}"/>
{{endregion}}

Note that in this case all __RadComboBoxItems__ will be disabled. However, you have the ability to determine which items to be disabled based on your custom logic. [Check out](#enabledisable-items-using-itemcontainerstyleselector) the next section to see the solution.

#### __Figure 2: Result of Example 5__
![](images/RadComboBox_HowTo_EnableDisableItems_020.png)

## Enable\Disable Items Using ItemContainerStyleSelector

The __StyleSelector__ provides a way to apply styles based on custom logic.

The next example demonstrates you how to achieve this.

#### __[XAML] Example 6: Create a custom logic class__

{{region radcombobox-howto-enable-disable-radcombobox-items_5}}
	public class EnableDisableSelector : StyleSelector
    {
        public Style EnableStyle { get; set; }
        public Style DisableStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            if ((item as Item).Id % 2 == 1)
                return this.DisableStyle;
            else
                return this.EnableStyle;
        }
    }
{{endregion}}

#### __[XAML] Example 7: Apply styles based on custom logic__

{{region radcombobox-howto-enable-disable-radcombobox-items_6}}
	<UserControl.Resources>
	    <Style x:Key="EnableStyle" TargetType="telerik:RadComboBoxItem">
	        <Setter Property="IsEnabled" Value="True"/>
	    </Style>
	
	    <Style x:Key="DisableStyle" TargetType="telerik:RadComboBoxItem">
	        <Setter Property="IsEnabled" Value="False"/>
	    </Style>
	
	    <example:EnableDisableSelector x:Key="StyleSelector" EnableStyle="{StaticResource EnableStyle}"
	        DisableStyle="{StaticResource DisableStyle}"/>
	</UserControl.Resources>

	<telerik:RadComboBox x:Name="radComboBox"
		Width="200"
	    ItemsSource="{Binding Items}"
	    DisplayMemberPath="Text"
	    ItemContainerStyleSelector="{StaticResource StyleSelector}"/>
{{endregion}}

#### __Figure 3: The result is that every odd item is disabled__

![](images/RadComboBox_HowTo_EnableDisableItems_030.png)

## Using Style Binding

{% if site.site_name == 'WPF' %}
Using __ItemContainerStyle__ is a good solution, however, it is not the best. Imagine that your business object has a boolean property named __IsEnabled__. Even more flexible solution is to directly bind the __RadComboBoxItem__'s __IsEnabled__ property to the __IsEnabled__ property exposed by your domain object. You can do this through __style binding__.
{% endif %}

#### __[XAML] Example 8: Use of style binding__

{{region radcombobox-howto-enable-disable-radcombobox-items_7}}
	<UserControl.Resources>
	    <Style x:Key="ItemContainerStyle" TargetType="{x:Type telerik:RadComboBoxItem}">
	        <Setter Property="IsEnabled" Value="{Binding IsEnabled}"/>
	    </Style>
	</UserControl.Resources>

	<telerik:RadComboBox x:Name="radComboBox"
		Width="200"
	    ItemsSource="{Binding Items}"
	    ItemTemplate="{StaticResource CustomItemTemplate}"
	    ItemContainerStyle="{StaticResource ItemContainerStyle}"/>
{{endregion}}

{% if site.site_name == 'WPF' %}
Two things should be mentioned here. First, note how the __IsEnabled__ property is bound in the __Style__. Second, the declared __Style__ is set as a __ItemContainerStyle__ of the __RadComboBox__. The result is shown on the image below.

#### __Picture 4: Result of Example 5__
![](images/RadComboBox_HowTo_EnableDisableItems_040_WPF.png)
{% endif %}

## See Also  
 * [RadComboBox Virtualization]({%slug radcombobox-howto-virtualization%}) 
 * [Setting up AutoComplete]({%slug radcombobox-setting-up-autocomplete%})
