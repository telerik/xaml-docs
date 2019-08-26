---
title: VirtualizingWrapPanel
page_title: VirtualizingWrapPanel
description: This article will describe the VirtualizingWrapPanel and how it can be used as an ItemsPanel for a RadListBox
slug: radlistbox-features-virtualizingwrappanel
tags: virtualizingwrappanel, itemspanel, listbox
published: True
position: 4
---

# VirtualizingWrapPanel

This article will describe the [VirtualizingWrapPanel](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.virtualizingwrappanel) and how it can be used as an ItemsPanel for a RadListBox.

## VirtualizingWrapPanel

In order to demonstrate how the VirtualizingWrapPanel can be used, we will setup some sample data as demonstrated in __Example 1__.

#### __[C#] Example 1: Setting up the model and viewmodel__

{{region cs-radlistbox-features-virtualizingwrappanel-0}}
	public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class ViewModel : ViewModelBase
    {
        private ObservableCollection<Customer> customers;
        private ICollectionView customersView;

        public ViewModel()
        {
            this.Customers = new ObservableCollection<Customer>()
			{
				new Customer { Id = 1, Name = "Customer 1" },
				new Customer { Id = 2, Name = "Customer 2" },
				new Customer { Id = 3, Name = "Customer 3" },
				new Customer { Id = 4, Name = "Customer 4" },
				new Customer { Id = 5, Name = "Customer 5" } 
			};

            // This will be needed in order to group the data
            var customersView = CollectionViewSource.GetDefaultView(this.Customers);
            customersView.GroupDescriptions.Add(new PropertyGroupDescription("Name"));
            this.CustomersView = customersView;
        }

        public ObservableCollection<Customer> Customers
        {
            get { return this.customers; }
            set
            {
                if (this.customers != value)
                {
                    this.customers = value;
                    this.OnPropertyChanged(() => this.Customers);
                }
            }
        }

        public ICollectionView CustomersView
        {
            get
            {
                return this.customersView;
            }
            set
            {
                if(this.customersView != value)
                {
                    this.customersView = value;
                    this.OnPropertyChanged(() => this.CustomersView);
                }
            }
        }
    }
{{endregion}}

#### __[VB.NET] Example 1: Setting up the model and viewmodel__

{{region cs-radlistbox-features-virtualizingwrappanel-0}}
	Public Class Customer
		Public Property Name() As String
		Public Property Id() As Integer
    End Class

    Public Class ViewModel
	Inherits ViewModelBase

		Private _customers As ObservableCollection(Of Customer)
		Private _customersView As ICollectionView

		Public Sub New()
			Me.Customers = New ObservableCollection(Of Customer)() From {
				New Customer With {
					.Id = 1,
					.Name = "Customer 1"
				},
				New Customer With {
					.Id = 2,
					.Name = "Customer 2"
				},
				New Customer With {
					.Id = 3,
					.Name = "Customer 3"
				},
				New Customer With {
					.Id = 4,
					.Name = "Customer 4"
				},
				New Customer With {
					.Id = 5,
					.Name = "Customer 5"
				}
			}
            
            'This will be needed in order to group the data
			Dim _customersView = CollectionViewSource.GetDefaultView(Me.Customers)
			_customersView.GroupDescriptions.Add(New PropertyGroupDescription("Name"))
			Me.CustomersView = _customersView
		End Sub

		Public Property Customers() As ObservableCollection(Of Customer)
			Get
				Return Me._customers
			End Get
			Set(ByVal value As ObservableCollection(Of Customer))
				If Me._customers IsNot value Then
					Me._customers = value
					Me.OnPropertyChanged(Function() Me.Customers)
				End If
			End Set
		End Property

		Public Property CustomersView() As ICollectionView
			Get
				Return Me._customersView
			End Get
			Set(ByVal value As ICollectionView)
				If Me._customersView IsNot value Then
					Me._customersView = value
					Me.OnPropertyChanged(Function() Me.CustomersView)
				End If
			End Set
		End Property
    End Class
{{endregion}}

## Setting up the RadListBox

__Example 2__ demonstrates how the VirtualizingWrapPanel can be used as an ItemsPanel for a __RadListBox__. You can read some more about the benefits of UI Virtualization in the following [article](https://docs.microsoft.com/en-us/dotnet/framework/wpf/advanced/optimizing-performance-controls#displaying-large-data-sets).

#### __[XAML] Example 2: RadListBox with VirtualizingWrapPanel as ItemsPanel__
{{region xaml-radlistbox-features-virtualizingwrappanel-3}}
	<UserControl>
		<UserControl.Resources>
			<local:ViewModel x:Key="ViewModel" />
		</UserControl.Resources>
		<Grid DataContext="{StaticResource ViewModel}">
			<telerik:RadListBox ItemsSource="{Binding CustomersView}" 
								DisplayMemberPath="Name"
								AllowDrop="True">
				<telerik:RadListBox.ItemContainerStyle>
					<!-- If you are using the NoXaml binaries, you will have to base the style on the default one for the theme like so: 
					<Style TargetType="telerik:RadListBoxItem" BasedOn="{StaticResource RadListBoxItemStyle}">-->

					<Style TargetType="telerik:RadListBoxItem">
						<Setter Property="Background" Value="Red" />
					</Style>
				</telerik:RadListBox.ItemContainerStyle>
				<telerik:RadListBox.ItemsPanel>
					<ItemsPanelTemplate>
						<telerik:VirtualizingWrapPanel  />
					</ItemsPanelTemplate>
				</telerik:RadListBox.ItemsPanel>
			</telerik:RadListBox>
		</Grid>
	</UserControl>	
{{endregion}}

#### __Figure 1: Result from Example 2 in the Office2016 theme__
![RadListBox with VirtualizingWrapPanel as ItemsPanel](images/radlistbox_features_virtualizingwrappanel.gif)

## Grouping

__Example 3__ demonstrates how you can apply grouping to the data by setting the __GroupStyle__ property. Otherwise, the example uses the same setup as __Example 2__.

#### __[XAML] Example 3: Grouped RadListBox with VirtualizingWrapPanel as ItemsPanel__
{{region xaml-radlistbox-features-virtualizingwrappanel-3}}
	<telerik:RadListBox.GroupStyle>
		<GroupStyle>
			<GroupStyle.HeaderTemplate>
				<DataTemplate>
					<TextBlock Text="{Binding Name}" Background="Green" />
				</DataTemplate>
			</GroupStyle.HeaderTemplate>
		</GroupStyle>
	</telerik:RadListBox.GroupStyle>
{{endregion}}

Since the __R3 2019__ version of __UI for WPF__ the VirtualizingWrapPanel supports virtualization when the data is grouped. This feature is only available for **.Net 4.5** and above. In order to turn on UI Virtualization for the grouped data, you have to set the **VirtualizingPanel.IsVirtualizingWhenGrouping** property to **True**. Additionally, you have to set the **VirtualizingPanel.ScrollUnit** to **Pixel**, since **VirtualizingPanel.ScrollUnit="Item"** is not supported. 

#### __[XAML] Example 4: Turning on virtualization while grouping__
{{region xaml-radlistbox-features-virtualizingwrappanel-4}}
	<telerik:RadListBox VirtualizingPanel.ScrollUnit="Pixel"
						VirtualizingPanel.IsVirtualizingWhenGrouping="True">
{{endregion}}

## See Also

* [Binding To Object]({%slug radlistbox-populating-with-data-binding-to-object%})