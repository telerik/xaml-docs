#region radhtmlplaceholder-howto-displayhtml_1
using System.Windows;
using System.Windows.Controls;
namespace RadHtmlPlaceholderDemo
{
	public partial class Page : UserControl
	{
		public Page()
		{
			InitializeComponent();
			Loaded += new RoutedEventHandler(Page_Loaded);
		}
		void Page_Loaded(object sender, RoutedEventArgs e)
		{
			RadHtmlPlaceholder1.HtmlSource = @"You can display <b>any</b> <span style=""color:#FF0000;"">valid</span>
<i>html</i> content.<br/>It will be displayed as part of the <a href=""http://silverlight.net"" 
target=""_blank"">Silverlight</a> page<br/> and will be rendered by the browser.";
		}
	}
}
#endregion
