---
title: Template and Style Selectors
page_title: Template and Style Selectors
description: Check our &quot;Template and Style Selectors&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-populating-with-data-template-and-style-selectors
tags: template,and,style,selectors
published: True
position: 4
---

# Template and Style Selectors

The __RadContextMenu__ and the __RadMenuItem__ controls come with a set of selector properties. Typically, you use a template or style selector when you have more than one data template or style defined for the same type of objects.

>The following example is based on the [Populating with Data - Binding to Dynamic Data]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%}) article.

Here is a list of the selectors provided by the __RadContextMenu__ control:

* __ItemTemplateSelector:__ Used to select the __DataTemplate__ that is set as the __HeaderTemplate__ property of the child __RadMenuItems__.

#### __[C#] Example 1: Define the ItemTemplateSelector__

{{region radcontextmenu-populating-with-data-template-and-style-selectors_1}}
	public class MyTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CutTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item.ToString() == "Cut")
            {
                return this.CutTemplate;
            }
            return this.DefaultTemplate;
        }
    }
	{{endregion}}

#### __[XAML] Example 2: Using the ItemTemplateSelector in XAML__

	{{region radcontextmenu-populating-with-data-template-and-style-selectors_0}}
		<Grid.Resources>
	    <!-- ... -->
            <local:MyTemplateSelector x:Key="MyTemplateSelector">
                <local:MyTemplateSelector.CutTemplate>
                    <DataTemplate>
                        <StackPanel Orientation="Horizontal">
                            <Rectangle Width="10" Height="10" Fill="Red"/>
                            <TextBlock Text="{Binding}" />
                        </StackPanel>
                    </DataTemplate>
                </local:MyTemplateSelector.CutTemplate>
                <local:MyTemplateSelector.DefaultTemplate>
                    <DataTemplate>
                        <TextBlock Text="{Binding}" />
                    </DataTemplate>
                </local:MyTemplateSelector.DefaultTemplate>
            </local:MyTemplateSelector>
        </Grid.Resources>

        <TextBox Width="200" VerticalAlignment="Top" ContextMenu="{x:Null}">
            <telerik:RadContextMenu.ContextMenu>
                <telerik:RadContextMenu x:Name="radContextMenu" 
                                        ItemContainerStyle="{StaticResource MenuItemStyle}"
                                        ItemTemplateSelector="{StaticResource MyTemplateSelector}"/>
            </telerik:RadContextMenu.ContextMenu>
        </TextBox>
    {{endregion}}

#### __Figure 1: Result of Example 1 and Example 2__ 
![RadContextMenu with ItemTemplateSelector](images/RadContextMenu_TemplateAndStyleSelectors_ItemTemplateSelector.PNG)

* __ItemContainerStyleSelector:__ Used to select the __Style__ that is applied to the child __RadMenuItems__.

#### __[C#] Example 3: Define the ItemContainerStyleSelector__

{{region radcontextmenu-populating-with-data-template-and-style-selectors_3}}
	public class MyStyleSelector : StyleSelector
    {
        public Style CutStyle { get; set; }
        public Style DefaultStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            var menuItem = item as MenuItem;
            if (menuItem.Text == "Cut")
            {
                return this.CutStyle;
            }
            return this.DefaultStyle;
        }
    }
	{{endregion}}

#### __[XAML] Example 4: Using the ItemContainerStyleSelector in XAML__

	{{region radcontextmenu-populating-with-data-template-and-style-selectors_2}}
		<Grid.Resources>
            <!-- ... -->
	    <local:MyStyleSelector x:Key="MyStyleSelector" DefaultStyle="{StaticResource MenuItemStyle}">
                <local:MyStyleSelector.CutStyle>
                    <Style TargetType="telerik:RadMenuItem" BasedOn="{StaticResource MenuItemStyle}">
                        <Setter Property="Background" Value="Red"/>
                    </Style>
                </local:MyStyleSelector.CutStyle>
            </local:MyStyleSelector>
        </Grid.Resources>

        <TextBox Width="200" VerticalAlignment="Top" ContextMenu="{x:Null}">
            <telerik:RadContextMenu.ContextMenu>
                <telerik:RadContextMenu x:Name="radContextMenu"
                                        ItemContainerStyleSelector="{StaticResource MyStyleSelector}"/>
            </telerik:RadContextMenu.ContextMenu>
        </TextBox>
    {{endregion}}

#### __Figure 2: Result of Example 3 and Example 4__ 
![RadContextMenu with ItemContainerStyleSelector](images/RadContextMenu_TemplateAndStyleSelectors_ItemContainerStyleSelector.PNG)

And a list of the selectors provided by the __RadMenuItem__ control:

* __HeaderTemplateSelector:__ Used to select the __DataTemplate__ that is set to its __HeaderTemplate__ property.

* __ItemContainerStyleSelector:__ Used to select the __Style__ that is applied to the child __RadMenuItems__.

* __ItemTemplateSelector:__ Used to select the __DataTemplate__ that is set as the __HeaderTemplate__ property of the child __RadMenuItems__.

>tipThese properties of the __RadMenuItem__ should be set through the __ItemContainerStyle__ of the parent item. If you set the __ItemContainerStyle__ property of the __RadContextMenu__ only (valid for [dynamic data scenarios]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%})), it will get inherited in the hierarchy, unless it is not explicitly set somewhere.

The __HierarchicalDataTemplate__ used with the __RadContextMenu__ also exposes __ItemContainerStyleSelector__ and __ItemTemplateSelector__ properties.

## See Also

 * [Data Binding Support Overview]({%slug radcontextmenu-populating-with-data-data-binding-support-overview%})

 * [Using Static Items]({%slug radcontextmenu-populating-with-data-using-static-items%})

 * [Binding to Dynamic Data]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%})

 * [Styles and Templates - Overview]({%slug radcontextmenu-styles-and-templates-overview%})
