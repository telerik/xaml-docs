---
title: Building Hierarchical Grid View
page_title: Building Hierarchical Grid View
description: Building Hierarchical Grid View
slug: gridview-building-hierarchical-grid-view
tags: building,hierarchical,grid,view
published: True
position: 1
---

# Building Hierarchical Grid View


This tutorial will walk you through the process of displaying hierarchical data in __RadGridView__. It will not cover the creation of a {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} application, adding __RadGridView__ to your __UserControl__ or how to define columns. If you need information on any of these topics please read the [Getting Started]({%slug gridview-getting-started2%}) topic. Building __Hierarchical GridView__ will lead you through:

* [How to prepare the sample hierarchical data and how to bind the data to your grid](#Preparing_the_Data)

* [How to define the child table definitions for your grid and how to configure them](#Defining_ChildTableDefinitions)

The final result should look like this:

![](images/RadGridView_BuildingHierarchicalGrid_2.png)

Assuming that you have already created a {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} application and defined the __RadGridView__ control, it is time to prepare the sample data for it.

## Preparing the Data

The sample data is represented by teams divided into divisions. First create the class that will represent a single team.

#### __C#__

{{region gridview-building-hierarchical-grid-view_0}}

	public class Team
	{
	    public int Id
	    {
	        get;
	        set;
	    }
	    public string Name
	    {
	        get;
	        set;
	    }
	    public int Place
	    {
	        get;
	        set;
	    }
	}
{{endregion}}


#### __VB.NET__

{{region gridview-building-hierarchical-grid-view_1}}

	Public Class Team
	Private _Id As Integer
	    Public Property Id() As Integer
	        Get
	            Return _Id
	        End Get
	        Set(ByVal value As Integer)
	            _Id = value
	        End Set
	    End Property
	
	Private _Name As String
	    Public Property Name() As String
	        Get
	            Return _Name
	        End Get
	        Set(ByVal value As String)
	            _Name = value
	        End Set
	    End Property
	
	Private _Place As Integer
	    Public Property Place() As Integer
	        Get
	            Return _Place
	        End Get
	        Set(ByVal value As Integer)
	            _Place = value
	        End Set
	    End Property
	End Class
{{endregion}}


The class that represents a single division will contain a collection of Team objects.

#### __C#__

{{region gridview-building-hierarchical-grid-view_2}}

	public class Division
	{
	   public int Id
	   {
	       get;
	       set;
	   }
	   public string Name
	   {
	       get;
	       set;
	   }
	   public List<Team> Teams
	   {
	       get;
	       set;
	   }
	}
{{endregion}}


#### __VB.NET__

{{region gridview-building-hierarchical-grid-view_3}}

	Public Class Division
	Private _Id As Integer
	    Public Property Id() As Integer
	        Get
	            Return _Id
	        End Get
	        Set(ByVal value As Integer)
	            _Id = value
	        End Set
	    End Property
	
	Private _Name As String
	    Public Property Name() As String
	        Get
	            Return _Name
	        End Get
	        Set(ByVal value As String)
	            _Name = value
	        End Set
	    End Property
	
	Private _Teams As List(Of Team)
	    Public Property Teams() As List(Of Team)
	        Get
	            Return _Teams
	        End Get
	        Set(ByVal value As List(Of Team))
	            _Teams = value
	        End Set
	    End Property
	End Class
{{endregion}}


>Note that if you want to support two way binding your classes should implement the __INotifyPropertyChanged__ interface and rise the __PropertyChanged__ event every time a property value changes.

Create "__DivisionsService__" class and implement a static method __GetDivisions.__ For the purpose of this tutorial it will return an observable collection containing several hard-coded divisions.

#### __C#__

{{region gridview-building-hierarchical-grid-view_4}}

	public class DivisionsService
	{
	   public static ObservableCollection<Division> GetDivisions()
	   {
	       ObservableCollection<Division> divisions = new ObservableCollection<Division>();
	       Division dA = new Division();
	       dA.Name = "Division A";
	       dA.Id = 1;
	       dA.Teams = new List<Team>();
	       Team team1 = new Team();
	       team1.Id = 1;
	       team1.Name = "Team I";
	       team1.Place = 1;
	       dA.Teams.Add( team1 );
	       Team team2 = new Team();
	       team2.Id = 2;
	       team2.Name = "Team II";
	       team2.Place = 2;
	       dA.Teams.Add( team2 );
	       Team team3 = new Team();
	       team3.Id = 3;
	       team3.Name = "Team III";
	       team3.Place = 3;
	       dA.Teams.Add( team3 );
	       divisions.Add( dA );
	       Division dB = new Division();
	       dB.Name = "Division B";
	       dB.Id = 2;
	       dB.Teams = new List<Team>();
	       Team teamRed = new Team();
	       teamRed.Id = 1;
	       teamRed.Name = "Team Red";
	       teamRed.Place = 1;
	       dB.Teams.Add( teamRed );
	       Team teamGreen = new Team();
	       teamGreen.Id = 2;
	       teamGreen.Name = "Team Green";
	       teamGreen.Place = 2;
	       dB.Teams.Add( teamGreen );
	       Team teamBlue = new Team();
	       teamBlue.Id = 3;
	       teamBlue.Name = "Team Blue";
	       teamBlue.Place = 3;
	       dB.Teams.Add( teamBlue );
	       divisions.Add( dB );
	
	       Division dC = new Division();
	       dC.Name = "Division C";
	       dC.Id = 3;
	       dC.Teams = new List<Team>();
	       Team teamAlpha = new Team();
	       teamAlpha.Id = 1;
	       teamAlpha.Name = "Team Alpha";
	       teamAlpha.Place = 1;
	       dC.Teams.Add( teamAlpha );
	       Team teamBeta = new Team();
	       teamBeta.Id = 2;
	       teamBeta.Name = "Team Beta";
	       teamBeta.Place = 2;
	       dC.Teams.Add( teamBeta );
	       Team teamGama = new Team();
	       teamGama.Id = 3;
	       teamGama.Name = "Team Gama";
	       teamGama.Place = 3;
	       dC.Teams.Add( teamGama );
	       divisions.Add( dC );
	       return divisions;
	   }
	}
{{endregion}}


#### __VB.NET__

{{region gridview-building-hierarchical-grid-view_5}}

	Public Class DivisionsService
	    Public Shared Function GetDivisions() As ObservableCollection(Of Division)
	        Dim divisions As New ObservableCollection(Of Division)()
	
	        Dim dA As New Division()
	        dA.Name = "Division A"
	        dA.Id = 1
	        dA.Teams = New List(Of Team)()
	        Dim team1 As New Team()
	        team1.Id = 1
	        team1.Name = "Team I"
	        team1.Place = 1
	        dA.Teams.Add(team1)
	        Dim team2 As New Team()
	        team2.Id = 2
	        team2.Name = "Team II"
	        team2.Place = 2
	        dA.Teams.Add(team2)
	        Dim team3 As New Team()
	        team3.Id = 3
	        team3.Name = "Team III"
	        team3.Place = 3
	        dA.Teams.Add(team3)
	        divisions.Add(dA)
	
	        Dim dB As New Division()
	        dB.Name = "Division B"
	        dB.Id = 2
	        dB.Teams = New List(Of Team)()
	        Dim teamRed As New Team()
	        teamRed.Id = 1
	        teamRed.Name = "Team Red"
	        teamRed.Place = 1
	        dB.Teams.Add(teamRed)
	        Dim teamGreen As New Team()
	        teamGreen.Id = 2
	        teamGreen.Name = "Team Green"
	        teamGreen.Place = 2
	        dB.Teams.Add(teamGreen)
	        Dim teamBlue As New Team()
	        teamBlue.Id = 3
	        teamBlue.Name = "Team Blue"
	        teamBlue.Place = 3
	        dB.Teams.Add(teamBlue)
	        divisions.Add(dB)
	
	        Dim dC As New Division()
	        dC.Name = "Division C"
	        dC.Id = 3
	        dC.Teams = New List(Of Team)()
	        Dim teamAlpha As New Team()
	        teamAlpha.Id = 1
	        teamAlpha.Name = "Team Alpha"
	        teamAlpha.Place = 1
	        dC.Teams.Add(teamAlpha)
	        Dim teamBeta As New Team()
	        teamBeta.Id = 2
	        teamBeta.Name = "Team Beta"
	        teamBeta.Place = 2
	        dC.Teams.Add(teamBeta)
	        Dim teamGama As New Team()
	        teamGama.Id = 3
	        teamGama.Name = "Team Gama"
	        teamGama.Place = 3
	        dC.Teams.Add(teamGama)
	        divisions.Add(dC)
	
	        Return divisions
	    End Function
	End Class
{{endregion}}


Now after the sample data is prepared you are ready to bind it to the __RadGridView__. To do this set the __ItemsSource__ property of the grid to the collection returned by the __GetDivisions__ method. But first define the following columns.

#### __XAML__

{{region gridview-building-hierarchical-grid-view_6}}

	<telerik:RadGridView x:Name="HierarchicalGridView"
	                         AutoGenerateColumns="False">
				<telerik:RadGridView.Columns>
					<telerik:GridViewDataColumn DataMemberBinding="{Binding Id}"
	                                        Header="Id" />
					<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
	                                        Header="Name" />
				</telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}


Set the __ItemsSource__ in the code-behind file of your UserControl.

#### __C#__

{{region gridview-building-hierarchical-grid-view_7}}

	public BuildingHierarchicalGrid()
	{
	    InitializeComponent();
	    this.HierarchicalGridView.ItemsSource = DivisionsService.GetDivisions();
	}
{{endregion}}


#### __VB.NET__

{{region gridview-building-hierarchical-grid-view_8}}

	Public Sub New()
	    InitializeComponent()
	    Me.HierarchicalGridView.ItemsSource = DivisionsService.GetDivisions()
	End Sub
{{endregion}}

If you run the application at this stage you should see this.

![](images/RadGridView_BuildingHierarchicalGrid_1.png)

## Defining ChildTableDefinitions

The next step is to make the __RadGridView__ display the collections of teams as children of the respective rows. To do that use the __ChildTableDefinitions__ property of the __RadGridView__ and define a new __GridViewTableDefinition__ with the following relation.

#### __XAML__

{{region gridview-building-hierarchical-grid-view_9}}

	<telerik:RadGridView x:Name="HierarchicalGridView"
	                         AutoGenerateColumns="False">
				<telerik:RadGridView.ChildTableDefinitions>
	
					<telerik:GridViewTableDefinition>
						<telerik:GridViewTableDefinition.Relation>
							<telerik:PropertyRelation ParentPropertyName="Teams" />
						</telerik:GridViewTableDefinition.Relation>
					</telerik:GridViewTableDefinition>
	
				</telerik:RadGridView.ChildTableDefinitions>
				<telerik:RadGridView.Columns>
					<telerik:GridViewDataColumn DataMemberBinding="{Binding Id}"
	                                        Header="Id" />
					<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
	                                        Header="Name" />
				</telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

And here is the final result.

![](images/RadGridView_BuildingHierarchicalGrid_2.png)

To learn more about the Hierarchical Grids you can visit the [Hierarchical GridView]({%slug gridview-hierachy-overview%}) section.

# See Also

 * [Getting Started]({%slug gridview-getting-started2%})

 * [Working with Data]({%slug gridview-working-with-data%})
