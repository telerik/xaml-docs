using System;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.RichTextBoxUI;
using Telerik.Windows.Controls.RichTextBoxUI.Menus;
using Telerik.Windows.Documents.RichTextBoxCommands;
using Telerik.Windows.Documents.UI;
using Telerik.Windows.Documents.UI.Layers;

namespace EditingImages
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs
    {
        public Default_Cs()
        {
            InitializeComponent();
        }

        private void DisableMiniToolBar()
        {
            #region radrichtextbox-features-editing-images_2
            this.radRichTextBox.IsImageMiniToolBarEnabled = false;
            #endregion
        }

        private void ChangeContextMenu()
        {
            #region radrichtextbox-features-editing-images_4
            ContextMenu contextMenu = (ContextMenu)this.radRichTextBox.ContextMenu;
            contextMenu.ContentBuilder = new CustomMenuBuilder(this.radRichTextBox);
            #endregion
        }

        private void DisableAdornerSettings()
        {
            #region radrichtextbox-features-editing-images_5
            this.radRichTextBox.ImageSelectionAdornerSettings.CanDrag = false;
            this.radRichTextBox.ImageSelectionAdornerSettings.CanResize = false;
            this.radRichTextBox.ImageSelectionAdornerSettings.CanRotate = false;
            #endregion
        }
    }
    #region radrichtextbox-features-editing-images_0
    public class CustomLayersBuilder : UILayersBuilder
    {
        protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
        {
            uiLayerContainer.UILayers.Remove("AdornerLayer");
        }
    }
    #endregion


    #region radrichtextbox-features-editing-images_3
    public class CustomMenuBuilder : ContextMenuContentBuilder
    {
        private RadRichTextBox radRichTextBox;

        public CustomMenuBuilder(RadRichTextBox radRichTextBox)
            : base(radRichTextBox)
        {
            this.radRichTextBox = radRichTextBox;
        }

        protected override ContextMenuGroup CreateImageCommands()
        {
            ContextMenuGroup imageCommands = new ContextMenuGroup(ContextMenuGroupType.ImageCommands);
            imageCommands.Add(RadMenuItemFactory.CreateMenuItem(LocalizationManager.GetString("Documents_ContextMenu_Image_InsertCaption"), "16/InsertCaption.png", this.radRichTextBox.Commands.ShowInsertCaptionDialogCommand));

            return imageCommands;
        }
    }

    internal static class RadMenuItemFactory
    {
        private const string BaseImagePath = "/Telerik.Windows.Controls.RichTextBoxUI;component/Images/MSOffice/";

        public static RadMenuItem CreateMenuItem(string text, string relativePath)
        {
            return CreateMenuItem(text, relativePath, null, null);
        }

        public static RadMenuItem CreateMenuItem(string text, string imageRelativePath, RichTextBoxCommandBase command, object commandParameter = null)
        {
            RadMenuItem menuItem = new RadMenuItem();
            menuItem.Header = text;

            if (imageRelativePath != null)
            {
                menuItem.Icon = new System.Windows.Controls.Image() { Source = new BitmapImage(new Uri(BaseImagePath + imageRelativePath, UriKind.Relative)), Stretch = Stretch.None };
            }

            menuItem.Command = command;

            if (commandParameter != null)
            {
                menuItem.CommandParameter = commandParameter;
            }

            return menuItem;
        }
    }
    #endregion



}
