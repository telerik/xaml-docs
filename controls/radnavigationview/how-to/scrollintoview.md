---
title: Scroll Item into View
page_title: Scroll Item into View
description: This article demonstrates the ScrollIntoView suppport of RadNavigationView.
slug: radnavigationview-how-to-scrollintoview
tags: scroll,item,into,view
published: True
position: 0
---

# {{ site.framework_name }} RadNavigationView Scroll Item into View

The __RadNavigationView API__ offers __ScrollIntoView__ support through the following method: __ScrollIntoView__. This method allows you to programmatically scroll an item into view when there are many RadNavigationViewItems.

## ScrollIntoView

The ScrollIntoView method has two overloads. One of them accepts an item and the other one accepts an index. __Examples 1, 2__ setup a RadNavigationView in a databinding scenario to demonstrate this method.

#### __[C#] Example 1: Setting up the model and viewmodel__
{{region cs-radnavigationview-how-to-scrollintoview-0}}
    public class NavigationItemModel
    {
        public string Title { get; set; }
    }

    public class MainViewModel
    {
        public ObservableCollection<NavigationItemModel> Items { get; set; }

        public MainViewModel()
        {
            this.Items = new ObservableCollection<NavigationItemModel>();

            for (int i = 1; i <= 50; i++)
            {
                this.Items.Add(new NavigationItemModel() { Title = "Item " + i });
            }
        }
    }
{{endregion}}

#### __[VB.NET] Example 1: Setting up the model and viewmodel__
{{region vb-radnavigationview-how-to-scrollintoview-1}}
    Public Class NavigationItemModel
		Public Property Title() As String
    End Class

    Public Class MainViewModel
		Public Property Items() As ObservableCollection(Of NavigationItemModel)

		Public Sub New()
			Me.Items = New ObservableCollection(Of NavigationItemModel)()

			For i As Integer = 1 To 50
				Me.Items.Add(New NavigationItemModel() With {.Title = "Item " & i})
			Next i
		End Sub
    End Class
{{endregion}}

#### __[XAML] Example 2: Setting up the xaml__
{{region xaml-radnavigationview-how-to-scrollintoview-2}}
    <Grid>
        <Grid.Resources>
            <!-- If you are using the NoXaml binaries, you will have to base the style on the default one for the theme like so:
            <Style TargetType="telerik:RadNavigationViewItem" BasedOn="{StaticResource RadNavigationViewItemStyle}">-->
        
            <Style TargetType="telerik:RadNavigationViewItem" >
                <Setter Property="Content" Value="{Binding Title}" />
            </Style>
        </Grid.Resources>
        <Grid.RowDefinitions>
            <RowDefinition />
            <RowDefinition />
        </Grid.RowDefinitions>
        
        <telerik:RadNavigationView x:Name="navigationView" DataContext="{StaticResource ViewModel}" ItemsSource="{Binding Items}" PaneHeader="Header" />

        <Button Click="ScrollItemIntoView" Content="Scroll Into View" Grid.Row="1" />
    </Grid>
{{endregion}}

__Example 3__ demonstrates how the ScrollIntoView method can be used, in the Button's Click event handler, by passing it either an item, or an index. 

#### __[C#] Example 3: Scrolling an item/index into View__
{{region cs-radnavigationview-how-to-scrollintoview-3}}
    private void ScrollItemIntoView(object sender, RoutedEventArgs e)
    {
        //this.navigationView.ScrollIntoView(this.navigationView.Items[15]);
        this.navigationView.ScrollIntoView(15);
    }
{{endregion}}

#### __[VB.NET] Example 3: Scrolling an item/index into View__
{{region vb-radnavigationview-how-to-scrollintoview-4}}
    Private Sub ScrollItemIntoView(ByVal sender As Object, ByVal e As RoutedEventArgs)
		'this.navigationView.ScrollIntoView(this.navigationView.Items[15]);
		Me.navigationView.ScrollIntoView(15)
    End Sub
{{endregion}}

## See Also

 * [Getting Started]({%slug radnavigationview-getting-started%})
 * [Selection]({%slug radnavigationview-features-selection%})
 * [DataBinding]({%slug radnavigationview-populating-with-data-databinding%})