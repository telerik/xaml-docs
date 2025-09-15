---
title: Events
page_title: Events
description: This article describes the RadAutoSuggestBox events.
slug: radautosuggestbox-events
tags: events
published: True
position: 3
---

# Events

This article lists the events specific for RadAutoSuggestBox.    

* __TextChanged__: Occurs on each change in the text of the TextBoxt part of the control. The event arguments are of type __TextChangedEventArgs__ and expose the following members:

	* __Reason__: A property of type TextChangeReason that allows you to identify how the text was changed - __Programmatic__, via __UserInput__ or on __SuggestionChosen__.
	
		__Example 1: TextChanged event handler__
		```C#
			private void RadAutoSuggestBox_TextChanged(object sender, TextChangedEventArgs e)
			{
				if (e.Reason == TextChangeReason.UserInput)
				{
					this.radAutoSuggestBox.ItemsSource = MyGetFilteredItems(this.radAutoSuggestBox.Text);
				}            
			}
		```
	
* __QuerySubmitted__: Occurs when the user submits a query. This happens on the following occassions - Enter press while the control is focused and the drop down is opened, a click over the query button or choosing suggestion from the drop down list. The event arguments are of type __QuerySubmittedEventArgs__ and expose the following members:

	* __QueryText__: A property that holds the currently searched text.
	* __Suggestion__: A property of type object, that holds a reference to the chosen suggestion. If no suggestion was selected the property value is `null`.
	
		__Example 2: QuerySubmitted event handler__
		```C#
			private void RadAutoSuggestBox_QuerySubmitted(object sender, QuerySubmittedEventArgs e)
			{     
			}
		```

* __SuggestionChosen__: Occurs when a suggestion is chosen from the drop down list. The event arguments are of type __SuggestionChosenEventArgs__ and expose the following members:

	* __Suggestion__: A property of type object, that holds a reference to the chosen suggestion.
	
		__Example 3: SuggestionChosen event handler__
		```C#
			private void RadAutoSuggestBox_SuggestionChosen(object sender, SuggestionChosenEventArgs e)
			{    
			}
		```
	
## See Also  
 * [Getting Started]({%slug radautosuggestbox-getting-started%}) 
 * [Buttons]({%slug radautosuggestbox-appearance-customize-buttons%})
 * [Watermark]({%slug radautosuggestbox-features-watermark%})
 * [Grouping]({%slug radautosuggestbox-features-grouping%})
