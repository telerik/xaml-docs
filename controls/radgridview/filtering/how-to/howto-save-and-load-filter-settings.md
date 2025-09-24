---
title: Save and Load Filter Settings
page_title: Save and Load Filter Settings
description: Learn how you can create a simple property bag class in order to save and load column filters in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-filtering-howto-save-and-load-filter-settings
tags: save,and,load,filter,settings
published: True
position: 18
---

# Save and Load Filter Settings

To save and load column filters, you would have to create a simple property bag class that will hold all relevant information. 



```C#
	public class FilterDescriptorProxy
	{
	    public Telerik.Windows.Data.FilterOperator Operator { get; set; }
	    public object Value { get; set; }
	    public bool IsCaseSensitive { get; set; }
	}
	
	public class FilterSetting
	{
	    public string ColumnUniqueName { get; set; }
	    public List<object> SelectedDistinctValues = new List<object>();
	    public FilterDescriptorProxy Filter1 { get; set; }
	    public Telerik.Windows.Data.FilterCompositionLogicalOperator FieldFilterLogicalOperator { get; set; }
	    public FilterDescriptorProxy Filter2 { get; set; }
	}
```




```VB.NET
	Public Class FilterDescriptorProxy
	    Public Property [Operator]() As Telerik.Windows.Data.FilterOperator
	        Get
	            Return m_Operator
	        End Get
	        Set(value As Telerik.Windows.Data.FilterOperator)
	            m_Operator = value
	        End Set
	    End Property
	    Private m_Operator As Telerik.Windows.Data.FilterOperator
	    Public Property Value() As Object
	        Get
	            Return m_Value
	        End Get
	        Set(value As Object)
	            m_Value = value
	        End Set
	    End Property
	    Private m_Value As Object
	    Public Property IsCaseSensitive() As Boolean
	        Get
	            Return m_IsCaseSensitive
	        End Get
	        Set(value As Boolean)
	            m_IsCaseSensitive = value
	        End Set
	    End Property
	    Private m_IsCaseSensitive As Boolean
	End Class
	
	Public Class FilterSetting
	    Public Property ColumnUniqueName() As String
	        Get
	            Return m_ColumnUniqueName
	        End Get
	        Set(value As String)
	            m_ColumnUniqueName = value
	        End Set
	    End Property
	    Private m_ColumnUniqueName As String
	    Public SelectedDistinctValues As New List(Of Object)()
	    Public Property Filter1() As FilterDescriptorProxy
	        Get
	            Return m_Filter1
	        End Get
	        Set(value As FilterDescriptorProxy)
	            m_Filter1 = value
	        End Set
	    End Property
	    Private m_Filter1 As FilterDescriptorProxy
	    Public Property FieldFilterLogicalOperator() As Telerik.Windows.Data.FilterCompositionLogicalOperator
	        Get
	            Return m_FieldFilterLogicalOperator
	        End Get
	        Set(value As Telerik.Windows.Data.FilterCompositionLogicalOperator)
	            m_FieldFilterLogicalOperator = value
	        End Set
	    End Property
	    Private m_FieldFilterLogicalOperator As Telerik.Windows.Data.FilterCompositionLogicalOperator
	    Public Property Filter2() As FilterDescriptorProxy
	        Get
	            Return m_Filter2
	        End Get
	        Set(value As FilterDescriptorProxy)
	            m_Filter2 = value
	        End Set
	    End Property
	    Private m_Filter2 As FilterDescriptorProxy
	End Class
```

To save the settings you need to read the current filtering information from RadGridView and store it in a collection of these property bag objects. You can then take this collection and serialize it to a medium of your choice a database or an XML file, for example, by using RadPersistenceFramework.



```C#
	public static IEnumerable<FilterSetting> SaveColumnFilters(Telerik.Windows.Controls.GridView.GridViewDataControl grid)
	{
	    IList<FilterSetting> settings = new List<FilterSetting>();
	
	    foreach (Telerik.Windows.Data.IFilterDescriptor filter in grid.FilterDescriptors)
	    {
	        Telerik.Windows.Controls.GridView.IColumnFilterDescriptor columnFilter = filter as Telerik.Windows.Controls.GridView.IColumnFilterDescriptor;
	        if (columnFilter != null)
	        {
	            FilterSetting setting = new FilterSetting();
	
	            setting.ColumnUniqueName = columnFilter.Column.UniqueName;
	
	            setting.SelectedDistinctValues.AddRange(columnFilter.DistinctFilter.DistinctValues);
	
	            if (columnFilter.FieldFilter.Filter1.IsActive)
	            {
	                setting.Filter1 = new FilterDescriptorProxy();
	                setting.Filter1.Operator = columnFilter.FieldFilter.Filter1.Operator;
	                setting.Filter1.Value = columnFilter.FieldFilter.Filter1.Value;
	                setting.Filter1.IsCaseSensitive = columnFilter.FieldFilter.Filter1.IsCaseSensitive;
	            }
	
	            setting.FieldFilterLogicalOperator = columnFilter.FieldFilter.LogicalOperator;
	
	            if (columnFilter.FieldFilter.Filter2.IsActive)
	            {
	                setting.Filter2 = new FilterDescriptorProxy();
	                setting.Filter2.Operator = columnFilter.FieldFilter.Filter2.Operator;
	                setting.Filter2.Value = columnFilter.FieldFilter.Filter2.Value;
	                setting.Filter2.IsCaseSensitive = columnFilter.FieldFilter.Filter2.IsCaseSensitive;
	            }
	
	            settings.Add(setting);
	        }
	    }
	
	    return settings;
	}
	
	public static void LoadColumnFilters(Telerik.Windows.Controls.GridView.GridViewDataControl grid
	    , IEnumerable<FilterSetting> savedSettings)
	{
	    grid.FilterDescriptors.SuspendNotifications();
	
	    foreach (FilterSetting setting in savedSettings)
	    {
	        Telerik.Windows.Controls.GridViewColumn column = grid.Columns[setting.ColumnUniqueName];
	
	        Telerik.Windows.Controls.GridView.IColumnFilterDescriptor columnFilter = column.ColumnFilterDescriptor;
	
	        foreach (object distinctValue in setting.SelectedDistinctValues)
	        {
	            columnFilter.DistinctFilter.AddDistinctValue(distinctValue);
	        }
	
	        if (setting.Filter1 != null)
	        {
	            columnFilter.FieldFilter.Filter1.Operator = setting.Filter1.Operator;
	            columnFilter.FieldFilter.Filter1.Value = setting.Filter1.Value;
	            columnFilter.FieldFilter.Filter1.IsCaseSensitive = setting.Filter1.IsCaseSensitive;
	        }
	
	        columnFilter.FieldFilter.LogicalOperator = setting.FieldFilterLogicalOperator;
	
	        if (setting.Filter2 != null)
	        {
	            columnFilter.FieldFilter.Filter2.Operator = setting.Filter2.Operator;
	            columnFilter.FieldFilter.Filter2.Value = setting.Filter2.Value;
	            columnFilter.FieldFilter.Filter2.IsCaseSensitive = setting.Filter2.IsCaseSensitive;
	        }
	    }
	
	    grid.FilterDescriptors.ResumeNotifications();
	}
```



```VB.NET
	Public Shared Function SaveColumnFilters(grid As Telerik.Windows.Controls.GridView.GridViewDataControl) As IEnumerable(Of FilterSetting)
	    Dim settings As IList(Of FilterSetting) = New List(Of FilterSetting)()
	
	    For Each filter As Telerik.Windows.Data.IFilterDescriptor In grid.FilterDescriptors
	        Dim columnFilter As Telerik.Windows.Controls.GridView.IColumnFilterDescriptor = TryCast(filter, Telerik.Windows.Controls.GridView.IColumnFilterDescriptor)
	        If columnFilter IsNot Nothing Then
	            Dim setting As New FilterSetting()
	
	            setting.ColumnUniqueName = columnFilter.Column.UniqueName
	
	            setting.SelectedDistinctValues.AddRange(columnFilter.DistinctFilter.DistinctValues)
	
	            If columnFilter.FieldFilter.Filter1.IsActive Then
	                setting.Filter1 = New FilterDescriptorProxy()
	                setting.Filter1.[Operator] = columnFilter.FieldFilter.Filter1.[Operator]
	                setting.Filter1.Value = columnFilter.FieldFilter.Filter1.Value
	                setting.Filter1.IsCaseSensitive = columnFilter.FieldFilter.Filter1.IsCaseSensitive
	            End If
	
	            setting.FieldFilterLogicalOperator = columnFilter.FieldFilter.LogicalOperator
	
	            If columnFilter.FieldFilter.Filter2.IsActive Then
	                setting.Filter2 = New FilterDescriptorProxy()
	                setting.Filter2.[Operator] = columnFilter.FieldFilter.Filter2.[Operator]
	                setting.Filter2.Value = columnFilter.FieldFilter.Filter2.Value
	                setting.Filter2.IsCaseSensitive = columnFilter.FieldFilter.Filter2.IsCaseSensitive
	            End If
	
	            settings.Add(setting)
	        End If
	    Next
	
	    Return settings
	End Function
	
	Public Shared Sub LoadColumnFilters(grid As Telerik.Windows.Controls.GridView.GridViewDataControl, savedSettings As IEnumerable(Of FilterSetting))
	    grid.FilterDescriptors.SuspendNotifications()
	
	    For Each setting As FilterSetting In savedSettings
	        Dim column As Telerik.Windows.Controls.GridViewColumn = grid.Columns(setting.ColumnUniqueName)
	
	        Dim columnFilter As Telerik.Windows.Controls.GridView.IColumnFilterDescriptor = column.ColumnFilterDescriptor
	
	        For Each distinctValue As Object In setting.SelectedDistinctValues
	            columnFilter.DistinctFilter.AddDistinctValue(distinctValue)
	        Next
	
	        If setting.Filter1 IsNot Nothing Then
	            columnFilter.FieldFilter.Filter1.[Operator] = setting.Filter1.[Operator]
	            columnFilter.FieldFilter.Filter1.Value = setting.Filter1.Value
	            columnFilter.FieldFilter.Filter1.IsCaseSensitive = setting.Filter1.IsCaseSensitive
	        End If
	
	        columnFilter.FieldFilter.LogicalOperator = setting.FieldFilterLogicalOperator
	
	        If setting.Filter2 IsNot Nothing Then
	            columnFilter.FieldFilter.Filter2.[Operator] = setting.Filter2.[Operator]
	            columnFilter.FieldFilter.Filter2.Value = setting.Filter2.Value
	            columnFilter.FieldFilter.Filter2.IsCaseSensitive = setting.Filter2.IsCaseSensitive
	        End If
	    Next
	
	    grid.FilterDescriptors.ResumeNotifications()
	End Sub
```

>Note that when the filters are being restored we suspend and resume the notifications in order to perform the filtering in a single batch. 

When you deserialize the filter settings, you only need to find the respective column and apply the information stored in the property bag to the column filter.



```C#
	private IEnumerable<FilterSetting> serializedSettings;
	
	private void OnSaveButtonClick(object sender, RoutedEventArgs e)
	{
	    IEnumerable<FilterSetting> savedSettings = SaveColumnFilters(this.radGridView);
	
	    // You can serialize the saved settings in any way that you like from here on.
	    this.serializedSettings = savedSettings;
	}
	
	private void OnLoadButtonClick(object sender, RoutedEventArgs e)
	{
	    // You should deserialize the settings from where you have serialized them.
	    IEnumerable<FilterSetting> savedSettings = this.serializedSettings;
	
	    LoadColumnFilters(this.radGridView, savedSettings);
	}
```



```VB.NET
	Private serializedSettings As IEnumerable(Of FilterSetting)
	
	Private Sub OnSaveButtonClick(sender As Object, e As RoutedEventArgs)
	    Dim savedSettings As IEnumerable(Of FilterSetting) = SaveColumnFilters(Me.radGridView)
	
	    ' You can serialize the saved settings in any way that you like from here on.
	    Me.serializedSettings = savedSettings
	End Sub
	
	Private Sub OnLoadButtonClick(sender As Object, e As RoutedEventArgs)
	    ' You should deserialize the settings from where you have serialized them.
	    Dim savedSettings As IEnumerable(Of FilterSetting) = Me.serializedSettings
	
	    LoadColumnFilters(Me.radGridView, savedSettings)
	End Sub
```

More about this you can learn [here]({%slug gridview-filtering-programmatic%}).

You can also check the [Save and Load Settings for RadGridView]({%slug gridview-overview-saveload-settings%}) article.
        
