using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
    #region common-styling-appearance-office2013-theme_0
    /// <summary>
    /// Represents theme color variations.
    /// </summary>
    public enum ColorVariation
    {
        /// <summary>
        /// Represents Dark Grey Office2013 theme palette.
        /// </summary>
        DarkGrey,

        /// <summary>
        /// Represents Light Grey Office2013 theme palette.
        /// </summary>
        LightGrey,

        /// <summary>
        /// Represents the default White Office2013 theme palette.
        /// </summary>
        White
    }
    #endregion

    public class MainWindow
    {
        #region common-styling-appearance-office2013-theme_1
        public MainWindow()
        {
            Office2013Palette.LoadPreset(Office2013Palette.ColorVariation.DarkGray);

            InitializeComponent();
        }
        #endregion
		
		#region common-styling-appearance-office2013-theme_2
        public UserControl()
        {
            Office2013Palette.LoadPreset(Office2013Palette.ColorVariation.DarkGray);

            InitializeComponent();
        }
        #endregion
    }
}
