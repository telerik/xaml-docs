---
title: Getting Started
page_title: Getting Started
description: This article will walk you through the creation of a sample application that contains a RadAutoSuggestBox control.
slug: radautosuggestbox-getting-started
tags: getting,started,radautosuggestbox
position: 2
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains a __RadAutoSuggestBox__ control.
			
## Assembly References

In order to use __RadAutoSuggestBox__, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Data__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining RadAutoSuggestBox

RadAutoSuggestBox allows you to visualize a list of search results on demand when you enter text. When the text in the control changes, the __TextChanged__ event is fired, where you can filter the ItemsSource of the control. This will open the drop down and display the filtered items. 

In the following example you will see a sample data provider that returns a list of countries that is filtered and displayed on text changed.

#### __[C#] Example 1: Creating sample data provider__
{{region radautosuggestbox-getting-started-0}}
	public static class CountryDataProvider
	{
		private static List<CountryInfo> Countries { get; set; }

		static CountryDataProvider()
		{
			Countries = new List<CountryInfo>();
			var cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
			foreach (CultureInfo culture in cultures)
			{
				var regionInfo = new RegionInfo(culture.LCID);
				if (!Countries.Any(x => x.Name.Equals(regionInfo.EnglishName)))
				{
					Countries.Add(new CountryInfo() { Name = regionInfo.EnglishName });
				}
			}
		}

		public static List<CountryInfo> GetCountriesByText(string searchText)
		{
			var result = new List<CountryInfo>();
			var lowerText = searchText.ToLowerInvariant();
			return Countries.Where(x => x.Name.ToLowerInvariant().Contains(lowerText)).ToList();
		}
	}
	
	public class CountryInfo
    {
        public string Name { get; set; }
    }
{{endregion}}

#### __[XAML] Example 2: Defining RadAutoSuggestBox and subscribing to TextChanged__
{{region radautosuggestbox-getting-started-1}}
	<telerik:RadAutoSuggestBox x:Name="radAutoSuggestBox"
							   TextChanged="RadAutoSuggestBox_TextChanged"
							   DisplayMemberPath="Name" 
							   TextMemberPath="Name" 							   
							   WatermarkContent="Type here" 
							   NoResultsContent="No results found" />
{{endregion}}

#### __[C#] Example 3: Implementing filtering in the TextChanged event handler__
{{region radautosuggestbox-getting-started-2}}
	private void RadAutoSuggestBox_TextChanged(object sender, Controls.AutoSuggestBox.TextChangedEventArgs e)
	{
		if (e.Reason == TextChangeReason.UserInput)
		{
			this.radAutoSuggestBox.ItemsSource = CountryDataProvider.GetCountriesByText(this.radAutoSuggestBox.Text);
		}            
	}
{{endregion}}

The definition in __Example 2__ has few additional settings:

* __DisplayMemberPath__: Specifies the property path used to get the value displayed for each data item in the drop down of the RadAutoSuggestBox control.
* __TextMemberPath__: Specifies the property path used to get the value displayed in the TextBox of the control.
* __WatermarkContent__: Specifies the value displayed in the TextBox of the control when no text is entered.
* __NoResultsContent__: Specifies the value displayed in the drop down when no results are presented in the ItemsSource of the control.

>tip Use the __Text__ property to get or set the current query or suggestion text.

#### Figure 1: Watermark content when no text is entered
![](images/radautosuggestbox-getting-started-0.png)

#### Figure 2: Filtered results in the drop down
![](images/radautosuggestbox-getting-started-1.png)

#### Figure 3: No result
![](images/radautosuggestbox-getting-started-2.png)

After selecting an item from the drop down list or click on the query icon, you can use __QuerySubmitted__ and __SuggestionChosen__ events to execute additional actions.

## Open Drop Down Manually

The drop down of the control can be opened or closed manually by setting its __IsDropDownOpen__ property.

#### __[XAML] Example 2: Setting IsDropDownOpen__
{{region radautosuggestbox-getting-started-}}
	<telerik:RadAutoSuggestBox IsDropDownOpen="True" />
{{endregion}}

## Customizing Appearance

RadAutoSuggestBox allows you to customize the appearance of its TextBox, buttons and items. You can read more about this in the [Customizing Appearance]({%slug radautosuggestbox-appearance-customize-buttons%}) section of the control's documentation.

## See Also  
* [Watermark]({%slug radautosuggestbox-features-watermark%})
* [Visual Structure]({%slug radautosuggestbox-visual-structure%})
* [Grouping]({%slug radautosuggestbox-features-grouping%})
* [Events]({%slug radautosuggestbox-events%})
