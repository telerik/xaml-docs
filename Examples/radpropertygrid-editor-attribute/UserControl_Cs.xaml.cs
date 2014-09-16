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
	
#region radpropertygrid-editor-attribute_1
private Player captain;
public Player Captain
{
	get 
	{
		if (this.captain == null)
		{
 			this.captain = new Player("Pepe Reina", 25, Position.GK, "Spain") { PhoneNumber = new PhoneNumber() { CountryCode = "359", RegionCode = "885", Number = "434343" } }
		}
		return this.captain; 
	}
}
#endregion

#region radpropertygrid-editor-attribute_2

[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(PhoneEditorControl)]
public PhoneNumber PhoneNumber
{
	get
	{
		return this.phoneNumber;
	}
	set
	{
		if (this.phoneNumber != value)
		{
			this.phoneNumber = value;
			this.OnPropertyChanged("PhoneNumber");
		}
	}
}

#endregion

#region radpropertygrid-editor-attribute_3

[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(PhoneEditorControl), Telerik.Windows.Controls.Data.PropertyGrid.EditorStyle.DropDown)]
public PhoneNumber PhoneNumber
{
	get
	{
		return this.phoneNumber;
	}
	set
	{
		if (this.phoneNumber != value)
		{
			this.phoneNumber = value;
			this.OnPropertyChanged("PhoneNumber");
		}
	}
}

#endregion

#region radpropertygrid-editor-attribute_4
[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(RadNumericUpDown), "Value")]
public int Number
{
	get { return this.number; }
	set
	{
		if (value != this.number)
		{
			this.number = value;
			this.OnPropertyChanged("Number");
		}
	}
}


#endregion

#region radpropertygrid-editor-attribute_5
[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(TextBox), "Text", Telerik.Windows.Controls.Data.PropertyGrid.EditorStyle.Modal)]
public string Name
{
	get { return this.name; }
	set
	{
		if (value != this.name)
		{
			this.name = value;
			this.OnPropertyChanged("Name");
		}
	}
}


#endregion


#region radpropertygrid-editor-attribute_6
public class PhoneNumber : INotifyPropertyChanged
{
	private string countryCode;
	public string CountryCode
	{
		get
		{
			return this.countryCode;
		}
		set
		{
			if (this.countryCode != value)
			{
				this.countryCode = value;
				this.OnPropertyChanged("CountryCode");
			}
		}
	}

	private string number;
	public string Number
	{
		get
		{
			return this.number;
		}
		set
		{
			if (this.number != value)
			{
				this.number = value;
				this.OnPropertyChanged("Number");
			}
		}
	}

	private string regionCode;
	public string RegionCode
	{
		get
		{
			return this.regionCode;
		}
		set
		{
			if (this.regionCode != value)
			{
				this.regionCode = value;
				this.OnPropertyChanged("RegionCode");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	private void OnPropertyChanged(string propertyName)
	{
		if (this.PropertyChanged != null)
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
	}
}

#endregion

#region radpropertygrid-editor-attribute_7
public class Player : INotifyPropertyChanged
{
public event PropertyChangedEventHandler PropertyChanged;

private string name;
private int number;
private Position position;
private string country;
private PhoneNumber phoneNumber;

[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(TextBox), "Text", Telerik.Windows.Controls.Data.PropertyGrid.EditorStyle.Modal)]
public string Name
{
	get { return this.name; }
	set
	{
		if (value != this.name)
		{
			this.name = value;
			this.OnPropertyChanged("Name");
		}
	}
}

[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(RadNumericUpDown), "Value")]
public int Number
{
	get { return this.number; }
	set
	{
		if (value != this.number)
		{
			this.number = value;
			this.OnPropertyChanged("Number");
		}
	}
}

public Position Position
{
	get { return this.position; }
	set
	{
		if (value != this.position)
		{
			this.position = value;
			this.OnPropertyChanged("Position");
		}
	}
}	
[Telerik.Windows.Controls.Data.PropertyGrid.Editor(typeof(PhoneEditorControl), Telerik.Windows.Controls.Data.PropertyGrid.EditorStyle.DropDown)]
public PhoneNumber PhoneNumber
{
	get
	{
		return this.phoneNumber;
	}
	set
	{
		if (this.phoneNumber != value)
		{
			this.phoneNumber = value;
			this.OnPropertyChanged("PhoneNumber");
		}
	}
}

public string Country
{
	get { return this.country; }
	set
	{
		if (value != this.country)
		{
			this.country = value;
			this.OnPropertyChanged("Country");
		}
	}
}

public Player()
{

}

public Player(string name, int number, Position position, string country)
{
	this.name = name;
	this.number = number;
	this.position = position;
	this.country = country;
}

protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
{
	PropertyChangedEventHandler handler = this.PropertyChanged;
	if (handler != null)
	{
		handler(this, args);
	}
}

private void OnPropertyChanged(string propertyName)
{
	this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
}

}

#endregion

}
