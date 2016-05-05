---
title: Styling Merged Cells
page_title: Styling Merged Cells
description: Styling Merged Cells
slug: gridview-styling-mergedcell
tags: styling,merged,cells
published: True
position: 5
site_name: WPF
---

# Styling Merged Cells

>tipMerged cells have a template structure similar to [RadGridView cells]({%slug gridview-styling-cell%}). You could also get check the [Template Structure of the GridViewMergedCell]({%slug radgridview-styles-and-templates-templates-structure%}#gridviewmergedcell).

In this article we will discuss the following topics:

* [Targeting the GridViewMergedCell element](#targeting-the-gridviewmergedcell-element)

* [Setting MergedCellsStyle](#setting-mergedcellsstyle)

* [Setting MergedCellsStyleSelector](#setting-mergedcellsstyleselector)

## Targeting the GridViewMergedCell element
        
In order to style merged cells, you should create an appropriate style targeting the __GridViewMergedCell__ element.

You have two options:

* To create an empty style and set it up on your own.

* To copy the default style of the control and modify it.

>To learn how to modify the default GridViewMergedCell style, please refer to the [Modifying Default Styles]({%slug gridview-modifying-default-styles%}) article.

>The __GridViewMergedCell__ is located in the __Telerik.Windows.Controls.GridView__ namespace of the __Telerik.Windows.Controls.GridView__ assembly.

>__GridViewMergedCell uses Triggers__, not VisualStateManager's states to apply property values based on specified conditions.

You can apply a style to the merged cells, similar to:

#### __[XAML] Example 1: Styling all merged cells of an application__

	{{region gridview-merged-cells_1}}
	<Style TargetType="telerik:GridViewMergedCell">
		<Setter Property="VerticalContentAlignment" Value="Top"/>
		<Setter Property="HorizontalContentAlignment" Value="Center"/>
		<Setter Property="Background" Value="#ffcc00"/>
	</Style>
	{{endregion}}

>If you're using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}), you should base your style on the __GridViewMergedCellStyle__.

>tipIf you choose to define the style in the resources of the application, it would be available for the entire application. This allows you to define a style only once and then reuse it where needed.

#### __Figure 1: Styled merged cells__

![RadGridView styled merged cells](images/gridview_merged_cells_5.png)

## Setting MergedCellsStyle

If instead you would like to set a style only for a specific RadGridView, you can use its **MergedCellsStyle** property, like so:

#### __[XAML] Example 2: Styling merged cells of a specific RadGridView__

	{{region gridview-merged-cells_2}}
	<Grid.Resources>
		<Style TargetType="telerik:GridViewMergedCell" x:Key="GridViewMergedCellsStyle">
			<Setter Property="VerticalContentAlignment" Value="Top"/>
			<Setter Property="HorizontalContentAlignment" Value="Center"/>
			<Setter Property="Background" Value="#ffcc00"/>
		</Style>
	</Grid.Resources>

	<telerik:RadGridView MergedCellsStyle="{StaticResource GridViewMergedCellsStyle}" />
	{{endregion}}

>tipIf you are using [Implicit Themes]({%slug styling-apperance-implicit-styles-overview%}), you should base the style on the one defined for the corresponding theme.

## Setting MergedCellsStyleSelector

You could also use RadGridView's **MergedCellsStyleSelector** property to style merged cells differently based on a specific condition.

>importantBear in mind that the **MergedCellsStyle** takes precedence over the **MergedCellsStyleSelector** and will overwrite it if both are defined simultaneously.

To do so, first create a new class which inherits the **StyleSelector** class and override its **SelectStyle** method:

#### __[C#] Example 3: The StadiumCapacityStyleSelector class__

	public class StadiumCapacityStyleSelector : StyleSelector
    {
        public override Style SelectStyle(object item, DependencyObject container)
        {
            var cell = item as MergedCellInfo;

            if (cell != null)
            {
                if (int.Parse(cell.Value.ToString()) > 50000)
                {
                    return BigStadiumStyle;
                }
                else
                {
                    return SmallStadiumStyle;
                }
            }

            return null; 
        }
        public Style BigStadiumStyle { get; set; }
        public Style SmallStadiumStyle { get; set; }
    }

In the XAML file, define the style selector as a resource and set the properties of the **BigStadiumStyle** and **SmallStadiumStyle**:

#### __[XAML] Example 4: Setting the BigStadiumStyle and SmallStadiumStyle__

	<Grid.Resources>
        <my:StadiumCapacityStyleSelector x:Key="StadiumCapacityStyleSelector">
            <my:StadiumCapacityStyleSelector.BigStadiumStyle>
                <Style TargetType="telerik:GridViewMergedCell">
                    <Setter Property="Background" Value="Red"/>
                </Style>
            </my:StadiumCapacityStyleSelector.BigStadiumStyle>
            <my:StadiumCapacityStyleSelector.SmallStadiumStyle>
                <Style TargetType="telerik:GridViewMergedCell">
                    <Setter Property="Background" Value="Yellow" />
                </Style>
            </my:StadiumCapacityStyleSelector.SmallStadiumStyle>
        </my:StadiumCapacityStyleSelector>
	</Grid.Resources>

>The **"my:"** prefix before **StadiumCapacityStyleSelector** specifies the mapping for the namespace of the project: **xmlns:my="..."**

Finally, set the **MergedCellsStyleSelector** property:

#### __[XAML] Example 5: Setting the MergedCellsStyleSelector property__

{{region gridview-merged-cells_3}}

	<telerik:RadGridView MergedCellsStyleSelector="{StaticResource StadiumCapacityStyleSelector}" />
{{endregion}}

And here is the final result:

#### __Figure 2: The merged cells styled using the MergedCellsStyleSelector property__

![Merged cells styled using the MergedCellsStyleSelector property](images/gridview-merged_cells_styleselector.png)

# See Also

 * [Setting a Theme (Using Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})

 * [Editing Control Templates]({%slug styling-apperance-editing-control-templates%})

 * [Styling a Cell]({%slug gridview-styling-cell%})
