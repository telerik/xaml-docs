---
title: Hyperlink Column
page_title: Hyperlink Column
description: Hyperlink Column
slug: radgridview-columns-column-types-hyperlink-column
tags: hyperlink,column
published: True
position: 7
---

# Hyperlink Column


The __GridViewHyperlinkColumn__ derives from the __GridViewBoundColumnBase__class and its content is represented by a __HyperlinkButton__ control. The bound value is automatically displayed as a link.

Here is a list of the most important properties.

* __DataMemberBinding__ - the bound value to be displayed as a content. It is automatically displayed as a link.
            

* __TargetName__ - specifies in which location the link to be opened.
            

If the bound data object has a property TeamUrl defined as follows:
        

#### __C#__

{{region radgridview-columns-column-types-hyperlink-column_1}}

	public class Employee
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

{{region radgridview-columns-column-types-hyperlink-column_2}}

    Public Class Employee
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

#### __XAML__

{{region radgridview-columns-column-types-hyperlink-column_0}}

	<telerik:RadGridView x:Name="radGridView"
	                     AutoGenerateColumns="False">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewHyperlinkColumn 
				Header="Team Url"
				DataMemberBinding="{Binding TeamUrl}">
	        </telerik:GridViewHyperlinkColumn>    
		</telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}


