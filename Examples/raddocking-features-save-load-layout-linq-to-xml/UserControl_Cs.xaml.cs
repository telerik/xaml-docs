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

    #region raddocking-features-save-load-layout-linq-to-xml_1
private XElement dockingLayout;

private void OnSaveLayoutButtonClick(object sender, RoutedEventArgs e)
{
    this.dockingLayout = this.GetXLayoutAsElement();
}

private XElement GetXLayoutAsElement()
{
    var destinationStream = new MemoryStream();
    this.radDocking.SaveLayout(destinationStream);
    destinationStream.Seek(0, SeekOrigin.Begin);

    return XElement.Load(destinationStream);
}
    #endregion

    #region raddocking-features-save-load-layout-linq-to-xml_2
private XElement dockingLayout;

private void OnLoadLayoutButtonClick(object sender, RoutedEventArgs e)
{
    MemoryStream sourceAsStream = new MemoryStream();
    this.dockingLayout.Save(sourceAsStream);
    sourceAsStream.Seek(0, SeekOrigin.Begin);
    this.radDocking.LoadLayout(sourceAsStream);
}
    #endregion
}
