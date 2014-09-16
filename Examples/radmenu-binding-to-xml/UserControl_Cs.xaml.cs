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

#region radmenu-binding-to-xml_1
using System;
using System.Windows;
using System.Collections.Generic;
using Telerik.Windows.Controls;
using System.IO;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
public class RadMenuXMLDataSource : List<RadMenuItem>
{
 private String source;
 public RadMenuXMLDataSource() {}
 public String Source
 {
  get { return this.source; }
  set
  {
   this.source = value;
   // load the xml file and pass it to the ParseData method, that will do all the parsing
   this.AddRange(ParseData(Application.GetResourceStream(new Uri(this.source, UriKind.Relative)).Stream));
  }
 }
 private IEnumerable<RadMenuItem> ParseData(Stream xmlStream)
 {
  XmlReader reader = XmlReader.Create(xmlStream);
  XDocument xml = XDocument.Load(reader);
  var items = from node in xml.Descendants("Item")
     where node.Parent == xml.Root
     select new RadMenuItem
     {
      Header = (string)node.Attribute("Text").Value,
      ItemsSource = GetDescendants(node)
     };
  return items as IEnumerable<RadMenuItem>;
 }
 // Recursive method that is used if an item has sub-items
 private IEnumerable<RadMenuItem> GetDescendants(XElement node)
 {
  return  from item in node.Descendants("Item")
   where item.Parent.Attribute("Text").Value == node.Attribute("Text").Value
   select new RadMenuItem
   {
    Header = (string)item.Attribute("Text").Value,
    ItemsSource = GetDescendants(item)
   };
 }
#endregion
}
