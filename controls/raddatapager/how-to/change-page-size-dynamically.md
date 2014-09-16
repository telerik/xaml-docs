---
title: Change PageSize dynamically
page_title: Change PageSize dynamically
description: Change PageSize dynamically
slug: raddatapager-change-page-size-dynamically
tags: change,pagesize,dynamically
publish: True
position: 3
---

# Change PageSize dynamically



## 

Generally, the page size of a RadDataPager can be set by the corresponding PageSize property. However, in some cases you may require it to be changed dynamically in run time. 

So, if for example you want to use a RadComboBox for changing the size and you want it defined in the template of the RadDataPager, you need to do a couple of things;

* Define an IValueConverter responsible for adding items in the RadComboBox depending on the number of data items in RadGridView:

#### __C#__

{{region raddatapager-change-page-size-dynamically_0}}
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



#### __VB.NET__

{{region raddatapager-change-page-size-dynamically_1}}
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



* Predefine the template of the RadDataPager and bind the SelectedValue of the RadComboBox to the PageSize property of the RadDataPager:

#### __XAML__

{{region raddatapager-change-page-size-dynamically_2}}
	<StackPanel Grid.Column="1" Margin="5,0" Orientation="Horizontal" Visibility="{Binding PagerControlsVisibility.TextControlVisibility, RelativeSource={RelativeSource TemplatedParent}}">
	          <telerik:RadComboBox ItemsSource="{Binding RelativeSource={RelativeSource TemplatedParent}, Converter={StaticResource countConverter}}" SelectedValue="{Binding PageSize, RelativeSource={RelativeSource TemplatedParent}, Mode=TwoWay}" x:Name="radComboBox" />  
	</StackPanel>
	{{endregion}}



* Set the updates style to the RadDataPager:

#### __XAML__

{{region raddatapager-change-page-size-dynamically_3}}
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




         
      ![](images/RadDataPager_ChangePageSizeDynamically.png)



>tipYou may download a full runnable sample project illustrating the approach described in this [Code Library](http://www.telerik.com/community/code-library/silverlight/datapager/dynamically-change-the-pagesize-of-raddatapager.aspx).
