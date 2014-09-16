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

#region radtileview-howto-use-fluidcontentcontrol-in-tileview_0
public class MyViewModel : INotifyPropertyChanged
{
 public MyViewModel()
 {
  this.SmallImage = new Uri("Images/SmallImage.png", UriKind.Relative);
  this.Image = new Uri("Images/Image.png", UriKind.Relative);
  this.LargeImage = new Uri("Images/LargeImage.png", UriKind.Relative);
 }
 public string Header { get; set; }
 public Uri SmallImage { get; set; }
 public Uri Image { get; set; }
 public Uri LargeImage { get; set; }
 private ContentState _contentState;
 /// <summary>
 ///     Gets or sets the name.
 /// </summary>
 public ContentState ContentState
 {
  get
  {
   return this._contentState;
  }
  set
  {
   if (this._contentState != value)
   {
    this._contentState= value;
    OnPropertyChanged("ContentState");
   }
  }
 }   
 /// <summary>
 ///     Event for INotifyPropertyChanged.
 /// </summary>
 public event PropertyChangedEventHandler PropertyChanged;
 /// <summary>
 ///     Raises the INotifyPropertyChanged event.
 /// </summary>
 /// <param name="propertyName">The property to be included in the INotifyPropertyChanged EventArgs.</param>
 protected virtual void OnPropertyChanged(String propertyName)
 {
  if (PropertyChanged != null)
  {
   PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
  }
 }
}
public enum ContentState
{
 SmallContent = 1,
 NormalContent = 0,
 LargeContent = 2
}
#endregion

#region radtileview-howto-use-fluidcontentcontrol-in-tileview_2
public static IList<object> GenerateItems()
{
 var result = new ObservableCollection<object>();
 foreach (var num in Enumerable.Range(1, 12))
 {
  result.Add(new MyViewModel() { Header = String.Format("Item {0}", num) });
 }
 return result;
}
#endregion

#region radtileview-howto-use-fluidcontentcontrol-in-tileview_6
public class FluidContentStateConverter : IValueConverter
{
 public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
 {
  var contentState = (ContentState)value;
  switch (contentState)
  {
   case ContentState.SmallContent:
    return FluidContentControlState.Small;
   case ContentState.NormalContent:
    return FluidContentControlState.Normal;
   case ContentState.LargeContent:
    return FluidContentControlState.Large;
   default:
    return FluidContentControlState.Normal;
  }
 }
 public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
 {
  var fluidState = (FluidContentControlState)value;
  switch (fluidState)
  {
   case FluidContentControlState.Small:
    return ContentState.SmallContent;
   case FluidContentControlState.Normal:
    return ContentState.NormalContent;
   case FluidContentControlState.Large:
    return ContentState.LargeContent;
   default:
    return ContentState.NormalContent;
  }
 }
}
#endregion

#region radtileview-howto-use-fluidcontentcontrol-in-tileview_10
public class TileStateConverter : IValueConverter
{
 #region IValueConverter Members
 public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
 {
  var contentState = (ContentState)value;
  switch (contentState)
  {
   case ContentState.SmallContent:
    return TileViewItemState.Minimized;
   case ContentState.NormalContent:
    return TileViewItemState.Restored;
   case ContentState.LargeContent:
    return TileViewItemState.Maximized;
   default:
    return TileViewItemState.Restored;
  }
 }
 public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
 {
  var tileState = (TileViewItemState)value;
  switch (tileState)
  {
   case TileViewItemState.Minimized:
    return ContentState.SmallContent;
   case TileViewItemState.Restored:
    return ContentState.NormalContent;
   case TileViewItemState.Maximized:
    return ContentState.LargeContent;
   default:
    return ContentState.NormalContent;
  }
 }
 #endregion
}
#endregion

#region radtileview-howto-use-fluidcontentcontrol-in-tileview_14
public partial class MainPage : UserControl
{
 public MainPage()
 {
  InitializeComponent();
  this.radTileView.ItemsSource = MyViewModel.GenerateItems();
 }
}
#endregion

#region radtileview-howto-use-fluidcontentcontrol-in-tileview_16
public partial class MainWindow : Window
{
 public MainWindow()
 {
  InitializeComponent();
  this.radTileView.ItemsSource = MyViewModel.GenerateItems();
 }
}
#endregion
}
