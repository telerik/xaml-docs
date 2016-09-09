---
title: GroupFooterRowStyleSelector
page_title: GroupFooterRowStyleSelector
description: GroupFooterRowStyleSelector
slug: gridview-group-footer-row-style-selector
tags: groupfooterrowstyleselector
published: True
position: 5
---

# GroupFooterRowStyleSelector

The **GroupFooterRowStyleSelector** property of RadGridView can be used to style group footer rows differently based on a specific condition.

>importantBear in mind that the **GroupFooterRowStyle** takes precedence over the **GroupFooterRowStyleSelector** and will overwrite it if both are defined simultaneously.

To do so, first create a new class that inherits the **StyleSelector** class and override its **SelectStyle** method:

#### __[C#] Example 1: The GroupFooterRowStyleSelector class__

	{{region gridview-styling-group-footers-3}}
	public class GroupFooterRowStyleSelector : StyleSelector
    {
        public override Style SelectStyle(object item, DependencyObject container)
        {
            var group = item as CollectionViewGroup;

            if (group != null)
            {
                if (group.ItemCount > 1)
                {
                    return BigGroupStyle;
                }
                else
                {
                    return SmallGroupStyle;
                }
            }

            return null;
        }

        public Style BigGroupStyle { get; set; }
        public Style SmallGroupStyle { get; set; }
    }
	{{endregion}}

#### __[VB.NET] Example 1: The GroupFooterRowStyleSelector class__
	
	{{region gridview-styling-group-footers-4}}
	Public Class GroupFooterRowStyleSelector
	Inherits StyleSelector
		Public Overrides Function SelectStyle(item As Object, container As DependencyObject) As Style
			Dim group = TryCast(item, CollectionViewGroup)
	
			If group IsNot Nothing Then
				If group.ItemCount > 1 Then
					Return BigGroupStyle
				Else
					Return SmallGroupStyle
				End If
			End If
	
			Return Nothing
		End Function

		Public Property BigGroupStyle() As Style
			Get
				Return m_BigGroupStyle
			End Get
			Set
				m_BigGroupStyle = Value
			End Set
		End Property
		Private m_BigGroupStyle As Style

		Public Property SmallGroupStyle() As Style
			Get
				Return m_SmallGroupStyle
			End Get
			Set
				m_SmallGroupStyle = Value
			End Set
		End Property
		Private m_SmallGroupStyle As Style
	End Class
	{{endregion}}

In the XAML file, define the style selector as a resource and set the properties of the **BigGroupStyle** and **SmallGroupStyle**:

#### __[XAML] Example 2: Setting the BigGroupStyle and SmallGroupStyle__

	{{region gridview-styling-group-footers-6}}
	<Grid.Resources>
        <my:GroupFooterRowStyleSelector x:Key="StadiumCapacityStyleSelector">
            <my:GroupFooterRowStyleSelector.BigGroupStyle>
                <Style TargetType="telerik:GridViewGroupFooterRow">
                    <Setter Property="Background" Value="Red"/>
                </Style>
            </my:GroupFooterRowStyleSelector.BigGroupStyle>
            <my:GroupFooterRowStyleSelector.SmallGroupStyle>
                <Style TargetType="telerik:GridViewGroupFooterRow">
                    <Setter Property="Background" Value="Yellow" />
                </Style>
            </my:GroupFooterRowStyleSelector.SmallGroupStyle>
        </my:GroupFooterRowStyleSelector>
	</Grid.Resources>
	{{endregion}}

>The **"my:"** prefix before **GroupFooterRowStyleSelector** specifies the mapping for the namespace of the project: **xmlns:my="..."**

Finally, set the **GroupFooterRowStyleSelector** property:

#### __[XAML] Example 3: Setting the GroupFooterRowStyleSelector property__

	{{region gridview-styling-group-footers-7}}
	<telerik:RadGridView GroupFooterRowStyleSelector="{StaticResource GroupFooterRowStyleSelector}" />
	{{endregion}}

And here is the final result:

#### __Figure 1: The group footer rows styled using the GroupFooterRowStyleSelector property__

![The group footer rows styled using the GroupFooterRowStyleSelector property](images/gridview-groupfooterrowstyleselector.png)

## See Also

 * [Styling Group Row]({%slug gridview-styling-group-row%})

 * [Styling Group Footers]({%slug gridview-styles-and-templates-styling-group-footers%})