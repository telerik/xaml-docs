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

#region radrichtextbox-troubleshooting-troubleshooting-common-problems_0
        public static void LoadExtensibleUIComponents(RadRichTextBox radRichTextBox)
        {
            radRichTextBox.FindReplaceDialog = new FindReplaceDialog();
            radRichTextBox.ParagraphPropertiesDialog = new RadParagraphPropertiesDialog();
            radRichTextBox.FontPropertiesDialog = new FontPropertiesDialog();

            radRichTextBox.InsertSymbolWindow = new RadInsertSymbolDialog();
            radRichTextBox.InsertHyperlinkDialog = new RadInsertHyperlinkDialog();
            radRichTextBox.ManageBookmarksDialog = new ManageBookmarksDialog();

            radRichTextBox.ContextMenu = new ContextMenu();
            radRichTextBox.SelectionMiniToolBar = new SelectionMiniToolBar();
            radRichTextBox.ImageMiniToolBar = new ImageMiniToolBar();

            radRichTextBox.InsertTableDialog = new InsertTableDialog();
            radRichTextBox.TablePropertiesDialog = new TablePropertiesDialog();
            radRichTextBox.TableBordersDialog = new TableBordersDialog();

            radRichTextBox.SpellCheckingDialog = new SpellCheckingDialog();
            radRichTextBox.EditCustomDictionaryDialog = new EditCustomDictionaryDialog();

            radRichTextBox.ImageEditorDialog = new ImageEditorDialog();
            radRichTextBox.FloatingBlockPropertiesDialog = new FloatingBlockPropertiesDialog();

            radRichTextBox.InsertDateTimeDialog = new InsertDateTimeDialog();
            radRichTextBox.TabStopsPropertiesDialog = new TabStopsPropertiesDialog();

            radRichTextBox.ProtectDocumentDialog = new ProtectDocumentDialog();
            radRichTextBox.UnprotectDocumentDialog = new UnprotectDocumentDialog();
            radRichTextBox.ChangeEditingPermissionsDialog = new ChangeEditingPermissionsDialog();

            radRichTextBox.ManageStylesDialog = new ManageStylesDialog();
            radRichTextBox.StyleFormattingPropertiesDialog = new StyleFormattingPropertiesDialog();

            ((DocumentSpellChecker)radRichTextBox.SpellChecker).AddDictionary(new RadEn_USDictionary(), CultureInfo.InvariantCulture);
        }
#endregion

#region radrichtextbox-troubleshooting-troubleshooting-common-problems_1
                DocumentFormatProvidersManager.RegisterFormatProvider(new XamlFormatProvider());
                DocumentFormatProvidersManager.RegisterFormatProvider(new DocxFormatProvider());
                DocumentFormatProvidersManager.RegisterFormatProvider(new RtfFormatProvider());
                DocumentFormatProvidersManager.RegisterFormatProvider(new HtmlFormatProvider());
                DocumentFormatProvidersManager.RegisterFormatProvider(new PdfFormatProvider());
                DocumentFormatProvidersManager.RegisterFormatProvider(new TxtFormatProvider());
#endregion

#region radrichtextbox-troubleshooting-troubleshooting-common-problems_2
                RuntimeHelpers.RunClassConstructor(typeof(XamlFormatProvider).TypeHandle);
                RuntimeHelpers.RunClassConstructor(typeof(DocxFormatProvider).TypeHandle);
                RuntimeHelpers.RunClassConstructor(typeof(RtfFormatProvider).TypeHandle);
                RuntimeHelpers.RunClassConstructor(typeof(HtmlFormatProvider).TypeHandle);
                RuntimeHelpers.RunClassConstructor(typeof(PdfFormatProvider).TypeHandle);
                RuntimeHelpers.RunClassConstructor(typeof(TxtFormatProvider).TypeHandle);
#endregion

#region radrichtextbox-troubleshooting-troubleshooting-common-problems_3
RadCompositionInitializer.Catalog = new TypeCatalog(
    // format providers
    typeof(XamlFormatProvider),
    typeof(RtfFormatProvider),
    typeof(DocxFormatProvider),
    typeof(PdfFormatProvider),
    typeof(HtmlFormatProvider),
    typeof(TxtFormatProvider),

    // mini toolbars
    typeof(SelectionMiniToolBar),
    typeof(ImageMiniToolBar),

    // context menu
    typeof(ContextMenu),

    // the default English spellchecking dictionary
    typeof(RadEn_USDictionary),

    // dialogs
    typeof(AddNewBibliographicSourceDialog),
    typeof(ChangeEditingPermissionsDialog),
    typeof(EditCustomDictionaryDialog),
    typeof(FindReplaceDialog),
    typeof(FloatingBlockPropertiesDialog),
    typeof(FontPropertiesDialog),
    typeof(ImageEditorDialog),
    typeof(InsertCaptionDialog),
    typeof(InsertCrossReferenceWindow),
    typeof(InsertDateTimeDialog),
    typeof(InsertTableDialog),
    typeof(InsertTableOfContentsDialog),
    typeof(ManageBibliographicSourcesDialog),
    typeof(ManageBookmarksDialog),
    typeof(ManageStylesDialog),
    typeof(NotesDialog),
    typeof(ProtectDocumentDialog),
    typeof(RadInsertHyperlinkDialog),
    typeof(RadInsertSymbolDialog),
    typeof(RadParagraphPropertiesDialog),
    typeof(SetNumberingValueDialog),
    typeof(SpellCheckingDialog),
    typeof(StyleFormattingPropertiesDialog),
    typeof(TableBordersDialog),
    typeof(TablePropertiesDialog),
    typeof(TabStopsPropertiesDialog),
    typeof(UnprotectDocumentDialog),
    typeof(WatermarkSettingsDialog)
    );
#endregion
}
