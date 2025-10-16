---
title: Hierarchical View
page_title: Hierarchical View
description: Check our &quot;Hierarchical View&quot; documentation article for the RadChart {{ site.framework_name }} control.
slug: radchart-features-drill-down-hierarchical-view
tags: hierarchical,view
published: True
position: 0
---

# Hierarchical View



## 

The __RadChart__ control displays drill down data in a hierarchical manner. In order to define the different level of the drill down hierarchy you have to use the __HierachicalViewDescriptors__ property of the __RadChart__ control. It is a collection which contains __ChartHierarchicalViewDescriptor__ objects. The __ChartHierarchicalViewDescriptor__ object is used to define a hierarchy level. The level of the descriptor in the hierarchy depends on the position it has in the collection.

For example if you have 3 descriptors in the __HierachicalViewDescriptors__ collection, the first one will be the main chart or the first level of hierarchy, the second one will be one level below and the third will be the last in the hierarchy.

In order to use a selector you simply have to create an instance of it. If it is the first level of the hierarchy you only have to define its __SeriesMappings__. If its below the first level, you have to define its __Relation__ property, in order to specify the relation between it and its parent descriptor.

Here is an example of a data with two levels of hierarchy. The data contains the following classes:



```C#
	public class Company
	{
	    public string Name
	    {
	        get;
	        set;
	    }
	    public ModelSalesCollection Sales
	    {
	        get;
	        set;
	    }
	}
```
```VB.NET
	Public Class Company
	    Public Property Name() As String
	    Public Property Sales() As ModelSalesCollection
	End Class
```





```C#
	public class ModelSalesCollection : List<ModelSales>
	{
	    public double TotalAmount
	    {
	        get
	        {
	            return this.Sum( modelSales => modelSales.Amount );
	        }
	    }
	}
```
```VB.NET
	Public Class ModelSalesCollection
	    Inherits List(Of ModelSales)
	    Public ReadOnly Property TotalAmount() As Double
	        Get
	            Return Me.Sum(Function(modelSales) modelSales.Amount)
	        End Get
	    End Property
	End Class
```



>tipThe __Sum()__ extension method is available via the __System.Linq__ namespace.



```C#
	public class ModelSales
	{
	    public string Model
	    {
	        get;
	        set;
	    }
	    public double Amount
	    {
	        get;
	        set;
	    }
	    public ModelSales( string model, double amount )
	    {
	        this.Model = model;
	        this.Amount = amount;
	    }
	}
```
```VB.NET
	Public Class ModelSales
	    Public Property Model() As String
	    Public Property Amount() As Double
	    Public Sub New(ByVal model As String, ByVal amount As Double)
	        Me.Model = model
	        Me.Amount = amount
	    End Sub
	End Class
```



Here is a method that generates some sample data for you.



```C#
	private List<Company> GetChartData()
	{
	    return new List<Company>() { 
	        new Company() { 
	            Name="ToyYoda",
	            Sales = new ModelSalesCollection() { 
	                new ModelSales("Coolla", 120000),
	                new ModelSales("Coolla", 115000),
	                new ModelSales("Veso", 89000),
	                new ModelSales("Veso", 79000)
	            }
	        },
	        new Company() { 
	            Name="Marda",
	            Sales =new ModelSalesCollection() {
	                new ModelSales("Tree", 145000),
	                new ModelSales("Tree", 132000),
	                new ModelSales("Six", 121000),
	                new ModelSales("Six", 111000)
	            }
	        }
	    };
	}
```
```VB.NET
	Private Function GetChartData() As List(Of Company)
	    Return New List(Of Company)() From { _
	        New Company() With { _
	            .Name = "ToyYoda", _
	            .Sales = New ModelSalesCollection() From { _
	                New ModelSales("Coolla", 120000), _
	                New ModelSales("Coolla", 115000), _
	                New ModelSales("Veso", 89000), _
	                New ModelSales("Veso", 79000) _
	            } _
	        }, _
	        New Company() With { _
	            .Name = "Marda", _
	            .Sales = New ModelSalesCollection() From { _
	                New ModelSales("Tree", 145000), _
	                New ModelSales("Tree", 132000), _
	                New ModelSales("Six", 121000), _
	                New ModelSales("Six", 111000) _
	            } _
	        } _
	    }
	End Function
```



At the first level of the hierarchy the __RadChart__ should display the value of the __TotalAmount__ for each company. 



```XAML
	<telerik:RadChart x:Name="radChart">
	    <telerik:RadChart.HierarchicalViewDescriptors>
	        <telerik:ChartHierarchicalViewDescriptor>
	            <telerik:ChartHierarchicalViewDescriptor.SeriesMappings>
	                <telerik:SeriesMapping>
	                    <telerik:ItemMapping DataPointMember="YValue" FieldName="Sales.TotalAmount" />
	                    <telerik:ItemMapping DataPointMember="XCategory" FieldName="Name" />
	                </telerik:SeriesMapping>
	            </telerik:ChartHierarchicalViewDescriptor.SeriesMappings>
	        </telerik:ChartHierarchicalViewDescriptor>
	    </telerik:RadChart.HierarchicalViewDescriptors>
	</telerik:RadChart>
```



Upon clicking on the respective company, the __RadChart__ should visualize the __Amount__for each model. The next __ChartHierarchicalViewDescriptor__ should be related to the __Sales__ property of the clicked parent item.



```XAML
	<telerik:RadChart>
	    <telerik:RadChart.HierarchicalViewDescriptors>
	        <telerik:ChartHierarchicalViewDescriptor>
	            <telerik:ChartHierarchicalViewDescriptor.SeriesMappings>
	                <telerik:SeriesMapping>
	                    <telerik:ItemMapping DataPointMember="YValue" FieldName="Sales.TotalAmount" />
	                    <telerik:ItemMapping DataPointMember="XCategory" FieldName="Name" />
	                </telerik:SeriesMapping>
	            </telerik:ChartHierarchicalViewDescriptor.SeriesMappings>
	        </telerik:ChartHierarchicalViewDescriptor>
	        <telerik:ChartHierarchicalViewDescriptor>
	            <telerik:ChartHierarchicalViewDescriptor.Relation>
	                <telerik:PropertyRelation ParentPropertyName="Sales" />
	            </telerik:ChartHierarchicalViewDescriptor.Relation>
	            <telerik:ChartHierarchicalViewDescriptor.SeriesMappings>
	                <telerik:SeriesMapping>
	                    <telerik:SeriesMapping.GroupingSettings>
	                        <telerik:GroupingSettings ShouldFlattenSeries="True">
	                            <telerik:ChartGroupDescriptor Member="Model" />
	                        </telerik:GroupingSettings>
	                    </telerik:SeriesMapping.GroupingSettings>
	                    <telerik:ItemMapping AggregateFunction="Sum"
	                                         DataPointMember="YValue"
	                                         FieldName="Amount" />
	                    <telerik:ItemMapping DataPointMember="XCategory" FieldName="Model" />
	                </telerik:SeriesMapping>
	            </telerik:ChartHierarchicalViewDescriptor.SeriesMappings>
	        </telerik:ChartHierarchicalViewDescriptor>
	    </telerik:RadChart.HierarchicalViewDescriptors>
	</telerik:RadChart>
```



To see how to use the drill down in different scenarios read the following topics:

* [Drill Down in a Single Chart Area]({%slug radchart-features-drill-down-in-a-single-chart-area%})

* [Drill Down in Multiple Chart Areas]({%slug radchart-features-drill-down-in-multiple-chart-areas%})

To learn how to navigate between levels read the [Navigation]({%slug radchart-features-drill-down-navigation%}) topic.
