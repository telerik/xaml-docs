using System;
using System.Linq;
using System.Windows.Controls;
using Telerik.Windows.Documents.UI;

namespace Printing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs : UserControl
    {
        public Default_Cs()
        {
            InitializeComponent();
        }

        private void PrintDocument()
        {
            #region radrichtextbox-printing_0
            this.radRichTextBox.Print("My document", PrintMode.Native);
            #endregion
        }

        private void PrintUsingSetting()
        {
#if silverlight
            #region radrichtextbox-printing_1
            PrintSettings settings = new PrintSettings()
            {
                DocumentName = "My document",
                PrintMode = PrintMode.Html,
                UseDefaultPrinter = true,
                ForceVector = true
            };
            this.radRichTextBox.Print(settings);
            #endregion
#endif
            #region radrichtextbox-printing_2
            PrintSettings settings = new PrintSettings()
            {
                DocumentName = "My document",
                PrintMode = PrintMode.Native,
                PrintScaling = PrintScaling.None,
                UseDefaultPrinter = true,
                PageRange = new PageRange(2, 4)
            };

            this.radRichTextBox.Print(settings);
#endregion
        }

        private void PrintUsinghDialog()
        {

        }
    }
}