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

#### __[C#] Example 1: Creating the Person and Country Classes__

	{{region cs-raddatafor-edit-lookup-values-with-radcombobox_0}}
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

#### __[VB.NET] Example 1: Creating the Person and Country Classes__

	{{region vb-raddatafor-edit-lookup-values-with-radcombobox_0}}
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

#### __[C#] Example 2: Set the ItemsSource__

	{{region cs-raddatafor-edit-lookup-values-with-radcombobox_1}}
	InitializeComponent();
    List<Person> persons = new List<Person>();
    // A sample list of source objects for the RadDataForm. 
    persons.Add(new Person() { FirstName = "John", LastName = "Smith", CountryID = 1 });
    persons.Add(new Person() { FirstName = "Angelo", LastName = "Romano", CountryID = 2 });
    persons.Add(new Person() { FirstName = "Jean", LastName = "Michel", CountryID = 3 });
    this.RadDataForm1.ItemsSource = persons;
	{{endregion}}

#### __[VB.NET] Example 2: Set the ItemsSource__

	{{region vb-raddatafor-edit-lookup-values-with-radcombobox_1}}
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
	{{endregion}}

Now, in order to edit the lookup values we have to do two things:

* Create a source for the RadComboBox - we'll create a **CountriesService** class with a public static **GetCountries()** method

#### __[C#] Example 3: Creating a CountriesService Class with a Static GetCountries() Method__

	{{region cs-raddatafor-edit-lookup-values-with-radcombobox_2}}
    public class CountriesService
    {
        public static List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country() { ID = 1, Name = "USA" });
            countries.Add(new Country() { ID = 2, Name = "Italy" });
            countries.Add(new Country() { ID = 3, Name = "France" });
            countries.Add(new Country() { ID = 4, Name = "Canada" });
            return countries;
        }
    }
	{{endregion}}

#### __[VB.NET] Example 3: Creating a CountriesService Class with a Static GetCountries() Method__

	{{region vb-raddatafor-edit-lookup-values-with-radcombobox_2}}
	Public Class CountriesService
        Public Shared Function GetCountries() As List(Of Country)
            Dim countries As New List(Of Country)()
            countries.Add(New Country() With { _
                .ID = 1, _
                .Name = "USA" _
            })
            countries.Add(New Country() With { _
                .ID = 2, _
                .Name = "Italy" _
            })
            countries.Add(New Country() With { _
                .ID = 3, _
                .Name = "France" _
            })
            countries.Add(New Country() With { _
                .ID = 4, _
                .Name = "Canada" _
            })
            Return countries
        End Function
    End Class
	{{endregion}}

* Define the RadComboBox as a field in the RadDataForm. To achieve this we have two options - to handle the AutoGeneratingField event and define a DataFormComboBoxField or create a template for the ReadOnlyTemplate, EditTemplate and NewItemTemplate:

1. Scenario 1 - handle the AutoGeneratingField:

#### __[C#] Example 4: Handling the AutoGeneratingField Event__

	{{region cs-raddatafor-edit-lookup-values-with-radcombobox_3}}
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

#### __[VB.NET] Example 4: Handling the AutoGeneratingField Event__

	{{region vb-raddatafor-edit-lookup-values-with-radcombobox_3}}
        Private Sub RadDataForm_AutoGeneratingField(sender As Object, e As Telerik.Windows.Controls.Data.DataForm.AutoGeneratingFieldEventArgs)
            If e.PropertyName = "CountryID" Then
                e.DataField = New DataFormComboBoxField() With { _
                 .ItemsSource = CountriesService.GetCountries(), _
                 .SelectedValuePath = "ID", _
                 .DisplayMemberPath = "Name", _
                 .DataMemberBinding = New Binding("CountryID") With { _
                 .Mode = BindingMode.TwoWay _
                 } _
                }
            End If
        End Sub
	{{endregion}}

Figure 1 shows the resulting RadDataForm:

#### __Figure 1: The DataFormComboBoxField__
  
![The DataFormComboBoxField](images/RadDataForm_EditLookupValues.png)

2. Scenario 2 - define the template for the ReadOnlyTemplate, EditTemplate and NewItemTemplate: 

#### __[XAML] Example 5: Defining the Template for ReadOnlyTemplate, EditTemplate and NewItemTemplate__

	{{region xaml-raddatafor-edit-lookup-values-with-radcombobox_4}}
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

        <telerik:RadDataForm x:Name="RadDataForm1"
            AutoGenerateFields="False"
            Header="Person"
            ItemsSource="{Binding Persons}"
            ReadOnlyTemplate="{StaticResource MyTemplate}"
            EditTemplate="{StaticResource MyTemplate}"
            NewItemTemplate="{StaticResource MyTemplate}">
        </telerik:RadDataForm>
    </Grid>
	{{endregion}}

In this case the Countries and Persons collections used for the ItemsSources of the ComboBoxField and the RadDataForm are defined in the ViewModel class:

#### __[C#] Example 6: Defining the Countries and Persons Collections in the ViewModel__

	{{region cs-raddatafor-edit-lookup-values-with-radcombobox_5}}
	public class MyViewModel
    {
        private List<Country> countries;
        private List<Person> persons;

        public List<Country> Countries
        {
            get
            {
                if (this.countries == null)
                {
                    this.countries = CountriesService.GetCountries();
                }

                return this.countries;
            }
        }

        public List<Person> Persons
        {
            get
            {
                if (this.persons == null)
                {
                    List<Person> persons = new List<Person>();
                    persons.Add(new Person() { FirstName = "John", LastName = "Smith", CountryID = 1 });
                    persons.Add(new Person() { FirstName = "Angelo", LastName = "Romano", CountryID = 2 });
                    persons.Add(new Person() { FirstName = "Jean", LastName = "Michel", CountryID = 3 });
                    this.persons = persons;
                }

                return this.persons;
            }
        }
    }
	{{endregion}}

#### __[VB.NET] Example 6: Defining the Countries and Persons Collections in the ViewModel__

	{{region vb-raddatafor-edit-lookup-values-with-radcombobox_5}}
	Public Class MyViewModel
        Private m_countries As List(Of Country)
        Private m_persons As List(Of Person)

        Public ReadOnly Property Countries() As List(Of Country)
            Get
                If Me.m_countries Is Nothing Then
                    Me.m_countries = CountriesService.GetCountries()
                End If

                Return Me.m_countries
            End Get
        End Property

        Public ReadOnly Property Persons() As List(Of Person)
            Get
                If Me.m_persons Is Nothing Then
                    Dim persons__1 As New List(Of Person)()
                    persons__1.Add(New Person() With { _
                        .FirstName = "John", _
                        .LastName = "Smith", _
                        .CountryID = 1 _
                    })
                    persons__1.Add(New Person() With { _
                        .FirstName = "Angelo", _
                        .LastName = "Romano", _
                        .CountryID = 2 _
                    })
                    persons__1.Add(New Person() With { _
                        .FirstName = "Jean", _
                        .LastName = "Michel", _
                        .CountryID = 3 _
                    })
                    Me.m_persons = persons__1
                End If

                Return Me.m_persons
            End Get
        End Property
    End Class
	{{endregion}}

The result will be same as the one in the first scenario.