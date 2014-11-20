---
title: Styling the CheckBoxColumn
page_title: Styling the CheckBoxColumn
description: Styling the CheckBoxColumn
slug: gridview-columns-styling-checkboxcolumn
tags: styling,the,checkboxcolumn
published: True
position: 21
---

# Styling the CheckBoxColumn

This topic will show you how to style the __GridViewCheckBoxColumn__

The standard GridViewCheckBoxColumn uses a __GridViewCheckBox__ in view mode and the standard __CheckBox__ control as its editor. __GridViewCheckBox__ is an element that emulates the behavior of a CheckBox and it is especially designed for RadGridView. Its control template contains a Grid container with Path elements that appear in its Checked/Indeterminate states. 

## Applying the default MS CheckBox style to GridViewCheckBox

__GridViewCheckBox__ is gray colored by design when the cell is not in __Edit__ mode.
        
![Rad Grid View Styles and Templates Styling Check Box Column 01](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_01.PNG)

If you want to predefine __GridViewCheckBox__ to look like the default __CheckBox__ control, you have two options:
        

* To copy the default style of __GridViewCheckBox__ and modify it using __MS Expression Blend__. You can find its full template below:
            

#### __XAML__

{{region gridview-checkbox-column_4}}

	<ControlTemplate x:Key="GridViewCheckBoxTemplate" TargetType="grid:GridViewCheckBox">
	  <Grid HorizontalAlignment="Left" VerticalAlignment="Center" Width="13" Height="13">
	    <VisualStateManager.VisualStateGroups>
	      <VisualStateGroup x:Name="CheckStates">
	        <VisualState x:Name="Checked">
	          <Storyboard>
	            <ObjectAnimationUsingKeyFrames BeginTime="0" Duration="0"
	                    Storyboard.TargetName="CheckedPath"
	                    Storyboard.TargetProperty="(UIElement.Visibility)">
	              <DiscreteObjectKeyFrame KeyTime="0">
	                <DiscreteObjectKeyFrame.Value>
	                  <Visibility>Visible</Visibility>
	                </DiscreteObjectKeyFrame.Value>
	              </DiscreteObjectKeyFrame>
	            </ObjectAnimationUsingKeyFrames>
	          </Storyboard>
	        </VisualState>
	        <VisualState x:Name="Unchecked" />
	        <VisualState x:Name="Indeterminate">
	          <Storyboard>
	            <ObjectAnimationUsingKeyFrames BeginTime="0" Duration="0"
	                    Storyboard.TargetName="IndeterminatePath"
	                    Storyboard.TargetProperty="(UIElement.Visibility)">
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
	          <Grid Margin="0">
	            <Path x:Name="IndeterminatePath" Visibility="Collapsed" Stretch="Fill" Stroke="#FF8D8D8D" StrokeThickness="1.5" Data="M14.708333,144.5 L20.667,144.5" Width="7" Height="7" HorizontalAlignment="Center" VerticalAlignment="Center" Margin="0"/>
	            <Path x:Name="CheckedPath"  Visibility="Collapsed" Stretch="Fill" Stroke="#FF8D8D8D" Data="M32.376187,77.162509 L35.056467,80.095277 40.075451,70.02144" StrokeThickness="1.5" Margin="0" HorizontalAlignment="Center" VerticalAlignment="Center"/>
	          </Grid>
	        </Border>
	      </Border>
	    </Border>
	  </Grid>
	</ControlTemplate>
	<Style x:Key="GridViewCheckBoxStyle" TargetType="grid:GridViewCheckBox">
	  <Setter Property="Template" Value="{StaticResource GridViewCheckBoxTemplate}" />
	</Style>
	<Style TargetType="grid:GridViewCheckBox" BasedOn="{StaticResource GridViewCheckBoxStyle}"/>
{{endregion}}


* To apply the MS CheckBox's style to __GridViewCheckBox__.
            

This topic will show you how to perform the second one.
        

The default __CheckBox__ style is available with the installation of the __RadControls__. You can find it browsing through the __Themes__ folder for a particlular Theme "..\Themes\OfficeBlack\Themes" inside "System.Windows.xaml" file.
        

#### __XAML__

{{region gridview-checkbox-column_1}}

	<Style x:Key="CheckBoxStyle" TargetType="CheckBox">           
	    <Setter Property="Template">
	        <Setter.Value>
	            <ControlTemplate TargetType="CheckBox">
	                .
	                .
	            </ControlTemplate>
	        </Setter.Value>
	    </Setter>
	</Style>
	<Style TargetType="CheckBox" BasedOn="{StaticResource CheckBoxStyle}" />
{{endregion}}


You can change CheckBox's __TargetType__ to __GridViewCheckBox__. That way the default CheckBox style will be applied to GridViewCheckBox.
        

#### __XAML__

{{region gridview-checkbox-column_2}}

	<Style x:Key="CheckBoxStyle" TargetType="telerik:GridViewCheckBox">           
	    <Setter Property="Template">
	        <Setter.Value>
	            <ControlTemplate TargetType="telerik:GridViewCheckBox">
	                .
	                .
	            </ControlTemplate>
	        </Setter.Value>
	    </Setter>
	</Style>
	<Style TargetType="telerik:GridViewCheckBox" BasedOn="{StaticResource CheckBoxStyle}" />
{{endregion}}

Now the __GridViewCheckBoxColumn__ will look like:

![Rad Grid View Styles and Templates Styling Check Box Column 02](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_02.PNG)

## Centering the checkbox

In order to center the checkbox in GridViewCheckBoxColumn you can define a style targeting GridViewCell and set the HorizontalContentAlignment property to "Center":

#### __XAML__

{{region gridview-checkbox-column_3}}

	<Style x:Key="MyCheckBoxColumnCellStyle" TargetType="telerik:GridViewCell">
		<Setter Property="HorizontalContentAlignment" Value="Center"/>
	</Style>
{{endregion}}


Now the __GridViewCheckBoxColumn__ will look like:
        

![Rad Grid View Styles and Templates Styling Check Box Column 03](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_03.PNG)

However, there is a pixel offset when the GridViewCheckBoxColumn goes into edit mode:
        

![Rad Grid View Styles and Templates Styling Check Box Column 04](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_04.PNG)

In order to align the dafault editor of GridViewCheckBoxColumn correctly, you can specify a different Margin for it by handling the PreparingCellForEdit event of RadGridView:
        

#### __C#__

{{region gridview-checkbox-column_4}}

	private void RadGridView_PreparingCellForEdit(object sender, Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs e)
	{
	   if (e.Column.UniqueName == "GridViewCheckBoxColumn")
	   {
	       var checkBox = e.EditingElement as CheckBox;
	       checkBox.Margin = new Thickness(4, 0, -3, 0);
	   }
	}
{{endregion}}

#### __VB.NET__

{{region gridview-checkbox-column_5}}
    Private Sub RadGridView_PreparingCellForEdit(sender As Object, e As Telerik.Windows.Controls.GridViewPreparingCellForEditEventArgs)
        If e.Column.UniqueName = "GridViewCheckBoxColumn" Then
            Dim checkBox = TryCast(e.EditingElement, CheckBox)
            checkBox.Margin = New Thickness(4, 0, -3, 0)
        End If
    End Sub
{{endregion}}

Here is the result:
        
![Rad Grid View Styles and Templates Styling Check Box Column 05](images/RadGridView_Styles_and_Templates_Styling_CheckBoxColumn_05.PNG)

# See Also

 * [CheckBox Column]({%slug gridview-checkbox-column%})
