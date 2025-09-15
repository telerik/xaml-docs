---
title: MVVM Support
page_title: MVVM Support
description: Check our &quot;MVVM Support&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-mvvm
tags: virtualgrid,mvvm
published: True
position: 1
---

# MVVM Support

This topic will go through the approach of using __RadVirtualGrid__ in MVVM scenarios. This can be achieved by benefiting from the __DataProvider__ mechanism of the control. More information on this matter can be found in the [Getting Started]({%slug virtualgrid-getting-started2%}) and [Custom DataProvider]({%slug virtualgrid-custom-dataprovider%}) topics.

## Defining the business model

Firstly, we need an object model that will be used to populate __RadVirtualGrid__ with data. For this purpose, the following __Club__ object is defined.

__Example 1: Defining the Club object__

```C#
	public class Club : ViewModelBase
    {
        private string name;
        private DateTime established;
        private int stadiumCapacity;
        private int primaryKey;

        public int PrimaryKey
        {
            get { return this.primaryKey; }
            set
            {
                this.primaryKey = value;
                this.OnPropertyChanged("PrimaryKey");
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        public DateTime Established
        {
            get { return this.established; }
            set
            {
                if (value != this.established)
                {
                    this.established = value;
                    this.OnPropertyChanged("Established");
                }
            }
        }

        public int StadiumCapacity
        {
            get { return this.stadiumCapacity; }
            set
            {
                if (value != this.stadiumCapacity)
                {
                    this.stadiumCapacity = value;
                    this.OnPropertyChanged("StadiumCapacity");
                }
            }
        }

        public Club()
        {

        }

        public Club(string name, DateTime established, int stadiumCapacity)
        {
            this.name = name;
            this.established = established;
            this.stadiumCapacity = stadiumCapacity;
        }

        public static ObservableCollection<Club> GetClubs()
        {
            ObservableCollection<Club> clubs = new ObservableCollection<Club>();
            Club club;
            
            club = new Club("Liverpool", new DateTime(1892, 1, 1), 45362) { PrimaryKey = 1};
            clubs.Add(club);

            club = new Club("Manchester Utd.", new DateTime(1878, 1, 1), 76212) {PrimaryKey = 2};
            clubs.Add(club);

            club = new Club("Chelsea", new DateTime(1905, 1, 1), 42055) { PrimaryKey = 3 };
            clubs.Add(club);

            club = new Club("Arsenal", new DateTime(1886, 1, 1), 60355) { PrimaryKey = 4 };
            clubs.Add(club);

            return clubs;
        }
    }
```

## Implementing a custom DataProvider

The next step is to define a custom __DataProvider__ that handles some specific scenarios. It demonstrates how the selection of the control can be persisted when sorting or filtering. Note, that by default the selection is being cleared when processing these operations. Also, the example demonstrates how to hide a given column, define a custom editor, set a given column to be readonly and apply a custom header.

__Example 2: Implementing a Custom DataProvider__

```C#
	public class MyDataProvider : DataProvider
	    {
	        private List<int> selectedIndexes;
	        public MyDataProvider(IEnumerable source) : base(source)
	        {
	            this.selectedIndexes = new List<int>();
	        }
	
	        //At this state the SelectedIndexes are not cleared yet and can be persisted.
	        protected override void SortDescriptorPrepared(SortedEventArgs e)
	        {
	            var selectedIndexes = this.ParentGrid.SelectedIndexes.ToList();
	            if (selectedIndexes.Count > 0)
	            {
	                this.PersistSelection(selectedIndexes);
	            }
	            base.SortDescriptorPrepared(e);
	        }
	
	        //Update the selection after the sorting is processed.
	        protected override void OnSortingCompleted()
	        {
	            base.OnSortingCompleted();
	            this.UpdateSelection(this.selectedIndexes);
	        }
	
	        //Hide the primary key property
	        public override IList<ItemPropertyInfo> ItemProperties
	        {
	            get
	            {
	                return base.ItemProperties.Skip(1).ToList();
	            }
	        }
	
	        protected override void OnHeaderValueNeeded(HeaderValueEventArgs e)
	        {
	            if (e.HeaderOrientation == VirtualGridOrientation.Horizontal)
	            {
	                int propertyIndex = this.GetPropertyIndex("Name");
	
	                if (e.Index == propertyIndex)
	                {
	                    e.Value = "Club Name";
	                }
	                else
	                {
	                    base.OnHeaderValueNeeded(e);
	                }
	            }
	        }
	
	        protected override void OnEditorNeeded(EditorNeededEventArgs args)
	        {
	            int propertyIndex = this.GetPropertyIndex("Established");
	            if (args.ColumnIndex == propertyIndex)
	            {
	                var editor = new RadDateTimePicker();
	                var item = (this.Source.GetItemAt(args.RowIndex) as Club);
	
	                args.Editor = editor;
	                editor.SelectedValue = item.Established;
	                args.EditorProperty = RadDateTimePicker.SelectedValueProperty;
	            }
	            else
	            {
	                base.OnEditorNeeded(args);
	            }
	            
	        }
	
	        protected override bool IsColumnReadOnly(int columnIndex)
	        {
	            int propertyIndex = this.GetPropertyIndex("Name");
	            if (columnIndex == propertyIndex)
	            {
	                return true;
	            }
	
	            return base.IsColumnReadOnly(columnIndex);
	        }
	
	        /// <summary>
	        /// Gets the index of a given property
	        /// </summary>
	        /// <param name="propertyName">The property name</param>
	        /// <returns>The property index</returns>
	        private int GetPropertyIndex(string propertyName)
	        {
	            ItemPropertyInfo itemProperty = this.ItemProperties.Where(ip => ip.Name == propertyName).FirstOrDefault();
	            int index = this.ItemProperties.IndexOf(itemProperty);
	
	            return index;
	        }
	
	        /// <summary>
	        /// Persists the selected indexes
	        /// </summary>
	        /// <param name="selectedIndexes"></param>
	        private void PersistSelection(IEnumerable<int> selectedIndexes)
	        {
	            foreach (int index in selectedIndexes)
	            {
	                this.selectedIndexes.Add(index);
	            }
	        }
	
	        /// <summary>
	        /// Adds the previously persisted indexes
	        /// </summary>
	        /// <param name="selectedIndexes"></param>
	        private void UpdateSelection(IEnumerable<int> selectedIndexes)
	        {
	            foreach (int index in selectedIndexes)
	            {
	                if (!this.ParentGrid.SelectedIndexes.Contains(index))
	                {
	                    this.ParentGrid.ToggleIndexSelection(index);
	                }
	            }
	        }
    }
```

## Defining the View Model

The following code snippet demonstrates how the custom DataProvider can be exposed by a view model.

__Example 2: Defining the View Model__

```C#
	public class MyViewModel: ViewModelBase
    {
        private MyDataProvider dataProvider;

        public MyDataProvider DataProvider 
        {
            get 
            {
                if (this.dataProvider == null)
                {
                    this.dataProvider = new MyDataProvider(Club.GetClubs());
                }

                return this.dataProvider;
            }
        }
    }
```

## Populate RadVirtualGrid

This section shows how the View Model can be set to be the DataContext of __RadVirtualGrid__ and how its __DataProvider__ property can be bound to the custom DataProvider.

__Example 3: Populating RadVirtualGrid__

```XAML
	<Window.Resources>
        <local:MyViewModel x:Key="MyViewModel"/>
    </Window.Resources>
    <Grid DataContext="{StaticResource MyViewModel}">
        <telerik:RadVirtualGrid DataProvider="{Binding DataProvider}" 
                                Margin="5" >
        </telerik:RadVirtualGrid>
    </Grid>
```

## See Also

* [Getting Started]({%slug virtualgrid-getting-started2%})
* [Custom DataProvider]({%slug virtualgrid-custom-dataprovider%})
* [Editing]({%slug virtualgrid-editing%})