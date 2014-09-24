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

#region radtabcontrol-how-to-add-close-button-to-the-tab-headers_0
public class RoutedEventHelper
{
    //Create the routed event:
    public static readonly RoutedEvent CloseTabEvent = EventManager.RegisterRoutedEvent(
        "CloseTab",
        RoutingStrategy.Bubble,
        typeof(RoutedEventHandler),
        typeof(RoutedEventHelper));
    //Add an attached property:
    public static bool GetEnableRoutedClick(DependencyObject obj)
    {
        return (bool)obj.GetValue(EnableRoutedClickProperty);
    }
    public static void SetEnableRoutedClick(DependencyObject obj, bool value)
    {
        obj.SetValue(EnableRoutedClickProperty, value);
    }
    // Using a DependencyProperty as the backing store for EnableRoutedClick.
    // This enables animation, styling, binding, etc...
    public static readonly DependencyProperty EnableRoutedClickProperty = DependencyProperty.RegisterAttached(
        "EnableRoutedClick",
        typeof(bool),
        typeof(RoutedEventHelper),
        new System.Windows.PropertyMetadata(OnEnableRoutedClickChanged));
    private static void OnEnableRoutedClickChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
    {
        var newValue = (bool)e.NewValue;
        var button = sender as Button;
        if (button == null)
            return;
        if (newValue)
            button.Click += new RoutedEventHandler(OnButtonClick);
    }
    static void OnButtonClick(object sender, RoutedEventArgs e)
    {
        var control = sender as Control;
        if (control != null)
        {
            control.RaiseEvent(new RadRoutedEventArgs(RoutedEventHelper.CloseTabEvent, control));
        }
    }
}
#endregion

#region radtabcontrol-how-to-add-close-button-to-the-tab-headers_3
public partial class MainPage : UserControl
{
    ObservableCollection<TabItemModel> tabItemsModel = new ObservableCollection<TabItemModel>();
    public MainPage()
    {
        InitializeComponent();
        this.CreateTabItems();
        EventManager.RegisterClassHandler( typeof(RadTabItem), RoutedEventHelper.CloseTabEvent, new RoutedEventHandler(OnCloseClicked));
    }
    public void OnCloseClicked(object sender, RoutedEventArgs e)
    {
        var tabItem = sender as RadTabItem;
        // Remove the item from the collection the control is bound to
        tabItemsModel.Remove(tabItem.DataContext as TabItemModel);
    }
    private void CreateTabItems()
    {
        // Create items:
        for (int num = 0; num < 5; num++)
        {
            tabItemsModel.Add(new TabItemModel()
            {
                Title = String.Format("Item {0}", num),
                Content = String.Format("Item Content {0}", num)
            });
        }
        // Attach the items:
        tabControl.ItemsSource = tabItemsModel;
    }
}
public class TabItemModel
{
    public String Title
    {
        get;
        set;
    }
    public String Content
    {
        get;
        set;
    }
}
#endregion
}
