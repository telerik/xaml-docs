---
title: Implementing Load on Demand in RadTreeListView
description: Learn how to improve the performance in RadTreeListView by loading data one level at a time on row expanded.
type: how-to
page_title: Enable Children Load on Demand on Expand of RadTreeListView Row
slug: kb-treelistview-load-on-demand
tags: radtreelistview, wpf, load-on-demand, performance
res_type: kb
ticketid: 1681805
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadTreeListView for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2025.1.211</td>
</tr>
</tbody>
</table>

## Description

How to implement load on demand behavior in RadTreeListView where the child items of each row are loaded only when the row gets expanded.

## Solution

To implement load on demand, you can populate the children collection of each row only when the row gets expanded. To data bind the expand state of the parent rows, you can use the [IsExpandedBinding and IsExpandableBinding]({%slug radtreelsitview-how-to-control-expand-settings%}) properties of RadTreeListView.

The row model implementation:

```csharp
	public class RowInfo : ViewModelBase
	{
		private static int itemsCounter = 0;
		private static Random rnd = new Random(0);
		private bool hasChildren;
		private bool isExpanded;
		private ObservableCollection<RowInfo> children;
		public BackgroundWorker itemsLoadingWorker;
		
		public event EventHandler ItemsLoaded;

		public int Id { get; set; }

		public string Name { get; set; }

		public bool HasChildren
		{
			get { return hasChildren; }
			set
			{ 
				hasChildren = value;
				OnPropertyChanged(nameof(HasChildren));
			}
		}

		public bool IsExpanded
		{
			get { return isExpanded; }
			set 
			{ 
				isExpanded = value; 
				OnPropertyChanged(nameof(IsExpanded));

				if (hasChildren && children == null && isExpanded)
				{
					itemsLoadingWorker.RunWorkerAsync();
				}
			}
		}

		public ObservableCollection<RowInfo> Children
		{
			get { return children; }
			private set
			{
				children = value;
				OnPropertyChanged(nameof(Children));
			}
		}

		public RowInfo()
		{
			Id = itemsCounter++;
			itemsLoadingWorker = new BackgroundWorker();
			itemsLoadingWorker.DoWork += ItemsLoadingWorker_DoWork;
		}

		private void ItemsLoadingWorker_DoWork(object? sender, DoWorkEventArgs e)
		{
			Thread.Sleep(2000);
			App.Current.Dispatcher.BeginInvoke(new Action(() =>
			{
				Children = GetChildren();
				ItemsLoaded?.Invoke(this, EventArgs.Empty);
			}));
		}

		private static ObservableCollection<RowInfo> GetChildren()
		{
			var result = new ObservableCollection<RowInfo>();
			for (int i = 0; i < 5; i++)
			{
				result.Add(new RowInfo() { Name = Guid.NewGuid().ToString(), HasChildren = (rnd.Next(0, 100) % 2 == 0) });
			}
			return result;
		}
	}
```

The view model implementation:

```csharp
	public class MainViewModel : ViewModelBase
	{
		private bool isLoadingItems;

		public DelegateCommand RowExpandStateChangeCommand { get; set; }
		public ObservableCollection<RowInfo> Items { get; set; }

		public bool IsLoadingItems
		{
			get { return isLoadingItems; }
			set { isLoadingItems = value; OnPropertyChanged(nameof(IsLoadingItems)); }
		}

		public MainViewModel()
		{
			RowExpandStateChangeCommand = new DelegateCommand(OnRowExpandStateChanged);
			Items = new ObservableCollection<RowInfo>();
			var rnd = new Random(0);
			for (int i = 0; i < 100; i++)
			{
				Items.Add(new RowInfo() { Name = Guid.NewGuid().ToString(), HasChildren = (rnd.Next(0, 100) % 2 == 0) });
			}
		}

		private void OnRowExpandStateChanged(object obj)
		{
			IsLoadingItems = true;

			var args = (RowEventArgs)obj;
			var dataItem = (RowInfo)args.Row.Item;
			dataItem.ItemsLoaded += DataItem_ItemsLoaded;
		}

		private void DataItem_ItemsLoaded(object? sender, EventArgs e)
		{
			IsLoadingItems = false;
			var dataItem = (RowInfo)sender;
			dataItem.ItemsLoaded -= DataItem_ItemsLoaded;
		}
	}
```

The XAML definition:

```xaml
	 <telerik:RadTreeListView x:Name="treelistview" ItemsSource="{Binding Items}"
							  IsExpandableBinding="{Binding HasChildren}"
							  IsExpandedBinding="{Binding IsExpanded, Mode=TwoWay}"
							  IsBusy="{Binding IsLoadingItems}"
							  AutoGenerateColumns="False">
		 <telerik:EventToCommandBehavior.EventBindings>
			 <telerik:EventBinding EventName="RowIsExpandedChanging"
								   Command="{Binding RowExpandStateChangeCommand}"
								   PassEventArgsToCommand="True" />
		 </telerik:EventToCommandBehavior.EventBindings>
		 <telerik:RadTreeListView.ChildTableDefinitions>
			 <telerik:TreeListViewTableDefinition ItemsSource="{Binding Children}" />
		 </telerik:RadTreeListView.ChildTableDefinitions>
		 <telerik:RadTreeListView.Columns>
			 <telerik:GridViewDataColumn DataMemberBinding="{Binding Id}" />
			 <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" />
		 </telerik:RadTreeListView.Columns>
	 </telerik:RadTreeListView>
```

Setting the DataContext of RadTreeListView

```csharp
   	 public MainWindow()
	 {		 
		 InitializeComponent();       
		 this.treelistview.DataContext = new MainViewModel();
	 }
```

