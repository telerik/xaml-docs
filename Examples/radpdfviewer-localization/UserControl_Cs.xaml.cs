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

    #region radpdfviewer-localization_0
            LocalizationManager.Manager = new CustomLocalizationManager();
    #endregion


    #region radpdfviewer-localization_1
        public class CustomLocalizationManager : LocalizationManager
    {
        public override string GetStringOverride(string key)
        {
            switch (key)
            {
                //----------------------
                case "BusyIndicatorLoading":
                    return "Loading...";
                case "FixedDocumentViewers_BeginningOfDocumentReachedMessage":
                    return "You have reached the beginning of the document.";
                case "FixedDocumentViewers_CaseSensitive":
                    return "Case Sensitive";
                case "FixedDocumentViewers_EndOfDocumentReachedMessage":
                    return "You have reached the end of the document.";
                case "FixedDocumentViewers_FindDialogHeader":
                    return "Find";
                case "FixedDocumentViewers_FindNext":
                    return "Find Next";
                case "FixedDocumentViewers_FindPrevious":
                    return "Find Previous";
                case "FixedDocumentViewers_Options":
                    return "Options";
                case "FixedDocumentViewers_SearchInTheDocument":
                    return "Search in the document...dddddd";
                case "FixedDocumentViewers_UseRegularExpression":
                    return "Use Regular Expression";
                case "FixedDocumentViewers_WholeWordsOnly":
                    return "Whole Words Only";
                //----------------------
            }
            return base.GetStringOverride(key);
        }
    }
    #endregion

    #region radpdfviewer-localization_2
        public class CustomLocalizationManager : LocalizationManager
    {
        public override string GetStringOverride(string key)
        {
            switch (key)
            {
                //----------------------
                case "FixedDocumentViewers_BeginningOfDocumentReachedMessage":
                    return MyRadPdfViewerResources.FixedDocumentViewers_BeginningOfDocumentReachedMessage;
                //----------------------
            }
            return base.GetStringOverride(key);
        }
    }
    #endregion

    #region radpdfviewer-localization_3
  LocalizationManager.Manager = new LocalizationManager()
{
    ResourceManager = RadPdfViewerResources.ResourceManager
};
    #endregion


}
