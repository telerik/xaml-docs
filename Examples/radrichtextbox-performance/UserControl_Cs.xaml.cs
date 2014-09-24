using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Documents.Model;
using Telerik.Windows.Documents.UI;
using Telerik.Windows.Documents.UI.Layers;

namespace Performance
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
    }


    #region radrichtextbox-performance_0
    class MyCustomUILayerBuilder : UILayersBuilder
    {
        protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
        {
            base.BuildUILayersOverride(uiLayerContainer);
            uiLayerContainer.UILayers.Remove(DefaultUILayers.TableCellBordersResizeLayer);
        }
    }
    #endregion
}
