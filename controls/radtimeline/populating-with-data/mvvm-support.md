---
title: MVVM support
page_title: MVVM support
description: Check our &quot;MVVM support&quot; documentation article for the RadTimeline {{ site.framework_name }} control.
slug: radtimeline-mvvm-support
tags: mvvm,support
published: True
position: 1
---

# MVVM support

The __RadTimeline__ control can be used with great success with the Model-View-ViewModel (MVVM) pattern. This help topic will demonstrate how to bind the control with the pattern.

1. We'll get started with a class with two properties - Duration and Date. They will be used to represent the two types of items in the Timeline. We'll also need a method that will set values to the newly created properties and will return a collection of our business objects.            

	```C#
		public class Product
		{
			public TimeSpan Duration { get; set; }
			public DateTime Date { get; set; }
		
			public static ObservableCollection<Product> GetData(int count)
			{
				var startDate = new DateTime(2010, 1, 1);
				var endDate = new DateTime(2012, 2, 1);
				Random r = new Random();
				ObservableCollection<Product> result = new ObservableCollection<Product>();
		
				for (DateTime i = startDate; i < endDate; i = i.AddMonths(1))
				{
					result.Add(new Product() { Date = i, Duration = TimeSpan.FromDays(r.Next(50, 100))} );
				}
		
				for (int i = 0; i < 15; i++)
				{
					result.Add(new Product()
					{
						Date = startDate.AddMonths(r.Next(0, 25)).AddDays(15)
					});
				}
		
				return result;
			}
		}
	```
	```VB.NET
		Public Class Product
			Public Property Duration() As TimeSpan
			Public Property [Date]() As Date
		
			Public Shared Function GetData(ByVal count As Integer) As ObservableCollection(Of Product)
				Dim startDate = New Date(2010, 1, 1)
				Dim endDate = New Date(2012, 2, 1)
				Dim r As New Random()
				Dim result As New ObservableCollection(Of Product)()
		
				Dim i As Date = startDate
				Do While i < endDate
					result.Add(New Product() With {.Date = i, .Duration = TimeSpan.FromDays(r.Next(50, 100))})
					i = i.AddMonths(1)
				Loop
		
				For i As Integer = 0 To 14
					result.Add(New Product() With {.Date = startDate.AddMonths(r.Next(0, 25)).AddDays(15)})
				Next i
		
				Return result
			End Function
		End Class
	```

2. Create new class that inherits the ViewModelBase abstract class. This will be your ViewModel. What we'll need to add in it - an ObservableCollection that will be used as data source. In the constructor of the class call the GetData method we created in our Product class. (check Step 1.) The parameter of the method will represent the number of items in the timeline.            

	>ViewModelBase class is part of the Telerik.Windows.Controls.dll

	```C#
		public class ExampleViewModel : ViewModelBase
		{
			private ObservableCollection<Product> _data;
			public ObservableCollection<Product> Data
			{
				get
				{
					return this._data;
				}
				set
				{
					if (this._data != value)
					{
						this._data = value;
						this.OnPropertyChanged("Data");
					}
				}
			}
		
			public ExampleViewModel()
			{
				this.Data = Product.GetData(15);
			}
		}
	```
	```VB.NET
		Public Class ExampleViewModel
			Inherits ViewModelBase
				Private _data As ObservableCollection(Of Product)
				Public Property Data() As ObservableCollection(Of Product)
					Get
						Return Me._data
					End Get
					Set(ByVal value As ObservableCollection(Of Product))
						If Me._data IsNot value Then
							Me._data = value
							Me.OnPropertyChanged("Data")
						End If
					End Set
				End Property
		
				Public Sub New()
					Me.Data = Product.GetData(15)
				End Sub
		End Class
	```

3. Add new RadTimeline declarations in XAML and bind the StartPath and DurationPath properties. To learn more about these properties, please check the [DataBinding]({%slug radtimeline-databinding%}) topic:            

	```XAML
		<telerik:RadTimeline Height="250" x:Name="RadTimeline1"
							VerticalAlignment="Top"
							Margin="6"
							PeriodStart="2011/01/01" PeriodEnd="2011/06/01"
							StartPath="Date"
							DurationPath="Duration"                
							ItemsSource="{Binding Data}">
			<telerik:RadTimeline.Intervals>
				<telerik:YearInterval />
				<telerik:MonthInterval />
				<telerik:WeekInterval />
				<telerik:DayInterval />
			</telerik:RadTimeline.Intervals>
		</telerik:RadTimeline>
	```