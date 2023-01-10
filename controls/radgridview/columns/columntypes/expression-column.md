---
title: Expression Column
page_title: Expression Column
description: Find out how you can display various calculations in the grid itself using the Expression column in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-expression-column
tags: expression,column
published: True
position: 7
---

# {{ site.framework_name }} RadGridView Expression Column

__GridViewExpressionColumn__ derives from the [GridViewColumn]({%slug radgridview-columns-column-types-basic-column%}) class and allows you to display various calculations in RadGridView itself. The __GridViewExpressionColumn__ can be sorted and grouped like any other type of column.

For the purposes of this example, we will use the objects and viewmodel defined in **examples 1 and 2**.

#### __[C#] Example 1: The Product class__

{{region cs-gridview-expression-column_0}}
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
{{endregion}}

#### __[VB.NET] Example 1: The Product class__

{{region vb-gridview-expression-column_0}}
	Public Class Product
		Public Property ProductID() As Integer
		Public Property ProductName() As String
		Public Property UnitPrice() As Integer
		Public Property UnitsInStock() As Integer
	End Class
{{endregion}}

#### __[C#] Example 2: The viewmodel__

{{region cs-gridview-expression-column_1}}
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Product> products;

        public ObservableCollection<Product> Products
        {
            get
            {
                if (this.products == null)
                {
                    this.products = new ObservableCollection<Product>();
                    for (int i = 1; i <= 5; i++)
                    {
                        this.products.Add(new Product() { ProductID = i, ProductName = "Product " + i, UnitPrice = i * 10, UnitsInStock = i });
                    }
                }

                return this.products;
            }
        }
    }
{{endregion}}

#### __[VB.NET] Example 2: The viewmodel__

{{region vb-gridview-expression-column_1}}	
	Public Class MainViewModel
		Inherits ViewModelBase

		Private _products_ As ObservableCollection(Of Product)

		Public ReadOnly Property Products() As ObservableCollection(Of Product)
			Get
				If Me._products_ Is Nothing Then
					Me._products_ = New ObservableCollection(Of Product)()
					For i As Integer = 1 To 5
						Me._products_.Add(New Product() With {
							.ProductID = i,
							.ProductName = "Product " & i,
							.UnitPrice = i * 10,
							.UnitsInStock = i
						})
					Next i
				End If

				Return Me._products_
			End Get
		End Property
	End Class
{{endregion}}

With this data setup, we can bind the GridViewExpressionColumn as shown in **Example 3**.

#### __[XAML] Example 3: Define GridViewExpressionColumn in XAML__

{{region xaml-gridview-expression-column_2}}
	<telerik:RadGridView x:Name="GridView" ItemsSource="{Binding Products}" AutoGenerateColumns="False" ColumnWidth="*">
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn Header="Product ID" DataMemberBinding="{Binding ProductID}" />
	        <telerik:GridViewDataColumn Header="Product name" DataMemberBinding="{Binding ProductName}" />
	        <telerik:GridViewDataColumn Header="Unit price" DataMemberBinding="{Binding UnitPrice}" DataFormatString="{}{0:C}" />
	        <telerik:GridViewDataColumn Header="Units in stock" DataMemberBinding="{Binding UnitsInStock}" />
	        <telerik:GridViewExpressionColumn Header="Total value in stock" Expression="UnitPrice * UnitsInStock" DataFormatString="{}{0:C}" />
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

The most important property to be set is the [Expression](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions) property. It can also be set in code-behind, for example, if the expression is too complex to be translated in XAML.

#### __[C#] Example 4: Set Expression for GridViewExpressionColumn in code.__

{{region cs-gridview-expression-column_3}}
	Expression<Func<Product, double>> expression = prod => prod.UnitPrice * prod.UnitsInStock;
	GridViewExpressionColumn column = this.GridView.Columns.OfType<GridViewExpressionColumn>().First();
	column.Expression = expression;
{{endregion}}

#### __[VB.NET] Example 4: Set Expression for GridViewExpressionColumn in code.__

{{region vb-gridview-expression-column_3}}	
	Dim expression As Expression(Of Func(Of Product, Double)) = Function(prod) prod.UnitPrice * prod.UnitsInStock
	Dim column As GridViewExpressionColumn = Me.GridView.Columns.OfType(Of GridViewExpressionColumn)().First()
	column.Expression = expression
{{endregion}}

> The values displayed in GridViewExpressionColumn will be updated automatically when a concerned property on the data item changes.

More information about expressions could be found [here](http://www.telerik.com/help/silverlight/radexpressioneditor-expressions-overview.html).
