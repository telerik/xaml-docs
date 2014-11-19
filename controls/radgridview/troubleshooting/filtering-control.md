---
title: Filter goes outside the window
page_title: Filter goes outside the window
description: Filter goes outside the window
slug: gridview-troubleshooting-filtering-control
tags: filter,goes,outside,the,window
published: True
position: 11
---

# Filter goes outside the window

__PROBLEM__

The filtering control goes out of the window (in WPF) or gets cut by the browser boundaries (in Silverlight) when there is not enough space for it. Here is an example:

![](images/troubleshooting_filtering_boundaries_gridview.png)

__SOLUTION__

You have two options here:

1. You can shorten the filtering control by either removing the distinct values listbox (top part) or the field filter controls (bottom part). The two boolean properties that controls these behaviors are: __ShowDistinctFilters__ and __ShowFieldFilters__

![](images/troubleshooting_filtering_boundaries_gridview2.png)

2. This method manipulates the [XAML of the filtering control]({%slug radgridview-styles-and-templates-templates-structure%}) to reduce the height of the distinct values listbox. This way you will have both the distinct values listbox and the other field filtering controls.

You need to find the __PART_DistinctValuesList__listbox and set its MaxHeight property to a smaller value, e.g. MaxHeight="100". If you make the Filtering style implicit - it will be applied to all filtering controls of the gridview. Here is the result it produces:

![](images/troubleshooting_filtering_boundaries_gridview4.png)

{% if site.site_name == 'WPF' %}

You might have problems extracting the control template of the Filtering control in WPF - the binding are missing. So, please use this one instead:{% endif %}

#### __XAML__

{{region gridview-troubleshooting-filtering-control_0}}

	<Style TargetType="telerik:FilteringControl" >
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="telerik:FilteringControl">
                    <Border BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="{TemplateBinding BorderThickness}" CornerRadius="1" Margin="{TemplateBinding Margin}">
                        <Border BorderBrush="White" BorderThickness="1" Background="{TemplateBinding Background}">
                            <Grid>
                                <StackPanel HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}" MaxWidth="350" Margin="{TemplateBinding Padding}" MinWidth="200" VerticalAlignment="{TemplateBinding VerticalContentAlignment}">
                                    <StackPanel x:Name="PART_DistinctFilter" Visibility="{TemplateBinding DistinctFiltersVisibility}">
                                        <CheckBox x:Name="PART_SelectAllCheckBox" Content="Select All" IsChecked="{Binding SelectAll, Mode=TwoWay}" Margin="0,2" telerik:LocalizationManager.ResourceKey="GridViewFilterSelectAll">
                                            <telerik:StyleManager.Theme>
                                                <telerik:Office_BlackTheme/>
                                            </telerik:StyleManager.Theme>
                                        </CheckBox>
                                        <ListBox x:Name="PART_DistinctValuesList" ItemsSource="{Binding DistinctValues}" ScrollViewer.HorizontalScrollBarVisibility="Auto" 
                                                 MaxHeight="100" SelectionMode="Multiple">
                                            <ListBox.ItemTemplate>
                                                <DataTemplate>
                                                    <CheckBox Content="{Binding ConvertedValue}" IsChecked="{Binding IsActive, Mode=TwoWay}" VerticalContentAlignment="Center">
                                                        <telerik:StyleManager.Theme>
                                                            <telerik:Office_BlackTheme/>
                                                        </telerik:StyleManager.Theme>
                                                    </CheckBox>
                                                </DataTemplate>
                                            </ListBox.ItemTemplate>
                                            <telerik:StyleManager.Theme>
                                                <telerik:Office_BlackTheme/>
                                            </telerik:StyleManager.Theme>
                                        </ListBox>
                                    </StackPanel>
                                    <StackPanel Margin="0,2" Visibility="{TemplateBinding FieldFiltersVisibility}">
                                        <TextBlock Margin="0,2,0,0" telerik:LocalizationManager.ResourceKey="GridViewFilterShowRowsWithValueThat" Text="Show rows with value that"></TextBlock>
                                        <telerik:RadComboBox x:Name="PART_Filter1ComboBox" ItemsSource="{Binding AvailableActions}" SelectedItem="{Binding Filter1.Operator, Mode=TwoWay}"  Margin="0,2">
                                            <telerik:RadComboBox.ItemTemplate>
                                                <DataTemplate>
                                                    <TextBlock>
											           <TextBlock.Text>
											            <Binding>
											             <Binding.Converter>
											              <telerik:FilterOperatorConverter/>
											             </Binding.Converter>
											            </Binding>
											           </TextBlock.Text>
                                                    </TextBlock>
                                                </DataTemplate>
                                            </telerik:RadComboBox.ItemTemplate>
                                            <telerik:StyleManager.Theme>
                                                <telerik:Office_BlackTheme/>
                                            </telerik:StyleManager.Theme>
                                        </telerik:RadComboBox>
                                        <ContentControl x:Name="PART_Filter1ContentControl" DataContext="{Binding Filter1}" HorizontalContentAlignment="Stretch" Margin="0,2" VerticalContentAlignment="Stretch"/>
                                        <telerik:RadComboBox x:Name="PART_LogicalOperatorsComboBox"  ItemsSource="{Binding LogicalOperators}" SelectedItem="{Binding FieldFilterLogicalOperator, Mode=TwoWay}" Margin="0,2">
                                            <telerik:RadComboBox.ItemTemplate>
                                                <DataTemplate>
                                                    <TextBlock>
											           <TextBlock.Text>
											            <Binding>
											             <Binding.Converter>
											              <telerik:FilterCompositionLogicalOperatorConverter/>
											             </Binding.Converter>
											            </Binding>
											           </TextBlock.Text>
                                                    </TextBlock>
                                                </DataTemplate>
                                            </telerik:RadComboBox.ItemTemplate>
                                            <telerik:StyleManager.Theme>
                                                <telerik:Office_BlackTheme/>
                                            </telerik:StyleManager.Theme>
                                        </telerik:RadComboBox>
                                        <telerik:RadComboBox x:Name="PART_Filter2ComboBox" ItemsSource="{Binding AvailableActions}"  SelectedItem="{Binding Filter2.Operator, Mode=TwoWay}"  Margin="0,2">
                                            <telerik:RadComboBox.ItemTemplate>
                                                <DataTemplate>
                                                    <TextBlock>
											           <TextBlock.Text>
											            <Binding>
											             <Binding.Converter>
											              <telerik:FilterOperatorConverter/>
											             </Binding.Converter>
											            </Binding>
											           </TextBlock.Text>
                                                    </TextBlock>
                                                </DataTemplate>
                                            </telerik:RadComboBox.ItemTemplate>
                                            <telerik:StyleManager.Theme>
                                                <telerik:Office_BlackTheme/>
                                            </telerik:StyleManager.Theme>
                                        </telerik:RadComboBox>
                                        <ContentControl x:Name="PART_Filter2ContentControl" DataContext="{Binding Filter2}" HorizontalContentAlignment="Stretch" Margin="0,2" VerticalContentAlignment="Stretch"/>
                                    </StackPanel>
                                    <Grid>
                                        <Grid.ColumnDefinitions>
                                            <ColumnDefinition/>
                                            <ColumnDefinition/>
                                        </Grid.ColumnDefinitions>
                                        <Button x:Name="PART_ApplyFilterButton" Content="Filter" Grid.Column="0" Height="22" Margin="0,2,2,2" telerik:LocalizationManager.ResourceKey="GridViewFilter">
                                            <telerik:StyleManager.Theme>
                                                <telerik:Office_BlackTheme/>
                                            </telerik:StyleManager.Theme>
                                        </Button>
                                        <Button x:Name="PART_ClearFilterButton" Content="Clear Filter" Grid.Column="1" Height="22" Margin="2,2,0,2" telerik:LocalizationManager.ResourceKey="GridViewClearFilter">
                                            <telerik:StyleManager.Theme>
                                                <telerik:Office_BlackTheme/>
                                            </telerik:StyleManager.Theme>
                                        </Button>
                                    </Grid>
                                </StackPanel>
                                <telerik:RadButton x:Name="PART_FilterCloseButton" HorizontalAlignment="Right" Height="13" Margin="{TemplateBinding Padding}" VerticalAlignment="Top" Width="13">
                                    <telerik:StyleManager.Theme>
                                        <telerik:Office_BlackTheme/>
                                    </telerik:StyleManager.Theme>
                                    <Path Data="M4,4L5,4 5,5 4,5z M0,4L1,4 1,5 0,5z M3,3L4,3 4,4 3,4z M1,3L2,3 2,4 1,4z M2,2L3,2 3,3 2,3z M4,0L5,0 5,1 4,1 4,2 3,2 3,0.99999994 4,0.99999994z M0,0L1,0 1,0.99999994 2,0.99999994 2,2 1,2 1,1 0,1z" Fill="Black" HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}" Height="6" VerticalAlignment="{TemplateBinding VerticalContentAlignment}" Width="6"/>
                                </telerik:RadButton>
                            </Grid>
                        </Border>
                    </Border>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
        <Setter Property="Background" Value="#FFE4E4E4"/>
        <Setter Property="BorderBrush" Value="#FF848484"/>
        <Setter Property="Padding" Value="5"/>
        <Setter Property="Margin" Value="0,2,0,0"/>
        <Setter Property="BorderThickness" Value="1"/>
        <Setter Property="VerticalContentAlignment" Value="Stretch"/>
        <Setter Property="HorizontalContentAlignment" Value="Stretch"/>
        <Setter Property="Foreground" Value="Black"/>
        <Setter Property="SnapsToDevicePixels" Value="True"/>
    </Style>
{{endregion}}


