---
title: Calculator Picker
page_title: Calculator Picker
description: Check our &quot;RadCalculatorPicker&quot; documentation article for the RadCalculator {{ site.framework_name }} control.
slug: radcalculatorpicker-gettingstarted
tags: radcalculatorpicker
published: True
position: 4
---

# Calculator Picker

The `RadCalculatorPicker` control is a drop down button with a `RadCalculator` in its drop down content. The button content shows the calculated value of the calculator.

#### __[XAML] Defining RadCalculatorPicker__
{{region radcalculatorpicker-gettingstarted-0}}
	<telerik:RadCalculatorPicker Height="30" Width="200" />		
{{endregion}}

__RadCalculatorPicker example__  

![A picture showing {{ site.framework_name }} RadCalculatorPicker](images/RadCalculatorPicker-Basic.png)

The drop down state can be controlled manually with the `IsDropDownOpen` property of `RadCalculatorPicker`.

#### __[C#] Opening the drop down content in code__
{{region radcalculatorpicker-gettingstarted-1}}
	this.calculatorPicker.IsDropDownOpen = true;
{{endregion}}

## DataGrid Integration

The following example shows how to utilize the `RadColorPicker` control as the cell editing element of a `RadGridView` column. To do so, define a custom `CellEditTemplate` for the column and in the `DataTemplate` add the calculator.

#### __[C#] Defining a model for the RadGridView rows__
{{region radcalculatorpicker-gettingstarted-2}}
	public class RowInfo
    {
        public string Name { get; set; }
        public double Value { get; set; }
    }
{{endregion}}

#### __[C#] Populating the data source__
{{region radcalculatorpicker-gettingstarted-3}}
	public MainWindow()
	{		
		InitializeComponent();
		var source = new ObservableCollection<RowInfo>();
		for (int i = 0; i < 10; i++)
		{
			source.Add(new RowInfo() { Name = "Item " + i, Value = 5 });
		}
		DataContext = source;
	}
{{endregion}}

#### __[XAML] Defining the RadGridView and setting up the RadCalculatorPicker as the cell edit element__
{{region radcalculatorpicker-gettingstarted-4}}
	<telerik:RadGridView GroupRenderMode="Flat"
						 ItemsSource="{Binding}"						 
						 AutoGenerateColumns="False">
		<telerik:RadGridView.Columns>
			<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"/>
			<telerik:GridViewDataColumn DataMemberBinding="{Binding Value}">
				<telerik:GridViewDataColumn.CellEditTemplate>
					<DataTemplate>
						<telerik:RadCalculatorPicker Value="{Binding Value, Mode=TwoWay}" />
					</DataTemplate>
				</telerik:GridViewDataColumn.CellEditTemplate>
			</telerik:GridViewDataColumn>
		</telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

__Using RadCalculatorPicker as a cell editor of RadGridView__  

![A picture showing {{ site.framework_name }} RadCalculator as the editor of RadGridView cells](images/RadCalculatorPicker-IntegrationWithRadGridView.png)

## See Also  
* [Getting Started]({%slug radcalculator-gettingstarted%})
