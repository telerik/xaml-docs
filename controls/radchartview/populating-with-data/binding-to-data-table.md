---
title: Binding to a DataTable
page_title: Binding to a DataTable
description: Check our &quot;Binding to a DataTable&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-populating-with-data-binding-to-data-table
tags: binding,to,a,datatable
published: True
position: 3
---

# Binding to a DataTable

In this section we will demonstrated how to bind a ChartView to a DataTable.

For the basis of this article we will declare a Bar Chart which is represented by the RadCartesianChart class. Here is the XAML declaration:        


<snippet id='radchartview-populating-with-data-binding-to-data-table-block_1-xaml' />


Next we will decalare a sample DataTable, containing 3 columns - actual (of type double), expected(of type double), month(of type DateTime). The "Actual" column will be the value source for the barSeries1 and the "Expected" - respectively for barSeries2. The values of the "Month" column will serve as the categories for both of these series.        


<snippet id='radchartview-populating-with-data-binding-to-data-table-block_2-cs' />

<snippet id='radchartview-populating-with-data-binding-to-data-table-block_2-vb' />


Using the traditional PropertyNameBinding the ChartView can only be bound to objects of type IEnumerable. In order for the binding to work with our DataTable we must use GenericDataPointBinding. It allows a lot more flexibility because it gives the control to user by allowing him to specify exactly how he wants to retrieve the data.        

We need to tell the barSeries1 to use the values in column "Actual" for the YValues of its data points and to use the values in the "Month" column for their categories. Also the barSeries2 should use the "Expected" column for YValues, and again the "Month" for categories.        

To do so, we have to set for each of our bar series bindings to a new instance of the GenericDataPointBinding <TElement, TResult> class. "TElement" is the type that is passed to the binding function, and "TResult" is the type of the value that is bound to the data point element.         

The ChartView will automatically traverse the the DataRowsCollection of the DataTable and will expect the binding function to extract the needed information from each DataRow. So the the type of TElement is DataRow, and the return type of the fuction is double for ValueBindings and string for the CategoryBindgings respectively.        

Using lambda syntax (as shown below) we set the path to the values in the DataTable for the bar series to use.        


<snippet id='radchartview-populating-with-data-binding-to-data-table-block_3-cs' />

<snippet id='radchartview-populating-with-data-binding-to-data-table-block_3-vb' />


The final result:
![Result](images/RadChartView-binding_to_datatable.png)

## See Also
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
