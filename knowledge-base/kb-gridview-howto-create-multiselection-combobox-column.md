---
title: Create Multi-Select GridViewComboBoxColumn
description: How to add a column with a RadComboBox editor which supports multiple selection.
type: howto
page_title: Multiselection ComboBox column for RadGridView
slug: kb-gridview-howto-create-multiselection-combobox-column
position: 0
tags: combobox,allowmultipleselection,editor
ticketid: 1410245
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

Create a column with a RadComboBox editor which supports multiple selection. 

## Solution

__1.__ First, we are going to create some sample objects with which to populate the RadGridView. The grid will be populated with a collection of Pilot objects and the RadComboBox will contain Country objects.


```C#
	public class MyViewModel : ViewModelBase
    {
        private ObservableCollection<Pilot> pilots;

        public ObservableCollection<Pilot> Pilots
        {
            get
            {
                if (this.pilots == null)
                {
                    this.pilots = Pilot.GetPilots();
                }

                return this.pilots;
            }
        }
    }

    public class Country : ViewModelBase
    {
        private string name;

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

        public Country(string name)
        {
            this.name = name;
        }

        public static ObservableCollection<Country> GetCountries()
        {
            ObservableCollection<Country> countries = new ObservableCollection<Country>();
           
            countries.Add(new Country("Germany"));
            countries.Add(new Country("Spain"));
            countries.Add(new Country("UK"));

            return countries;
        }
    }

    public class Pilot : ViewModelBase
    {
        private string firstName;
        private string lastName;
        private ObservableCollection<Country> selectedCountries = new ObservableCollection<Country>();

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value != this.firstName)
                {
                    this.firstName = value;
                    this.OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value != this.lastName)
                {
                    this.lastName = value;
                    this.OnPropertyChanged("LastName");
                }
            }
        }
        
        public ObservableCollection<Country> SelectedCountries
        {
            get
            {
                return this.selectedCountries;
            }

            set
            {
                if(this.selectedCountries != value)
                {
                    this.selectedCountries = value;
                    this.OnPropertyChanged("SelectedCountries");
                }
            }
        }

        public Pilot()
        {
            
        }

        public Pilot(string firstName, string lastName) : this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public static ObservableCollection<Pilot> GetPilots()
        {
            ObservableCollection<Pilot> pilots = new ObservableCollection<Pilot>();
          
            pilots.Add(new Pilot("Sebastian", "Vettel"));
            pilots.Add(new Pilot("Fernando", "Alonso"));
            pilots.Add(new Pilot("James", "Button"));

            return pilots;
        }
    }
```

__2.__ Next, we will implement our custom column. We will inherit [GridViewDataColumn]({%slug radgridview-columns-column-types-data-column%}) and override the __CreateCellElement__ and __CreateCellEditElement__ methods. Those are responsible for creating the TextBlock visible in view mode and the RadComboBox editor. We also define two custom properties which will be transferred to the RadComboBox when it is created. 


```C#
    public class MultiSelectionGridViewComboBoxColumn : GridViewDataColumn
    {
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource",
                typeof(IEnumerable),
                typeof(MultiSelectionGridViewComboBoxColumn),
                null);
       
        public static readonly DependencyProperty DisplayMemberPathProperty =
            DependencyProperty.Register("DisplayMemberPath",
                typeof(string),
                typeof(MultiSelectionGridViewComboBoxColumn),
                new PropertyMetadata(string.Empty));

      
        public IEnumerable ItemsSource
        {
            get
            {
                return (IEnumerable)this.GetValue(ItemsSourceProperty);
            }
            set
            {
                this.SetValue(ItemsSourceProperty, value);
            }
        }
       
        public string DisplayMemberPath
        {
            get
            {
                return (string)this.GetValue(DisplayMemberPathProperty);
            }
            set
            {
                this.SetValue(DisplayMemberPathProperty, value);
            }
        }

        public override FrameworkElement CreateCellElement(GridViewCell cell, object dataItem)
        {
            var displayTextBlock = new TextBlock();

            var items = base.GetCellContent(dataItem) as IList<Country>;

            if (items != null && items.Count != 0)
            {
                displayTextBlock.Text = items.Select(country => country.Name).Aggregate((head, next) => string.Format("{0}{1} {2}", head, ',', next));
            }

            return displayTextBlock;
        }

        public override FrameworkElement CreateCellEditElement(GridViewCell cell, object dataItem)
        {
            var comboBox = new RadComboBox() { AllowMultipleSelection = true };
            this.InitializeEditorProperties(comboBox);

            if (this.DataMemberBinding != null)
            {
                var items = base.GetCellContent(dataItem) as IList;

                if (items != null)
                {
                    var selectionChanged = new SelectionChangedEventHandler((s, e) =>
                    {
                        if (e.AddedItems != null && e.AddedItems.Count != 0 && !items.Contains(e.AddedItems[0]))
                        {
                            items.Add(e.AddedItems[0]);
                        }
                        else if (e.RemovedItems != null && e.RemovedItems.Count != 0)
                        {
                            items.Remove(e.RemovedItems[0]);
                        }
                    });

                    comboBox.SelectionChanged += selectionChanged;

                    comboBox.Unloaded += (s, e) =>
                    {
                        comboBox.SelectionChanged -= selectionChanged;
                    };

                    if (items.Count > 0)
                    {
                        foreach (var item in items)
                        {
                            comboBox.SelectedItems.Add(item);
                        }
                    }
                }
            }

            return comboBox;
        }

        private void InitializeEditorProperties(RadComboBox comboBox)
        {
            comboBox.DisplayMemberPath = this.DisplayMemberPath;
            comboBox.ItemsSource = this.ItemsSource;
        }
    }
```

__3.__ Finally, we need to define our custom column and set the ItemsSource property to a collection which will be transferred to the RadComboBox.

 
```XAML
    <telerik:RadGridView x:Name="pilotsGrid"
                         ItemsSource="{Binding Pilots}"
                         AutoGenerateColumns="False">
        <telerik:RadGridView.Columns>
            <local:MultiSelectionGridViewComboBoxColumn DataMemberBinding="{Binding SelectedCountries}" DisplayMemberPath="Name" UniqueName="Country" Header="Countries" />
            <telerik:GridViewDataColumn DataMemberBinding="{Binding FirstName}"/>
            <telerik:GridViewDataColumn DataMemberBinding="{Binding LastName}"/>
        </telerik:RadGridView.Columns>
    </telerik:RadGridView>
```

 
```C#
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MyViewModel();
            ((MultiSelectionGridViewComboBoxColumn)this.pilotsGrid.Columns["Country"]).ItemsSource = Country.GetCountries();
        }
    }
```

#### __Figure 1: Result after selecting some countries in the Office2016 theme__
![GridView with multi selection combobox column](images/kb-gridview-multiselection-combobox-column.png)

## See Also

* [ComboBox Column]({%slug radgridview-columns-column-types-combobox-column%})
