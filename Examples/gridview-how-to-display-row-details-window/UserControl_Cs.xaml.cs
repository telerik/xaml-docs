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
	}

#region gridview-how-to-display-row-details-window_0
public MainPage()
{
     InitializeComponent();
     this.DataContext = new FootballViewModel();
     this.window = new RadWindow();
     this.window.Content = new DetailsPresenter() 
     { 
          // Link the external details presenter to our RadGridView.
          DetailsProvider = this.clubsGrid.RowDetailsProvider 
     };
     this.window.WindowStartupLocation = WindowStartupLocation.Manual;
     this.window.Header = "Players";
     this.window.ResizeMode = ResizeMode.NoResize;
     this.clubsGrid.RowDetailsProvider.PropertyChanged += this.OnRowDetailsProviderPropertyChanged;
}
#endregion

#region gridview-how-to-display-row-details-window_1
public interface IDetailsProvider : INotifyPropertyChanged 
{ 
     DataTemplate Template { get; } 
     Visibility Visibility { get; } 
     object DataContext { get; } 
     //Rest of the code is omitted
 }
#endregion

#region gridview-how-to-display-row-details-window_2
private void OnRowDetailsProviderPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
{
   if (e.PropertyName == "DataContext")
   {
      // This indicates that selection has changed in RadGridView.
      Club currentClub = this.clubsGrid.RowDetailsProvider.DataContext as Club;
      if (currentClub != null)
      {
           // A row is selected.
           var row = this.clubsGrid.ItemContainerGenerator.ContainerFromItem(currentClub) as GridViewRow;
           Point newLocation = this.CalculateWindowLocation(row);
           // Show the window next to the row on the right
           this.window.Left = newLocation.X;
           this.window.Top = newLocation.Y;
           this.window.Show();
      }
      else
      {
          // There is no selection.
          this.window.Hide();
      }
   }
}
#endregion
}
