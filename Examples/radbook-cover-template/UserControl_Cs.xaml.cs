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

#region radbook-cover-template_1
/// <summary>
 /// DataTemplateSelector responsible for picking template for the back cover page and every consecutive left page.
 /// </summary>
 public class LeftPageTemplateSelector : DataTemplateSelector
 {
  /// <summary>
  /// Gets or sets the back cover template.
  /// </summary>
  /// <value>The back cover template.</value>
  public DataTemplate BackCoverTemplate { get; set; }
  /// <summary>
  /// Gets or sets template for every left page in the book, except only in the case of a last page.
  /// </summary>
  /// <value>The left page template.</value>
  public DataTemplate LeftPageTemplate { get; set; }
  public override DataTemplate SelectTemplate(object item, DependencyObject container)
  {
   RadBookItem page = container as RadBookItem;
   // we need an instance of the book so that we can determine the whether the current page is the last page.
   RadBook book = System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(container) as RadBook;
   // Using the index property, we can determine whether the page is last page or it is one of the inner left pages.
   if (page.Index == book.Items.Count - 1)
   {
    return this.BackCoverTemplate;
   }
   else
   {
    return this.LeftPageTemplate;
   }
  }
 }
 /// <summary>
 /// DataTemplateSelector responsible for picking template for the fron cover page and every consecutive right page.
 /// </summary>
 public class RightPageTemplateSelector : DataTemplateSelector
 {
  /// <summary>
  /// Gets or sets the front cover template.
  /// </summary>
  /// <value>The front cover template.</value>
  public DataTemplate FrontCoverTemplate { get; set; }
  /// <summary>
  /// Gets or sets template for every right page in the book, except only in the case of a first page.
  /// </summary>
  /// <value>The right page template.</value>
  public DataTemplate RightPageTemplate { get; set; }
  public override DataTemplate SelectTemplate(object item, DependencyObject container)
  {
   RadBookItem page = container as RadBookItem;
   // Using the index property, we can determine whether the page is first page or it is one of the inner right pages.
   if (page.Index == 0)
   {
    return this.FrontCoverTemplate;
   }
   else
   {
    return this.RightPageTemplate;
   }
  }
 }
#endregion

#region radbook-cover-template_4
public partial class MainPage : UserControl
 {
  public MainPage()
  {
   InitializeComponent();
   book1.ItemsSource = Enumerable.Range(0, 10);
  }
 }
#endregion
}
