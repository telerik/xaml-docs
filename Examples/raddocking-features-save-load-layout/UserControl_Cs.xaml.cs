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

#region raddocking-features-save-load-layout_2
private string SaveLayout()
{
    string xml;
    // Save your layout for example in the isolated storage.
    using ( IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication() )
    {
        using ( var isoStream = storage.OpenFile( "RadDocking_Layout.xml", FileMode.Create ) )
        {
            this.radDocking.SaveLayout( isoStream );
            isoStream.Seek( 0, SeekOrigin.Begin );
            StreamReader reader = new StreamReader( isoStream );
            xml = reader.ReadToEnd();
        }
    }
    // Return the generated XML
    return xml;
}
#endregion

#region raddocking-features-save-load-layout_2_1
private string SaveLayout()
{
    string xml;
    // Save your layout for example in the isolated storage.
    using ( IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForAssembly() )
    {
        using ( var isoStream = storage.OpenFile( "RadDocking_Layout.xml", FileMode.Create ) )
        {
            this.radDocking.SaveLayout( isoStream );
            isoStream.Seek( 0, SeekOrigin.Begin );
            StreamReader reader = new StreamReader( isoStream );
            xml = reader.ReadToEnd();
        }
    }
    // Return the generated XML
    return xml;
}
#endregion


#region raddocking-features-save-load-layout_5
private void LoadLayout()
{
    // Load your layot from the isolated storage.
    using ( IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication() )
    {
        using ( var isoStream = storage.OpenFile( "RadDocking_Layout.xml", FileMode.Open ) )
        {
            this.radDocking.LoadLayout( isoStream );
        }
    }
}
#endregion

#region raddocking-features-save-load-layout_5_1
private void LoadLayout()
{
    // Load your layot from the isolated storage.
    using ( IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForAssembly() )
    {
        using ( var isoStream = storage.OpenFile( "RadDocking_Layout.xml", FileMode.Open ) )
        {
            this.radDocking.LoadLayout( isoStream );
        }
    }
}
#endregion


#region raddocking-features-save-load-layout_7
public void SaveLayout( Stream destination, bool raiseEventsIfNoSerializationTag );
#endregion
}
