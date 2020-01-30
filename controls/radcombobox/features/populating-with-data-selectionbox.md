---
title: SelectionBoxTemplate
page_title: SelectionBoxTemplate
description: SelectionBoxTemplate
slug: radcombobox-populating-with-data-selectionbox
tags: selectionboxtemplate
published: True
position: 8
---

# SelectionBoxTemplate

The __SelectionBoxTemplate__ gives you the ability to define a separate template for the selected item of Non-Editable __RadComboBox__. The purpose of this tutorial is to show you how to create and apply __SelectionBoxTemplate__.

>important The __SelectionBoxTemplate__ is used only by the non-editable __RadComboBox__. However, if you want to customize the TextBox part of ab editable __RadComboBox__ you could use the [TextBoxStyle]({%slug radcombobox-features-textboxstyle%}) property.

<!-- -->

>important If you're using a RadComboBox with [multiple selection]({%slug radcombobox-features-multiple-selection%}) you should use the [MultipleSelectionBoxTemplate]({%slug radcombobox-features-multiple-selection%}#multipleselectionboxtemplate) property instead of the __SelectionBoxTemplate__.

## Creating custom DataTemplate for the SelectionBoxTemplate property


To bind the RadComboBox to a collection of business objects, you should set its ItemsSource property. If you want the changes to the collection to be automatically reflected in the RadComboBoxItems, the collection needs to implement the INotifyCollectionChanged interface and your business objects have to implement the INotifyPropertyChanged interface.

First, create a new business object named __Agency__. Its structure is shown in **Example 1**.

#### __[C#] Example 1: The Agency class__

{{region cs-radcombobox-populating-with-data-binding-to-object_1}}
	public class Agency
    {
        public Agency(string name, string phone, string zip)
        {
            Name = name;
            Phone = phone;
            Zip = zip;
        }
        public string Name { get; set; }
        public string Phone { get; set;}
        public string Zip { get; set;}
    }
{{endregion}}

Then create a new class named __AgencyViewModel__ to hold an __ObservableCollection__ of __Agency__ objects. This collection will be the data source for the RadComboBox. 

#### __[C#] Example 2: The AgencyViewModel class__

{{region cs-radcombobox-populating-with-data-binding-to-object_2}}
	public class AgencyViewModel
    {
        private ObservableCollection<Agency> agencies;
        public ObservableCollection<Agency> Agency
        {
            get
            {
                if (agencies == null)
                {
                    agencies = new ObservableCollection<Agency>();

                    agencies.Add(new Agency("Exotic Liquids", "(171) 555-2222", "EC1 4SD"));
                    agencies.Add(new Agency("New Orleans Cajun Delights", "(100) 555-4822", "70117"));
                    agencies.Add(new Agency("Grandma Kelly's Homestead", "(313) 555-5735", "48104"));
                    agencies.Add(new Agency("Tokyo Traders", "(03) 3555-5011", "100"));
                    agencies.Add(new Agency("Cooperativa de Quesos 'Las Cabras'", "(98) 598 76 54", "33007"));
                    agencies.Add(new Agency("Mayumi's", "(06) 431-7877", "545"));
                }
                return agencies;
            }
        }
    }
{{endregion}}

What's left is to set an ItemsSource of the RadComboBox and define custom DataTemplate for the items in the drop-down. **Examples 3 and 4** demonstrate how you can do that.

#### __[XAML] Example 3: Define a custom DataTemplate and AgencyViewModel resources__

{{region xaml-radcombobox-populating-with-data-binding-to-object_3}}
	<UserControl.Resources>
	    <example:AgencyViewModel x:Key="DataSource"/>
	
	    <DataTemplate x:Key="ComboBoxCustomTemplate">
	        <Grid Margin="5,5,5,5" Width="350">
	            <Grid.ColumnDefinitions>
	                <ColumnDefinition />
	                <ColumnDefinition />
	            </Grid.ColumnDefinitions>
	            <Grid.RowDefinitions>
	                <RowDefinition />
	                <RowDefinition />
	            </Grid.RowDefinitions>
	            <TextBlock FontWeight="Bold" Grid.ColumnSpan="2" Text="{Binding Name}" />
	            <TextBlock Grid.Row="1" Text="Phone:" />
	            <TextBlock Grid.Row="1" Foreground="Blue" Margin="40,0,0,0"
	                        Text="{Binding Phone}" />
	            <TextBlock Grid.Row="1" Grid.Column="1" Text="Zip:" />
	            <TextBlock Grid.Row="1" Foreground="Blue" Grid.Column="1" Margin="26,0,0,0"
	                        Text="{Binding Zip}" />
	        </Grid>
	    </DataTemplate>
	</UserControl.Resources>
{{endregion}}

#### __[XAML] Example 4: Set RadComboBox's ItemsSource and ItemTemplate properties__

{{region xaml-radcombobox-populating-with-data-binding-to-object_4}}	
	<telerik:RadComboBox Width="200" x:Name="radComboBox" ItemsSource="{Binding Source={StaticResource DataSource}, Path=Agency}" ItemTemplate={StaticResource ComboBoxCustomTemplate}/>
{{endregion}}

If you run the example now you will get the result in __Figure 1__.

#### __Figure 1: RadComboBox with ItemTemplate__
![](images/RadComboBox_PopulatingWithData_SelectionBoxItemTemplate_1.png)

__RadComboBox__ gives you the ability to define a separate template for the selected item. In order to do that, you have to perform two simple steps:

* Create custom __DataTemplate__.

#### __[XAML] Example 5: Create custom DataTemplate for selected items__

{{region radcombobox-populating-with-data-selectionbox_5}}
	<DataTemplate x:Key="SelectionBoxTemplate">
		<TextBlock Text="{Binding Name}" Foreground="Green" FontWeight="Bold"/>
	</DataTemplate>
{{endregion}}

* Set the declared __DataTemplate__ to the __RadComboBox__'s __SelectionBoxTemplate__ property.

#### __[XAML] Example 6: RadComboBox with SelectionBoxTemplate__

{{region radcombobox-populating-with-data-selectionbox_6}}
    <telerik:RadComboBox x:Name="radComboBox" ItemsSource="{Binding Source={StaticResource DataSource}, Path=Agency}" ItemTemplate="{StaticResource ComboBoxCustomTemplate}" SelectionBoxTemplate="{StaticResource SelectionBoxTemplate}"/>
{{endregion}}

Note how in __Figure 2__ the template of the selected item differs from the items in the drop-down.

#### __Figure 2: RadComboBox with SelectionBoxTemplate and ItemTemplate__
![](images/RadComboBox_PopulatingWithData_SelectionBoxItemTemplate_2.png)

## See Also

 * [Binding to WCF Service]({%slug radcombobox-populating-with-data-binding-to-wcf%})

 * [Binding to Object]({%slug radcombobox-populating-with-data-binding-to-object%})

 * [Binding to ADO.NET Data Service]({%slug radcombobox-populating-with-data-binding-adonet%})
