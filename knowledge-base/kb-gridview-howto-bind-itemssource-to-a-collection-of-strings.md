---
title: RadGridView with ItemsSource of ObservableCollection&lt;string&gt; does not allow row additions or edits
description: How to set RadGridView ItemsSource to a collection of strings.
type: how-to
page_title: Binding RadGridView ItemsSource to a string collection
slug: kb-gridview-howto-bind-itemssource-to-a-collection-of-strings
position: 0
tags: gridview, collection, strings, binding
ticketid: 1401848
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>


## Description

Since RadGridView is designed to work with collections of business objects, a lot of the core functionality would not work when the ItemsSource of the control is set to a collection of strings.

## Solution

In order to avoid that, we can create a simple wrapper class around the string data. 


```C#
	public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var wrappedData = from str in new List<string>() { "one", "two", "three" }
                              select new StringWrapper { Text = str };

            this.gridView.ItemsSource = wrappedData;
        }
    }
    
    public class StringWrapper
    {
        public string Text { get; set; }
    }
```


```XAML
	<telerik:RadGridView x:Name="gridView" />
```
