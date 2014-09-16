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

#region radmap-features-zoom-modes_0
public MainPage()
        {
            InitializeComponent();
            this.radMap.InitializeCompleted += new EventHandler(radMap_InitializeCompleted);
        }
        private void radMap_InitializeCompleted(object sender, EventArgs e)
        {
            this.SetCustomZoomLevelLabel(18, "My Level");
        }
        private void SetCustomZoomLevelLabel(int zoomLevel, string label)
        {
            CommandDescription description = (from cmd in this.radMap.MapZoomBar.Commands
                                              where (int)cmd.CommandParameter == zoomLevel
                                              select cmd).FirstOrDefault();
            if (description != null)
            {
                RoutedUICommand command = description.Command as RoutedUICommand;
                if (command != null)
                {
                    command.Text = label;
                }
            }
        }
#endregion
}
