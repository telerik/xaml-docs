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

#region raddatetimepicker-how-to-implement-custom-parsing_1
private void radDateTimePicker_ParseDateTimeValue( object sender, Telerik.Windows.Controls.ParseDateTimeEventArgs args )
{
    string input = args.TextToParse.ToLower();
    System.Globalization.DateTimeFormatInfo formatInfo = new System.Globalization.DateTimeFormatInfo();
    int monthIndex = 1;
    foreach ( string month in formatInfo.MonthNames )
    {
        if ( input.Contains(month.ToLower()) == true )
            break;
        monthIndex++;
    }
    if ( monthIndex < 12 )
    {
        args.Result = new DateTime( 2010, monthIndex, 1 );
    }
    else
    {
        args.IsParsingSuccessful = false;
    }
}
#endregion
}
