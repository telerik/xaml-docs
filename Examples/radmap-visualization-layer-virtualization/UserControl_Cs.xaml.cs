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
}
#region radmap-visualization-layer-virtualization_0
public class MyVirtualizationSource : IMapItemsVirtualizationSource
{
	private XmlDocument document;

	public MyVirtualizationSource()
	{
		StreamResourceInfo streamInfo = Application.GetResourceStream(
			new Uri(
				"/TestMapFeatures;component/Resources/GeoData/StoresLocation.xml", 
				UriKind.Relative));

		this.document = new XmlDocument();
		this.document.Load(streamInfo.Stream);
	}

	public void MapItemsRequest(object sender, MapItemsRequestEventArgs eventArgs)
	{
		double minZoom = eventArgs.MinZoom;
		Location upperLeft = eventArgs.UpperLeft;
		Location lowerRight = eventArgs.LowerRight;

		if (this.document == null)
			return;

		if (minZoom == 3)
		{
			// request areas
			List<StoreLocation> list = this.GetStores(
				upperLeft.Latitude,
				upperLeft.Longitude,
				lowerRight.Latitude,
				lowerRight.Longitude,
				StoreType.Area);

			eventArgs.CompleteItemsRequest(list);
		}

		if (minZoom == 9)
		{
			// request areas
			List<StoreLocation> list = this.GetStores(
				upperLeft.Latitude,
				upperLeft.Longitude,
				lowerRight.Latitude,
				lowerRight.Longitude,
				StoreType.Store);

			eventArgs.CompleteItemsRequest(list);
		}
	}

	internal List<StoreLocation> GetStores(
		double upperLeftLat,
		double upperLeftLong,
		double lowerRightLat,
		double lowerRightLong,
		StoreType storeType)
	{
		List<StoreLocation> locations = new List<StoreLocation>();

		string latLonCondition = "[number(@Latitude) < " 
			+ upperLeftLat.ToString(CultureInfo.InvariantCulture) 
			+ " and number(@Latitude) > " 
			+ lowerRightLat.ToString(CultureInfo.InvariantCulture) 
			+ " and number(@Longitude) > " 
			+ upperLeftLong.ToString(CultureInfo.InvariantCulture) 
			+ " and number(@Longitude) < " 
			+ lowerRightLong.ToString(CultureInfo.InvariantCulture) 
			+ "]";

		switch (storeType)
		{
			case StoreType.Area:
				{
					XmlNodeList nodeList = document.SelectNodes(
						"/StoresLocation/Area" + latLonCondition);
					foreach (XmlNode node in nodeList)
					{
						XmlElement element = (XmlElement)node;

						locations.Add(new StoreLocation(
							Convert.ToDouble(
								element.GetAttribute("Latitude"), 
								CultureInfo.InvariantCulture),
							Convert.ToDouble(
								element.GetAttribute("Longitude"), 
								CultureInfo.InvariantCulture),
							element.GetAttribute("Name"), StoreType.Area));
					}
				}
				break;

			case StoreType.Store:
				{
					XmlNodeList nodeList = document.SelectNodes(
						"/StoresLocation/Area/*" + latLonCondition);
					foreach (XmlNode node in nodeList)
					{
						XmlElement element = (XmlElement)node;

						locations.Add(new StoreLocation(
							Convert.ToDouble(
								element.GetAttribute("Latitude"), 
								CultureInfo.InvariantCulture),
							Convert.ToDouble(
								element.GetAttribute("Longitude"), 
								CultureInfo.InvariantCulture),
							element.GetAttribute("Name"),
							element.LocalName == "Market" ? StoreType.Market : StoreType.Store));
					}
				}
				break;
		}

		return locations;
	}
}

#endregion
}
