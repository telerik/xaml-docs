using System;
using RadControlsSilverlightApp2.ViewModel;

namespace RadControlsSilverlightApp2
{
	public partial class MainPage : System.Windows.Controls.UserControl
	{
		public MainPage()
		{
			InitializeComponent();
			this.DataContext = new MainViewModel();
		}
	}

	#region radtabcontrol-how-to-add-close-button-mvvm-0
	public class MainViewModel
	{
		public MainViewModel()
		{
			this.Tabs = new ObservableCollection<TabViewModel>();
			this.AddItem(null);
		}

		/// <summary>
		/// Gets the collection of tabs.
		/// </summary>
		public ObservableCollection<TabViewModel> Tabs
		{
			get;
			private set;
		}

		/// <summary>
		/// Adds new tab item to the Tabs collection.
		/// </summary>
		public void AddItem(TabViewModel sender)
		{
			TabViewModel newTabItem = new TabViewModel(this);
			newTabItem.Header = "New Tab";
			newTabItem.IsSelected = true;
			if (sender != null)
			{
				int insertIndex = this.Tabs.IndexOf(sender) + 1;
				this.Tabs.Insert(insertIndex, newTabItem);
			}
			else
			{
				this.Tabs.Add(newTabItem);
			}
		}

		/// <summary>
		/// Removes an item from the Tabs collection.
		/// </summary>
		/// <param name="tabItem">The tab item.</param>
		public void RemoveItem(TabViewModel tabItem)
		{
			this.Tabs.Remove(tabItem);
			tabItem.Dispose();
		}
	}
	#endregion

	#region radtabcontrol-how-to-add-close-button-mvvm-1
	public class TabViewModel : INotifyPropertyChanged, IDisposable
	{
		private bool isSelected;
		private readonly MainViewModel mainViewModel;

		public TabViewModel(MainViewModel mainViewModel)
		{
			this.mainViewModel = mainViewModel;
			this.mainViewModel.Tabs.CollectionChanged += this.Tabs_CollectionChanged;

			this.AddItemCommand = new DelegateCommand(
				delegate
				{
					this.mainViewModel.AddItem(this);
				},
				delegate
				{
					return this.mainViewModel.Tabs.Count < 5;
				});

			this.RemoveItemCommand = new DelegateCommand(
				delegate
				{
					this.mainViewModel.RemoveItem(this);
				},
				delegate
				{
					return this.mainViewModel.Tabs.Count > 1;
				});
		}

		public void Dispose()
		{
			this.mainViewModel.Tabs.CollectionChanged -= this.Tabs_CollectionChanged;
		}

		void Tabs_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.AddItemCommand.InvalidateCanExecute();
			this.RemoveItemCommand.InvalidateCanExecute();
		}

		public string Header
		{
			get;
			set;
		}

		public bool IsSelected
		{
			get
			{
				return this.isSelected;
			}
			set
			{
				if (this.isSelected != value)
				{
					this.isSelected = value;
					this.OnPropertyChanged("IsSelected");
				}
			}
		}

		public DelegateCommand AddItemCommand { get; set; }
		public DelegateCommand RemoveItemCommand { get; set; }

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		#endregion
	}
#endregion

}

