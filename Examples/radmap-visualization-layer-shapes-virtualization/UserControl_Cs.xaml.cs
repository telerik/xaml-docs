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

#region radmap-visualization-layer-shapes-virtualization_1
using System.Windows;
using System.Windows.Controls;

namespace ShapeVirtualization
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            this.mapShapeDataVirtualizationSource.BusyIndicator = this.busyIndicator;
            this.mapShapeDataVirtualizationSource.ReadAsync();
        }
    }
}
#endregion
#region radmap-visualization-layer-shapes-virtualization_3
using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Windows.Controls.Map;

namespace ShapeVirtualization
{
    public class ShapeDataVirtualizer : IMapItemsVirtualizationSource
    {
        private List<ExtendedDataProvider> sateData;
        private List<ExtendedDataProvider> countyData;
        private bool firstRequest = true;
        private WeakReference layer = null;

        public ShapeDataVirtualizer()
        {
            this.StartRead();
        }

        /// <summary>
        /// Gets or sets the layer this virtualization source belongs to.
        /// </summary>
        private VisualizationLayer Layer
        {
            get
            {
                if (this.layer != null
                    && this.layer.IsAlive)
                {
                    return this.layer.Target as VisualizationLayer;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                this.layer = value != null ? new WeakReference(value) : null;
            }
        }

        public void MapItemsRequest(object sender, MapItemsRequestEventArgs e)
        {
            if (this.firstRequest)
            {
                this.Layer = e.Layer;
                this.firstRequest = false;
            }

            this.QueryItems(e);
        }

        private void QueryItems(MapItemsRequestEventArgs e)
        {
            List<ExtendedDataProvider> shapes = null;
            if (this.sateData != null && this.countyData != null)
            {
                IEnumerable<ExtendedDataProvider> query;

                if (e.MinZoom < 8)
                {
                    // Sate zoom level 
                    query = from ExtendedDataProvider item in this.sateData
                            where this.ShouldBeAdded(e.Region, item)
                            select item;
                }
                else
                {
                    // County zoom level
                    query = from ExtendedDataProvider item in this.countyData
                            where this.ShouldBeAdded(e.Region, item)
                            select item;
                }

                shapes = query.ToList();
            }

            e.CompleteItemsRequest(shapes);
        }

        private bool ShouldBeAdded(LocationRect rect, ExtendedDataProvider item)
        {
            MapShapeData shape = item as MapShapeData;
            if (shape != null)
            {
                return rect.Intersect(shape.GeoBounds);
            }

            return rect.Contains(item.Location);
        }

        private void StartRead()
        {
            AsyncShapeFileReader stateReader = new AsyncShapeFileReader()
            {
                Source = new Uri("/ShapeVirtualization;component/Resources/usa_states.shp", UriKind.Relative),
                ToolTipFormat = "STATE_NAME"
            };

            stateReader.PreviewReadShapeDataCompleted += this.State_PreviewReadShapeDataCompleted;
            stateReader.ReadAsync();

            AsyncShapeFileReader cuntyReader = new AsyncShapeFileReader()
            {
                Source = new Uri("/ShapeVirtualization;component/Resources/County.shp", UriKind.Relative),
                ToolTipFormat = "{COUNTY} ({STATE})"
            };

            cuntyReader.PreviewReadShapeDataCompleted += this.County_PreviewReadShapeDataCompleted;
            cuntyReader.ReadAsync();
        }

        private void State_PreviewReadShapeDataCompleted(object sender, PreviewReadShapeDataCompletedEventArgs e)
        {
            this.sateData = e.Items;
            this.RefreshVisualizationLayer();
        }

        private void County_PreviewReadShapeDataCompleted(object sender, PreviewReadShapeDataCompletedEventArgs e)
        {
            this.countyData = e.Items;
            this.RefreshVisualizationLayer();
        }

        private void RefreshVisualizationLayer()
        {
            if (this.Layer != null)
            {
                this.Layer.RefreshVirtualSource();
            }
        }
    }
}
#endregion

}
