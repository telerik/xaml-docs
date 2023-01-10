---
title: Exclude Column from Search
page_title: Exclude Column from Search
description: Learn how to set the IsSearchable property to False in order to exclude column from search within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-exclude-column-from-search
tags: exclude,column,search
published: True
position: 15
---

# {{ site.framework_name }} RadGridView Exclude Column from Search

__GridViewBoundColumnBase__ provides a mechanism for it to be excluded from the search mechanism. This can be achieved through its __IsSearchable__ property. It is available as of __R2 2018__. Its default value is __True__, meaning that the column will be included in the search operation. When set to __False__ the column will not take part in the searching. 

#### __Figure 1: RadGridView without having the IsSearchable set to none of its columns__

![Columns not Excluded from Search in RadGridView - Telerik's {{ site.framework_name }} DataGrid](images/gridview-howto-exclude-column-from-search_01.png)

#### __[XAML] Example 1: Setting the IsSearchable property to False__

{{region xaml-gridview-how-to-exclude-column-from-search_0}}
		<telerik:RadGridView Grid.Row="0"
                             ItemsSource="{Binding Clubs}"
                             ShowSearchPanel="True"
                             AutoGenerateColumns="False"
                             GroupRenderMode="Flat">
            <telerik:RadGridView.Columns>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" 
                                            IsSearchable="False"/>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding City}"/>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Established}" 
                                            Header="Est"
                                            DataFormatString="{}{0:yyyy}"/>
				<telerik:GridViewDataColumn DataMemberBinding="{Binding StadiumCapacity}" 
                                            Header="Stadium"
                                            DataFormatString="{}{0:N0}"/>
            </telerik:RadGridView.Columns>
		</telerik:RadGridView>
{{endregion}}

#### __Figure 2: RadGridView with having the IsSearchable set to one of its columns__

![Column Excluded from Search in RadGridView - Telerik's {{ site.framework_name }} DataGrid](images/gridview-howto-exclude-column-from-search_02.png)

## See Also

* [Search As You Type]({%slug radgridview-search-as-you-type%})
* [Basic Filtering]({%slug gridview-filtering-basic%})
* [Programmatic Filtering]({%slug gridview-filtering-programmatic%})


