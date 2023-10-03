---
title: RadHighlightTextBlock in an editable RadComboBox
page_title: Use RadHighlightTextBlock in an editable RadComboBox
description: How to use RadHighlightTextBlock control in an editable RadComboBox.
type: how-to
slug: kb-highlighttextblock-integration-with-radcombobox
position: 0
tags: highlighttextblock, integration, radcombobox
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2023.3.1011</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadHighlightTextBlock for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to use `RadHighlightTextBlock` in an editable `RadComboBox`.

## Solution

Define a new `DataTemplate` that contains a RadHighlightTextBlock instance and set it to the `ItemTemplate` property of RadComboBox. Bind the `Text` property of the RadHighlightTextBlock to the property from the items' model that will be displayed in the RadComboBox instance. Bind the `HighlightText` property to the `Text` property of RadComboBox.

#### __[C#] Define the items' model and the view model__
{{region kb-highlighttextblock-integration-with-radcombobox-0}}
    public class ItemInfo
    {
        public string Content { get; set; }
    }

    public class MainViewModel
    {
        public MainViewModel()
        {
            this.ItemInfos = new ObservableCollection<ItemInfo>()
            {
                new ItemInfo() { Content = "Item 1" },
                new ItemInfo() { Content = "Item 2" },
                new ItemInfo() { Content = "Item 3" },
            };
        }

        public ObservableCollection<ItemInfo> ItemInfos { get; set; }
    }
{{endregion}}

#### __[VB.NET] Defining the items' model and the view model__
{{region kb-highlighttextblock-integration-with-radcombobox-1}}
    Public Class ItemInfo
        Public Property Content As String
    End Class

    Public Class MainViewModel
        Public Sub New()
            Me.ItemInfos = New ObservableCollection(Of ItemInfo)() From {
                New ItemInfo() With {
                    .Content = "Item 1"
                },
                New ItemInfo() With {
                    .Content = "Item 2"
                },
                New ItemInfo() With {
                    .Content = "Item 3"
                }
            }
        End Sub

        Public Property ItemInfos As ObservableCollection(Of ItemInfo)
    End Class
{{endregion}}

#### __[XAML] Creating a DataTemplate with a RadHighlightTextBlock__
{{region kb-highlighttextblock-integration-with-radcombobox-2}}
    <DataTemplate x:Key="HighlightTextBlockDataTemplate">
        <telerik:RadHighlightTextBlock Text="{Binding Content}" 
                                       HighlightText="{Binding Path=Text, RelativeSource={RelativeSource    AncestorType=telerik:RadComboBox}, Mode=TwoWay}"/>
    </DataTemplate>
{{endregion}}

#### __[XAML] Set the custom DataTemplate to the ItemTemplate property of RadComboBox__
{{region kb-highlighttextblock-integration-with-radcombobox-3}}
    <telerik:RadComboBox IsEditable="True"
                         ItemsSource="{Binding ItemInfos}"
                         telerik:TextSearch.TextPath="Content"
                         ItemTemplate="{StaticResource HighlightTextBlockDataTemplate}"/>
{{endregion}}

__RadComboBox with RadHighlightTextBlock__

![{{ site.framework_name }} RadComboBox with RadHighlightTextBlock](images/kb-highlighttextblock-integration-with-radcombobox-0.png)

>important Integration with the RadHighlightTextBlock control and enabled autocomplete functionality is not supported. If you need highlighting in an autocomplete scenario, you can check the [RadHighlightTextBlock with RadAutoCompleteBox]({%slug kb-highlighttextblock-integration-with-radautocompletebox%}) and [RadHighlightTextBlock with RadAutoSuggestBox]({%slug kb-highlighttextblock-integration-with-radautosuggestbox%}) articles.