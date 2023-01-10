---
title: Alternation
page_title: Alternation
description: Check our &quot;Alternation&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-alternation
tags: alternation
published: True
position: 6
---

# {{ site.framework_name }} RadVirtualGrid Alternation

__RadVirtualGrid__ allows alternating its rows and columns when readability needs to be improved. This article covers the mechanism in details.

## Row Alternation

The row alternation of the control can be utilized through the __RowAlternationCount__ property. 

#### __[XAML] Example 1: Setting the RowAlternationCount__
{{region radvirtualgrid-features_alternation_0}}
	<telerik:RadVirtualGrid x:Name="VirtualGrid" 
                                InitialColumnCount="4" 
                                InitialRowCount="4"
                                RowAlternationCount="2"/>
{{endregion}}

#### __Figure 1: Setting the RowAlternationCount property__
![Setting the RowAlternationCount property](images/RadVirtualGrid_Features_Alternation_01.png)

## Column Alternation

Respectively, the alternation of the columns of __RadVirtualGrid__ can be manipulated through the __ColumnAlternationCount__ property of the control.

#### __[XAML] Example 2: Setting the ColumnAlternationCount__
{{region radvirtualgrid-features_alternation_1}}
	<telerik:RadVirtualGrid x:Name="VirtualGrid" 
                                InitialColumnCount="4" 
                                InitialRowCount="4"
                                ColumnAlternationCount="2"/>
{{endregion}}

#### __Figure 2: Setting the ColumnAlternationCount property__
![Setting the ColumnAlternationCount property](images/RadVirtualGrid_Features_Alternation_02.png)

## Custom Alternation color

__RadVirtualGrid__ exposes a property for altering the default background applied to the elements participating in the alternation: __AlternationBrush__.

#### __[XAML] Example 3: Setting the AlternationBrush__
{{region radvirtualgrid-features_alternation_2}}
		<telerik:RadVirtualGrid x:Name="VirtualGrid" 
                                InitialColumnCount="4" 
                                InitialRowCount="4"
								RowAlternationCount="2"
                                ColumnAlternationCount="2"
								AlternationBrush="Beige"/>
{{endregion}}

#### __Figure 3: Setting the AlternationBrush property__
![Setting the ColumnAlternationCount property](images/RadVirtualGrid_Features_Alternation_03.png)

## See Also

* [Column and Row Resizing]({%slug virtualgrid-column-and-row-resizing%})

* [Editing]({%slug virtualgrid-editing%})

* [Insert and Remove Data]({%slug virtualgrid-insert-data-and-remove-data%})