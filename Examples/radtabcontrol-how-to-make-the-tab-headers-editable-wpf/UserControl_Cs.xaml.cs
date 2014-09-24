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

#region radtabcontrol-how-to-make-the-tab-headers-editable-wpf_0
public class EditableTabHeaderControl : ContentControl
{
 static EditableTabHeaderControl()
 {
  DefaultStyleKeyProperty.OverrideMetadata(typeof(EditableTabHeaderControl), new FrameworkPropertyMetadata(typeof(EditableTabHeaderControl)));
 }
}
#endregion

#region radtabcontrol-how-to-make-the-tab-headers-editable-wpf_3
[TemplatePart(Name = "PART_EditArea", Type = typeof(TextBox))]
public class EditableTabHeaderControl : ContentControl
{
 static EditableTabHeaderControl()
 {
  DefaultStyleKeyProperty.OverrideMetadata(typeof(EditableTabHeaderControl), new FrameworkPropertyMetadata(typeof(EditableTabHeaderControl)));
 }
 private TextBox textBox;
 public static DependencyProperty IsInEditModeProperty =
  DependencyProperty.Register("IsInEditMode", typeof(Boolean), typeof(EditableTabHeaderControl));
 public bool IsInEditMode
 {
  get
  {
   return (bool)this.GetValue(IsInEditModeProperty);
  }
  set
  {
   this.SetValue(IsInEditModeProperty, value);
  }
 }
 public override void OnApplyTemplate()
 {
  base.OnApplyTemplate();
  this.textBox = this.Template.FindName("PART_EditArea", this) as TextBox;
  this.textBox.LostFocus += new RoutedEventHandler(textBox_LostFocus);
  this.MouseDoubleClick += new MouseButtonEventHandler(EditableTabHeaderControl_MouseDoubleClick);
 }
 private void textBox_LostFocus(object sender, RoutedEventArgs e)
 {
  this.IsInEditMode = false;
 }
 private void EditableTabHeaderControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
 {
  if (e.LeftButton == MouseButtonState.Pressed)
  {
   this.IsInEditMode = true;
  }
 }
}
#endregion

#region radtabcontrol-how-to-make-the-tab-headers-editable-wpf_6
public partial class MainWindow : Window
{
 public MainWindow()
 {
  InitializeComponent();
  radTabControl.ItemsSource = Enumerable.Range(1, 5).Select(num =>
  new TabItemModel()
  {
   Name = String.Format("Header {0}", num),
   Content = String.Format("Content {0}", num)
  });
 }
}
public class TabItemModel : ViewModelBase
{
 private String name;
 private String content;
 public String Name
 {
  get
  {
   return this.name;
  }
  set
  {
   if (this.name != value)
   {
    this.name = value;
    OnPropertyChanged("Name");
   }
  }
 }
 public String Content
 {
  get
  {
   return this.content;
  }
  set
  {
   if (this.content != value)
   {
    this.content = value;
    OnPropertyChanged("Content");
   }
  }
 }
}
#endregion
}
