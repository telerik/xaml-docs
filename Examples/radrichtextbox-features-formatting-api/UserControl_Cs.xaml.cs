using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Documents.Model;

namespace FormattingAPI
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

        #region radrichtextbox-features-formatting-api_1
        private void BoldButton_Click(object sender, RoutedEventArgs e)
        {
            this.radRichTextBox.ToggleBold();
        }
        #endregion

        private void CreateFragments()
        {
            RadDocument radDocument = this.radRichTextBox.Document;

            #region radrichtextbox-features-formatting-api_6
            DocumentFragment fragmentFromDocument = new DocumentFragment(radDocument);
            #endregion

            #region radrichtextbox-features-formatting-api_8
            DocumentFragment fragmentFromSelection = radDocument.Selection.CopySelectedDocumentElements();
            #endregion
        }

        private void InsertText()
        {
            #region radrichtextbox-features-formatting-api_3
            this.radRichTextBox.ActiveDocumentEditor.Insert("text");
            #endregion
        }

        private void InsertFragment(DocumentFragment fragment)
        {
            #region radrichtextbox-features-formatting-api_5
            this.radRichTextBox.InsertFragment(fragment);
            #endregion
        }


    }
}
