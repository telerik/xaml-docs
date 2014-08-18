---
title: Customizing the DropDownItemTemplate
page_title: Customizing the DropDownItemTemplate
description: Customizing the DropDownItemTemplate
{{slug: radautocompletebox-customizing-drop-down-itemtemplate}}
tags: customizing,the,dropdownitemtemplate
publish: True
ordinal: 0
---


In the __RadAutoCompleteBox__ control you can customize the way items are rendered in the DropDown portion of the control.
      

By customizing the __DropDownItemTemplate__ of the control you can easily show different template for the items in the DropDown portion of the control.
      

## Creating custom DropDownItemTemplate

The next example will demonstrate how to create a custom DropDownItemTemplate in order to show two of the properties of the bound items from the ItemsSource collection.
        

>Before proceeding with this example you should get familiar with [Binding To Object]({%slug radautocompletebox-populating-with-data-binding-to-object%}).
          

The next steps show how to create and set a custom DropDownItemTemplate to the RadAutoCompleteBox control:
        

1. First we will need to create and populate the __ViewModel__ with some sample data, more details can be found [here]({%slug radautocompletebox-populating-with-data-binding-to-object%}).
            

1. Next we need to create a valid __DataTemplate__ and set the necessary binding for the __Name__, __Capital__ properties of the ItemsSource items:
            

## XAML

{{region radautocompletebox-customizing-drop-down-itemtemplate-0}}
	<DataTemplate x:Key="CustomDropDownItemTemplate">
		<Border BorderBrush="Gray" BorderThickness="1" Margin="2">
			<Grid>
				<Grid.ColumnDefinitions>
					<ColumnDefinition Width="Auto"/>
					<ColumnDefinition Width="Auto"/>
					<ColumnDefinition Width="*"/>
				</Grid.ColumnDefinitions>
				<Grid.RowDefinitions>
					<RowDefinition/>
					<RowDefinition/>
					<RowDefinition/>
				</Grid.RowDefinitions>
				<TextBlock Grid.Column="0" Grid.Row="0"
							Margin="5"
							FontWeight="Bold"
							Text="Name" />
				<TextBlock Grid.Row="0" Grid.Column="1" Margin="0 5 0 0"
							Text=":"
							FontWeight="Bold"/>
				<TextBlock Grid.Column="2" Grid.Row="0" Margin="5"
							Text="{Binding Name}" />
				<Border BorderBrush="Gray" BorderThickness="0.5" Grid.Row="1" Grid.Column="0" Grid.ColumnSpan="3"/>
				<TextBlock Grid.Column="0" Grid.Row="2" Margin="5"
							FontWeight="Bold"
							Text="Capital" />
				<TextBlock Grid.Row="2" Grid.Column="1" Margin="0 5 0 0"
							Text=":"
							FontWeight="Bold"/>
				<TextBlock Grid.Column="2" Grid.Row="2" Margin="5"
							Text="{Binding Capital}" />
			</Grid>
		</Border>
	</DataTemplate>
	{{endregion}}



1. Finally you will need to declare the __RadAutoCompleteBox__ in the xaml and set its __ItemsSource__, __DisplayMemberPath__ and __DropDownItemTemplate__ properties:
            

## XAML

{{region radautocompletebox-customizing-drop-down-itemtemplate-1}}
	<telerik:RadAutoCompleteBox ItemsSource="{Binding Countries}"
								Width="200"
								DisplayMemberPath="Name"
								DropDownItemTemplate="{StaticResource CustomDropDownItemTemplate}"/>
	{{endregion}}



The next screenshots show the final result:
        ![radautocompletebox-customizing-drop-down-itemtemplate-1](images/radautocompletebox-customizing-drop-down-itemtemplate-1.png)![radautocompletebox-customizing-drop-down-itemtemplate-2](images/radautocompletebox-customizing-drop-down-itemtemplate-2.png)![radautocompletebox-customizing-drop-down-itemtemplate-3](images/radautocompletebox-customizing-drop-down-itemtemplate-3.png)

# See Also

 * [Binding To Object]({%slug radautocompletebox-populating-with-data-binding-to-object%})
