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

#region gridview-troubleshooting-sum-aggregate_1
var aggregate = new AggregateFunction<Player, int>()
{
	AggregationExpression = players => players.Select(x => x.Number).Sum()
};
playersGrid.Columns[0].AggregateFunctions.Add(aggregate);
#endregion
}
