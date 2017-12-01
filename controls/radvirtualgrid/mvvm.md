---
title: MVVM Support
page_title: MVVM Support
description: MVVM Support
slug: virtualgrid-mvvm
tags: virtualgrid,mvvm
published: True
position: 1
---

# MVVM Support

This topic will go through the approach of using __RadVirtualGrid__ in an MVVM environment. This can be achieved by benefiting from the __DataProvider__ mechanism of the control. More information on this matter can be found in the [Getting Started]({%slug virtualgrid-getting-started2%}) and [Custom DataProvider]({%slug virtualgrid-custom-dataprovider%}) topics.

## Defining the business model

Firstly, we need an object model that will be used for further populating __RadVirtualGrid__ with data. For this purpose, the following __Club__ object is defined.

#### __[C#] Example 1: Defining the Club object__

{{region radvirtualgrid-mvvm_0}}
	public class Club : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return this.Name;
        }

        public static ObservableCollection<Club> GetClubs()
        {
            ObservableCollection<Club> clubs = new ObservableCollection<Club>();
            Club club;
            int id = 0;

            // Liverpool
            club = new Club("Liverpool", new DateTime(1892, 1, 1), 45362) { PrimaryKey = id};
            clubs.Add(club);

            id++;
            // Manchester Utd.
            club = new Club("Manchester Utd.", new DateTime(1878, 1, 1), 76212) {PrimaryKey = id};
            clubs.Add(club);

            id++;
            // Chelsea
            club = new Club("Chelsea", new DateTime(1905, 1, 1), 42055) { PrimaryKey = id };
            clubs.Add(club);

            id++;
            // Arsenal
            club = new Club("Arsenal", new DateTime(1886, 1, 1), 60355) { PrimaryKey = id };
            clubs.Add(club);

            return clubs;
        }
    }
{{endregion}}

## Implementing a custom DataProvider

Then, a custom __DataProvider__ that handles some specific scenarios will be defined. Speaking shortly, it demonstrates how the selection of the control can be persisted when sorting or filtering. Note, that by default it is being cleared when processing these operations. Also, hiding a given column, defining a custom editor, setting a given column to be readonly and applying a custom header is demonstrated.

#### __[C#] Example 2: Implementing a Custom DataProvider__

{{region radvirtualgrid-mvvm_1}}
	public class MyDataProvider : DataProvider
	    {
	        private List<int> selectedIndexes;
	        public MyDataProvider(IEnumerable source) : base(source)
	        {
	            this.selectedIndexes = new List<int>();
	        }
	
	        /// <summary>
	        /// At this state the SelectedIndexes are not cleared yet and can be persisted.
	        /// </summary>
	        /// <param name="e"></param>
	        protected override void SortDescriptorPrepared(SortedEventArgs e)
	        {
	            var selectedIndexes = this.ParentGrid.SelectedIndexes.ToList();
	            if (selectedIndexes.Count > 0)
	            {
	                this.PersistSelection(selectedIndexes);
	            }
	            base.SortDescriptorPrepared(e);
	        }
	
	        /// <summary>
	        /// Update the selection after the sorting is processed.
	        /// </summary>
	        protected override void OnSortingCompleted()
	        {
	            base.OnSortingCompleted();
	            this.UpdateSelection(this.selectedIndexes);
	        }
	
	        /// <summary>
	        /// Hide the primary key property
	        /// </summary>
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
{{endregion}}

## Defining the View Model

Furthermore, the custom DataProvider needs to be exposed by a view model.

#### __[C#] Example 2: Defining the View Model__

{{region radvirtualgrid-mvvm_1}}
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
{{endregion}}

## Populate RadVirtualGrid

Finally, the View Model is set to be the DataContext of __RadVirtualGrid__ and its __DataProvider__ property is bound to the custom DataProvider.

#### __[XAML] Example 3: Populating RadVirtualGrid__

{{region radvirtualgrid-mvvm_2}}
	<Window.Resources>
        <local:MyViewModel x:Key="MyViewModel"/>
    </Window.Resources>
    <Grid DataContext="{StaticResource MyViewModel}">
        <telerik:RadVirtualGrid DataProvider="{Binding DataProvider}" 
                                Margin="5" >
        </telerik:RadVirtualGrid>
    </Grid>
{{endregion}}

## See Also

* [Getting Started]({%slug virtualgrid-getting-started2%})

* [Custom DataProvider]({%slug virtualgrid-custom-dataprovider%})

* [Editing]({%slug virtualgrid-editing%})