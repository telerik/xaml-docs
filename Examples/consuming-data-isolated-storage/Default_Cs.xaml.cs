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

#region consuming-data-isolated-storage_0
IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
#endregion

#region consuming-data-isolated-storage_2
IsolatedStorageFileStream isfs = new IsolatedStorageFileStream( fileName, FileMode.Open, isf );
#endregion

#region consuming-data-isolated-storage_4
using ( StreamReader sr = new StreamReader( isfs ) )
{
    string lineOfData = String.Empty;
    while ( ( lineOfData = sr.ReadLine() ) != null )
        data += lineOfData;
}
#endregion

#region consuming-data-isolated-storage_6
private string LoadData( string fileName )
{
    string data = String.Empty;
    using ( IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication() )
    {
        using ( IsolatedStorageFileStream isfs = new IsolatedStorageFileStream( fileName, FileMode.Open, isf ) )
        {
            using ( StreamReader sr = new StreamReader( isfs ) )
            {
                string lineOfData = String.Empty;
                while ( ( lineOfData = sr.ReadLine() ) != null )
                    data += lineOfData;
            }
        }
    }
    return data;
}
#endregion
}
