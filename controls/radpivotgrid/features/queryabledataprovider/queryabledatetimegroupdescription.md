---
title: QueryableDateTimeGroupDescription
page_title: QueryableDateTimeGroupDescription
description: This article will describe the QueryableDateTimeGroupDescription class.
slug: radpivotgrid-features-queryabledatetimegroupdescription
tags: queryabledatetimegroupdescription
published: True
position: 9
---

# QueryableDateTimeGroupDescription

In this article you will learn how to use a QueryableDateTimeGroupDescription with your DateTime and DateTimeOffset data.

## QueryableDateTimeGroupDescription

__QueryableDateTimeGroupDescription__ is used when you want to group your data by a property of type *DateTime* or *DateTimeOffset*. It has the following properties:      

* __PropertyName__ : defines the name of the property by which the data will be grouped. It is mandatory to set a value.            

* __Step__ : defines the grouping interval. Default value is Year, but you can change it to one of the following: Quarter, Month, Day, Week Hour, Minute, Second (The Week, Hour, Minute and Second steps are available since the __2019.2.729__ version). 

>tip If you have the following dates: 01-01-2013 and 20-02-2013 and you set Step to Year, the two values will be in one group - 2013. But if you change the step to Month, the values will be in two different groups - January and February.            

When you have a property of type DateTime (DateTimeOffset), you can create several QueryableDateTimeGroupDescription with different steps. You may also create a QueryablePropertyGroupDescription - this way the DateTime will be treated as a string and grouped as such. All of them can be used simultaneously. You can add the description in RowGroupDescriptions or ColumnGroupDescriptions collections of QueryableDataSourceProvider.

__Example 1: Adding multiple group descriptions in xaml__

```XAML
	<pivot:QueryableDataProvider.RowGroupDescriptions>
	    <pivot:QueryableDateTimeGroupDescription PropertyName="Date" Step="Quarter"/>
	    <pivot:QueryableDateTimeGroupDescription PropertyName="Date" Step="Month" />
	    <pivot:QueryablePropertyGroupDescription PropertyName="Date"/>
	</pivot:LocalDataSourceProvider.RowGroupDescriptions>
```

__Example 2: Adding multiple group descriptions in code__

```C#
	QueryableDateTimeGroupDescription dateTimeGroupDescription1 = new QueryableDateTimeGroupDescription();
	dateTimeGroupDescription1.PropertyName = "Date";
	dateTimeGroupDescription1.Step = DateTimeStep.Quarter;
	QueryableDateTimeGroupDescription dateTimeGroupDescription2 = new QueryableDateTimeGroupDescription();
	dateTimeGroupDescription2.PropertyName = "Date";
	dateTimeGroupDescription2.Step = DateTimeStep.Month;
	QueryablePropertyGroupDescription propertyGroupDescription = new QueryablePropertyGroupDescription();
	propertyGroupDescription.PropertyName = "Date";
	
	var dataProvider = new QueryableDataProvider();
	dataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription1);
	dataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription2);
	dataProvider.RowGroupDescriptions.Add(propertyGroupDescription);
```
```VB.NET
	Dim dateTimeGroupDescription1 As New QueryableDateTimeGroupDescription()
	dateTimeGroupDescription1.PropertyName = "Date"
	dateTimeGroupDescription1.Step = DateTimeStep.Quarter
	Dim dateTimeGroupDescription2 As New QueryableDateTimeGroupDescription()
	dateTimeGroupDescription2.PropertyName = "Date"
	dateTimeGroupDescription2.Step = DateTimeStep.Month
	Dim propertyGroupDescription As New QueryablePropertyGroupDescription()
	propertyGroupDescription.PropertyName = "Date"

	Dim dataProvider = New QueryableDataProvider()
	dataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription1)
	dataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription2)
	dataProvider.RowGroupDescriptions.Add(propertyGroupDescription)
```

## Modify FieldTree of RadPivotFieldList

By default __RadPivotFieldList__ will show the following steps in its FieldTree for each QueryableDateTimeGroupDescription: Year, Month, Quarter, Day (you will also see one additional item, which will create a QueryablePropertyGroupDescription instead of a QueryableDateTimeGroupDescription). 

That said, you can set four more steps in code or xaml - Week, Hour, Minute, Second(Those 4 steps were added with the __2019.2.729__ version). In order to add them to the FieldTree of RadPivotFieldList you have two options:

* Handle the __GetDescriptionsDataAsyncCompleted__ of the __FieldDescriptionsProvider__.

	__Examples 3 and 4__ below demonstrate how the GetDescriptionsDataAsyncCompleted event can be handled in xaml and code respectively. __Example 5__ demonstrate a sample implementation of the event handler that shows the Week, Hour, Minute and Second steps for a property named "Date".

	__Example 3: Handling the GetDescriptionsDataAsyncCompleted event in xaml__
	```XAML
		<pivot:QueryableDataProvider>
				<pivot:QueryableDataProvider.FieldDescriptionsProvider>
					<pivot:QueryableFieldDescriptionsProvider GetDescriptionsDataAsyncCompleted="FieldDescriptionsProvider_GetDescriptionsDataAsyncCompleted" />
				</pivot:QueryableDataProvider.FieldDescriptionsProvider>
		</pivot:QueryableDataProvider>
	```

	__Example 4: Handling the GetDescriptionsDataAsyncCompleted event in code__
	```C#
		(this.PivotGrid.DataProvider as QueryableDataProvider).FieldDescriptionsProvider.GetDescriptionsDataAsyncCompleted += FieldDescriptionsProvider_GetDescriptionsDataAsyncCompleted;
	```
```VB.NET
		TryCast(Me.PivotGrid.DataProvider, QueryableDataProvider).FieldDescriptionsProvider.GetDescriptionsDataAsyncCompleted 
	```

	__Example 5: Showing the additional steps__
	```C#
		private void FieldDescriptionsProvider_GetDescriptionsDataAsyncCompleted(object sender, Telerik.Pivot.Core.Fields.GetDescriptionsDataCompletedEventArgs e)
			{
				// The code below assumes that there is a DateTime property called "Date"
				var dateTimeNodes = e.DescriptionsData.RootFieldInfo.Children.Where(n => n.Caption == "Date").FirstOrDefault().Children;
			
				foreach (var dateTimeNode in dateTimeNodes)
				{
					var fieldInfoNode = dateTimeNode as FieldInfoNode;

					if (fieldInfoNode.FieldInfo.DisplayName == "Date - Week")
					{
						(fieldInfoNode.FieldInfo as PropertyFieldInfo).AutoGenerateField = true;
					}
					if(fieldInfoNode.FieldInfo.DisplayName == "Date - Hour")
					{
						(fieldInfoNode.FieldInfo as PropertyFieldInfo).AutoGenerateField = true;
					}
					if (fieldInfoNode.FieldInfo.DisplayName == "Date - Minute")
					{
						(fieldInfoNode.FieldInfo as PropertyFieldInfo).AutoGenerateField = true;
					}
					if (fieldInfoNode.FieldInfo.DisplayName == "Date - Second")
					{
						(fieldInfoNode.FieldInfo as PropertyFieldInfo).AutoGenerateField = true;
					}
				}
			}
	```
```VB.NET
		Private Sub FieldDescriptionsProvider_GetDescriptionsDataAsyncCompleted(ByVal sender As Object, ByVal e As Telerik.Pivot.Core.Fields.GetDescriptionsDataCompletedEventArgs)
				' The code below assumes that there is a DateTime property called "Date"
				Dim dateTimeNodes = e.DescriptionsData.RootFieldInfo.Children.Where(Function(n) n.Caption = "Date").FirstOrDefault().Children

				For Each dateTimeNode In dateTimeNodes
					Dim fieldInfoNode = TryCast(dateTimeNode, FieldInfoNode)

					If fieldInfoNode.FieldInfo.DisplayName = "Date - Week" Then
						TryCast(fieldInfoNode.FieldInfo, PropertyFieldInfo).AutoGenerateField = True
					End If
					If fieldInfoNode.FieldInfo.DisplayName = "Date - Hour" Then
						TryCast(fieldInfoNode.FieldInfo, PropertyFieldInfo).AutoGenerateField = True
					End If
					If fieldInfoNode.FieldInfo.DisplayName = "Date - Minute" Then
						TryCast(fieldInfoNode.FieldInfo, PropertyFieldInfo).AutoGenerateField = True
					End If
					If fieldInfoNode.FieldInfo.DisplayName = "Date - Second" Then
						TryCast(fieldInfoNode.FieldInfo, PropertyFieldInfo).AutoGenerateField = True
					End If
				Next dateTimeNode
		End Sub
	```

* Create a custom __QueryableFieldDescriptionsProvider__.

	__Example 6__ demonstrates how to create a custom QueryableFieldDescriptionsProvider and ovveride its __GetFieldDescriptionHierarchy__ method in order to show the additional steps. __Examples 7 and 8__ demonstrate how to use the created class by setting it to the __FieldDescriptionsProvider__ property of the QueryableDataProvider.

	__Example 6: Custom QueryableFieldDescriptionsProvider__
	```C#
		public class CustomQueryableFieldDescriptionsProvider : QueryableFieldDescriptionsProvider
		{
			protected override ContainerNode GetFieldDescriptionHierarchy(IEnumerable<IPivotFieldInfo> fieldInfos)
			{
				var hierarchy = base.GetFieldDescriptionHierarchy(fieldInfos);
				// The code below assumes that there is a DateTime property called "Date"
				var dateTimeNodes = hierarchy.Children.Where(n => n.Caption == "Date").FirstOrDefault().Children;

				foreach (var dateTimeNode in dateTimeNodes)
				{
					var fieldInfoNode = dateTimeNode as FieldInfoNode;

					if (fieldInfoNode.FieldInfo.DisplayName == "Date - Week")
					{
						(fieldInfoNode.FieldInfo as PropertyFieldInfo).AutoGenerateField = true;
					}
					if (fieldInfoNode.FieldInfo.DisplayName == "Date - Hour")
					{
						(fieldInfoNode.FieldInfo as PropertyFieldInfo).AutoGenerateField = true;
					}
					if (fieldInfoNode.FieldInfo.DisplayName == "Date - Minute")
					{
						(fieldInfoNode.FieldInfo as PropertyFieldInfo).AutoGenerateField = true;
					}
					if (fieldInfoNode.FieldInfo.DisplayName == "Date - Second")
					{
						(fieldInfoNode.FieldInfo as PropertyFieldInfo).AutoGenerateField = true;
					}
				}

				return hierarchy;
			}
		}
	```
```VB.NET
		Public Class CustomQueryableFieldDescriptionsProvider
		Inherits QueryableFieldDescriptionsProvider

			Protected Overrides Function GetFieldDescriptionHierarchy(ByVal fieldInfos As IEnumerable(Of IPivotFieldInfo)) As ContainerNode
				Dim hierarchy = MyBase.GetFieldDescriptionHierarchy(fieldInfos)
				' The code below assumes that there is a DateTime property called "Date"
				Dim dateTimeNodes = hierarchy.Children.Where(Function(n) n.Caption = "Date").FirstOrDefault().Children

				For Each dateTimeNode In dateTimeNodes
					Dim fieldInfoNode = TryCast(dateTimeNode, FieldInfoNode)

					If fieldInfoNode.FieldInfo.DisplayName = "Date - Week" Then
						TryCast(fieldInfoNode.FieldInfo, PropertyFieldInfo).AutoGenerateField = True
					End If
					If fieldInfoNode.FieldInfo.DisplayName = "Date - Hour" Then
						TryCast(fieldInfoNode.FieldInfo, PropertyFieldInfo).AutoGenerateField = True
					End If
					If fieldInfoNode.FieldInfo.DisplayName = "Date - Minute" Then
						TryCast(fieldInfoNode.FieldInfo, PropertyFieldInfo).AutoGenerateField = True
					End If
					If fieldInfoNode.FieldInfo.DisplayName = "Date - Second" Then
						TryCast(fieldInfoNode.FieldInfo, PropertyFieldInfo).AutoGenerateField = True
					End If
				Next dateTimeNode

				Return hierarchy
			End Function
		End Class
	```

	__Example 7: Using the CustomQueryableFieldDescriptionsProvider in xaml__
	```XAML
		<pivot:QueryableDataProvider>
			<pivot:QueryableDataProvider.FieldDescriptionsProvider>
				<local:CustomQueryableFieldDescriptionsProvider/>
			</pivot:QueryableDataProvider.FieldDescriptionsProvider>
		</pivot:QueryableDataProvider>
	```

	__Example 8: Using the CustomQueryableFieldDescriptionsProvider in code__
	```C#
		(this.PivotGrid.DataProvider as QueryableDataProvider).FieldDescriptionsProvider = new CustomQueryableFieldDescriptionsProvider();
	```
```VB.NET
		TryCast(Me.PivotGrid.DataProvider, QueryableDataProvider).FieldDescriptionsProvider = New CustomQueryableFieldDescriptionsProvider()
	```

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [Features]({%slug radpivotgrid-features%})
