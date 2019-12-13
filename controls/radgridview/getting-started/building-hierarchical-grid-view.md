---
title: Building Hierarchical Grid View
page_title: Building Hierarchical Grid
description: Check out our tutorial that will walk you through the process of displaying hierarchical data in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-building-hierarchical-grid-view
tags: building,hierarchical,grid,view
published: True
position: 1
---

# Building Hierarchical Grid

This tutorial will walk you through the process of displaying hierarchical data in __RadGridView__. It will not cover the creation of a {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} application, adding __RadGridView__ to your __UserControl__ or how to define columns. If you need information on any of these topics please read the [Getting Started]({%slug gridview-getting-started2%}) topic. 

The final result should look like the one displayed on **Figure 1**.

#### Figure 1: Hierarchical RadGridView

![Telerik {{ site.framework_name }} DataGrid Building Hierarchical Grid](images/RadGridView_BuildingHierarchicalGrid_3.png)

Assuming that you have already created a {{ site.framework_name }} application and defined the __RadGridView__ control, it is time to prepare the sample data for it.

## Preparing the Data

The sample data is represented by teams divided into divisions. First create the class that will represent a single team.

#### __[C#] Example 1: The Team class__

{{region cs-gridview-building-hierarchical-grid-view_0}}
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

#### __[VB.NET] Example 1: The Team class__

{{region vb-gridview-building-hierarchical-grid-view_1}}
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

#### __[C#] Example 2: The Division class__

{{region cs-gridview-building-hierarchical-grid-view_2}}
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

#### __[VB.NET] Example 2: The Division class__

{{region vb-gridview-building-hierarchical-grid-view_3}}
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

>Note that if you want to support two way binding your classes should implement the __INotifyPropertyChanged__ interface and raise the __PropertyChanged__ event every time a property value changes.

Create a __DivisionsService__ class and implement a static method __GetDivisions.__ For the purpose of this tutorial it will return an observable collection containing several hard-coded divisions.

#### __[C#] Example 3: The DivisionsService class__

{{region cs-gridview-building-hierarchical-grid-view_4}}
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
	        dA.Teams.Add(team1);
	        Team team2 = new Team();
	        team2.Id = 2;
	        team2.Name = "Team II";
	        team2.Place = 2;
	        dA.Teams.Add(team2);
	        Team team3 = new Team();
	        team3.Id = 3;
	        team3.Name = "Team III";
	        team3.Place = 3;
	        dA.Teams.Add(team3);
	        divisions.Add(dA);
	        Division dB = new Division();
	        dB.Name = "Division B";
	        dB.Id = 2;
	        dB.Teams = new List<Team>();
	        Team teamRed = new Team();
	        teamRed.Id = 1;
	        teamRed.Name = "Team Red";
	        teamRed.Place = 1;
	        dB.Teams.Add(teamRed);
	        Team teamGreen = new Team();
	        teamGreen.Id = 2;
	        teamGreen.Name = "Team Green";
	        teamGreen.Place = 2;
	        dB.Teams.Add(teamGreen);
	        Team teamBlue = new Team();
	        teamBlue.Id = 3;
	        teamBlue.Name = "Team Blue";
	        teamBlue.Place = 3;
	        dB.Teams.Add(teamBlue);
	        divisions.Add(dB);
	
	        Division dC = new Division();
	        dC.Name = "Division C";
	        dC.Id = 3;
	        dC.Teams = new List<Team>();
	        Team teamAlpha = new Team();
	        teamAlpha.Id = 1;
	        teamAlpha.Name = "Team Alpha";
	        teamAlpha.Place = 1;
	        dC.Teams.Add(teamAlpha);
	        Team teamBeta = new Team();
	        teamBeta.Id = 2;
	        teamBeta.Name = "Team Beta";
	        teamBeta.Place = 2;
	        dC.Teams.Add(teamBeta);
	        Team teamGama = new Team();
	        teamGama.Id = 3;
	        teamGama.Name = "Team Gama";
	        teamGama.Place = 3;
	        dC.Teams.Add(teamGama);
	        divisions.Add(dC);
	        return divisions;
	    }
	}
{{endregion}}

#### __[VB.NET] Example 3: The DivisionsService class__

{{region vb-gridview-building-hierarchical-grid-view_5}}
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

#### __[XAML] Example 4: Defining the RadGridView__

{{region xaml-gridview-building-hierarchical-grid-view_6}}
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

#### __[C#] Example 5: Setting the control's ItemsSource__

{{region cs-gridview-building-hierarchical-grid-view_7}}
	this.HierarchicalGridView.ItemsSource = DivisionsService.GetDivisions();
{{endregion}}

#### __[VB.NET] Example 5: Setting the control's ItemsSource__

{{region vb-gridview-building-hierarchical-grid-view_8}}
	Me.HierarchicalGridView.ItemsSource = DivisionsService.GetDivisions()
{{endregion}}

If you run the application at this stage you will observe the result from **Figure 2**.

#### Figure 2: RadGridView without a hierarchy

![Telerik {{ site.framework_name }} DataGrid No Hierarchy](images/RadGridView_BuildingHierarchicalGrid_1.png)

## Defining ChildTableDefinitions

The next step is to make the __RadGridView__ display the collections of teams as children of the respective rows. To do that use the __ChildTableDefinitions__ property of the __RadGridView__ and define a new __GridViewTableDefinition__ with the following relation.

#### __[XAML] Example 6: Defining ChildTableDefinitions__

{{region xaml-gridview-building-hierarchical-grid-view_9}}
	<telerik:RadGridView x:Name="HierarchicalGridView" AutoGenerateColumns="False">
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

>You can read more about the **GridViewTableDefinition** [here]({%slug gridview-basic-hierarchies%}).

After defining the definitions you will observe the hierarchical grids as illustrated on **Figure 3**.

#### Figure 3: RadGridView with a hierarchy

![Telerik {{ site.framework_name }} DataGrid with a Hierarchy](images/RadGridView_BuildingHierarchicalGrid_2.png)

## HierarchyChildTemplate

If you need to set properties of the child RadGridView instances, you can use the **HierarchyChildTemplate**.

#### __[XAML] Example 7: Setting the control's HierarchyChildTemplate__

{{region xaml-gridview-building-hierarchical-grid-view_10}}
	<telerik:RadGridView x:Name="HierarchicalGridView" AutoGenerateColumns="False" GroupRenderMode="Flat">
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
		<telerik:RadGridView.HierarchyChildTemplate>
			<DataTemplate>
				<telerik:RadGridView ShowGroupPanel="False" AutoGenerateColumns="False" ItemsSource="{Binding Teams}" GroupRenderMode="Flat">
					<telerik:RadGridView.Columns>
						<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" 
							Header="Name" />
						<telerik:GridViewDataColumn DataMemberBinding="{Binding Place}" 
							Header="Place" />
					</telerik:RadGridView.Columns>
				</telerik:RadGridView>
			</DataTemplate>
		</telerik:RadGridView.HierarchyChildTemplate>
	</telerik:RadGridView>
{{endregion}}

The final result is observed on **Figure 4**.

#### Figure 4: Customized child grids

![Telerik {{ site.framework_name }} DataGrid with Customized Child Grids](images/RadGridView_BuildingHierarchicalGrid_2.png)

>You can also use the **HierarchyChildTemplateSelector** property to specify a DataTemplateSelector and provide different templates for the child elements based on the parent row which is expanded.

To learn more about the Hierarchical Grids you can visit the [Hierarchical GridView]({%slug gridview-hierachy-overview%}) section.

## See Also

 * [Getting Started]({%slug gridview-getting-started2%})
 * [Working with Data]({%slug gridview-working-with-data%})
 * [Set Properties to the Child GridView]({%slug gridview-how-to-access-child-gridview%})
