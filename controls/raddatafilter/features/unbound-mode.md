---
title: Unbound Mode
page_title: Unbound Mode
description: Check our &quot;Unbound Mode&quot; documentation article for the RadDataFilter {{ site.framework_name }} control.
slug: raddatafilter-features-unbound-mode
tags: unbound,mode
published: True
position: 4
---

# Unbound Mode

There are scenarios, in which you might want to use __RadDataFilter__ only for its UI without passing any data to it. This scenarios will require you to use the __RadDataFilter's Unbound Mode__ feature. The usage of this feature consists in manually setting some of the __RadDataFilter's__ properties and handling events.

The example in this topic will show you a __RadGridView__ bound to a list of __Employee__ objects. A __RadDataFilter__ will be used as UI to filter the data, but the filtering itself will be done outside the __RadDataFilter__ via manipulation of __FilterDescriptor__ objects.

Here is the XAML for the example. In it you can see a __RadGridView__ and a __RadDataFilter__.



```XAML

	<Grid x:Name="LayoutRoot"
	        Background="White">
	    <Grid.RowDefinitions>
	        <RowDefinition Height="Auto" />
	        <RowDefinition />
	    </Grid.RowDefinitions>
	    <telerik:RadDataFilter x:Name="radDataFilter" />
	    <telerik:RadGridView x:Name="radGridView"
	                            ItemsSource="{Binding FilteredSource, ElementName=radDataFilter}"
	                            AutoGenerateColumns="False"
	                            Grid.Row="1">
	        <telerik:RadGridView.Columns>
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" />
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding CompanyName}" />
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding Title}" />
	        </telerik:RadGridView.Columns>
	    </telerik:RadGridView>
	</Grid>
```


When in __Unbound Mode__, __RadDataFilter__ has no __Source__. The developer instructs it what properties to show in its drop-downs by assigning its __ItemPropertyDefinitions__ property. This is a collection of __ItemPropertyDefinition objects__ that contains all the information regarding the properties, their type, their attributes, etc. 

Here is the code-behind for the example. In it you should take notice at the instantiation of the __ItemPropertyDefinition__ class and the objects passed to its constructor as arguments. Also take a closer look at the code inside the event handler for the __FilterDescriptors__ collection's __CollectionChanged__ event. In it is implemented the actual filtering. This is done by synchronizing the __FilterDescriptors__ collection of the __RadDataFilter__ with the one of the __RadDataGridView__.

>At the end of the topic you can find the code for the __Employee__ class, used in the example.



```C#

	    public UnboundModeSample()
	    {
	        InitializeComponent();
	        ItemPropertyDefinition nameDefinition = new ItemPropertyDefinition( "Name", typeof( string ), "Employee's Name" );
	        this.radDataFilter.ItemPropertyDefinitions.Add( nameDefinition );
	        this.radDataFilter.FilterDescriptors.CollectionChanged += this.FilterDescriptors_CollectionChanged;
	        this.radGridView.ItemsSource = RadGridViewSampleData.GetEmployees();
	    }
	    private void FilterDescriptors_CollectionChanged( object sender, NotifyCollectionChangedEventArgs e )
	    {
	        if ( e.Action == NotifyCollectionChangedAction.Add )
	        {
	            this.radGridView.FilterDescriptors.AddRange( e.NewItems.OfType<IFilterDescriptor>() );
	        }
	        else if ( e.Action == NotifyCollectionChangedAction.Remove )
	        {
	            foreach ( var item in e.OldItems.OfType<IFilterDescriptor>() )
	            {
	                this.radGridView.FilterDescriptors.Remove( item );
	            }
	        }
	    }
```





```VB.NET

	    Public Sub New()
	        InitializeComponent()
	        Dim nameDefinition As New ItemPropertyDefinition("Name", GetType(String), "Employee's Name")
	        Me.radDataFilter.ItemPropertyDefinitions.Add(nameDefinition)
	        AddHandler Me.radDataFilter.FilterDescriptors.CollectionChanged, AddressOf FilterDescriptors_CollectionChanged
	        Me.radGridView.ItemsSource = RadGridViewSampleData.GetEmployees()
	    End Sub
	    Private Sub FilterDescriptors_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
	        If e.Action = NotifyCollectionChangedAction.Add Then
	            Me.radGridView.FilterDescriptors.AddRange(e.NewItems.OfType(Of IFilterDescriptor)())
	        ElseIf e.Action = NotifyCollectionChangedAction.Remove Then
	            For Each item In e.OldItems.OfType(Of IFilterDescriptor)()
	                Me.radGridView.FilterDescriptors.Remove(item)
	            Next item
	        End If
	    End Sub
```



Here is also the code for the __Employee__ class, used in the example.



```C#

	public class Employee
	{
	    public Employee( string name, string companyName, string title )
	    {
	        this.Name = name;
	        this.CompanyName = companyName;
	        this.Title = title;
	    }
	    public string Name
	    {
	        get;
	        set;
	    }
	    public string CompanyName
	    {
	        get;
	        set;
	    }
	    public string Title
	    {
	        get;
	        set;
	    }
	}
```





```VB.NET

	Public Class Employee
	    Public Sub New(name As String, companyName As String, title As String)
	        Me.Name = name
	        Me.CompanyName = companyName
	        Me.Title = title
	    End Sub
	    Public Property Name() As String
	        Get
	            Return m_Name
	        End Get
	        Set(value As String)
	            m_Name = Value
	        End Set
	    End Property
	    Private m_Name As String
	    Public Property CompanyName() As String
	        Get
	            Return m_CompanyName
	        End Get
	        Set(value As String)
	            m_CompanyName = Value
	        End Set
	    End Property
	    Private m_CompanyName As String
	    Public Property Title() As String
	        Get
	            Return m_Title
	        End Get
	        Set(value As String)
	            m_Title = Value
	        End Set
	    End Property
	    Private m_Title As String
	End Class
```



## See Also

 * [Getting Started]({%slug datafilter-getting-started%})

 * [Data Annotations]({%slug raddatafilter-features-data-annotations%})

 * [Source and Filtered Source]({%slug raddatafilter-features-source-and-filtered-source%})
