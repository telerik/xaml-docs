---
title: Show First Page On The Right
page_title: Show First Page On The Right
description: Check our &quot;Show First Page On The Right&quot; documentation article for the RadBook {{ site.framework_name }} control.
slug: radbook-show-first-page-on-the-right
tags: show,first,page,on,the,right
published: True
position: 0
---

# Show First Page On The Right

To show the first page on the right the you should define the __FirstPagePosition__. It is an enumeration and has two values:

* __Left__ - the first page will be displayed on the left side of the book and next to it will be displayed the second page

* __Right__ - only the first page will be displayed on the right side of the book.

Here is the result when the first page is displayed on the righ side of the book.

![RadBook](images/book_step4.png)

__Example 1: Setting the FirstPagePosition property__  
```XAML
	<telerik:RadBook x:Name="RadBook1" 
	                    Margin="50"
	                    FirstPagePosition="Right">
	    <telerik:RadBookItem Background="Red">
	        <StackPanel>
	            <TextBlock FontSize="36" Text="Page 1" />
	            <Button Content="Click Me" />
	        </StackPanel>
	    </telerik:RadBookItem>
	    <telerik:RadBookItem Background="BlueViolet">
	        <StackPanel>
	            <TextBlock HorizontalAlignment="Right" 
	                        FontSize="36"
	                        Text="Page 2" />
	            <Image Width="320" 
	                    Height="240"
	                    Source="Koala.jpg" />
	        </StackPanel>
	    </telerik:RadBookItem>
	    <telerik:RadBookItem Background="RosyBrown">
	        <TextBlock FontSize="36" Text="Page 3" />
	    </telerik:RadBookItem>
	    <telerik:RadBookItem Background="Chocolate">
	        <TextBlock HorizontalAlignment="Right" 
	                    FontSize="36"
	                    Text="Page 4" />
	    </telerik:RadBookItem>
	</telerik:RadBook>
```