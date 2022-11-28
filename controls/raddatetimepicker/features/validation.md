---
title: Validation
page_title: Validation
description: Check our &quot;Validation&quot; documentation article for the RadDateTimePicker {{ site.framework_name }} control.
slug: raddatetimepicker-features-validation
tags: validation, idataerrorinfo
published: True
position: 6
---

# Validation

RadDateTimePicker supports data validation that can be implemented in the view model. 

The data validation can be done through the [IDataErrorInfo](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/data/how-to-implement-validation-logic-on-custom-objects?view=netframeworkdesktop-4.8) interface implemented in the view model of RadDateTimePicker. The following example shows how to enable the validation.

When the IDataErrorInfo interface is implemented, the validation logic executes when a property changes, which allows you to return an error message that will be displayed in the UI. 

#### __[C#] Example 1: View model with validation logic implementation__
{{region raddatetimepicker-features-validation-0}}
	public class ValidationViewModel : ViewModelBase, IDataErrorInfo
	{
		private DateTime date;
		public DateTime Date
		{
			get
			{
				return this.date;
			}
			set
			{
				if (this.date != value)
				{
					this.date = value;
					this.OnPropertyChanged("Date");
				}
			}
		}

		public string Error
		{
			get
			{
				return null;
			}
		}

		public string this[string columnName]
		{
			get
			{
				if (columnName == nameof(Date))
				{
					return this.ValidateDate();
				}
				return null;
			}
		}

		private string ValidateDate()
		{
			if ((this.date.DayOfWeek == DayOfWeek.Saturday) || (this.date.DayOfWeek == DayOfWeek.Sunday))
			{
				return "This date is in the weekend. Please choose a weekday.";
			}
			return null;
		}
	}
{{endregion}}

To show the data error, set the __ValidatesOnDataErrors__ property of the Binding to True.

#### __[XAML] Example 2: RadDateTimePicker definition and ValidatesOnDataErrors setting__
{{region raddatetimepicker-features-validation-1}}
	<telerik:RadDateTimePicker SelectedValue="{Binding Date, Mode=TwoWay, ValidatesOnDataErrors=True}" />
{{endregion}}

#### __[C#] Example 3: Setting the view model__
{{region raddatetimepicker-features-validation-2}}
	public MainWindow()
	{
		InitializeComponent();
		this.DataContext = new ValidationViewModel() { Date = DateTime.Now }; 
	}
{{endregion}}

![WPF RadDateTimePicker ](images/raddatetimepicker-features-validation-0.png)

## See Also  
 * [Overview]({%slug raddatetimepicker-overview%})
 * [Visual Structure]({%slug raddatetimepicke-visual-structure%})
 * [Input Modes]({%slug raddatetimepicker-features-input-modes%})
 * [ViewModelBase]({%slug common-viewmodelbase-class%})
