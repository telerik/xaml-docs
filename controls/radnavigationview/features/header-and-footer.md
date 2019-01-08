---
title: Header and Footer
page_title: Header and Footer
description: This article will demonstrate how the RadNavigationView header and footer can be customized.
slug: radnavigationview-header-and-footer
tags: header, footer
position: 1
---

# Header and Footer

The RadNavigationView's header and footer parts are fully customizable. This article will demonstrate how this can be achieved.

## Customizing the Header

RadNavigationView's header can be customized with the following properties: __PaneHeader__, __PaneHeaderTemplate__ and __PaneHeaderHeight__. __Example 1__ demonstrates how you set the RadNavigationView's PaneHeader property.

#### __[XAML] Example 1: Setting the PaneHeader property__
{{region xaml-radnavigationview-header-and-footer-0}}
     <telerik:RadNavigationView PaneHeader="My Header" />
{{endregion}}

#### __Figure 1: Result from Example 1 in the Office 2016 theme__
![NavigationView Header](images/NavigationView_Header.png)

It is possible to further customize the header by setting the __PaneHeaderTemplate__ property. The DataContext inside the PaneHeaderTemplate will be whatever is set to the PaneHeader property of the RadNavigationView. __Example 2__ demonstrates how you can set this property along with the __PaneHeaderHeight__ property which controls the height of the pane header.

#### __[XAML] Example 2: Setting the PaneHeaderTemplate and PaneHeaderHeight properties__
{{region xaml-radnavigationview-header-and-footer-1}}
    <Grid>
        <Grid.Resources>
            <DataTemplate x:Key="PaneHeaderTemplate">
                <Border BorderBrush="White" BorderThickness="1" Margin="3">
                    <TextBlock Text="{Binding}" Margin="5"/>
                </Border>
            </DataTemplate>
        </Grid.Resources>

        <telerik:RadNavigationView PaneHeader="My Header" PaneHeaderTemplate="{StaticResource PaneHeaderTemplate}" PaneHeaderHeight="35">
            <telerik:RadNavigationView.Items>
                <telerik:RadNavigationViewItem Content="Bookmarks">
                    <telerik:RadNavigationViewItem.Icon>
                        <telerik:RadGlyph Glyph="&#xe303;" FontSize="16"/>
                    </telerik:RadNavigationViewItem.Icon>
                </telerik:RadNavigationViewItem>
            </telerik:RadNavigationView.Items>
        </telerik:RadNavigationView>
    </Grid>
{{endregion}}

#### __Figure 2: Result from Example 2 in the Office 2016 theme__
![NavigationView HeaderTemplate](images/NavigationView_HeaderTemplate.png)

## Customizing the Footer

RadNavigationView's footer can be customized with the following properties: __PaneFooter__, __PaneFooterTemplate__. The approach for doing so is identical to customizing its header which is described in the previous section.

#### __[XAML] Example 3: Setting the PaneFooter and PaneFooterTemplate properties__
{{region xaml-radnavigationview-header-and-footer-2}}
    <Grid>  
        <Grid.Resources>
            <DataTemplate x:Key="PaneHeaderTemplate">
                <Border BorderBrush="White" BorderThickness="1" Margin="3">
                    <TextBlock Text="{Binding}" Margin="5"/>
                </Border>
            </DataTemplate>

            <DataTemplate x:Key="PaneFooterTemplate">
                <Border BorderBrush="White" BorderThickness="1" Margin="3">
                    <TextBlock Text="{Binding}" Margin="5"/>
                </Border>
            </DataTemplate>
        </Grid.Resources>
    

        <telerik:RadNavigationView PaneHeader="My Header" PaneHeaderTemplate="{StaticResource PaneHeaderTemplate}" PaneFooter="My Footer" PaneFooterTemplate="{StaticResource PaneFooterTemplate}">
            <telerik:RadNavigationView.Items>
                <telerik:RadNavigationViewItem Content="Bookmarks">
                    <telerik:RadNavigationViewItem.Icon>
                        <telerik:RadGlyph Glyph="&#xe303;" FontSize="16"/>
                    </telerik:RadNavigationViewItem.Icon>
                </telerik:RadNavigationViewItem>
            </telerik:RadNavigationView.Items>
        </telerik:RadNavigationView>
    </Grid>
{{endregion}}

#### __Figure 3: Result from Example 3 in the Office 2016 theme__
![NavigationView Footer](images/NavigationView_Footer_FooterTemplate.png)

## Customizing the Pane Toggle Button

RadNavigationView has a RadToggleButton next to its header which allows for expanding or closing the navigation pane. This button is specially designed to show [RadGlyphs]({%slug common-styling-appearance-radglyph%}) ,since it has a RadGlyph in its ContentTemplate. You can easily change which glyph is displayed by setting the __PaneToggleButtonContent__ property to the desired [glyph string]({%slug common-styling-appearance-glyphs-reference-sheet%}). __Example 4__ demonstrates how this can be achieved.

#### __[XAML] Example 4: Setting the PaneToggleButtonContent__
{{region xaml-radnavigationview-header-and-footer-3}}
     <telerik:RadNavigationView x:Name="navigationView" PaneHeader="Header" PaneToggleButtonContent="&#xe301;" />
{{endregion}}

#### __Figure 4: Result from Example 4 in the Office 2016 theme__
![NavigationView Toggle Button](images/NavigationView_PaneToggleButtonContent.png)

If do not want to show a RadGlyph as the Content of the toggle button, you can modify the __PaneToggleButtonContentTemplate__ as demosntrated in __Example 5__.

#### __[XAML] Example 5: Setting the PaneToggleButtonContentTemplate__
{{region xaml-radnavigationview-header-and-footer-4}}
    <DataTemplate x:Key="PaneToggleButtonContentTemplate">
        <Rectangle Width="15" Height="15" Fill="White" />
    </DataTemplate>

     <telerik:RadNavigationView x:Name="navigationView" PaneHeader="Header" PaneToggleButtonContentTemplate="{StaticResource PaneToggleButtonContentTemplate}" />
{{endregion}}

#### __Figure 5: Result from Example 5 in the Office 2016 theme__
![NavigationView Toggle Button with custom content](images/NavigationView_PaneToggleButtonContentTemplate.png)

>The Pane Toggle Button can be customized further by setting the __PaneToggleButtonStyle__ property. It can also be hidden by setting the __PaneToggleButtonVisibility__ property.

## See Also

* [Getting Started]({%slug radnavigationview-getting-started%})
* [DataBinding]({%slug radnavigationview-populating-with-data-databinding%})
* [Display Mode]({%slug radnavigationview-display-mode%})
* [Icon and IconTemplate]({%slug radnavigationview-icon-and-icontemplate%})