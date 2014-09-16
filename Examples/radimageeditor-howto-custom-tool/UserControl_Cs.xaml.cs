using System.IO;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Telerik.Windows.Controls;
using Telerik.Windows.Media.Imaging;
using Telerik.Windows.Media.Imaging.Commands;
using Telerik.Windows.Media.Imaging.Tools;
using Telerik.Windows.Media.Imaging.Tools.UI;

namespace ImageEditorDocumentationSourceCode.Examples.radimageeditor_howto_custom_tool
{
    /// <summary>
    /// Interaction logic for UserControl_Cs.xaml
    /// </summary>
    public partial class UserControl_Cs : UserControl
    {
        public UserControl_Cs()
        {
            InitializeComponent();
        }
    }

    #region radimageeditor-howto-custom-tool_0
    public class WatermarkTool : ITool
    #endregion
    {
        #region Fields
        public static readonly double DefaultOpacity = 0.5;
        public static readonly double DefaultScale = 1;
        public static readonly double DefaultRotation = 0;

        private bool isDirty;
        private Panel previewPanel;
        private RadImageEditor currnetEditor;

        private RadBitmap watermarkBitmap;
        private Image watermarkImage;
        private RotateTransform imageRotateTransform;
        private ScaleTransform imageScaleTransform;

        private ScaleTransform imageEditorScale;

        private WatermarkToolSettings settings;

        #region radimageeditor-howto-custom-tool_1
        private WatermarkCommand watermarkCommand;

        public class WatermarkCommand : IImageCommand
        {
            public RadBitmap Execute(RadBitmap source, object context)
            {
                WatermarkCommandContext myContext = (WatermarkCommandContext)context;

                Grid grid = new Grid();
                grid.Children.Add(new Image()
                {
                    Source = source.Bitmap,
                    Stretch = Stretch.None
                });

                Image image = new Image()
                {
                    Source = myContext.Image.Bitmap,
                    Stretch = Stretch.None,
                    Opacity = myContext.Opacity,
                };

                ScaleTransform scaleTransform = new ScaleTransform();
                scaleTransform.ScaleX = myContext.Scale;
                scaleTransform.ScaleY = myContext.Scale;

                RotateTransform rotateTransform = new RotateTransform();
                rotateTransform.Angle = myContext.Rotation;

                TransformGroup transform = new TransformGroup();
                transform.Children.Add(rotateTransform);
                transform.Children.Add(scaleTransform);

                image.RenderTransform = transform;
                image.RenderTransformOrigin = new Point(0.5, 0.5);

                grid.Children.Add(image);

                return new RadBitmap(source.Width, source.Height, grid);
            }
        }
        #endregion

        #endregion

        #region Properties

        public bool IsPreviewOverlay
        {
            get
            {
                return true;
            }
        }

        public bool IsDirty
        {
            get
            {
                return this.isDirty;
            }
        }

        public bool AffectsLayout
        {
            get
            {
                return false;
            }
        }

        #endregion

        #region Constructors

        public WatermarkTool()
        {
            this.settings = new WatermarkToolSettings();

            this.settings.open.Click += new RoutedEventHandler(Open_Click);

            Uri imageUri = ImageExampleHelper.GetResourceUri("Images/telerik-logo.png");
            this.watermarkBitmap = new RadBitmap(Application.GetResourceStream(imageUri).Stream);

            this.watermarkImage = new Image();
            this.watermarkImage.Source = new BitmapImage(imageUri);
            this.watermarkImage.Stretch = Stretch.None;

            this.watermarkCommand = new WatermarkCommand();
            this.imageRotateTransform = new RotateTransform();
            this.imageScaleTransform = new ScaleTransform();
            this.imageEditorScale = new ScaleTransform();

            TransformGroup transform = new TransformGroup();
            transform.Children.Add(this.imageRotateTransform);
            transform.Children.Add(this.imageScaleTransform);
            transform.Children.Add(this.imageEditorScale);
            this.watermarkImage.RenderTransform = transform;

            this.watermarkImage.RenderTransformOrigin = new Point(0.5, 0.5);
            this.watermarkImage.HorizontalAlignment = HorizontalAlignment.Center;
            this.watermarkImage.VerticalAlignment = VerticalAlignment.Center;

            this.settings.opacity.ValueChanged += new EventHandler(settings_ValueChanged);
            this.settings.rotation.ValueChanged += new EventHandler(settings_ValueChanged);
            this.settings.scale.ValueChanged += new EventHandler(settings_ValueChanged);

            Binding opacityBinding = new Binding("Value");
            opacityBinding.Source = this.settings.opacity;
            BindingOperations.SetBinding(this.watermarkImage, Image.OpacityProperty, opacityBinding);

            Binding rotationBinding = new Binding("Value");
            rotationBinding.Source = this.settings.rotation;
            BindingOperations.SetBinding(this.imageRotateTransform, RotateTransform.AngleProperty, rotationBinding);

            Binding scaleXBinding = new Binding("Value");
            scaleXBinding.Source = this.settings.scale;
            BindingOperations.SetBinding(this.imageScaleTransform, ScaleTransform.ScaleXProperty, scaleXBinding);

            Binding scaleYBinding = new Binding("Value");
            scaleYBinding.Source = this.settings.scale;
            BindingOperations.SetBinding(this.imageScaleTransform, ScaleTransform.ScaleYProperty, scaleYBinding);

        }

        #endregion

        #region Event Handlers

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Images (*.png)|*.png|JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg|All images|*.png;*.jpg;*.jpeg";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == true)
            {
                Stream fileStream = ofd.OpenFile();

                // Open the selected file to read.
                using (fileStream)
                {
                    this.watermarkBitmap = new RadBitmap(fileStream);
                    this.watermarkImage.Source = this.watermarkBitmap.Bitmap;
                }
            }
        }

        private void settings_ValueChanged(object sender, EventArgs e)
        {
            this.isDirty = true;
        }

        private void currnetEditor_ScaleFactorChanged(object sender, EventArgs e)
        {
            this.UpdateScaleFactor();
        }

        #endregion

        #region Methods

        public IImageCommand GetCommand()
        {
            return this.watermarkCommand;
        }

        public object GetContext()
        {
            return new WatermarkCommandContext(this.settings.opacity.Value, this.settings.rotation.Value,
                this.settings.scale.Value, this.watermarkBitmap);
        }

        #region radimageeditor-howto-custom-tool_4
        public void AttachUI(ToolInitInfo previewInitInfo)
        {
            this.currnetEditor = previewInitInfo.ImageEditor;
            this.previewPanel = previewInitInfo.PreviewPanel;

            this.currnetEditor.ScaleFactorChanged += currnetEditor_ScaleFactorChanged;
            this.previewPanel.SizeChanged += currnetEditor_ScaleFactorChanged;
            this.previewPanel.Children.Add(this.watermarkImage);

            this.UpdateScaleFactor();
        }

        public void DetachUI()
        {
            this.currnetEditor.ScaleFactorChanged -= currnetEditor_ScaleFactorChanged;
            this.previewPanel.SizeChanged -= currnetEditor_ScaleFactorChanged;

            this.previewPanel.Children.Clear();
            this.currnetEditor = null;
            this.previewPanel = null;
        }

        public void ResetSettings()
        {
            this.isDirty = false;
            this.settings.opacity.Value = DefaultOpacity;
            this.settings.rotation.Value = DefaultRotation;
            this.settings.scale.Value = DefaultScale;
        }
        #endregion

        private void UpdateScaleFactor()
        {
            if (this.currnetEditor != null)
            {
                double scale = this.currnetEditor.ActualScaleFactor;
                this.imageEditorScale.ScaleX = scale;
                this.imageEditorScale.ScaleY = scale;
            }
        }

        public UIElement GetSettingsUI()
        {
            this.ResetSettings();
            return this.settings;
        }
        #endregion
    }

    public class ImageExampleHelper
    {
        internal static Uri GetResourceUri(string p)
        {
            throw new NotImplementedException();
        }
    }

    #region radimageeditor-howto-custom-tool_2
    public class WatermarkCommandContext
    {
        public double Opacity { get; private set; }
        public double Rotation { get; private set; }
        public double Scale { get; private set; }
        public RadBitmap Image { get; private set; }

        public WatermarkCommandContext(double opacity, double rotation, double scale, RadBitmap image)
        {
            this.Opacity = opacity;
            this.Rotation = rotation;
            this.Scale = scale;
            this.Image = image;
        }
    }
    #endregion
}
