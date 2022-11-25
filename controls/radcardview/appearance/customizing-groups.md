---
title: Customizing Groups
page_title: Customizing Groups
description: RadCardView groups can be cusomized using several properties of the control.
slug: radcardview-appearance-customizing-groups
tags: customize, group, style, panel
published: True
position: 1
---

# Customizing Groups

A RadCardView group can be customized in order to match the expected design or functionality.

>tip Read the [Grouping]({%slug radcardview-features-grouping%}) article to see how to setup the grouping.

## Group Panel

To change the __visibility__ of the [group panel]({%slug radcardview-visual-structure%})'s text and items, set the __ShowGroupPanel__ property of RadCardView.

#### __[XAML] Example 1: Hiding group panel__
{{region radcardview-appearance-customizing-groups-0}}
    <telerik:RadCardView ShowGroupPanel="False"/>
{{endregion}}

#### Figure 1: Hidden group panel
![WPF RadCardView Hidden group panel](images/radcardview-appearance-customizing-groups-0.png)

To change the __background color__ of the group panel, set the __GroupPanelBackground__ property of RadCardView.

To change the __text color__ of the group panel, set the __GroupPanelForeground__ property of RadCardView.

To __disable the sorting__ of groups with the [group member button]({%slug radcardview-visual-structure%}), set the __CanUserSortGroups__ property of RadCardView.

#### __[XAML] Example 2: Customizing group panel colors__
{{region radcardview-appearance-customizing-groups-1}}
    <telerik:RadCardView GroupPanelBackground="#CA5100"
						 GroupPanelForeground="White"
                         CanUserSortGroups="False"/>
{{endregion}}

#### Figure 2: Changed group panel background
![WPF RadCardView Changed group panel background](images/radcardview-appearance-customizing-groups-1.png)

Additionally, the element that represents the group panel can be customized using the __GroupPanelStyle__ property.

#### __[XAML] Example 3: Customizing group panel style__
{{region radcardview-appearance-customizing-groups-2}}
	<telerik:RadCardView.GroupPanelStyle>
		<Style TargetType="cardView:CardViewGroupPanel">
			<Setter Property="Height" Value="50" />
			<Setter Property="Opacity" Value="0.5" />
		</Style>
	</telerik:RadCardView.GroupPanelStyle>
{{endregion}}

The "cardView:" namespace points to `xmlns:cardView="clr-namespace:Telerik.Windows.Controls.Data.CardView;assembly=Telerik.Windows.Controls.Data"`

#### Figure 3: Customized group panel style
![WPF RadCardView Customized group panel style](images/radcardview-appearance-customizing-groups-2.png)

To customize the [group member button]({%slug radcardview-visual-structure%}) elements in the group panel, set the __GroupPanelItemStyle__ property.

#### __[XAML] Example 4: Customizing group panel items__
{{region radcardview-appearance-customizing-groups-3}}
	<telerik:RadCardView.GroupPanelItemStyle>
		<Style TargetType="cardView:CardViewGroupPanelItem">
			<Setter Property="Height" Value="50" />
		</Style>
	</telerik:RadCardView.GroupPanelItemStyle>
{{endregion}}

#### Figure 4: Customized group panel items
![WPF RadCardView Customized group panel items](images/radcardview-appearance-customizing-groups-3.png)

## Group Item Indentation

To set the group items horizontal offset (indentation), set the __GroupItemIndentation__ property. 

#### __[XAML] Example 5: Changing group items indentation__
{{region radcardview-appearance-customizing-groups-4}}
	<telerik:RadCardView GroupItemIndentation="25" />
{{endregion}}

#### Figure 5: Customized group panel items
![WPF RadCardView Customized group panel items](images/radcardview-appearance-customizing-groups-4.png)

## See Also  
* [Data Binding]({%slug radcardview-populating-with-data-data-binding%})
* [Customizing Cards]({%slug radcardview-appearance-customizing-cards%}) 
* [Customizing Filtering Control]({%slug radcardview-appearance-customizing-filtering-control%}) 