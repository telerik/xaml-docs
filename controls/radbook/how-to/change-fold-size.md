---
title: How To Change the Fold Size
page_title: How To Change the Fold Size
description: Check our &quot;How To Change the Fold Size&quot; documentation article for the RadBook {{ site.framework_name }} control.
slug: radbook-how-to-change-fold-size
tags: how,to,change,the,fold,size
published: True
position: 1
---

# How To Change the Fold Size

To change the fold size you can use the __FoldSize__ property of __RadBook__. It is of type __Size__. Here is an example below: 

![RadBook Fold Size](images/book_foldsize.png)

__Example 1: Changing the fold size__  
```XAML
	<telerik:RadBook x:Name="RadBook1" 
	                    Margin="50"
	                    FoldSize="150,150" RightPageIndex="1">
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

## See Also
 * [Getting Started]({%slug radbook-getting-started%})
 * [Visual Structure]({%slug radbook-visual-structure%})