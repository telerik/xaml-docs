---
title: TextBoxStyle
page_title: TextBoxStyle
description: Check our &quot;TextBoxStyle&quot; documentation article for the RadAutoCompleteBox {{ site.framework_name }} control.
slug: radautocompletebox-textboxstyle
tags: textboxstyle
published: True
position: 4
---

# TextBoxStyle
The __TextBoxStyle__ property makes it easy to customize the __RadAutoCompleteBox__ and __RadAutoCompleteBoxItem__. This article will show you how to apply a custom __TextBoxStyle__.

## Applying custom TextBoxStyle

The first thing is to create a __RadAutoCompleteBox__ with an ItemsSource bound to a collection of countries.

__Example 1: Create an objects class__
```C#
	public class Country
	{
		public string Name { get; set; }
		public string Capital { get; set; }
	}
```

__Example 2: Create the ViewModel__
```C#
	public class MyViewModel : ViewModelBase
    {
        private ObservableCollection<Country> countries;
        public ObservableCollection<Country> Countries
        {
            get
            {
                if (this.countries == null)
                {
                    this.countries = new ObservableCollection<Country>();
                    this.countries.Add(new Country() { Name = "Australia", Capital = "Canberra" });
                    this.countries.Add(new Country() { Name = "Bulgaria", Capital = "Sofia" });
                    this.countries.Add(new Country() { Name = "Canada", Capital = "Ottawa" });
                    this.countries.Add(new Country() { Name = "Denmark", Capital = "Copenhagen" });
                    this.countries.Add(new Country() { Name = "France", Capital = "Paris" });
                    this.countries.Add(new Country() { Name = "Germany", Capital = "Berlin" });
                    this.countries.Add(new Country() { Name = "India", Capital = "New Delhi" });
                    this.countries.Add(new Country() { Name = "Italy", Capital = "Rome" });
                    this.countries.Add(new Country() { Name = "Norway", Capital = "Oslo" });
                    this.countries.Add(new Country() { Name = "Russia", Capital = "Moscow" });
                    this.countries.Add(new Country() { Name = "Spain", Capital = "Madrid" });
                    this.countries.Add(new Country() { Name = "United Kingdom", Capital = "London" });
                    this.countries.Add(new Country() { Name = "United States", Capital = "Washington, D.C." });
                }
                return countries;
            }
        }
    }
```

__Example 3: Create the RadAutoCompleteBox and sets its ItemsSource__
```XAML
	<Window.DataContext>
        <local:MyViewModel/>
    </Window.DataContext>
	<Grid>
        <telerik:RadAutoCompleteBox Name="autoCompleteBox"
                                    Width="200" Height="25"
                                    ItemsSource="{Binding Countries}"  
                                    DisplayMemberPath="Name" 
                                    AutoCompleteMode="Suggest"
                                    WatermarkContent="Select a country..."/>
    </Grid>
```

#### __Figure 1: RadAutoCompleteBox without custom TextBoxStyle applied__
![Rad Auto Complete Box Features Text Box Style 01](images/RadAutoCompleteBox_StylesAndTemplates_TextBoxStyle_01.png)

You have to create a custom __Style__ with __TargetType__ __RadAutoCompleteBox__ or __RadAutoCompleteBoxItem__:

__Example 4: Create the custom Style__
```XAML
	<Grid.Resources>
        <Style x:Key="textBoxStyle" TargetType="telerik:RadWatermarkTextBox">
            <Setter Property="BorderThickness" Value="0"/>
            <Setter Property="Margin" Value="3 3 0 0"/>
            <Setter Property="Padding" Value="0"/>
            <Setter Property="BorderBrush" Value="Transparent"/>
            <Setter Property="FocusVisualStyle" Value="{x:Null}"/>
            <Setter Property="HorizontalContentAlignment" Value="Stretch"/>
            <Setter Property="Foreground" Value="Red" />
        </Style>
    </Grid.Resources>
```

>If you are using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) to style the controls, you would need to base that Style to the default TextBoxStyle of RadAutoCompleteBox named **RadAutoCompleteTextBoxStyle**.

The last step would be to simply set the custom style as __TextBoxStyle__ of __RadAutoCompleteBox__:

__Example 5: Apply the custom Style__
```XAML
	<Grid>
		<telerik:RadAutoCompleteBox Name="autoCompleteBox"
									Width="200" Height="25"
									ItemsSource="{Binding Countries}"  
									DisplayMemberPath="Name" 
									AutoCompleteMode="Suggest"
									WatermarkContent="Select a country..."
                                    TextBoxStyle="{StaticResource textBoxStyle}"/>
    </Grid>
```

You can see the final result on __Figure 2__.

#### __Figure 2: RadAutoCompleteBox with custom TextBoxStyle applied__
![Rad Auto Complete Box Features Text Box Style 02](images/RadAutoCompleteBox_StylesAndTemplates_TextBoxStyle_02.png)

## See Also

 * [Customizing the BoxesItemTemplate]({%slug radautocompletebox-customizing-boxes-itemtemplate%})

 * [BoxesItemStyle]({%slug radautocompletebox-boxesitemstyle%})
