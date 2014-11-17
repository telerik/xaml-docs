using System;
using System.Linq;
using System.Windows.Controls;
using SpreadsheetDocumentationSourceCode.Examples.radspreadsheet_localization;
using Telerik.Windows.Controls;

namespace Localization
{
    /// <summary>
    /// Interaction logic for UserControl_Cs.xaml
    /// </summary>
    public partial class UserControl_Cs : UserControl
    {
        public UserControl_Cs()
        {
            InitializeComponent();

            #region radspreadsheet-localization_0
            LocalizationManager.Manager = new LocalizationManager()
            {
                ResourceManager = RadSpreadsheetResources.ResourceManager
            };
            #endregion

            #region radspreadsheet-localization_1
            LocalizationManager.Manager = new CustomLocalizationManager();
            #endregion
        }
    }

    #region radspreadsheet-localization_2
    public class CustomLocalizationManager : LocalizationManager
    {
        public override string GetStringOverride(string key)
        {
            switch (key)
            {
                //----------------------
                case "Spreadsheet_Workbook":
                    return RadSpreadsheetResources.Spreadsheet_Workbook;
                //----------------------
            }
            return base.GetStringOverride(key);
        }
    }
    #endregion


    public class CustomLocalizationManagerWithFile : LocalizationManager
    {
        #region radspreadsheet-localization_3
        public override string GetStringOverride(string key)
        {
            switch (key)
            {
                case "Ok":
                    return "~Ok~";
                case "Cancel":
                    return "~Cancel~";

                //Insert any other keys that you need.
            }
            return base.GetStringOverride(key);
        }
        #endregion
    }
}
