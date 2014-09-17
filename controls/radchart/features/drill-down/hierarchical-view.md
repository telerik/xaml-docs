---
title: Hierarchical View
page_title: Hierarchical View
description: Hierarchical View
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

#### __C#__

{{region radchart-features-drill-down-hierarchical-view_0}}
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
	{{endregion}}



#### __VB.NET__

{{region radchart-features-drill-down-hierarchical-view_1}}
	Public Class Company
	 Public Property Name() As String
	 Public Property Sales() As ModelSalesCollection
	End Class
	{{endregion}}



#### __C#__

{{region radchart-features-drill-down-hierarchical-view_2}}
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
	{{endregion}}



#### __VB.NET__

{{region radchart-features-drill-down-hierarchical-view_3}}
	Public Class ModelSalesCollection
	 Inherits List(Of ModelSales)
	 Public ReadOnly Property TotalAmount() As Double
	  Get
	   Return Me.Sum(Function(modelSales) modelSales.Amount)
	  End Get
	 End Property
	End Class
	{{endregion}}



>tipThe __Sum()__ extension method is available via the __System.Linq__ namespace.

#### __C#__

{{region radchart-features-drill-down-hierarchical-view_4}}
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
	{{endregion}}



#### __VB.NET__

{{region radchart-features-drill-down-hierarchical-view_5}}
	Public Class ModelSales
	 Public Property Model() As String
	 Public Property Amount() As Double
	 Public Sub New(ByVal model As String, ByVal amount As Double)
	  Me.Model = model
	  Me.Amount = amount
	 End Sub
	End Class
	{{endregion}}



Here is a method that generates some sample data for you.

#### __C#__

{{region radchart-features-drill-down-hierarchical-view_6}}
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
	{{endregion}}



#### __VB.NET__

{{region radchart-features-drill-down-hierarchical-view_7}}
	Private Function GetChartData() As List(Of Company)
	 Return New List(Of Company)() _
	     From {New Company() With {.Name="ToyYoda", .Sales = New ModelSalesCollection()
	             From { New ModelSales("Coolla", 120000), New ModelSales("Coolla", 115000), New ModelSales("Veso", 89000), New ModelSales("Veso", 79000) }}, New Company() With {.Name="Marda", .Sales = New ModelSalesCollection()
	             From { New ModelSales("Tree", 145000), New ModelSales("Tree", 132000), New ModelSales("Six", 121000), New ModelSales("Six", 111000) }}}
	End Function
	{{endregion}}



At the first level of the hierarchy the __RadChart__ should display the value of the __TotalAmount__ for each company. 

#### __XAML__

{{region radchart-features-drill-down-hierarchical-view_8}}
	<telerik:RadChart x:Name="radChart">
	    <telerik:RadChart.HierarchicalViewDescriptors>
	        <telerik:ChartHierarchicalViewDescriptor>
	            <telerik:ChartHierarchicalViewDescriptor.SeriesMappings>
	                <telerik:SeriesMapping>
	                    <telerik:ItemMapping FieldName="Sales.TotalAmount"
	                                            DataPointMember="YValue">
	                    </telerik:ItemMapping>
	                    <telerik:ItemMapping FieldName="Name"
	                                            DataPointMember="XCategory"></telerik:ItemMapping>
	                </telerik:SeriesMapping>
	            </telerik:ChartHierarchicalViewDescriptor.SeriesMappings>
	        </telerik:ChartHierarchicalViewDescriptor>
	    </telerik:RadChart.HierarchicalViewDescriptors>
	</telerik:RadChart>
	{{endregion}}



Upon clicking on the respective company, the __RadChart__ should visualize the __Amount__for each model. The next __ChartHierarchicalViewDescriptor__ should be related to the __Sales__ property of the clicked parent item.

#### __XAML__

{{region radchart-features-drill-down-hierarchical-view_9}}
	<telerik:RadChart x:Name="radChart">
	    <telerik:RadChart.HierarchicalViewDescriptors>
	        <telerik:ChartHierarchicalViewDescriptor>
	            <telerik:ChartHierarchicalViewDescriptor.SeriesMappings>
	                <telerik:SeriesMapping>
	                    <telerik:ItemMapping FieldName="Sales.TotalAmount"
	                                            DataPointMember="YValue" />
	                    <telerik:ItemMapping FieldName="Name"
	                                            DataPointMember="XCategory" />
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
	                            <telerik:ChartGroupDescriptor Member="Model"></telerik:ChartGroupDescriptor>
	                        </telerik:GroupingSettings>
	                    </telerik:SeriesMapping.GroupingSettings>
	                    <telerik:ItemMapping FieldName="Amount"
	                                            DataPointMember="YValue"
	                                            AggregateFunction="Sum" />
	                    <telerik:ItemMapping FieldName="Model"
	                                            DataPointMember="XCategory" />
	                </telerik:SeriesMapping>
	            </telerik:ChartHierarchicalViewDescriptor.SeriesMappings>
	        </telerik:ChartHierarchicalViewDescriptor>                
	    </telerik:RadChart.HierarchicalViewDescriptors>
	</telerik:RadChart>
	{{endregion}}



To see how to use the drill down in different scenarios read the following topics:

* [Drill Down in a Single Chart Area]({%slug radchart-features-drill-down-in-a-single-chart-area%})

* [Drill Down in Multiple Chart Areas]({%slug radchart-features-drill-down-in-multiple-chart-areas%})

To learn how to navigate between levels read the [Navigation]({%slug radchart-features-drill-down-navigation%}) topic.
