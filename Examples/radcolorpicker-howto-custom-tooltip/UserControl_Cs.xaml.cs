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

#region radcolorpicker-howto-custom-tooltip_1
public class ColorModel : ViewModelBase
{
	private Color currColor;
	public Color CustomColor
	{
		get { return this.currColor; }
		set
		{
			if (this.currColor != value)
			{
				this.currColor = value;
				this.OnPropertyChanged("CustomColor");
			}
		}
	}

	public string ToolTipString { get; set; }
}
#endregion radcolorpicker-howto-custom-tooltip_1
#region radcolorpicker-howto-custom-tooltip_3
public class MainViewModel : ViewModelBase
{
	#region PrivateFilds
	private ObservableCollection<ColorModel> mainPaletteColors;
	private ObservableCollection<ColorModel> headerPaletteColors;
	private ObservableCollection<ColorModel> standardPaletteColors;
	#endregion PrivateFilds

	#region Constructor
	public MainViewModel()
	{
		mainPaletteColors = new ObservableCollection<ColorModel>();
		headerPaletteColors = new ObservableCollection<ColorModel>();
		standardPaletteColors = new ObservableCollection<ColorModel>();

		GenerateSampleData();
	}
	#endregion Constructor

	#region GenerateSampleData
	private void GenerateSampleData()
	{
		Random rand = new Random();
		for (int i = 0; i < 50; i++)
		{
			ColorModel color = new ColorModel()
			{
				CustomColor = Color.FromArgb(255, (byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)),
				ToolTipString = "Custom ToolTip " + i,
			};
			this.mainPaletteColors.Add(color);
		}

		for (int i = 0; i < 10; i++)
		{
			ColorModel color = new ColorModel()
			{
				CustomColor = Color.FromArgb(255, (byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)),
				ToolTipString = "Custom ToolTip " + i,
			};
			this.headerPaletteColors.Add(color);
		}

		for (int i = 0; i < 10; i++)
		{
			ColorModel color = new ColorModel()
			{
				CustomColor = Color.FromArgb(255, (byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)),
				ToolTipString = "Custom ToolTip " + i,
			};
			this.standardPaletteColors.Add(color);
		}
	}
	#endregion GenerateSampleData

	#region Properties
	public ObservableCollection<ColorModel> MainPaletteColors
	{
		get { return this.mainPaletteColors; }
		set
		{
			if (this.mainPaletteColors != value)
			{
				this.mainPaletteColors = value;
				this.OnPropertyChanged("MainPaletteColors");
			}
		}
	}

	public ObservableCollection<ColorModel> StandardPaletteColors
	{
		get { return this.standardPaletteColors; }
		set
		{
			if (this.standardPaletteColors != value)
			{
				this.standardPaletteColors = value;
				this.OnPropertyChanged("StandardPaletteColors");
			}
		}
	}

	public ObservableCollection<ColorModel> HeaderPaletteColors
	{
		get { return this.headerPaletteColors; }
		set
		{
			if (this.headerPaletteColors != value)
			{
				this.headerPaletteColors = value;
				this.OnPropertyChanged("HeaderPaletteColors");
			}
		}
	}
	#endregion Properties
}
#endregion radcolorpicker-howto-custom-tooltip_3
}
