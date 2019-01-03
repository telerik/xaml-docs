---
title: Icon and IconTemplate
page_title: Icon and IconTemplate
description: The article describes the Icon and IconTemplate properties of the RadNavigationViewItem.
slug: radnavigationview-icon-and-icontemplate
tags: icon, icontemplate,radnavigationviewitem
position: 2
---

# Icon and IconTemplate

The __RadNavigationViewItem__ allows you to display a custom icon in its template. To show an icon, you can use either the Icon, or the IconTemplate properties.

## RadNavigationViewItem Icon

Since the __Icon__ property is of type object, you can set it to an image, glyph or any custom control. __Example 1__ demonstrates how you can set the Icon of __RadNavigationViewItem__ to a [RadGlyph]({%slug common-styling-appearance-radglyph%}).

#### __[XAML] Example 1: Setting the Icon of a RadNavigationViewItem__
{{region xaml-radnavigationview-item-icon-0}}
    <telerik:RadNavigationViewItem Content="Bookmarks" Width="200" Height="50" >
        <telerik:RadNavigationViewItem.Icon>
            <telerik:RadGlyph Glyph="&#xe303;" FontSize="16"/>
        </telerik:RadNavigationViewItem.Icon>
    </telerik:RadNavigationViewItem>
{{endregion}}

#### __Figure 1: Result from Example 1 in the Office2016 theme__
![RadNaviationViewItem Icon](images/NavigationViewItem_Icon.png)

## RadNavigationViewItem IconTemplate

The __IconTemplate__ property is useful, because a single DataTemplate can be set to many __RadNavigationViewItems__. 
This section will demonstrate how this property can be used in a databinding scenario.

> Note that whatever is set to the Icon property will be the DataContext inside the IconTemplate.

First we will define a model for our items and a viewmodel which will hold a collection of those models. This is demonstrated in __Example 2__.

#### __[C#] Example 2: Defining a model and a viewmodel__
{{region cs-radnavigationview-item-icon-1}}
    public class MainViewModel
    {
        private readonly string[] glyphStrings = new string[] { "&#xe501;", "&#xe13d;", "&#xe500;" };

        public ObservableCollection<NavigationItemModel> Items { get; set; }

        public MainViewModel()
        {
            this.Items = new ObservableCollection<NavigationItemModel>();

            for (int i = 1; i <= 3; i++)
            {
                var glyphString = this.glyphStrings[i - 1];
                this.Items.Add(new NavigationItemModel() {Title = "Item " + i, IconGlyph = glyphString });
            }
        }
    }

    public class NavigationItemModel
    {
        public string Title { get; set; }
        public string IconGlyph { get; set; }
    }
{{endregion}}

#### __[VB.NET] Example 2: Defining a model and a viewmodel__
{{region vb-radnavigationview-item-icon-2}}
    Public Class MainViewModel
		Private ReadOnly glyphStrings() As String = { "&#xe501;", "&#xe13d;", "&#xe500;" }

		Public Property Items() As ObservableCollection(Of NavigationItemModel)

		Public Sub New()
			Me.Items = New ObservableCollection(Of NavigationItemModel)()

			For i As Integer = 1 To 3
				Dim glyphString = Me.glyphStrings(i - 1)
				Me.Items.Add(New NavigationItemModel() With {
					.Title = "Item " & i,
					.IconGlyph = glyphString
				})
			Next i
		End Sub
    End Class

	Public Class NavigationItemModel
		Public Property Title() As String
		Public Property IconGlyph() As String
	End Class
{{endregion}}

After that we can setup our __RadNavigationView__ and set its ItemsSource to an instance of our viewmodel. We also need to create a style targeting __RadNavigationViewItem__ in order to bind the properties of the NavigationItemModel class. Note, that a StringToGlyphConverter is used to convert the IconGlyph string property to a glyph. 

#### __[C#] Example 3: Setting up the view__
{{region xaml-radnavigationview-item-icon-3}}
    <Window.Resources>
        <local:MainViewModel x:Key="ViewModel" />
        <telerik:StringToGlyphConverter x:Key="StringToGlyphConverter" />

        <!-- If you are using the NoXaml binaries, you will have to base the style on the default one for the theme like so:
        <Style TargetType="telerik:RadNavigationViewItem" BasedOn="{StaticResource RadNavigationViewItemStyle}">-->

        <Style TargetType="telerik:RadNavigationViewItem">
            <Setter Property="Content" Value="{Binding Title}" />
            <Setter Property="Icon" Value="{Binding IconGlyph}" />
            <Setter Property="IconTemplate">
                <Setter.Value>
                    <DataTemplate>
                        <telerik:RadGlyph Glyph="{Binding Converter={StaticResource StringToGlyphConverter}}" />
                    </DataTemplate>
                </Setter.Value>
            </Setter>
        </Style>
    </Window.Resources>
    <Grid>
        <telerik:RadNavigationView DataContext="{StaticResource ViewModel}" ItemsSource="{Binding Items}" PaneHeader="Header" />
    </Grid>
{{endregion}}

#### __Figure 2: Result from Example 3 in the Office2016 theme__
![RadNavigationViewItems with Icons set through IconTemplate](images/NavigationViewItem_IconTemplate.png)

>For a more extensive databinding example check out the [DataBinding]({%slug radnavigationview-populating-with-data-databinding%}) article.

## See Also

* [DataBinding]({%slug radnavigationview-populating-with-data-databinding%})
* [Display Mode]({%slug radnavigationview-display-mode%})
* [Icon and IconTemplate]({%slug radnavigationview-icon-and-icontemplate%})