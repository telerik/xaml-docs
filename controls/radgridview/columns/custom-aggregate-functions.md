---
title: Custom Aggregate Functions
page_title: Custom Aggregate Functions
description: This article shows how to create custom EnumerableSelectorAggregateFunction and EnumerableAggregateFunction that can be used with the Telerik's data APIs.
slug: radgridview-columns-custom-aggregate-functions
tags: aggregatefunction,customfunctions
published: True
position: 2
---

# Custom Aggregate Functions

The Telerik UI for WPF suite comes with its own data engine that is used in the `RadGridView` control. The engine provides a set of predefined aggregate functions that can be applied over the data - count, sum, max, average, etc.

This article describes how to implement custom aggregate functions by inheriting the `EnumerableAggregateFunction` `EnumerableSelectorAggregateFunction` classes, and also the generic `AggregateFunction<TElement, TResult>` class.

## Implementing Custom EnumerableAggregateFunction

The `EnumerableAggregateFunction` represents a function that uses aggregate extension methods to return a specific result. Examples of Telerik built-in functions using this class are - `CountFunction`, `FirstFunction` and `LastFunction`.

To implement your own aggregate with custom behavior, inherit the `EnumerableAggregateFunction` and override its `AggregateMethodName` and `ExtensionMethodsType` members. 

The `ExtensionMethodsType` tells the type of the static class that holds the methods used for aggregation.

The `AggregateMethodName` returns the name of the aggregation method from the static class.

__Implementing a static class that holds the aggregation functions__
```C#
	public static class ClubModelAggregates
    {
        public static string SumGoalsPerHalfSeason<TSource>(IEnumerable<Club> clubs)
        {
            StringBuilder sb = new StringBuilder();
            double sum0 = 0, sum1 = 0;

            foreach (var club in clubs)
            {
                if (club.Period != null )
                {
                    sum0 += club.FirstHalfSeasonNumberOfGoals;
                    sum1 += club.SecondHalfSeasonNumberOfGoals;
                }
            }

            sb.Append("1st Half Season Total Goals: ");
            sb.Append(sum0);
            sb.Append(" ");
            sb.AppendLine();
            sb.Append("2nd Half Season Total Goals: ");
            sb.Append(sum1);

            return sb.ToString();
        }
    }
```

__Implementing a custom function that calculates the median of the items__
```C#
	public class CustomSumFunction : EnumerableAggregateFunction
    {
        protected override string AggregateMethodName
        {
            get { return nameof(ClubModelAggregates.SumGoalsPerHalfSeason); }
        }

        protected override Type ExtensionMethodsType
        {
            get
            {
                return typeof(ClubModelAggregates);
            }
        }
    }
```

__The Club model used to populate the ItemsSource of RadGridView__
```C#
	public class Club : ViewModelBase
    {	
		// other properties here
	
        private double firstHalfSeasonNumberOfGoals;
        private double secondHalfSeasonNumberOfGoals;
        
		public double FirstHalfSeasonNumberOfGoals 
		{
            get { return this.firstHalfSeasonNumberOfGoals;  }
            set { this.firstHalfSeasonNumberOfGoals = value; this.OnPropertyChanged(nameof(FirstHalfSeasonNumberOfGoals)); }
        }
		
		public double SecondHalfSeasonNumberOfGoals 
		{
            get { return this.secondHalfSeasonNumberOfGoals;  }
            set { this.secondHalfSeasonNumberOfGoals = value; this.OnPropertyChanged(nameof(SecondHalfSeasonNumberOfGoals)); }
        }

        public static ObservableCollection<Club> GetClubs()
        {
            return new ObservableCollection<Club>()
			{
				new Club() { FirstHalfSeasonNumberOfGoals = 44, SecondHalfSeasonNumberOfGoals = 39, /* other settings here */ },
				new Club() { FirstHalfSeasonNumberOfGoals = 52, SecondHalfSeasonNumberOfGoals = 47, /* other settings here */ },
				new Club() { FirstHalfSeasonNumberOfGoals = 29, SecondHalfSeasonNumberOfGoals = 51, /* other settings here */ },
				new Club() { FirstHalfSeasonNumberOfGoals = 33, SecondHalfSeasonNumberOfGoals = 49, /* other settings here */ },
			};
        }
    }
```

__Adding the function in the AggregateFunctions collection of RadGridView's columns__
```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding MyProperty}">
		<telerik:GridViewDataColumn.AggregateFunctions>
			<local:CustomSumFunction />
		</telerik:GridViewDataColumn.AggregateFunctions>
	</telerik:GridViewDataColumn>
```

Find a runnable project showing this approach in the [following SDK sample](https://github.com/telerik/xaml-sdk/tree/master/GridView/CustomAggregateFunctionEnumerableProperty).

## Implementing Custom EnumerableSelectorAggregateFunction

The `EnumerableSelectorAggregateFunction` represents a function that uses a specific field from the data items in order to apply calculations over the data set. Examples of Telerik built-in functions using this class are - `AverageFunction`, `MaxFunction`, `MinFunction`, `SumFunction`.

To implement your own aggregate with custom behavior, inherit the `EnumerableSelectorAggregateFunction` and override its `AggregateMethodName` and `ExtensionMethodsType` members. 

The `ExtensionMethodsType` tells the type of the static class that holds the methods used for aggregation.

The `AggregateMethodName` returns the name of the aggregation method from the static class.

__Implementing a static class that holds the aggregation functions__
```C#
	public static class MedianAggregates
	{
		// Invoked when the SourceFiled of the AggregateFunction points to a property which Type is System.Int32
		public static object GetMedian<TSource>(IEnumerable<TSource> items, Func<TSource, int> selector)
		{
			IEnumerable<int> selectedValues = items.Select(selector).Cast<int>();
			return GetMedian(selectedValues.ToArray());
		}

		// Invoked when the SourceFiled of the AggregateFunction points to a property which Type is System.Double
		public static object GetMedian<TSource>(IEnumerable<TSource> items, Func<TSource, double> selector)
		{
			IEnumerable<double> selectedValues = items.Select(selector).Cast<double>();
			return GetMedian(selectedValues.ToArray());
		}

		// Invoked when the SourceFiled of the AggregateFunction points to a property which Type is System.Decimal
		public static object GetMedian<TSource>(IEnumerable<TSource> items, Func<TSource, decimal> selector)
		{
			IEnumerable<decimal> selectedValues = items.Select(selector).Cast<decimal>();
			return GetMedian(selectedValues.ToArray());
		}

		// Invoked in the following situations:
		// - when the SourceFiled of the AggregateFunction is not set
		// - when the corresponding data type is not supported (non numeric type)
		// - when no method overload for the corresponding Type is defined in this class
		public static object GetMedian<TSource, TProperty>(IEnumerable<TSource> items, Func<TSource, TProperty> selector)
		{
			throw new ArgumentException(string.Format("Please set the SourceField property of the {0} object. The property Type should be numeric (int, double, etc.)", nameof(MedianFunction)));
			// or implement custom logic that fetches whatever values you need
		}

		private static double GetMedian(int[] items)
		{
			Array.Sort(items);
			int mid = items.Length / 2;
			if (items.Length % 2 != 0)
			{
				return items[mid];
			}			
			return items.Length == 2 ? (items[0] + items[1]) / 2d : (items[mid - 1] + items[mid]) / 2d;
		}

		private static double GetMedian(double[] items)
		{
			Array.Sort(items);
			int mid = items.Length / 2;
			if (items.Length % 2 != 0)
			{
				return items[mid];
			}
			return items.Length == 2 ? (items[0] + items[1]) / 2d : (items[mid - 1] + items[mid]) / 2d;
		}	

		private static decimal GetMedian(decimal[] items)
		{
			Array.Sort(items);
			int mid = items.Length / 2;
			if (items.Length % 2 != 0)
			{
				return items[mid];
			}
			return items.Length == 2 ? (items[0] + items[1]) / 2m : (items[mid - 1] + items[mid]) / 2m;
		}
	}
```

__Implementing a custom function that calculates the median of the items__
```C#
	public class MedianFunction : EnumerableSelectorAggregateFunction
	{
		protected override string AggregateMethodName
		{
			get { return nameof(MedianAggregates.GetMedian); }
		}

		protected override Type ExtensionMethodsType
		{
			get
			{
				return typeof(MedianAggregates);
			}
		}
	}
```

__Adding the function in the AggregateFunctions collection of RadGridView's columns__
```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Number}">
		<telerik:GridViewDataColumn.AggregateFunctions>
			<local:MedianFunction SourceField="Number"/>
		</telerik:GridViewDataColumn.AggregateFunctions>
	</telerik:GridViewDataColumn>
```

## Using Generic Aggregate Function

To implement a generic aggregate function, you can use the `AggregateFunction<TElement, TResult>` class and set its `AggregationExpression` property.

__Defining custom aggregate function__
```C#
	var customSumFunction  = new AggregateFunction<Club, int>() 
	{ 
		AggregationExpression = clubs => clubs.Select(x => x.StadiumCapacity).Sum() 
	}; 
	this.gridView.Columns[0].AggregateFunctions.Add(customSumFunction); 
```
