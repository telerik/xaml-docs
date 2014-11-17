---
title: Edit Lookup Values with RadComboBox
page_title: Edit Lookup Values with RadComboBox
description: Edit Lookup Values with RadComboBox
slug: raddatafor-edit-lookup-values-with-radcombobox
tags: edit,lookup,values,with,radcombobox
published: True
position: 1
---

# Edit Lookup Values with RadComboBox



__RadDataForm__ gives you the opportunity to edit the current item's properties directly as well as displaying and using lookup ones. This is easily achievable by using a RadComboBox and defining its required properties. 

For the purpose of this tutorial we will create two quite simple classes - Person and Country:

#### __C#__

{{region raddatafor-edit-lookup-values-with-radcombobox_0}}

	public class Person
	 {
	  public string FirstName { get; set; }
	  public string LastName { get; set; }
	  public int CountryID { get; set; }
	 }
	public class Country
	 {
	  public int ID { get; set; }
	  public string Name { get; set; }
	 }
	{{endregion}}



#### __VB.NET__

{{region raddatafor-edit-lookup-values-with-radcombobox_1}}

	Public Class Person
	 Public Property FirstName() As String
	  Get
	   Return m_FirstName
	  End Get
	  Set
	   m_FirstName = Value
	  End Set
	 End Property
	 Private m_FirstName As String
	 Public Property LastName() As String
	  Get
	   Return m_LastName
	  End Get
	  Set
	   m_LastName = Value
	  End Set
	 End Property
	 Private m_LastName As String
	 Public Property CountryID() As Integer
	  Get
	   Return m_CountryID
	  End Get
	  Set
	   m_CountryID = Value
	  End Set
	 End Property
	 Private m_CountryID As Integer
	End Class
	Public Class Country
	 Public Property ID() As Integer
	  Get
	   Return m_ID
	  End Get
	  Set
	   m_ID = Value
	  End Set
	 End Property
	 Private m_ID As Integer
	 Public Property Name() As String
	  Get
	   Return m_Name
	  End Get
	  Set
	   m_Name = Value
	  End Set
	 End Property
	 Private m_Name As String
	End Class
	{{endregion}}



Afterwards, we may add the source of the RadDataForm:

{% if site.site_name == 'Silverlight' %}

#### __C#__

{{region raddatafor-edit-lookup-values-with-radcombobox_2}}

	public MainPage()
	  {
	   InitializeComponent();
	   List<Person> persons = new List<Person>();
	   // A sample list of source objects for the RadDataForm. 
	   persons.Add(new Person() { FirstName = "John", LastName = "Smith", CountryID = 1 });
	   persons.Add(new Person() { FirstName = "Angelo", LastName = "Romano", CountryID = 2 });
	   persons.Add(new Person() { FirstName = "Jean", LastName = "Michel", CountryID = 3 });
	   this.RadDataForm1.ItemsSource = persons;
	  }
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

#### __C#__

{{region raddatafor-edit-lookup-values-with-radcombobox_3}}

	public MainWindow()
	  {
	   InitializeComponent();
	   List<Person> persons = new List<Person>();
	   // A sample list of source objects for the RadDataForm. 
	   persons.Add(new Person() { FirstName = "John", LastName = "Smith", CountryID = 1 });
	   persons.Add(new Person() { FirstName = "Angelo", LastName = "Romano", CountryID = 2 });
	   persons.Add(new Person() { FirstName = "Jean", LastName = "Michel", CountryID = 3 });
	   this.RadDataForm1.ItemsSource = persons;
	  }
	{{endregion}}

{% endif %}



#### __VB.NET__

{{region raddatafor-edit-lookup-values-with-radcombobox_4}}

	Public Sub New()
	 InitializeComponent()
	 Dim persons As New List(Of Person)()
	 ' A sample list of source objects for the RadDataForm. 
	 persons.Add(New Person() With { _
	  Key .FirstName = "John", _
	  Key .LastName = "Smith", _
	  Key .CountryID = 1 _
	 })
	 persons.Add(New Person() With { _
	  Key .FirstName = "Angelo", _
	  Key .LastName = "Romano", _
	  Key .CountryID = 2 _
	 })
	 persons.Add(New Person() With { _
	  Key .FirstName = "Jean", _
	  Key .LastName = "Michel", _
	  Key .CountryID = 3 _
	 })
	 Me.RadDataForm1.ItemsSource = persons
	End Sub
	{{endregion}}



Now, in order to edit the lookup values we have to do two things:

* Create source for the RadComboBox:

#### __C#__

{{region raddatafor-edit-lookup-values-with-radcombobox_5}}

	private List<Country> GetCountries()
	  {
	   List<Country> countries = new List<Country>();
	   countries.Add(new Country() { ID = 1, Name = "USA" });
	   countries.Add(new Country() { ID = 2, Name = "Italy" });
	   countries.Add(new Country() { ID = 3, Name = "France" });
	   countries.Add(new Country() { ID = 4, Name = "Canada" });
	   return countries;
	  }
	{{endregion}}



#### __VB.NET__

{{region raddatafor-edit-lookup-values-with-radcombobox_6}}

	Private Function GetCountries() As List(Of Country)
	 Dim countries As New List(Of Country)()
	 countries.Add(New Country() With { _
	  Key .ID = 1, _
	  Key .Name = "USA" _
	 })
	 countries.Add(New Country() With { _
	  Key .ID = 2, _
	  Key .Name = "Italy" _
	 })
	 countries.Add(New Country() With { _
	  Key .ID = 3, _
	  Key .Name = "France" _
	 })
	 countries.Add(New Country() With { _
	  Key .ID = 4, _
	  Key .Name = "Canada" _
	 })
	 Return countries
	End Function
	{{endregion}}



* Define the RadComboBox as a field in the RadDataForm. To achieve we have two options - to handle the AutoGeneratingField event and define a DataFormComboBoxField or create a template for the ReadOnlyTemplate, EditTemplate and NewItemTemplate:

1. Scenario 1 - handle the AutoGeneratingField:

#### __C#__

{{region raddatafor-edit-lookup-values-with-radcombobox_7}}

	private void RadDataForm_AutoGeneratingField(object sender, Telerik.Windows.Controls.Data.DataForm.AutoGeneratingFieldEventArgs e)
	  {
	   if (e.PropertyName == "CountryID")
	   {
	    e.DataField = new DataFormComboBoxField()
	    {
	     ItemsSource = this.GetCountries(),
	     SelectedValuePath = "ID",
	     DisplayMemberPath = "Name",
	     DataMemberBinding = new Binding("CountryID") { Mode = BindingMode.TwoWay }
	    };
	   }
	  }
	{{endregion}}



#### __VB.NET__

{{region raddatafor-edit-lookup-values-with-radcombobox_8}}

	Private Sub RadDataForm_AutoGeneratingField(sender As Object, e As Telerik.Windows.Controls.Data.DataForm.AutoGeneratingFieldEventArgs)
	 If e.PropertyName = "CountryID" Then
	  e.DataField = New DataFormComboBoxField() With { _
	   Key .ItemsSource = Me.GetCountries(), _
	   Key .SelectedValuePath = "ID", _
	   Key .DisplayMemberPath = "Name", _
	   Key .DataMemberBinding = New Binding("CountryID") With { _
	   Key .Mode = BindingMode.TwoWay _
	   } _
	  }
	 End If
	End Sub
	{{endregion}}



Once you run the application, you will have to see the following view:
  
![](images/RadDataForm_EditLookupValues.png)

2. Scenario 2 - define the template for the ReadOnlyTemplate, EditTemplate and NewItemTemplate: 

#### __XAML__

{{region raddatafor-edit-lookup-values-with-radcombobox_9}}

	<UserControl.Resources>
	 <my:MyViewModel x:Key="MyViewModel" />
	</UserControl.Resources>
	<Grid x:Name="LayoutRoot" Background="White" DataContext="{StaticResource MyViewModel}">
	 <Grid.Resources>   
	  <DataTemplate x:Key="MyTemplate">
	   <Grid>
	              <Grid.ColumnDefinitions>
	     <ColumnDefinition/>
	     <ColumnDefinition/>
	    </Grid.ColumnDefinitions>
	   <Grid.RowDefinitions>
	     <RowDefinition/>
	     <RowDefinition/>
	   </Grid.RowDefinitions>
	   <telerik:DataFormDataField Label="First Name" DataMemberBinding="{Binding FirstName, Mode=TwoWay}" Grid.Row="0" Grid.Column="0"/>
	   <telerik:DataFormDataField Label="Last Name" DataMemberBinding="{Binding LastName, Mode=TwoWay}" Grid.Row="0" Grid.Column="1"/>
	   <telerik:DataFormComboBoxField SelectedValuePath="ID" DisplayMemberPath="Name"
	                                  Grid.Row="2" Grid.Column="1" DataMemberBinding="{Binding CountryID, Mode=TwoWay}" 
	                                  ItemsSource="{Binding Countries, Source={StaticResource MyViewModel}}" />
	   </Grid>
	  </DataTemplate>
	 </Grid.Resources>
	 <telerik:RadDataForm x:Name="DataForm1"
	    AutoGenerateFields="False"
	    Header="Person" 
	    ItemsSource="{Binding Persons}"
	    ReadOnlyTemplate="{StaticResource MyTemplate}"
	    EditTemplate="{StaticResource MyTemplate}"
	    NewItemTemplate="{StaticResource MyTemplate}">
	 </telerik:RadDataForm>
	</Grid>
	{{endregion}}



In this case the Countries and Persons collections used for the ItemsSources of the ComboBoxField and the RadDataForm are defined in the ViewModel class.

The result will be same as the one in the first scenario. 
