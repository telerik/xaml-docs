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
		#region radtileview-howto-change-headers-background_5
		public class ItemViewModel : ViewModelBase
		{
			private readonly SolidColorBrush maximizedHeaderBackground;
			private readonly SolidColorBrush minimizedHeaderBackground;
			private readonly SolidColorBrush restoredHeaderBackground;
			private SolidColorBrush headerColor;
			private TileViewItemState currentState = TileViewItemState.Minimized;

			public ItemViewModel(SolidColorBrush maximizedHeaderBackground, SolidColorBrush restoredHeaderBackground, SolidColorBrush minimizedHeaderBackground)
			{
				this.maximizedHeaderBackground = maximizedHeaderBackground;
				this.restoredHeaderBackground = restoredHeaderBackground;
				this.minimizedHeaderBackground = minimizedHeaderBackground;

				this.SetColor();
			}

			public string Header { get; set; }

			public SolidColorBrush HeaderColor
			{
				get
				{
					return this.headerColor;
				}
				set
				{
					if (this.headerColor != value)
					{
						this.headerColor = value;
						this.OnPropertyChanged("HeaderColor");
					}
				}
			}

			public TileViewItemState CurrentState
			{
				get
				{
					return this.currentState;
				}
				set
				{
					if (this.currentState != value)
					{
						this.currentState = value;
						this.OnPropertyChanged("CurrentState");
						this.SetColor();
					}
				}
			}

			private void SetColor()
			{
				if (this.CurrentState == TileViewItemState.Maximized)
				{
					this.HeaderColor = this.maximizedHeaderBackground;
				}
				else if (this.CurrentState == TileViewItemState.Minimized)
				{
					this.HeaderColor = this.minimizedHeaderBackground;
				}
				else if (this.CurrentState == TileViewItemState.Restored)
				{
					this.HeaderColor = this.restoredHeaderBackground;
				}
			}
		}
		#endregion

		#region radtileview-howto-change-headers-background_7
		public class MainViewModel
		{
			public MainViewModel()
			{
				this.Items = new ObservableCollection<ItemViewModel>();
				this.GenerateItems();
			}

			public ObservableCollection<ItemViewModel> Items { get; set; }

			private void GenerateItems()
			{
				var blue = new SolidColorBrush(Colors.Blue);
				var green = new SolidColorBrush(Colors.Green);
				var purple = new SolidColorBrush(Colors.Purple);

				this.Items.Add(new ItemViewModel(blue, green, purple)
				{
					Header = "Item 1",
					CurrentState = TileViewItemState.Maximized,
				});
				this.Items.Add(new ItemViewModel(blue, green, purple)
				{
					Header = "Item 2",
				});
				this.Items.Add(new ItemViewModel(blue, green, purple)
				{
					Header = "Item 3",
				});
				this.Items.Add(new ItemViewModel(blue, green, purple)
				{
					Header = "Item 4",
				});
				this.Items.Add(new ItemViewModel(blue, green, purple)
				{
					Header = "Item 5",
				});
			}
		}
		#endregion

		#region radtileview-howto-change-headers-background_9
		this.DataContext = new MainViewModel();
		#endregion
	}
}
