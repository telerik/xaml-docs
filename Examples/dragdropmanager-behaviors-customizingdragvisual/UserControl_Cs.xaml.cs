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

    #region dragdropmanager-behaviors-customizingdragvisual_1
    public class DragVisualProvider : DependencyObject, IDragVisualProvider
    {
        public DataTemplate DraggedItemTemplate
        {
            get
            {
                return (DataTemplate)GetValue(DraggedItemTemplateProperty);
            }
            set
            {
                SetValue(DraggedItemTemplateProperty, value);
            }
        }

        public static readonly DependencyProperty DraggedItemTemplateProperty =
        DependencyProperty.Register("DraggedItemTemplate", typeof(DataTemplate), typeof(DragVisualProvider), new PropertyMetadata(null));

        public FrameworkElement CreateDragVisual(DragVisualProviderState state)
        {
            var visual = new DragVisual();

            var theme = StyleManager.GetTheme(state.Host);
            if (theme != null)
            {
                StyleManager.SetTheme(visual, theme);
            }

            visual.Content = state.DraggedItems.OfType<object>().FirstOrDefault();
            visual.ContentTemplate = this.DraggedItemTemplate;

            return visual;
        }

        public Point GetDragVisualOffset(DragVisualProviderState state)
        {
            return state.RelativeStartPoint;
        }

        public bool UseDefaultCursors { get; set; }
    }
    #endregion
}
