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

#region gridview-how-to-create-date-time-picker-column_0
public class Club
{
    public Club( string name, DateTime established, int stadiumCapacity )
    {
        this.Name = name;
        this.Established = established;
        this.StadiumCapacity = stadiumCapacity;
    }
    public string Name
    {
        get;
        set;
    }
    public DateTime? Established
    {
        get;
        set;
    }
    public int StadiumCapacity
    {
        get;
        set;
    }
    public static IEnumerable<Club> GetClubs()
    {
        ObservableCollection<Club> clubs = new ObservableCollection<Club>();
        clubs.Add( new Club( "Liverpool", new DateTime( 1892, 1, 1 ), 45362 ) );
        clubs.Add( new Club( "Manchester Utd.", new DateTime( 1878, 1, 1 ), 76212 ) );
        clubs.Add( new Club( "Chelsea", new DateTime( 1905, 1, 1 ), 42055 ) );
        clubs.Add( new Club( "Arsenal", new DateTime( 1886, 1, 1 ), 60355 ) );
        return clubs;
    }
}
#endregion

#region gridview-how-to-create-date-time-picker-column_1
this.radGridView.ItemsSource = Club.GetClubs();
#endregion

#region gridview-how-to-create-date-time-picker-column_2
public partial class DateTimePicker : UserControl
{
	public static readonly DependencyProperty SelectedDateProperty =
		DependencyProperty.Register("SelectedDate", typeof(DateTime?), typeof(DateTimePicker), new PropertyMetadata(null));

	public DateTimePicker()
	{
		InitializeComponent();
	}

	public DateTime? SelectedDate
	{
		get
		{
			return (DateTime?)this.GetValue(SelectedDateProperty);
		}
		set
		{
			this.SetValue(SelectedDateProperty, value);
		}
	}

	private void HandlePickersSelectionChanged()
	{
		if (this.Calendar.SelectedDate != null && this.TimePicker.SelectedTime != null)
		{
			this.SelectedDate = this.Calendar.SelectedDate + this.TimePicker.SelectedTime;
		}
	}

	private void OnTimePickerSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
	{
		this.HandlePickersSelectionChanged();
	}

	private void OnCalendarSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
	{
		this.HandlePickersSelectionChanged();
	}
}
#endregion

#region gridview-how-to-create-date-time-picker-column_3
public partial class DateTimePicker : UserControl
{
	public static readonly DependencyProperty SelectedDateProperty =
		DependencyProperty.Register("SelectedDate", typeof(DateTime?), typeof(DateTimePicker), new PropertyMetadata(null));

	public DateTimePicker_SL()
	{
		InitializeComponent();
	}

	public DateTime? SelectedDate
	{
		get
		{
			return (DateTime?)this.GetValue(SelectedDateProperty);
		}
		set
		{
			this.SetValue(SelectedDateProperty, value);
		}
	}

	private void HandlePickersSelectionChanged()
	{
		if (this.Calendar.SelectedDate != null && this.TimePicker.SelectedTime != null)
		{
			this.SelectedDate = this.Calendar.SelectedDate + this.TimePicker.SelectedTime;
		}
	}

	private void OnTimePickerSelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
	{
		this.HandlePickersSelectionChanged();
	}

	private void OnCalendarSelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
	{
		this.HandlePickersSelectionChanged();
	}
}
#endregion

#region gridview-how-to-create-date-time-picker-column_4
public class DateTimePickerColumn : GridViewBoundColumnBase
{
	public override FrameworkElement CreateCellEditElement(GridViewCell cell, object dataItem)
	{
		this.BindingTarget = DateTimePicker.SelectedDateProperty;
		var picker = new DateTimePicker();
		picker.SetBinding(this.BindingTarget, this.CreateValueBinding());
		return picker;
	}

	private Binding CreateValueBinding()
	{
		var valueBinding = new Binding();
		valueBinding.Mode = BindingMode.TwoWay;
		valueBinding.NotifyOnValidationError = true;
		valueBinding.ValidatesOnExceptions = true;
		valueBinding.UpdateSourceTrigger = UpdateSourceTrigger.Explicit;
		valueBinding.Path = new PropertyPath(this.DataMemberBinding.Path.Path);
		return valueBinding;
	}
}
#endregion

}
