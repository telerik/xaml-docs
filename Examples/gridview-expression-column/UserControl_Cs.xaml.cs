using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region gridview-expression-column_1
Expression<Func<Products, double>> expression = prod => prod.UnitPrice * prod.UnitsInStock;
GridViewExpressionColumn column = this.RadGridView1.Columns["TotalValue"] as GridViewExpressionColumn;
column.Expression = expression;
#endregion
}
