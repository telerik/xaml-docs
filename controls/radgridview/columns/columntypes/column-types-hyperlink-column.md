---
title: Hyperlink Column
page_title: Hyperlink Column
description: Hyperlink Column
slug: radgridview-columns-column-types-hyperlink-column
tags: hyperlink,column
published: True
position: 6
---

# Hyperlink Column

__GridViewHyperlinkColumn__ derives from [GridViewBoundColumnBase]({%slug radgridview-columns-column-types-boundcolumnbase%}) class and its content is represented by a __HyperlinkButton__ control. The bound value is automatically displayed as a link.

Here is a list of the most important properties.

* __DataMemberBinding__ - you can specify the property of the business object to be displayed as value in the cell. It is automatically displayed as a link.
            
* __TargetName__ - specifies the location to open the link.
            
Lets say the bound data object exposes a TeamUrl property defined as follows:
        
#### __C#__

{{region cs-radgridview-columns-column-types-hyperlink-column_1}}
	public class Employee : ObservableObject
	{
	    private string teamUrl = "http://google.com";
	    public string TeamUrl
	    {
	        get { return this.teamUrl; }
	        set
	        {
	            if (value != this.teamUrl)
	            {
	                this.teamUrl = value;
	                this.OnPropertyChanged("TeamUrl");
	            }
	        }
	    }
	}
{{endregion}}


#### __VB.NET__

{{region vb-radgridview-columns-column-types-hyperlink-column_2}}
	Public Class Employee
	    Inherits ObservableObject
	    Private m_teamUrl As String = "http://google.com"
	    Public Property TeamUrl() As String
	        Get
	            Return Me.m_teamUrl
	        End Get
	        Set(value As String)
	            If value <> Me.m_teamUrl Then
	                Me.m_teamUrl = value
	                Me.OnPropertyChanged("TeamUrl")
	            End If
	        End Set
	    End Property
	End Class
{{endregion}}

Then, here is how to define a column of such a type.

#### __[XAML] Example 1: Define GridViewHyperlinkColumn in XAML.__

{{region xaml-radgridview-columns-column-types-hyperlink-column_0}}
	<telerik:RadGridView x:Name="radGridView"
	                 AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewHyperlinkColumn Header="Team Url"
	                     DataMemberBinding="{Binding TeamUrl}">
	        </telerik:GridViewHyperlinkColumn>
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

# See also

* [Dynamic Hyperlink Column]({%slug radgridview-columns-column-types-dynamic-hyperlink-column%})

* [CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})