using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		#region radtreeview-features-command-support_0
		public class ItemModel : ViewModelBase
		{
			private bool inInEditMode;
			public bool IsInEditMode
			{
				get
				{
					return this.inInEditMode;
				}
				set
				{
					if (this.inInEditMode != value)
					{
						this.inInEditMode = value;
						this.OnPropertyChanged("IsInEditMode");
					}
				}
			}

			private string header;
			public string Header
			{
				get
				{
					return this.header;
				}
				set
				{
					if (this.header != value)
					{
						this.header = value;
						this.OnPropertyChanged("Header");
					}
				}
			}

			public DelegateCommand EditCommand { get; set; }

			public ObservableCollection<ItemModel> Children { get; set; }
		}
		#endregion

		#region radtreeview-features-command-support_2
		public class ViewModel
		{
			public ViewModel()
			{
				this.Items = new ObservableCollection<ItemModel>();
				this.GenerateItems();
			}

			public ObservableCollection<ItemModel> Items { get; set; }

			private void GenerateItems()
			{
				ObservableCollection<ItemModel> children;
				for (byte j = 1; j < 5; j++)
				{
					children = new ObservableCollection<ItemModel>();
					for (byte i = 1; i < 4; i++)
					{
						children.Add(new ItemModel()
						{
							Header = string.Format("Child {0} of root {1}", i, j),
							EditCommand = new DelegateCommand((x) => this.OnEditCommandExecute(x))
						});
					}
					this.Items.Add(new ItemModel()
					{
						Header = string.Format("Root Item {0}", j),
						Children = children,
						EditCommand = new DelegateCommand((x) => this.OnEditCommandExecute(x))
					});
				}
			}

			private void OnEditCommandExecute(object sender)
			{
				var item = sender as ItemModel;
				if (item != null)
				{
					item.IsInEditMode = true;
				}
			}
		}
		#endregion
	}
}
