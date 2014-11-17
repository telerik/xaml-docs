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

#region gridview-filtering-howto-save-and-load-filter-settings_0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace BasicFiltering
{
	public class FilterDescriptorProxy
	{
		public Telerik.Windows.Data.FilterOperator Operator { get; set; }
		public object Value { get; set; }
		public bool IsCaseSensitive { get; set; }
	}
	
	public class FilterSetting
	{
		public string ColumnUniqueName { get; set; }
		public List<object> SelectedDistinctValues = new List<object>();
		public FilterDescriptorProxy Filter1 { get; set; }
		public Telerik.Windows.Data.FilterCompositionLogicalOperator FieldFilterLogicalOperator { get; set; }
		public FilterDescriptorProxy Filter2 { get; set; }
	}

	public partial class SaveLoadSettings : Window
	{
		public static IEnumerable<FilterSetting> SaveColumnFilters(Telerik.Windows.Controls.GridView.GridViewDataControl grid)
		{
			IList<FilterSetting> settings = new List<FilterSetting>();

			foreach (Telerik.Windows.Data.IFilterDescriptor filter in grid.FilterDescriptors)
			{
				Telerik.Windows.Controls.GridView.IColumnFilterDescriptor columnFilter = filter as Telerik.Windows.Controls.GridView.IColumnFilterDescriptor;
				if (columnFilter != null)
				{
					FilterSetting setting = new FilterSetting();

					setting.ColumnUniqueName = columnFilter.Column.UniqueName;

					setting.SelectedDistinctValues.AddRange(columnFilter.DistinctFilter.DistinctValues);

					if (columnFilter.FieldFilter.Filter1.IsActive)
					{
						setting.Filter1 = new FilterDescriptorProxy();
						setting.Filter1.Operator = columnFilter.FieldFilter.Filter1.Operator;
						setting.Filter1.Value = columnFilter.FieldFilter.Filter1.Value;
						setting.Filter1.IsCaseSensitive = columnFilter.FieldFilter.Filter1.IsCaseSensitive;
					}

					setting.FieldFilterLogicalOperator = columnFilter.FieldFilter.LogicalOperator;

					if (columnFilter.FieldFilter.Filter2.IsActive)
					{
						setting.Filter2 = new FilterDescriptorProxy();
						setting.Filter2.Operator = columnFilter.FieldFilter.Filter2.Operator;
						setting.Filter2.Value = columnFilter.FieldFilter.Filter2.Value;
						setting.Filter2.IsCaseSensitive = columnFilter.FieldFilter.Filter2.IsCaseSensitive;
					}

					settings.Add(setting);
				}
			}

			return settings;
		}

		public static void LoadColumnFilters(Telerik.Windows.Controls.GridView.GridViewDataControl grid
			, IEnumerable<FilterSetting> savedSettings)
		{
			grid.FilterDescriptors.SuspendNotifications();

			foreach (FilterSetting setting in savedSettings)
			{
				Telerik.Windows.Controls.GridViewColumn column = grid.Columns[setting.ColumnUniqueName];

				Telerik.Windows.Controls.GridView.IColumnFilterDescriptor columnFilter = column.ColumnFilterDescriptor;

				foreach (object distinctValue in setting.SelectedDistinctValues)
				{
					columnFilter.DistinctFilter.AddDistinctValue(distinctValue);
				}

				if (setting.Filter1 != null)
				{
					columnFilter.FieldFilter.Filter1.Operator = setting.Filter1.Operator;
					columnFilter.FieldFilter.Filter1.Value = setting.Filter1.Value;
					columnFilter.FieldFilter.Filter1.IsCaseSensitive = setting.Filter1.IsCaseSensitive;
				}

				columnFilter.FieldFilter.LogicalOperator = setting.FieldFilterLogicalOperator;

				if (setting.Filter2 != null)
				{
					columnFilter.FieldFilter.Filter2.Operator = setting.Filter2.Operator;
					columnFilter.FieldFilter.Filter2.Value = setting.Filter2.Value;
					columnFilter.FieldFilter.Filter2.IsCaseSensitive = setting.Filter2.IsCaseSensitive;
				}
			}

			grid.FilterDescriptors.ResumeNotifications();
		}

	
		public SaveLoadSettings()
		{
			InitializeComponent();

			this.radGridView.ItemsSource = new NorthwindEntities().Customers;
		}

		private IEnumerable<FilterSetting> serializedSettings;

		private void OnSaveButtonClick(object sender, RoutedEventArgs e)
		{
			IEnumerable<FilterSetting> savedSettings = SaveColumnFilters(this.radGridView);
			
			// You can serialize the saved settings in any way that you like from here on.
			this.serializedSettings = savedSettings;
		}
		
		private void OnLoadButtonClick(object sender, RoutedEventArgs e)
		{
			// You should deserialize the settings from where you have serialized them.
			IEnumerable<FilterSetting> savedSettings = this.serializedSettings;

			LoadColumnFilters(this.radGridView, savedSettings);
		}
	}
}
#endregion

}
