---
title: Styling the FilterRow
page_title: Styling the FilterRow
description: Styling the FilterRow
slug: gridview-styling-filterrow
tags: styling,the,filterrow
published: True
position: 19
---

# Styling the FilterRow



This topic will show you how to style the Filter Row

![Rad Grid View Styles and Templates Styling Filter Row 01](images/RadGridView_Styles_and_Templates_Styling_FilterRow_01.PNG)

The type of the actual editor, which is determined, created and inserted at runtime depends on the __DataType__ of the column.
    

Here are the four different scenarios that you can get:

* 
        String: __StringFilterEditor__

* 
        DateTime: __RadDateTimePicker__

* 
        Boolean: Nothing
        

>tipWhen the DataType of the column is of __Boolean__ type, you will have IsTrue and IsFalse filter operators in the drop-down. For that reason, you do not need an editor.

* 
       Everything Else: plain standard __TextBox__

>These are the four editors that you will ever get.
      

## Modifying the StringFilterEditor's Style

Basically the __StringFilterEditor__ is a __TextBox__ + __ToggleButton__ wrapped in a control. In order to change __StringFilterEditor__'s visual appearance you may
          extract and predefine its template using __Expression Blend__ such as:
        

#### __XAML__

{{region gridview-styling-editors_1}}
	<telerik:Office_BlackTheme x:Key="Theme"/>
	 <ControlTemplate x:Key="StringFilterEditorTemplate" TargetType="Editors:StringFilterEditor">
	    <Grid MinWidth="100">
	        <Grid.ColumnDefinitions>
	            <ColumnDefinition Width="*"/>
	            <ColumnDefinition Width="Auto"/>
	        </Grid.ColumnDefinitions>
	        <TextBox Grid.Column="0"
	                 telerik:TextBoxBehavior.SelectAllOnGotFocus="True" 
	                 Text="{Binding Text, Mode=TwoWay, RelativeSource={RelativeSource TemplatedParent}}"
	                 telerik:StyleManager.Theme="{StaticResource Theme}" 
	                 telerik:TextBoxBehavior.UpdateTextOnEnter="True"
	                 VerticalAlignment="Stretch"/>
	        <telerik:RadToggleButton Content="aA"
	                                 Grid.Column="1"
	                                 IsChecked="{Binding IsCaseSensitive, Mode=TwoWay, RelativeSource={RelativeSource TemplatedParent}}" 
	                                 Margin="2,0,0,0" telerik:StyleManager.Theme="{StaticResource Theme}" 
	                                 Visibility="{Binding MatchCaseVisibility, RelativeSource={RelativeSource TemplatedParent}}">
	            <ToolTipService.ToolTip>
	                <ToolTip telerik:LocalizationManager.ResourceKey="GridViewFilterMatchCase" telerik:StyleManager.Theme="{StaticResource Theme}"/>
	            </ToolTipService.ToolTip>
	        </telerik:RadToggleButton>
	    </Grid>
	 </ControlTemplate>
	 <Style TargetType="Editors:StringFilterEditor">
	   <Setter Property="Template" Value="{StaticResource StringFilterEditorTemplate}"/>    
	 </Style>
	{{endregion}}



Also, you have to declare the following namespace:
        

#### __XAML__

{{region gridview-styling-editors_2}}
	 xmlns:Editors="clr-namespace:Telerik.Windows.Controls.Filtering.Editors;assembly=Telerik.Windows.Controls"
	{{endregion}}



>tipTo learn more about how to style the __FilteringControl__ take a look at the [Styling the FilteringControl]({%slug gridview-styling-filteringcontrol%}) topic.
          

## Modifying the RadDropDownButton's Style

In order to change RadDropDownButton's (the funnel) visual appearance you may extract and predefine the FieldFilterControl's template using Expression Blend such as:
        

#### __XAML__

{{region gridview-styling-editors_3}}
	<SolidColorBrush x:Key="ControlOuterBorder" Color="#FF848484" />
	 <ControlTemplate x:Key="FieldFilterControlTemplate" TargetType="grid:FieldFilterControl">
	            <Border BorderBrush="{TemplateBinding BorderBrush}" 
					BorderThickness="{TemplateBinding BorderThickness}">
	                <Grid x:Name="PART_MainGrid">
	                    <Grid.ColumnDefinitions>
	                        <ColumnDefinition Width="*"/>
	                        <ColumnDefinition Width="Auto"/>
	                    </Grid.ColumnDefinitions>
	                    <ContentControl x:Name="PART_FilterEditorContentControl"
								Grid.Column="0"
								IsEnabled="{Binding EditorIsEnabled}"
								HorizontalContentAlignment="Stretch"
								VerticalContentAlignment="Stretch" Margin="2 1 0 2"/>
	                    <telerik:RadDropDownButton x:Name="PART_DropDownButton"
										   Grid.Column="1"
										   KeepOpen="False" Style="{StaticResource FieldFilterDropDownButtonStyle}"
										   DropDownIndicatorVisibility="Collapsed">
	                        <Border Cursor="Hand" Background="Transparent" Padding="3 0 0 0">
	                            <Grid Width="12" Height="13" Cursor="Hand">
	                                <Path Fill="{StaticResource GridView_FilterIconOuterBorder}" Stretch="Fill" Margin="0 1 0 0" Data="M5,9 L6,9 6,10 5,10 z M4,4 L5,4 5,5 5,6 5,7 5,8 5,9 4,9 4,8 4,7 4,6 4,5 z M7.9850001,3 L8.985,3 8.985,4 8,4 8,5 8,6 8,7 8,8 8,9 8,10 8,11 7.9999997,12 6.9999998,12 6.9999998,11 6,11 6,10 6.9999999,10 6.9999999,9 6.9999999,8 6.9999999,7 6.9999999,6 6.9999999,5 6.9999999,4 7.9850001,4&#xa; z M3,3 L4,3 4,4 3,4 z M9,2 L10,2 10,3 9,3 z M2,2 L3,2 3,3 2,3 z M7.9999999,0 L9,0 10,0 11,0 12,0 12,1 11,1 11,2 10,2 10,1 9,1 7.9999999,1 z M0,0 L1,0 2,0 3,0 4,0 5,0 6,0 6.9999998,0 7.9999997,0 7.9999997,1 6.9999998,1 6,1 5,1 4,1 3,1 2,1 2,2 1,2 1,1 0,1 z"/>
	                                <Path Fill="{StaticResource GridView_FilterIconTopBorder}" Stretch="Fill" Margin="2 1 2 0" VerticalAlignment="Top" Height="1" Data="M0,0 L1,0 2,0 3.0000002,0 4.0000002,0 5.0000001,0 5.9850001,0 6.0000001,0 6.9850001,0 7.9850001,0 7.9850001,1 6.9850001,1 6.0000001,1 5.9850001,1 5.0000001,1 4.0000002,1 3.0000002,1 2,1 1,1 0,1 z"/>
	                                <Path Fill="{StaticResource GridView_FilterIconBackground}" Stretch="Fill" Margin="3 2 3 3" Data="M0,0 L1,0 2,0 3,0 4,0 5,0 6,0 6,1 5,1 4.985,1 4.985,2 4,2 4,3 4,4 4,5 4,6 4,7 4,8 3,8 3,7 2,7 2,6 2,5 2,4&#xa;2,3 2,2 1,2 1,1 0,1 z" />
	                                <Path Fill="{StaticResource GridView_FilterIconBackground_Filtered}" Visibility="{Binding FunnelFillVisibility}" Stretch="Fill" Margin="3,2,3,3" Data="M0,0 L1,0 2,0 3,0 4,0 5,0 6,0 6,1 5,1 4.985,1 4.985,2 4,2 4,3 4,4 4,5 4,6 4,7 4,8 3,8 3,7 2,7 2,6 2,5 2,4&#xa;2,3 2,2 1,2 1,1 0,1 z" />
	                                <Path Fill="{StaticResource GridView_FilterIconInnerBorder}" Stretch="Fill" Margin="0 0 0 1" Data="M5,9 L6,9 6,10 5,10 z M4,4 L5,4 5,5 5,6 5,7 5,8 5,9 4,9 4,8 4,7 4,6 4,5 z M7.9850001,3 L8.985,3 8.985,4 8,4 8,5 8,6 8,7 8,8 8,9 8,10 8,11 7.9999997,12 6.9999998,12 6.9999998,11 6,11 6,10 6.9999999,10 6.9999999,9 6.9999999,8 6.9999999,7 6.9999999,6 6.9999999,5 6.9999999,4 7.9850001,4&#xa; z M3,3 L4,3 4,4 3,4 z M9,2 L10,2 10,3 9,3 z M2,2 L3,2 3,3 2,3 z M7.9999999,0 L9,0 10,0 11,0 12,0 12,1 11,1 11,2 10,2 10,1 9,1 7.9999999,1 z M0,0 L1,0 2,0 3,0 4,0 5,0 6,0 6.9999998,0 7.9999997,0 7.9999997,1 6.9999998,1 6,1 5,1 4,1 3,1 2,1 2,2 1,2 1,1 0,1 z"/>
	                            </Grid>
	                        </Border>
	
	                        <telerik:RadDropDownButton.DropDownContent>
	                            <ListBox x:Name="PART_FilterOperatorsListBox"
									 ItemsSource="{Binding AvailableOperatorViewModels}"
									 SelectedItem="{Binding SelectedOperatorViewModel, Mode=TwoWay}" 
									 telerik:StyleManager.Theme="{StaticResource Theme}"/>
	                        </telerik:RadDropDownButton.DropDownContent>
	                    </telerik:RadDropDownButton>
	                </Grid>
	            </Border>
	        </ControlTemplate>
	         <Style TargetType="grid:FieldFilterControl">
	            <Setter Property="Template" Value="{StaticResource FieldFilterControlTemplate}" />
	            <Setter Property="BorderThickness" Value="0 0 1 0"/>
	            <Setter Property="MinHeight" Value="26"/>
	            <Setter Property="BorderBrush" Value="{StaticResource ControlOuterBorder}"/>
	            <Setter Property="SnapsToDevicePixels" Value="True" />
	        </Style>
	{{endregion}}



## Modifying other editors

Since the created editor will be inserted as the Content of the __PART_FilterEditorContentControl__,
          you can attach to the __FieldFilterEditorCreated__ event and apply the respective style to the respective editor. For example, if the editor is a plain __TextBox__ you can change its __Background__ like so:
        

#### __C#__

{{region gridview-styling-editors_3}}
	 private void clubsGrid_FieldFilterEditorCreated(object sender, Telerik.Windows.Controls.GridView.EditorCreatedEventArgs e)
	    {
	        if (e.Column.UniqueName == "StadiumCapacity")
	        {
	            TextBox txtBox = e.Editor as TextBox;
	            if (txtBox != null)
	            {
	                txtBox.Background = new SolidColorBrush(Colors.Yellow);
	            }
	        }     
	    }
	{{endregion}}



#### __VB.NET__

{{region gridview-styling-editors_4}}
	    Private Sub clubsGrid_FieldFilterEditorCreated(sender As Object, e As Telerik.Windows.Controls.GridView.EditorCreatedEventArgs)
	        If e.Column.UniqueName = "StadiumCapacity" Then
	            Dim txtBox As TextBox = TryCast(e.Editor, TextBox)
	            If txtBox IsNot Nothing Then
	                txtBox.Background = New SolidColorBrush(Colors.Yellow)
	            End If
	        End If
	    End Sub
	{{endregion}}



# See Also

 * [Styling the FilteringControl]({%slug gridview-styling-filteringcontrol%})
