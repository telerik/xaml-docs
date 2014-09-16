using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Media.Imaging.Tools;

namespace ImageEditorDocumentationSourceCode.Examples.radimageeditor_howto_use_crop
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

        private void CreateToolInitialSize()
        {
            #region radimageeditor-howto-use-crop_0
            CropTool cropTool = new CropTool();
            cropTool.InitialSize = new Size(150, 150);
            #endregion
        }

        private void CreateToolFixedSize()
        {
            #region radimageeditor-howto-use-crop_1
            CropTool tool = new CropTool();
            tool.FixedSize = new Size(200, 100);
            #endregion
        }

        private void CreateToolAspectRatio()
        {
            #region radimageeditor-howto-use-crop_2
            CropTool tool = new CropTool();
            tool.AspectRatio = 0.5;
            #endregion
        }
    }
}
