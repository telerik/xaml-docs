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

    #region radpdfviewer-command-descriptors_0
    public class FitToWidthCommand : FixedDocumentViewerCommandBase
    {
        private const double PageMargin = 20;

        public FitToWidthCommand(FixedDocumentViewerBase fixedDocumentViewerBase)
            : base(fixedDocumentViewerBase)
        {
        }

        public override void Execute(object parameter)
        {
            double width = this.Viewer.ActualWidth - 2 * PageMargin;
            double pageWidth = this.Viewer.CurrentPage.ActualWidth;
            this.Viewer.ScaleFactor = width / pageWidth;
        }
    }
    #endregion

    #region radpdfviewer-command-descriptors_1
    public class CustomCommandDescriptors : DefaultCommandDescriptors
    {
        private readonly CommandDescriptor fitToWidthCommandDescriptor;

        public CommandDescriptor FitToWidthCommandDescriptor
        {
            get
            {
                return this.fitToWidthCommandDescriptor;
            }
        }

        public CustomCommandDescriptors(FixedDocumentViewerBase fixedDocumentViewerBase)
            : base(fixedDocumentViewerBase)
        {
            this.fitToWidthCommandDescriptor = new CommandDescriptor(new FitToWidthCommand(fixedDocumentViewerBase));
        }
    }
    #endregion

    #region radpdfviewer-command-descriptors_2
      this.customCommandDescriptors = new CustomCommandDescriptors(this.viewer);
    #endregion
}
