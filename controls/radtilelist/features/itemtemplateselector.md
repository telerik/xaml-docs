---
title: ItemTemplateSelector
page_title: ItemTemplateSelector
description: ItemTemplateSelector
slug: radtilelist-itemtemplateselector
tags: itemtemplateselector
published: True
position: 1
---

# ItemTemplateSelector

This article will show you how to conditionally apply a different data template to __RadTileList__ tiles using the __ItemTemplateSelector__ property.      
      

Assume we have a __RadGridView__ bound to a collection of clubs. Each club has a property __StadiumCapacity__.  What we want to achieve is to apply one data template if the capacity is greater than 50 000 and another otherwise:
      

![Rad Tile List Item Template Selector](images/RadTileList_ItemTemplateSelector.png)

To do so follow these steps:
      

1. Create a new class which inherits the __DataTemplateSelector__ class (which resides in the System.Windows.Controls assembly).
      

2. Override its __SelectTemplate method__. Based on your conditions - you return the proper __DataTemplate__ that will be applied to the framework element (a tile in our case).
      

#### __[C#] Example 1: Defining the ItemTemplateSelector__

{{region cs-radtilelist-itemtemplateselector_0}}
	public class MyTileTemplateSelector : DataTemplateSelector
	{
	    public override System.Windows.DataTemplate SelectTemplate(object item, System.Windows.DependencyObject container)
	    {
	        if (item is Club)
	        {
	            Club club = item as Club;
	            if (club.StadiumCapacity > 50000)
	            {
	                return BigStadium;
	            }
	            else
	            {
	                return SmallStadium;
	            }
	        }
	        return null;
	    }
	    public DataTemplate BigStadium { get; set; }
	    public DataTemplate SmallStadium { get; set; }
	}
{{endregion}}



In this case we have two different __DataTemplates__ that could be applied - __BigStadium__ and __SmallStadium__. Depending on the underlying data we choose / select which template to apply.
      

3. In the XAML file define the template selector as a resource and set the properties of the __BigStadium__ and __SmallStadium__:
      

#### __[XAML] Example: Defining the ItemTemplateSelector as a Resource in XAML__

{{region xaml-radtilelist-itemtemplateselector-1}}
	<Grid.Resources>
	  <my:MyTileTemplateSelector x:Key="myTileTemplateSelector">
	    <my:MyTileTemplateSelector.BigStadium>
	      <DataTemplate>
	        <Grid Background="Green">
	          <Grid.RowDefinitions>
	            <RowDefinition />
	            <RowDefinition />
	          </Grid.RowDefinitions>
	          <Grid.ColumnDefinitions>
	            <ColumnDefinition/>
	            <ColumnDefinition/>
	          </Grid.ColumnDefinitions>
	          <TextBlock Grid.Row="0" Grid.Column="0" Text="First Name"/>
	          <TextBlock Grid.Row="0" Grid.Column="1" Text="{Binding Name}" />
	          <TextBlock Grid.Row="1" Grid.Column="0" Text="Stadium Capacity"/>
	          <TextBlock Grid.Row="1" Grid.Column="1" Text="{Binding StadiumCapacity}" />
	        </Grid>
	      </DataTemplate>
	    </my:MyTileTemplateSelector.BigStadium>
	    <my:MyTileTemplateSelector.SmallStadium>
	      <DataTemplate>
	        <Grid Background="Red">
	          <Grid.RowDefinitions>
	            <RowDefinition />
	            <RowDefinition />
	          </Grid.RowDefinitions>
	          <Grid.ColumnDefinitions>
	            <ColumnDefinition/>
	            <ColumnDefinition/>
	          </Grid.ColumnDefinitions>
	          <TextBlock Grid.Row="0" Grid.Column="0" Text="First Name"/>
	          <TextBlock Grid.Row="0" Grid.Column="1" Text="{Binding Name}" />
	          <TextBlock Grid.Row="1" Grid.Column="0" Text="Stadium Capacity"/>
	          <TextBlock Grid.Row="1" Grid.Column="1" Text="{Binding StadiumCapacity}" />
	        </Grid>
	      </DataTemplate>
	    </my:MyTileTemplateSelector.SmallStadium>
	  </my:MyTileTemplateSelector>
	</Grid.Resources>
{{endregion}}



4. Finally, set the __ItemTemplateSelector__ property of __RadTileList__:
      

#### __[XAML] Example 3: Applying the ItemTemplateSelector__

{{region xaml-radtilelist-itemtemplateselector-2}}
	<telerik:RadTileList  x:Name="RadTileList"
	                      ItemTemplateSelector="{StaticResource myTileTemplateSelector}"
	                      ItemsSource="{Binding Clubs}"/>
{{endregion}}


