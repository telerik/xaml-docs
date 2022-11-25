---
title: Customizing Filtering Control
page_title: Customizing Filtering Control
description: RadCardView filtering control can be cusomized using several properties of the control.
slug: radcardview-appearance-customizing-filtering-control
tags: customize, filteringcontrol
published: True
position: 2
---

# Customizing Filtering Control

RadCardView filtering control can be customized in order to match the expected design or functionality.

>tip Read the [Filtering]({%slug radcardview-features-filtering%}) article to see how to use the filtering feature.

To hide the button that opens the [filtering control popup]({%slug radcardview-visual-structure%}), set the __IsFilteringAllowed__ property to __False__. 

#### __[XAML] Example 1: Setting the IsFilteringAllowed property__
{{region radcardview-appearance-customizing-filtering-control-0}}
	<telerik:RadCardView IsFilteringAllowed="False" />
{{endregion}}

#### Figure 1: Hidden filtering control icon
![WPF RadCardView Hidden filtering control icon](images/radcardview-appearance-customizing-filtering-control-0.png)

To keep the filtering control popup open when you click outside of it, set the __FilteringDropDownStaysOpen__ property to __True__.

#### __[XAML] Example 2: Setting the FilteringDropDownStaysOpen property__
{{region radcardview-appearance-customizing-filtering-control-1}}
	<telerik:RadCardView FilteringDropDownStaysOpen="True" />
{{endregion}}

To change the visibility of the __Filter__ button in the popup, set the __ShowFilterButton__ property of the associated [CardDataFieldDescriptor]({%slug radcardview-features-datafielddescriptors%}).

#### __[XAML] Example 3: Setting the ShowFilterButton property__
{{region radcardview-appearance-customizing-filtering-control-2}}
	<telerik:RadCardView.DataFieldDescriptors>
		<telerik:CardDataFieldDescriptor DataMemberBinding="{Binding Name}" ShowFilterButton="False"/>
	</telerik:RadCardView.DataFieldDescriptors>
{{endregion}}

#### Figure 2: Hidden filtering button
![WPF RadCardView Hidden filtering button](images/radcardview-appearance-customizing-filtering-control-1.png)

To change the visibility of the distinct values list from the popup, set the __ShowDistinctFilters__ property of the associated CardDataFieldDescriptor.

#### __[XAML] Example 4: Setting the ShowDistinctFilters property__
{{region radcardview-appearance-customizing-filtering-control-3}}
	<telerik:RadCardView.DataFieldDescriptors>
		<telerik:CardDataFieldDescriptor DataMemberBinding="{Binding Name}" ShowDistinctFilters="False"/>
	</telerik:RadCardView.DataFieldDescriptors>
{{endregion}}

#### Figure 3: Hidden the distinct values list
![WPF RadCardView Hidden the distinct values list](images/radcardview-appearance-customizing-filtering-control-2.png)

To change the visibility of the field filters in the popup, set the __ShowFieldFilters__ property of the associated CardDataFieldDescriptor.

#### __[XAML] Example 5: Setting the ShowFieldFilters property__
{{region radcardview-appearance-customizing-filtering-control-4}}
	<telerik:RadCardView.DataFieldDescriptors>
		<telerik:CardDataFieldDescriptor DataMemberBinding="{Binding Name}" ShowFieldFilters="False"/>
	</telerik:RadCardView.DataFieldDescriptors>
{{endregion}}

#### Figure 4: Hidden the field filters
![WPF RadCardView Hidden the field filters](images/radcardview-appearance-customizing-filtering-control-3.png)

## Custom Filtering Control

The UI filters are hosted in a __FilteringControl__ element. To get or replace the control, use the __FilteringControl__ property of the associated [CardDataFieldDescriptor]({%slug radcardview-features-datafielddescriptors%}). The value assigned to the property should implement the `IFilteringControl` interface or alternatively the `FilteringControl` class can be used as a base for the implementation.

#### __[C#] Example 6: Creating custom FilteringControl and changing few of the default settings__
{{region radcardview-appearance-customizing-filtering-control-5}}
	public class CustomFilteringControl : FilteringControl
    {
        public CustomFilteringControl(CardDataFieldDescriptor cardDataFieldDescriptor)
            : base(cardDataFieldDescriptor)
        {
        }

        public override void Prepare(CardDataFieldDescriptor cardDataFieldDescriptorToPrepare)
        {
            base.Prepare(cardDataFieldDescriptorToPrepare);
            var viewModel = (FilteringViewModel)this.DataContext;
            viewModel.FieldFilterLogicalOperator = FilterCompositionLogicalOperator.Or;
            viewModel.Filter1.Operator = FilterOperator.Contains;
            viewModel.Filter1.Value = "1";
            viewModel.SelectAll = true;
        }
    }
{{endregion}}

#### __[C#] Example 7: Setting the custom FilteringControl__
{{region radcardview-appearance-customizing-filtering-control-6}}
	public MainWindow()
	{
		InitializeComponent();
		
		var descriptor = this.cardView.DataFieldDescriptors[0];
		descriptor.FilteringControl = new CustomFilteringControl(descriptor);
	}
{{endregion}}

#### Figure 5: Customized FiltertingControl
![WPF RadCardView Customized FiltertingControl](images/radcardview-appearance-customizing-filtering-control-4.png)

The UI of the __FilteringControl__ can be customized using the __FilteringControlStyle__ property of the CardDataFieldDescriptor.

#### __[C#] Example 8: Setting the custom FilteringControlStyle__
{{region radcardview-appearance-customizing-filtering-control-7}}
	<telerik:CardDataFieldDescriptor.FilteringControlStyle>		
		<Style TargetType="cardView:FilteringControl">
			<Setter Property="Background" Value="LightSeaGreen" />
		</Style>
	</telerik:CardDataFieldDescriptor.FilteringControlStyle>
{{endregion}}

The "cardView:" namespace points to `xmlns:cardView="clr-namespace:Telerik.Windows.Controls.Data.CardView;assembly=Telerik.Windows.Controls.Data"`

#### Figure 6: Customized FiltertingControlStyle
![WPF RadCardView Customized FiltertingControlStyle](images/radcardview-appearance-customizing-filtering-control-5.png)

## See Also  
* [Data Binding]({%slug radcardview-populating-with-data-data-binding%})
* [Customizing Groups]({%slug radcardview-appearance-customizing-groups%}) 
* [Customizing Cards]({%slug radcardview-appearance-customizing-cards%}) 