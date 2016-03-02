---
title: Styling CheckBoxColumn
page_title: Styling CheckBoxColumn
description: Styling CheckBoxColumn
slug: gridview-columns-styling-checkboxcolumn
tags: styling,checkboxcolumn
published: True
position: 21
---

# Styling GridViewCheckBoxColumn

This topic will show you how to style the __GridViewCheckBoxColumn__.

* [Styling GridViewCheckBoxColumn in View Mode](#styling-gridviewcheckboxcolumn-in-view-mode)

* [Styling GridViewCheckBoxColumn in Edit Mode](#styling-gridviewcheckboxcolumn-in-edit-mode)

* [Applying the Styles to GridViewCheckBoxColumn Explicitly](#applying-the-styles-to-gridviewcheckboxcolumn-explicitly)

* [Centering GridViewCheckBoxColumn in Edit Mode](#centering-gridviewcheckboxcolumn-in-edit-mode) 

The cells of __RadGridView__ have two templates for their current state - when in __view mode__ and in __edit mode__. By default, __GridViewCheckBoxColumn__ uses a __GridViewCheckBox__ when in __view mode__ and the standard __CheckBox__ control as its __editor__. __GridViewCheckBox__ is an element that emulates the behavior of a __CheckBox__ and is especially designed for __RadGridView__. 

>In order to style the whole cell rather than the __GridViewCheckBox__ element only, you can set the __CellStyle__ property of the __GridViewCheckBoxColumn__. More information can be found in the [Styling Cells]({%slug gridview-styling-cell%}) topic. 

## Styling GridViewCheckBoxColumn in View Mode

#### __Figure 1: Default look of GridViewCheckBox__
        
![Rad Grid View Styles and Templates Styling Check Box Column 01](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_01.PNG)


For modifying the visual appearance of the cell in __view mode__, the __ControlTemplate__ of __GridViewCheckBox__ should be modified.

#### __[XAML] Example 1: Defining the ControlTemplate of GridViewCheckBox__

	<ControlTemplate x:Key="GridViewCheckBoxTemplate" TargetType="grid:GridViewCheckBox">
            <Grid HorizontalAlignment="Left" VerticalAlignment="Center" Width="13" Height="13">
                <VisualStateManager.VisualStateGroups>
                    <VisualStateGroup x:Name="CheckStates">
                        <VisualState x:Name="Checked">
                            <Storyboard>
                                <ObjectAnimationUsingKeyFrames BeginTime="0" Duration="0" Storyboard.TargetName="CheckedPath" Storyboard.TargetProperty="(UIElement.Visibility)">
                                    <DiscreteObjectKeyFrame KeyTime="0">
                                        <DiscreteObjectKeyFrame.Value>
                                            <Visibility>Visible</Visibility>
                                        </DiscreteObjectKeyFrame.Value>
                                    </DiscreteObjectKeyFrame>
                                </ObjectAnimationUsingKeyFrames>
                            </Storyboard>
                        </VisualState>
                        <VisualState x:Name="Unchecked"/>
                        <VisualState x:Name="Indeterminate">
                            <Storyboard>
                                <ObjectAnimationUsingKeyFrames BeginTime="0" Duration="0" Storyboard.TargetName="IndeterminatePath" Storyboard.TargetProperty="(UIElement.Visibility)">
                                    <DiscreteObjectKeyFrame KeyTime="0">
                                        <DiscreteObjectKeyFrame.Value>
                                            <Visibility>Visible</Visibility>
                                        </DiscreteObjectKeyFrame.Value>
                                    </DiscreteObjectKeyFrame>
                                </ObjectAnimationUsingKeyFrames>
                            </Storyboard>
                        </VisualState>
                    </VisualStateGroup>
                </VisualStateManager.VisualStateGroups>
                <Border BorderBrush="#FF989898" BorderThickness="1 1 1 1">
                    <Border BorderBrush="#FFEEEEEE" BorderThickness="1 1 1 1">
                        <Border BorderThickness="1 1 1 1" Background="#FFE0E0E0" BorderBrush="#FFB9B9B9">
                            <Grid Margin="0" Background="Blue">
                                <Path x:Name="IndeterminatePath"
                                    Visibility="Collapsed"
                                    Stretch="Fill"
                                    Stroke="#FF8D8D8D"
                                    StrokeThickness="1.5"
                                    Data="M14.708333,144.5 L20.667,144.5"
                                    Width="7"
                                    Height="7"
                                    HorizontalAlignment="Center"
                                    VerticalAlignment="Center"
                                    Margin="0"/>
                                <Path x:Name="CheckedPath"
                                    Visibility="Collapsed"
                                    Stretch="Fill"
                                    Stroke="#FF8D8D8D"
                                    Data="M32.376187,77.162509 L35.056467,80.095277 40.075451,70.02144"
                                    StrokeThickness="1.5"
                                    Margin="0"
                                    HorizontalAlignment="Center"
                                    VerticalAlignment="Center"/>
                            </Grid>
                        </Border>
                    </Border>
                </Border>
            </Grid>
        </ControlTemplate>



After the needed __ControlTemplate__ is defined, it can be applied through the __Template__ property of __GridViewCheckBox__.

#### __[XAML] Example 2: Applying the ControlTemplate to GridViewCheckBox__

	<Style x:Key="GridViewCheckBoxStyle" TargetType="grid:GridViewCheckBox">
    	<Setter Property="Template" Value="{StaticResource GridViewCheckBoxTemplate}"/>
	</Style>

	<Style TargetType="grid:GridViewCheckBox" BasedOn="{StaticResource GridViewCheckBoxStyle}"/>


## Styling GridViewCheckBoxColumn in Edit Mode


In order to alter the appearance of the __editor__ of __GridViewCheckBoxColumn__, a __ControlTemplate__ targeting the __CheckBox__ control should be defined.

#### __[XAML] Example 3: Defining the ControlTemplate of CheckBox__

	<ControlTemplate TargetType="CheckBox" x:Key="CheckBoxTemplate">
                    <Grid Background="Yellow">
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="CommonStates">
                                <VisualState x:Name="Normal"/>
                                <VisualState x:Name="MouseOver">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="OuterBorder" Storyboard.TargetProperty="BorderBrush">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxOuterBorder_MouseOver}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="InnerBorder" Storyboard.TargetProperty="BorderBrush">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxInnerBorder_MouseOver}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="InnerBorder" Storyboard.TargetProperty="Background">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxInnerBackground_MouseOver}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="CheckIcon" Storyboard.TargetProperty="Stroke">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxTickStroke_MouseOver}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="IndeterminateIcon" Storyboard.TargetProperty="Stroke">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxTickStroke_MouseOver}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                                <VisualState x:Name="Pressed">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="IntermediateBorder" Storyboard.TargetProperty="BorderBrush">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxIntermediateBorder_Pressed}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="OuterBorder" Storyboard.TargetProperty="BorderBrush">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxOuterBorder_Pressed}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="InnerBorder" Storyboard.TargetProperty="BorderBrush">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxInnerBorder_Pressed}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="InnerBorder" Storyboard.TargetProperty="Background">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxInnerBackground_Pressed}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="CheckIcon" Storyboard.TargetProperty="Stroke">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxTickStroke_Pressed}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="IndeterminateIcon" Storyboard.TargetProperty="Stroke">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxTickStroke_Pressed}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                                <VisualState x:Name="Disabled">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="IntermediateBorder" Storyboard.TargetProperty="BorderBrush">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxIntermediateBorder_Disabled}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="OuterBorder" Storyboard.TargetProperty="BorderBrush">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxOuterBorder_Disabled}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="OuterBorder" Storyboard.TargetProperty="Background">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxOuterBackground_Disabled}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="InnerBorder" Storyboard.TargetProperty="BorderBrush">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxInnerBorder_Disabled}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="InnerBorder" Storyboard.TargetProperty="Background">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxInnerBackground_Disabled}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <DoubleAnimation Duration="0" Storyboard.TargetName="ContentItem" Storyboard.TargetProperty="Opacity" To="0.5"/>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="CheckIcon" Storyboard.TargetProperty="Stroke">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxTickStroke_Disabled}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="IndeterminateIcon" Storyboard.TargetProperty="Stroke">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource CheckBoxTickStroke_Disabled}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                            </VisualStateGroup>
                            <VisualStateGroup x:Name="CheckStates">
                                <VisualState x:Name="Unchecked"/>
                                <VisualState x:Name="Checked">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="CheckIcon" Storyboard.TargetProperty="Visibility">
                                            <DiscreteObjectKeyFrame KeyTime="0">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <Visibility>Visible</Visibility>
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                                <VisualState x:Name="Indeterminate">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="IndeterminateIcon" Storyboard.TargetProperty="Visibility">
                                            <DiscreteObjectKeyFrame KeyTime="0">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <Visibility>Visible</Visibility>
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                            </VisualStateGroup>
                            <VisualStateGroup x:Name="FocusStates">
                                <VisualState x:Name="Focused">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="FocusBorder" Storyboard.TargetProperty="Visibility">
                                            <DiscreteObjectKeyFrame KeyTime="0">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <Visibility>Visible</Visibility>
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="OuterBorder" Storyboard.TargetProperty="Visibility">
                                            <DiscreteObjectKeyFrame KeyTime="0">
                                                <DiscreteObjectKeyFrame.Value>
                                                    <Visibility>Collapsed</Visibility>
                                                </DiscreteObjectKeyFrame.Value>
                                            </DiscreteObjectKeyFrame>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                                <VisualState x:Name="Unfocused"/>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="Auto"/>
                            <ColumnDefinition Width="*"/>
                        </Grid.ColumnDefinitions>
                        <Grid Width="15" Height="15" HorizontalAlignment="Left" VerticalAlignment="Center" >
                            <Border x:Name="FocusBorder"
                                    Width="13"
                                    Height="13"
                                    Visibility="Collapsed"
                                    BorderThickness="{TemplateBinding BorderThickness}"
                                    BorderBrush="{StaticResource CheckBoxOuterBorder_Focused}"
                                    Background="{StaticResource CheckBoxOuterBackground_Focused}"/>
                            <Border x:Name="OuterBorder" Width="13" Height="13" BorderThickness="{TemplateBinding BorderThickness}" BorderBrush="{TemplateBinding BorderBrush}"/>
                            <Border x:Name="IntermediateBorder"
                                    Width="11"
                                    Height="11"
                                    VerticalAlignment="Center"
                                    HorizontalAlignment="Center"
                                    BorderThickness="1"
                                    BorderBrush="{TemplateBinding Background}">
                                <Border x:Name="InnerBorder" BorderThickness="1" BorderBrush="{StaticResource CheckBoxInnerBorder_Normal}" Background="{StaticResource CheckBoxInnerBackground_Normal}"/>
                            </Border>
                            <Path x:Name="CheckIcon"
                                    FlowDirection="LeftToRight"
                                    Visibility="Collapsed"
                                    Width="9"
                                    Height="9"
                                    Stretch="None"
                                    StrokeThickness="1.5"
                                    Stroke="{StaticResource CheckBoxTickStroke_Normal}"
                                    Data="M1.5,6 L3.5,7.5 L7,2"/>
                            <Path x:Name="IndeterminateIcon"
                                    FlowDirection="LeftToRight"
                                    Visibility="Collapsed"
                                    Width="9"
                                    Height="9"
                                    Stretch="None"
                                    StrokeThickness="1.5"
                                    Stroke="{StaticResource CheckBoxTickStroke_Normal}"
                                    Data="M2,4 L 7,4"/>
                        </Grid>
                        <ContentPresenter x:Name="ContentItem"
                                Grid.Column="1"
                                Margin="{TemplateBinding Padding}"
                                Content="{TemplateBinding Content}"
                                ContentTemplate="{TemplateBinding ContentTemplate}"
                                HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
                                VerticalAlignment="{TemplateBinding VerticalContentAlignment}"
                                RecognizesAccessKey="True"/>
                    </Grid>
                </ControlTemplate>



The customized __ControlTemplate__ can be applied as follows.

#### __[XAML] Example 4: Applying the ControlTemplate to CheckBox__

	<Style x:Key="CheckBoxStyleGridViewColumn" TargetType="CheckBox">
    	<Setter Property="Template" Value="{StaticResource CheckBoxTemplate}"/>
    </Style>

    <Style TargetType="CheckBox" BasedOn="{StaticResource CheckBoxStyleGridViewColumn}"/>

## Applying the Styles to GridViewCheckBoxColumn Explicitly

The aforementioned approach implies defining the styles __implicitly__. If applying the modifications to a particular instance of __RadGridView__ is needed, these Styles can be applied __explicitly__ through the __Resources__ of __RadGridView__.

	<telerik:RadGridView.Resources>
		...
	</telerik:RadGridView.Resources>

## Centering GridViewCheckBoxColumn in Edit Mode

In order to center the checkbox in a GridViewCheckBoxColumn you can define a style targeting GridViewCell and set the HorizontalContentAlignment property to "Center":

####  __[XAML] Example 4: Centering the GridViewCheckBoxColumn__

{{region gridview-checkbox-column_3}}

	<Style x:Key="MyCheckBoxColumnCellStyle" TargetType="telerik:GridViewCell">
		<Setter Property="HorizontalContentAlignment" Value="Center"/>
	</Style>
{{endregion}}


Now the __GridViewCheckBoxColumn__ will look like:
        

![Rad Grid View Styles and Templates Styling Check Box Column 03](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_03.PNG)

However, there is a pixel offset when the GridViewCheckBoxColumn goes into edit mode:
        

![Rad Grid View Styles and Templates Styling Check Box Column 04](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_04.PNG)

In order to align the default editor of __GridViewCheckBoxColumn__ correctly, you can specify a different __Margin__ for it by handling the __PreparingCellForEdit__ event of __RadGridView__:
        

#### __[C#] Example 5: Setting the Margin of the editor GridViewCheckBoxColumn__

	private void RadGridView_PreparingCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
	{
	   if (e.Column.UniqueName == "GridViewCheckBoxColumn")
	   {
	       var checkBox = e.EditingElement as CheckBox;
	       checkBox.Margin = new Thickness(4, 0, -3, 0);
	   }
	}



Here is the result:
        
![Rad Grid View Styles and Templates Styling Check Box Column 05](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_05.PNG)


# See Also

 * [CheckBox Column]({%slug gridview-checkbox-column%})
