---
title: Change PageSize dynamically
page_title: Change PageSize dynamically
description: Change PageSize dynamically
slug: raddatapager-change-page-size-dynamically
tags: change,pagesize,dynamically
published: True
position: 3
---

# Change PageSize dynamically

Generally, the page size of a __RadDataPager__ can be set by the corresponding __PageSize__ property. However, in some cases you may require it to be changed dynamically in run time. 

So, if for example you want to use a __RadComboBox__ for changing the size and you want it defined in the template of the __RadDataPager__, you need to do a couple of things;

* Define an __IValueConverter__ responsible for adding items in the __RadComboBox__ depending on the number of data items in __RadGridView__:

#### __[C#]Example 1: Declare a Count Converter__
{{region cs-raddatapager-change-page-size-dynamically_0}}

	public class CountConverter : IValueConverter
	 {
	  public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	  {
	   var items = (value as DataPagerPresenter).DataContext as SampleDataSource;
	   int i = 1;
	   List<int> result = new List<int>();
	   foreach (var item in items.Collection)
	   {
	    if (i % 5 == 0)
	    {
	     result.Add(i);
	    }
	    i++;
	   }
	   return result;
	  }
	  public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	  {
	   return value;
	  }
	 }
{{endregion}}



#### __[VB.NET]Example 1: Declare a Count Converter__
{{region vb-raddatapager-change-page-size-dynamically_1}}

	Public Class CountConverter
	 Implements IValueConverter
	 Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
	  Dim items = TryCast(TryCast(value, DataPagerPresenter).DataContext, SampleDataSource)
	  Dim i As Integer = 1
	  Dim result As New List(Of Integer)()
	  For Each item As var In items.Collection
	   If i Mod 5 = 0 Then
	    result.Add(i)
	   End If
	   i += 1
	  Next
	  Return result
	 End Function
	 Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
	  Return value
	 End Function
	End Class
{{endregion}}



* Predefine the template of the __RadDataPager__ and bind the __SelectedValue__ of the __RadComboBox__ to the __PageSize__ property of the __RadDataPager__:

#### __[XAML]Example 2: Predefine RadDataPager`s template__
{{region xaml-raddatapager-change-page-size-dynamically_2}}

	<StackPanel Grid.Column="1" Margin="5,0" Orientation="Horizontal" Visibility="{Binding PagerControlsVisibility.TextControlVisibility, RelativeSource={RelativeSource TemplatedParent}}">
	          <telerik:RadComboBox ItemsSource="{Binding RelativeSource={RelativeSource TemplatedParent}, Converter={StaticResource countConverter}}" SelectedValue="{Binding PageSize, RelativeSource={RelativeSource TemplatedParent}, Mode=TwoWay}" x:Name="radComboBox" />  
	</StackPanel>
{{endregion}}



* Set the updates style to the __RadDataPager__:

#### __[XAML]Example 3: Apply the style to the RadDataPager__
{{region xaml-raddatapager-change-page-size-dynamically_3}}

	<Grid x:Name="LayoutRoot" DataContext="{Binding Source={StaticResource SampleDataSource}}">
	    <Grid.RowDefinitions>
	 <RowDefinition Height="auto"/>
	 <RowDefinition Height="auto"/>
	    </Grid.RowDefinitions>
	    <telerik:RadGridView  x:Name="grid" ColumnWidth="*" ItemsSource="{Binding Collection}" Width="900"/>
	    <telerik:RadDataPager Grid.Row="1" Source="{Binding Items, ElementName=grid}" PageSize="10" 
	                          IsTotalItemCountFixed="True" 
	                          Style="{StaticResource RadDataPagerStyle1}"/>
	</Grid>
{{endregion}}



Once you created all the necessary elements, your application should be displayed as follows:

#### __Figure 1: RadDataPager`s appearance after the modifications__
![](images/RadDataPager_ChangePageSizeDynamically.png)


>tip You may download a full runnable sample project illustrating the approach described in this [Code Library](http://www.telerik.com/community/code-library/silverlight/datapager/dynamically-change-the-pagesize-of-raddatapager.aspx).
