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

#region gridview-filtering-custom-filtering-controls_0
/// <summary>
/// Provides functionality required by all filtering components.
/// </summary>
public interface IFilteringControl
{
	/// <summary>
	/// Prepares the component for the column it will service.
	/// </summary>
	/// <param name="column">The column to prepare for.</param>
	void Prepare(GridViewColumn column);

	/// <summary>
	/// Gets a value indicating whether the filtering is active.
	/// </summary>
	bool IsActive { get; set; }
}
#endregion

#region gridview-filtering-custom-filtering-controls_1
/// <summary>
/// FromDateToDateFilterControl
/// </summary>
public partial class FromDateToDateFilterControl : UserControl, IFilteringControl
{
	private GridViewBoundColumnBase column;
	private CompositeFilterDescriptor compositeFilter;
	private Telerik.Windows.Data.FilterDescriptor fromFilter;
	private Telerik.Windows.Data.FilterDescriptor toFilter;

	/// <summary>
	/// Gets or sets a value indicating whether the filtering is active.
	/// </summary>
	public bool IsActive
	{
		get { return (bool)GetValue(IsActiveProperty); }
		set { SetValue(IsActiveProperty, value); }
	}

	/// <summary>
	/// Identifies the <see cref="IsActive"/> dependency property.
	/// </summary>
	public static readonly DependencyProperty IsActiveProperty =
		DependencyProperty.Register(
			"IsActive",
			typeof(bool),
			typeof(FromDateToDateFilterControl),
			new System.Windows.PropertyMetadata(false));

	[TypeConverter(typeof(DateTimeTypeConverter))]
	public DateTime FromDate
	{
		get { return this.fromDatePicker.SelectedDate.GetValueOrDefault(DateTime.MinValue); }
		set { this.fromDatePicker.SelectedDate = value; }
	}

	[TypeConverter(typeof(DateTimeTypeConverter))]
	public DateTime ToDate
	{
		get { return this.toDatePicker.SelectedDate.GetValueOrDefault(DateTime.MaxValue); }
		set { this.toDatePicker.SelectedDate = value; }
	}

	public RadDatePicker FromPicker
	{
		get { return this.fromDatePicker; }
	}

	public RadDatePicker ToPicker
	{
		get { return this.toDatePicker; }
	}

	public FromDateToDateFilterControl()
	{
		InitializeComponent();
	}

	public void Prepare(Telerik.Windows.Controls.GridViewColumn column)
	{
		this.column = column as GridViewBoundColumnBase;
		if (this.column == null)
		{
			return;
		}

		if (this.compositeFilter == null)
		{
			this.CreateFilters();
		}

		this.fromFilter.Value = this.FromDate;
		this.toFilter.Value = this.ToDate;
	}

	private void CreateFilters()
	{
		string dataMember = this.column.DataMemberBinding.Path.Path;

		this.compositeFilter = new CompositeFilterDescriptor();

		this.fromFilter = new Telerik.Windows.Data.FilterDescriptor(dataMember
			, Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo
			, null);
		this.compositeFilter.FilterDescriptors.Add(this.fromFilter);

		this.toFilter = new Telerik.Windows.Data.FilterDescriptor(dataMember
			, Telerik.Windows.Data.FilterOperator.IsLessThanOrEqualTo
			, null);
		this.compositeFilter.FilterDescriptors.Add(this.toFilter);
	}

	private void OnFilter(object sender, RoutedEventArgs e)
	{
		this.fromFilter.Value = this.FromDate;
		this.toFilter.Value = this.ToDate;

		if (!this.column.DataControl.FilterDescriptors.Contains(this.compositeFilter))
		{
			this.column.DataControl.FilterDescriptors.Add(this.compositeFilter);
		}

		this.IsActive = true;
	}

	private void OnClear(object sender, RoutedEventArgs e)
	{
		if (this.column.DataControl.FilterDescriptors.Contains(this.compositeFilter))
		{
			this.column.DataControl.FilterDescriptors.Remove(this.compositeFilter);
		}

		this.FromDate = new DateTime(1990, 1, 1);
		this.ToDate = new DateTime(1995, 1, 1);

		this.IsActive = false;
	}
}

#endregion
}
