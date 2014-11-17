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

#region radtoolbar-template-parts_0
[DefaultProperty("Items")]
[TemplatePart(Name = "PART_DropdownButton", Type = typeof(ToggleButton))]
[TemplatePart(Name = "PART_StripPanel", Type = typeof(StackPanel))]
[TemplatePart(Name = "PART_OverflowPanel", Type = typeof(StackPanel))]
[TemplatePart(Name = "PART_Overflow", Type = typeof(Popup))]
public partial class RadToolBar : ItemsControl
#endregion
}
	