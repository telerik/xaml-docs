---
title: ItemTemplateSelector
page_title: ItemTemplateSelector
description: ItemTemplateSelector
slug: radtilelist-itemtemplateselector
tags: itemtemplateselector
publish: True
position: 1
---

# ItemTemplateSelector



This article will show you how to conditionally apply a different data template to RadTileList tiles using the ItemTemplateSelector property.      
      

Assume we have a gridview bound to a collection of clubs. Each club has a property StadiumCapacity. 
      What we want to achieve is to apply one data template if the capacity is greater than 50 000 and another otherwise:
      

![Rad Tile List Item Template Selector](images/RadTileList_ItemTemplateSelector.png)

To do so follow these steps:
      

1. Create a new class which inherits the DataTemplateSelector class (which resides in the System.Windows.Controls assembly).
      

2. Override its SelectTemplate method. Based on your conditions - you return the proper DataTemplate that will be applied to the framework element (a tile in our case).
      

#### __C#__

{{region radtilelist-itemtemplateselector_0}}
	    public class MyTileTemplateSelector : DataTemplateSelector
	    {
	        public override System.Windows.DataTemplate SelectTemplate(object item, System.Windows.DependencyObject container)
	        {
	            if (item is Club)
	            {
	                Club club = item as Club;
	                if (club.StadiumCapacity > 50000)
	                {
	                    return bigStadium;
	                }
	                else
	                {
	                    return smallStadium;
	                }
	            }
	            return null;
	        }
	        public DataTemplate bigStadium { get; set; }
	        public DataTemplate smallStadium { get; set; }
	    }
	{{endregion}}



In this case we have two different DataTemplates that could be applied - bigStadium and smallStadium. Depending on the underlying data we choose / select which template to apply.
      

3. In the XAML file define the template selector as a resource and set the properties of the bigStadium and smallStadium:
      

#### __XAML__

{{region radtilelist-itemtemplateselector-1}}
	  <my:MyTileTemplateSelector x:Key="myTileTemplateSelector">
	            <my:MyTileTemplateSelector.bigStadium>
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
	            </my:MyTileTemplateSelector.bigStadium>
	            <my:MyTileTemplateSelector.smallStadium>
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
	            </my:MyTileTemplateSelector.smallStadium>
	        </my:MyTileTemplateSelector> 
	{{endregion}}



4. Finally, set the CellTemplateSelector property of the RadTileList:
      

#### __XAML__

{{region radtilelist-itemtemplateselector-2}}
	  <telerik:RadTileList  x:Name="RadTileList" 
	                        ItemTemplateSelector="{StaticResource myTileTemplateSelector}" 
	                        ItemsSource="{Binding Clubs}"
	                        ScrollViewer.HorizontalScrollBarVisibility="Visible"/>
	{{endregion}}


