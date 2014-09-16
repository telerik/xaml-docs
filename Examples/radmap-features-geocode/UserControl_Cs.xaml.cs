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

#region radmap-features-geocode_0
BingGeocodeProvider geocodeProvider;
public Sample()
{
    InitializeComponent();
    this.geocodeProvider = new BingGeocodeProvider();
    this.geocodeProvider.ApplicationId = "key";
    this.geocodeProvider.MapControl = this.radMap;
    this.geocodeProvider.GeocodeCompleted += this.geocodeProvider_GeocodeCompleted;
}
private void geocodeProvider_GeocodeCompleted( object sender, GeocodeCompletedEventArgs e )
{
}
#endregion

#region radmap-features-geocode_3
private void GeocodeButton_Click( object sender, RoutedEventArgs e )
{
    GeocodeRequest request = new GeocodeRequest();
    request.Query = this.InputBox.Text;
    this.geocodeProvider.GeocodeAsync( request );
}
#endregion

#region radmap-features-geocode_6
private void radMap_MapMouseDoubleClick( object sender, MapMouseRoutedEventArgs e )
{
    ReverseGeocodeRequest reverseRequest = new ReverseGeocodeRequest();
    reverseRequest.Location = e.Location;
    this.geocodeProvider.ReverseGeocodeAsync( reverseRequest );
}
#endregion

#region radmap-features-geocode_8
private void geocodeProvider_GeocodeCompleted( object sender, GeocodeCompletedEventArgs e )
{
    foreach ( GeocodeResult result in e.Response.Results )
    {
        MessageBox.Show( string.Format( "Longitude: {0}, Latitude: {1}, Address: {2}", result.Locations.First().Longitude, result.Locations.First().Latitude, result.DisplayName ) );
    }
}
#endregion
}
