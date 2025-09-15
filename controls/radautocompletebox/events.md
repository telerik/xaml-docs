---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadAutoCompleteBox {{ site.framework_name }} control.
slug: radautocompletebox-events
tags: events
published: True
position: 100
---

# Events

The __RadAutoCompleteBox__ exposes almost all of the **TextBox** events. Additionally, it provides the following events:

* __SelectionChanged__: Occurs when an item of the RadAutoCompleteBox is selected. The type of the passed arguments is __SelectionChangedEventArgs__. You can use the readonly **AddedItems** and **RemovedItems** properties to see what item(s) were selected or deselected.

* __SearchTextChanged__: Occurs when the text in the text box portion of the RadAutoCompleteBox changes. This event should be used instead of the **TextChanged** event. The type of the passed arguments is __EventArgs__.

* __Populating__: Occurs when RadAutoCompleteBox starts populating its popup with items. The type of the passed arguments is **CancelRoutedEventArgs** meaning that you can cancel the event based on your custom logic by setting the Cancel property of the arguments to **True**.

* __Populated__: Occurs after RadAutoCompleteBox populates its popup with items. The type of the passed arguments is __EventArgs__.

* __ItemsFound__: Occurs when the items' search is completed. It is an event of [AsyncFilteringBehavior](https://docs.telerik.com/devtools/wpf/controls/radautocompletebox/features/filteringbehavior). The type of the passed arguments is __AsyncItemSearchEventArgs__.

__Example 1: Modify the collection with the found results from the event arguments__

	```C#
		public MainWindow()
        {
            InitializeComponent();

            var source = new List<ItemInfo>();
            for (int i = 0; i < 100000; i++)
            {
                source.Add(new ItemInfo() { Id = i });
            }
            this.autoCompleteBox.ItemsSource = source;
            var behavior = new AsyncFilteringBehavior();
            behavior.ItemsFound += Behavior_ItemsFound;
            this.autoCompleteBox.FilteringBehavior = behavior;
        }

        private void Behavior_ItemsFound(object sender, Telerik.Windows.Controls.Primitives.AsyncItemSearchEventArgs e)
        {
            var result = (List<object>)e.Result;
            var orderedResult = result.OfType<ItemInfo>().OrderByDescending(x => x.Id).ToList();
            result.Clear();
            foreach (var item in orderedResult)
            {
                result.Add(item);
            }
        }
	```

>tipYou can remove and add items from the e.Results collection or sort and filter them.
