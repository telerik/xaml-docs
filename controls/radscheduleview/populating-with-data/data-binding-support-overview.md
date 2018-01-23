---
title: Data Binding Support Overview
page_title: Data Binding Support Overview
description: Data Binding Support Overview
slug: radscheduleview-populating-with-data-data-binding-support-overview
tags: data,binding,support,overview
published: True
position: 0
---

# Data Binding Support Overview

Data binding allows you to establish a link between the UI and the underlying business logic and keep them synchronized. It means that when a value is changed in the business layer, that change is automatically populated to the UI and vice versa. Of course, in order to work, you have to implement the proper notification or to use objects that have already implemented it.        

Binding to __RadScheduleView__ involves the following properties:

* [AppointmentsSource](#appointmentssource)
* [ResourceTypesSource](#resourcetypessource)
* [CategoriesSource](#categoriessource)
* [TimeMarkersSource](#timemarkerssource)
* [GroupDescriptionsSource](#groupdescriptionssource)

## AppointmentsSource

__AppointmentsSource__ - gets or sets the data source (__IEnumerable__) used to generate the Appointments in the __RadScheduleView__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML.            

>Note that the data source passed to the property __AppointmentsSource__ should contain only objects that implement the __IAppointment__ interface.

#### __[C#] Example 1: Defining the AppointmentsSource collection in the view model__

{{region radscheduleview-populating-with-data-data-binding_0}}
	public class MyViewModel : ViewModelBase
    {
        private ObservableCollection<Appointment> appointments;
        public ObservableCollection<Appointment> Appointments
        {
            get
            {
                if (this.appointments == null)
                {
                    this.appointments = this.CreateAppointments();
                }
                return this.appointments;
            }
        }

        private ObservableCollection<Appointment> CreateAppointments()
        {
            var apps = new ObservableCollection<Appointment>();

            var app1 = new Appointment
            {
                Subject = "Front-End Meeting",
                Start = DateTime.Today.AddHours(9),
                End = DateTime.Today.AddHours(10)
            };
            apps.Add(app1);

            var app2 = new Appointment
            {
                Subject = "Planning Meeting",
                Start = DateTime.Today.AddHours(11),
                End = DateTime.Today.AddHours(12)
            };
            apps.Add(app2);

            return apps;
        }
    }
{{endregion}}

#### __[XAML] Example 2: Binding the AppointmentsSource__

{{region radscheduleview-populating-with-data-implementing-view-model_1}}
	   <telerik:RadScheduleView x:Name="scheduleView"
                DataContext="{StaticResource MyViewModel}"
                AppointmentsSource="{Binding Appointments}">
                <telerik:RadScheduleView.ViewDefinitions>
                    <telerik:WeekViewDefinition/>
                    <telerik:DayViewDefinition />
                </telerik:RadScheduleView.ViewDefinitions>
            </telerik:RadScheduleView>
{{endregion}}

## ResourceTypesSource

__ResourceTypesSource__ -  gets or sets the data source (__IEnumerable__) used to generate the ResourceTypes of the __RadScheduleView__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML.

>Note that the data source passed to the property __ResourceTypesSource__ should contain only objects of type __ResourceType__.

#### __[C#] Example 3: Defining the ResourceTypesSource collection in the view model__

{{region radscheduleview-populating-with-data-implementing-view-model_2}}
	private ObservableCollection<ResourceType> resourceTypesSource;
        public ObservableCollection<ResourceType> ResourceTypesSource
        {
            get
            {
                if (this.resourceTypesSource == null)
                {
                    this.resourceTypesSource = new ObservableCollection<ResourceType>(this.CreateResources());
                }

                return this.resourceTypesSource;
            }
        }

        private List<ResourceType> CreateResources()
        {
            IEnumerable<IResource> resourcesProgrammes;
            IEnumerable<IResource> resourcesTVs;
            List<ResourceType> resourceTypes;

            resourcesProgrammes = new List<IResource>
            {
                new Resource("Movies", "Programme"),
                new Resource("Sports", "Programme"),
                new Resource("Shows", "Programme"),
                new Resource("Kids", "Programme"),
            };

            resourcesTVs = new List<IResource>
            {
                new Resource("LiveCastNews", "TV"),
                new Resource("Voozy", "TV"),
                new Resource("Sportix", "TV"),
            };
            resourceTypes = new List<ResourceType>();

            ResourceType resourceTypeProgramme = new ResourceType("Programme");
            resourceTypeProgramme.Resources.AddRange(resourcesProgrammes);
            ResourceType resourceTypeTV = new ResourceType("TV");
            resourceTypeTV.Resources.AddRange(resourcesTVs);

            resourceTypes.Add(resourceTypeProgramme);
            resourceTypes.Add(resourceTypeTV);

            return resourceTypes;
        }
{{endregion}}

#### __[XAML] Example 4: Binding the ResourceTypesSource__
{{region radscheduleview-populating-with-data-implementing-view-model_3}}
	<telerik:RadScheduleView x:Name="scheduleView"
                DataContext="{StaticResource MyViewModel}"
                ResourceTypesSource="{Binding ResourceTypesSource}"
                AppointmentsSource="{Binding Appointments}">
                <telerik:RadScheduleView.ViewDefinitions>
                    <telerik:WeekViewDefinition/>
                    <telerik:DayViewDefinition />
                </telerik:RadScheduleView.ViewDefinitions>
            </telerik:RadScheduleView>
{{endregion}}

## CategoriesSource

__CategoriesSource__ - gets or sets the data source (__IEnumerable__) used to generate the Categories in the __RadScheduleView__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML.

>Note that the data source passed to the property __CategoriesSource__ should contain only objects of type __Category__.

#### __[C#] Example 5: Defining the Categories colleciton in the view model__
{{region radscheduleview-populating-with-data-implementing-view-model_4}}
	private ObservableCollection<Category> categories;
	        public ObservableCollection<Category> Categories
	        {
	            get
	            {
	                if (this.categories == null)
	                {
	                    this.categories = this.CreateCategories();
	                }
	
	                return this.categories;
	            }
	        }
	
	        private ObservableCollection<Category> CreateCategories()
	        {
	            ObservableCollection<Category> categories = new ObservableCollection<Category>() {
	            new Category( "Red Category", new SolidColorBrush( Colors.Red ) ),
	            new Category( "Orange Category", new SolidColorBrush( Colors.Orange ) ),
	            new Category( "Green Category", new SolidColorBrush( Colors.Green ) )};
	
	            return categories;
	        }
{{endregion}}


#### __[XAML] Example 6: Binding the CategoriesSource__
{{region radscheduleview-populating-with-data-implementing-view-model_5}}
	<telerik:RadScheduleView x:Name="scheduleView"
                DataContext="{StaticResource MyViewModel}"
                CategoriesSource="{Binding Categories}"
                AppointmentsSource="{Binding Appointments}">
                <telerik:RadScheduleView.ViewDefinitions>
                    <telerik:WeekViewDefinition/>
                    <telerik:DayViewDefinition />
                </telerik:RadScheduleView.ViewDefinitions>
            </telerik:RadScheduleView>
{{endregion}}

## TimeMarkersSource

__TimeMarkersSource__ - gets or sets the data source (__IEnumerable__) used to generate the TimeMarkers in the __RadScheduleView__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML.

>Note that the data source passed to the property __TimeMarkersSource__ should contain only objects of type __TimeMarker__.

#### __[C#] Example 7: Defining the TimeMarkers colleciton in the view model__
{{region radscheduleview-populating-with-data-implementing-view-model_6}}
	private ObservableCollection<TimeMarker> timeMarkers;
        public ObservableCollection<TimeMarker> TimeMarkers
        {
            get
            {
                if (this.timeMarkers == null)
                {
                    this.timeMarkers = this.CreateTimeMarkers();
                }

                return this.timeMarkers;
            }
        }

        private ObservableCollection<TimeMarker> CreateTimeMarkers()
        {
            ObservableCollection<TimeMarker> timeMarkers = new ObservableCollection<TimeMarker>() {
            new TimeMarker("Busy", new SolidColorBrush( Colors.Red ) ),
            new TimeMarker("Free", new SolidColorBrush( Colors.Green ) )};

            return timeMarkers;
        }
{{endregion}}

#### __[XAML] Example 8: Binding the TimeMarkersSource__
{{region radscheduleview-populating-with-data-implementing-view-model_7}}
	<telerik:RadScheduleView x:Name="scheduleView"
                DataContext="{StaticResource MyViewModel}"
                TimeMarkersSource="{Binding TimeMarkers}"
                AppointmentsSource="{Binding Appointments}">
                <telerik:RadScheduleView.ViewDefinitions>
                    <telerik:WeekViewDefinition/>
                    <telerik:DayViewDefinition />
                </telerik:RadScheduleView.ViewDefinitions>
            </telerik:RadScheduleView>
{{endregion}}

## GroupDescriptionsSource

__GroupDescriptionsSource__ - gets or sets the data source (__IEnumerable\<GroupDescription\>__) used to generate the GroupDescriptions in the __RadScheduleView__ control. It can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML.

>Note that the data source passed to the property __GroupDescriptionsSource__ should contain only objects of type __GroupDescription__.

#### __[C#] Example 9: Defining the GroupDescriptions colleciton in the view model__
{{region radscheduleview-populating-with-data-implementing-view-model_8}}
	 private GroupDescriptionCollection groupDescriptions;
        public GroupDescriptionCollection GroupDescriptions
        {
            get
            {
                if (this.groupDescriptions == null)
                {
                    this.groupDescriptions = new GroupDescriptionCollection() { new DateGroupDescription() };
                    TimeZoneGroupDescription groupDescription = new TimeZoneGroupDescription();
                    this.groupDescriptions.Add(groupDescription);
                }
                return this.groupDescriptions;
            }
        }
{{endregion}}

#### __[XAML] Example 10: Binding the GroupDescriptionsSource__
{{region radscheduleview-populating-with-data-implementing-view-model_9}}
	<telerik:RadScheduleView x:Name="scheduleView"
                DataContext="{StaticResource MyViewModel}"
                GroupDescriptionsSource="{Binding GroupDescriptions}"
                AppointmentsSource="{Binding Appointments}">
                <telerik:RadScheduleView.ViewDefinitions>
                    <telerik:WeekViewDefinition/>
                    <telerik:DayViewDefinition />
                </telerik:RadScheduleView.ViewDefinitions>
            </telerik:RadScheduleView>
{{endregion}}

## See Also

 * [Implementing View-ViewModel ]({%slug radscheduleview-populating-with-data-implementing-view-model%})