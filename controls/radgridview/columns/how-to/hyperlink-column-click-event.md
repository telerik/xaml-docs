---
title: GridViewHyperlinkColumn Click Event
page_title: GridViewHyperlinkColumn Click Event
description: Attach to GridViewHyperlinkColumn`s Click Event
slug: gridview-hyperlink-column-click-event
tags: click, event, hyperlink, column, gridview
published: True
position: 9
---

# Subscribe to GridViewHyperlinkColumn`s Click Event

If you have defined a __GridViewHyperlinkColumn__ within your RadGridView, you might need to subscribe to its Click event for some internal operations. There are a couple of approaches that you can take.

In case the first column of the RadGridView is a GridViewHyperlinkColumn:
 
![](images/gridview-hyperlinkcolumn-initial.PNG)

You can apply the following logic in the code behind:

		public MainWindow()
        {
            InitializeComponent();
            this.AddHandler(Hyperlink.ClickEvent, new RoutedEventHandler(hyperlinkClicked));
        }

        private void hyperlinkClicked(object sender, RoutedEventArgs e)
        {
            Hyperlink hyperLink = e.OriginalSource as Hyperlink;
            MessageBox.Show(hyperLink.NavigateUri.ToString());
        }


The result after clicking the Hyperlink will be:

![](images/gridview-hyperlink-clicked.PNG)

Another possible approach is to use a standard __GridViewDataColumn__ instead of __GridViewHyperlinkColumn__. You can subscribe to the MouseLeftButtonUp event of the TextBlock element defined within a CellTemplate of the GridViewDataColumn and use a Style to imitate a hyperlink:



#### XAML: Declare the GridViewHyperlinkColumn and its CellTemplate:
		
		 <Style x:Key="HyperlinkStyle" TargetType="TextBlock">
            <Setter Property="Foreground" Value="Blue" />
            <Setter Property="TextDecorations" Value="Underline" />
        </Style>
				
									...

	   <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}">
                    <telerik:GridViewDataColumn.CellTemplate>
                        <DataTemplate>
                            <TextBlock Style="{StaticResource HyperlinkStyle}" Text="{Binding Name}" MouseLeftButtonUp="TextBlock_MouseLeftButtonUp"/>
                        </DataTemplate>
                    </telerik:GridViewDataColumn.CellTemplate>
                </telerik:GridViewDataColumn>

#### C#: Handling the MouseLeftButtonUp event

		private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var teamName = (e.Source as TextBlock).Text;
            MessageBox.Show(teamName);
        }


# See Also
 * [CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})

 * [CheckBox Column]({%slug gridview-checkbox-column%}) 

 

