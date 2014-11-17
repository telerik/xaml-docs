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

#region radcolorpicker-getting-started_0
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.SelectedColor = Colors.Red;
#endregion

#region radcolorpicker-getting-started_2
colorPicker.SelectedColorChanged += new EventHandler(RadColorPicker_SelectedColorChanged1);

void RadColorPicker_SelectedColorChanged1(object sender, EventArgs e)
{
   RadColorPicker colorPicker = sender as RadColorPicker;
   Color selectedColor = colorPicker.SelectedColor;
}
#endregion

#region radcolorpicker-getting-started_3
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.MainPalette = ColorPreset.Grayscale;
#endregion

#region radcolorpicker-getting-started_5
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.HeaderPalette = ColorPreset.Office;
#endregion

#region radcolorpicker-getting-started_7
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.StandardPalette = ColorPreset.Standard;
#endregion

#region radcolorpicker-getting-started_9
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.StandardPaletteVisibility = Visibility.Visible;
Collection<Color> colors = new Collection<Color>();
colors.Add(Colors.Red);
colors.Add(Colors.Green);
colors.Add(Colors.Blue);
colorPicker.StandardPaletteItemsSource = colors;
#endregion

#region radcolorpicker-getting-started_11
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.HeaderPaletteVisibility = Visibility.Visible;
Collection<Color> colors = new Collection<Color>();
colors.Add(Colors.Red);
colors.Add(Colors.Green);
colors.Add(Colors.Blue);
colorPicker.HeaderPaletteItemsSource = colors;
#endregion

#region radcolorpicker-getting-started_13
RadColorPicker colorPicker = new RadColorPicker();
Collection<Color> colors = new Collection<Color>();
colors.Add(Colors.Red);
colors.Add(Colors.Green);
colors.Add(Colors.Blue);
colorPicker.MainPaletteItemsSource = colors;
#endregion

#region radcolorpicker-getting-started_15
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.SelectedColorChanged += new EventHandler(RadColorPicker_SelectedColorChanged);

void RadColorPicker_SelectedColorChanged(object sender, EventArgs e)
{
   RadColorPicker colorPicker = sender as RadColorPicker;
   Color selectedColor = colorPicker.SelectedColor;
}
#endregion

#region radcolorpicker-getting-started_17
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.DropDownClosed += new EventHandler(colorPicker_DropDownClosed);

private void colorPicker_DropDownClosed(object sender, EventArgs e)
{
	// handle the DropDownClosed event
}
#endregion

#region radcolorpicker-getting-started_19
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.DropDownOpened += new EventHandler(colorPicker_DropDownOpened);
private void colorPicker_DropDownOpened(object sender, EventArgs e)
{
	// handle the DropDownOpened event
}
#endregion

#region radcolorpicker-getting-started_21
RadColorPicker colorPicker = new RadColorPicker();
colorPicker.Click += new EventHandler(colorPicker_Click);

private void colorPicker_Click(object sender, EventArgs e)
{
	// handle the Click event
}
#endregion
}
