using ImageEditorDocumentationSourceCode.Examples.radimageeditor_howto_custom_tool;
using System;
using System.Linq;
using Telerik.Windows.Media.Imaging.Tools.UI;

namespace ImageEditorDocumentationSourceCode.Examples
{
    #region radimageeditor-howto-custom-tool_3
    public partial class WatermarkToolSettings : ToolSettingsHeader
    {
        public WatermarkToolSettings()
        {
            InitializeComponent();

            this.opacity.Value = WatermarkTool.DefaultOpacity;
            this.scale.Value = WatermarkTool.DefaultScale;
            this.rotation.Value = WatermarkTool.DefaultRotation;
        }
    }
    #endregion
}