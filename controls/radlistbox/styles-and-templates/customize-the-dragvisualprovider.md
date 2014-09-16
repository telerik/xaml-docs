---
title: How to customize the DragVisualProvider
page_title: How to customize the DragVisualProvider
description: How to customize the DragVisualProvider
slug: radlistbox-styles-and-templates-customize-the-dragvisualprovider
tags: how,to,customize,the,dragvisualprovider
publish: True
position: 0
---

# How to customize the DragVisualProvider



In __RadListBox__ it is possible to enrich the drag-drop functionality of the control by creating a custom __DragVisualProvider__ or using one of the built-in DragVisualProviders. More information about the built-in DragVisualProviders could be found [here]({%slug radlistbox-features-dragdrop%}).
      

## Custom DragVisualProvider

The next example will demonstrate the how to create a custom DragVisualProvider in order to change its __Foreground__, __Background__, __BorderBrush__ and __Template__.

>Before proceeding with this example you should get familiar with [Drag and Drop: Overview]({%slug radlistbox-features-dragdrop%}), [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) and [Binding To Object]({%slug radlistbox-populating-with-data-binding-to-object%}).
          

1. First you will need to create a __Country__ class with the necessary properties:
            

#### __C#__

{{region radlistbox-styles-and-templates-customize-the-dragvisualprovider-0}}
	public class Country
	{
		public string Name { get; set; }
	
		public string Capital { get; set; }
	
		public int Id { get; set; }
	} 
	{{endregion}}



1. Next you should create a __Countries__ collection in your ViewModel and populate it with some sample data:
            

#### __C#__

{{region radlistbox-styles-and-templates-customize-the-dragvisualprovider-1}}
	public class ViewModel : ViewModelBase
	{
		private ObservableCollection<Country> countries;
	
		public ViewModel()
		{
			this.countries = new ObservableCollection<Country>()
			{
				new Country() { Name = "Australia", Capital = "Canberra", Id = 1 },
				new Country() { Name = "Bulgaria", Capital = "Sofia", Id = 2 },
				new Country() { Name = "Canada", Capital = "Ottawa", Id = 3 },
				new Country() { Name = "Denmark", Capital = "Copenhagen", Id = 4 },
				new Country() { Name = "France", Capital = "Paris", Id = 5 },
				new Country() { Name = "Germany", Capital = "Berlin", Id = 6 },
				new Country() { Name = "India", Capital = "New Delhi", Id = 7 },
				new Country() { Name = "Italy", Capital = "Rome", Id = 8 },
				new Country() { Name = "Norway", Capital = "Oslo", Id = 9 },
				new Country() { Name = "Russia", Capital = "Moscow", Id = 10 },
				new Country() { Name = "Spain ", Capital = "Madrid", Id = 11 },
				new Country() { Name = "United Kingdom", Capital = "London", Id = 12 },
				new Country() { Name = "United States", Capital = "Washington, D.C.", Id = 13 }
			};
		}
	
		public ObservableCollection<Country> Countries
		{
			get
			{
				return this.countries;
			}
	
			set
			{
				if (this.countries != value)
				{
					this.countries = value;
					this.OnPropertyChanged(() => this.Countries);
				}
			}
		}
	}
	{{endregion}}



1. In the App.xaml file merge the necessary __ResourceDictionary__ for the RadListBox control based on the theme you are using. This example uses the Office_Black theme:
            

#### __XAML__

{{region radlistbox-styles-and-templates-customize-the-dragvisualprovider-0}}
	<Application.Resources>
		<ResourceDictionary>
			<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml"/>
				<ResourceDictionary Source="/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.xaml"/>
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
	{{endregion}}



1. Next you will need to create a Style in the same file that targets __ListBoxDragVisual__ and set its Foreground, Background, BorderBrush and Template properties:
            

#### __XAML__

{{region radlistbox-styles-and-templates-customize-the-dragvisualprovider-1}}
	<Application.Resources>
	    <ResourceDictionary>
	        <ResourceDictionary.MergedDictionaries>
	            ...
	        </ResourceDictionary.MergedDictionaries>
	        <Style TargetType="telerikDragDrop:ListBoxDragVisual" BasedOn="{StaticResource DragVisualStyle}">
		        <Setter Property="Foreground" Value="White"/>
		        <Setter Property="BorderBrush" Value="DarkGreen"/>
		        <Setter Property="Background" Value="Green"/>
		        <Setter Property="Template">
			        <Setter.Value>
				        <ControlTemplate TargetType="telerikDragDrop:DragVisual">
					        <Grid>
						        <VisualStateManager.VisualStateGroups>
							        ...
						        </VisualStateManager.VisualStateGroups>
						        ...
						        <Border Margin="0 0 4 4" Padding="{TemplateBinding BorderThickness}">
							        <Grid Margin="2, 0, 2, 0">
								        ...
								        <Grid.RowDefinitions>
									        <RowDefinition Height="20"/>
									        <RowDefinition Height="Auto"/>
									        <RowDefinition Height="20"/>
									        <RowDefinition Height="Auto"/>
									        <RowDefinition Height="20"/>
								        </Grid.RowDefinitions>
								        ...
								        <StackPanel Orientation="Horizontal" Margin="15, 0, 0, 0" Grid.Row="0" VerticalAlignment="Center">
									        <TextBlock Text="ID: "/>
									        <TextBlock Text="{Binding Content.Id, RelativeSource={RelativeSource TemplatedParent}}"
										        FontWeight="Bold"/>
								        </StackPanel>
								        <Border Background="White" Height="1" Grid.Row="1"/>
								        <StackPanel Orientation="Horizontal" Margin="15, 0, 0, 0" Grid.Row="2" VerticalAlignment="Center">
									        <TextBlock Text="Name: "/>
									        <TextBlock Text="{Binding Content.Name, RelativeSource={RelativeSource TemplatedParent}}"
										        FontWeight="Bold"/>
								        </StackPanel>
								        <Border Background="White" Height="1" Grid.Row="3"/>
								        <StackPanel Orientation="Horizontal" Margin="15, 0, 0, 0" Grid.Row="4" VerticalAlignment="Center">
									        <TextBlock Text="Capital: "/>
									        <TextBlock Text="{Binding Content.Capital, RelativeSource={RelativeSource TemplatedParent}}"
										        FontWeight="Bold"/>
								        </StackPanel>
							        </Grid>
				        </ControlTemplate>
			        </Setter.Value>
		        </Setter>
	        </Style>
	    </ResourceDictionary>
	</Application.Resources>
	{{endregion}}

You can find the entire ListBoxDragVisual Template code in each specific theme for the RadListBox control.
            

>The custom __DragVisualStyle__ must be created in the App.xaml file as the __DragVisualProvider__ is placed
                inside of another visual tree and cannot be targeted from the {% if site.site_name == 'Silverlight' %}Page{% endif %}/{% if site.site_name == 'WPF' %}Window{% endif %} where RadListBox is placed.
              

1. Finally you will need to declare the __RadListBox__ control. The xaml of the control should look like this:
            

#### __XAML__

{{region radlistbox-styles-and-templates-customize-the-dragvisualprovider-2}}
	<telerik:RadListBox ItemsSource="{Binding Countries}" 
						DisplayMemberPath="Name">
		<telerik:RadListBox.DragDropBehavior>
			<telerik:ListBoxDragDropBehavior AllowReorder="True" />
		</telerik:RadListBox.DragDropBehavior>
		<telerik:RadListBox.DragVisualProvider>
			<telerik:ListBoxDragVisualProvider/>
		</telerik:RadListBox.DragVisualProvider>
	</telerik:RadListBox>
	{{endregion}}



>tipYou can download a runnable project of the previous example from our online SDK repository
            [here](https://github.com/telerik/xaml-sdk), the example is listed as __ListBox / CustomDragVisualStyle__.
          

The next screenshots show the final result:
          ![radlistbox-styles-and-templates-customize-the-dragvisualprovider-1](images/radlistbox-styles-and-templates-customize-the-dragvisualprovider-1.jpg)![radlistbox-styles-and-templates-customize-the-dragvisualprovider-2](images/radlistbox-styles-and-templates-customize-the-dragvisualprovider-2.jpg)

# See Also

 * [Overview]({%slug radlistbox-features-dragdrop%})

 * [Drag-Drop between RadListBox and RadScheduleView]({%slug radlistbox-features-dragdrop-scheduleview%})
