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
#region radmaskedinput-features-validation_1
public class DataValidationViewModel : ViewModelBase
{
	private double doubleValue;
	private string stringValue;
	private decimal decimalValue;
	private DateTime dateTimeValue;

	public double DoubleValue 
	{
		get { return doubleValue; }
		set 
        {
			if (value < -100 || value > 100) 
            {
				throw new ValidationException(String.Format("Value is {0} than {1}.", (value > 100 ? "greater" : "less"), value));
			}
			doubleValue = value;
			this.OnPropertyChanged("DoubleValue");
		}
	}

	public decimal DecimalValue 
	{
		get { return decimalValue; }
		set 
        {
			if (value < -100 || value > 100) 
            {
				throw new ValidationException(String.Format("Value is {0} than {1}.", (value > 100 ? "greater" : "less"), value));
			}
			decimalValue = value;
			this.OnPropertyChanged("DecimalValue");
		}
	}

	public DateTime DateTimeValue 
	{
		get { return dateTimeValue; }
		set 
        {
			if (value < DateTime.Parse("01.01.1900") || value > DateTime.Parse("01.01.2099")) 
            {
				throw new ValidationException(String.Format("Value is {0} than {1}.", (value > DateTime.Parse("01.01.2099") ? "greater" : "less"), value));
			}
			dateTimeValue = value;
			this.OnPropertyChanged("DateTimeValue");
		}
	}

	public string StringValue 
	{
		get { return stringValue; }
		set 
        {
			if (value.Length > 6) 
            {
				throw new ValidationException(String.Format("Value's length is greater than {0}.", value.Length));
			}
			stringValue = value;
			this.OnPropertyChanged("StringValue");
		}
	}
}
#endregion

#region radmaskedinput-features-validation_0
public class DataValidationViewModel : ViewModelBase
{
        private double doubleValue;
		private string stringValue;
		private decimal decimalValue;
		private DateTime dateTimeValue;
		[Range(-100d, 100d)]
		public double DoubleValue
		{
			get { return doubleValue; }
			set
			{
				doubleValue = value;
				this.OnPropertyChanged("DoubleValue");
			}
		}
		[Range(typeof(decimal), "-100", "100")]
		public decimal DecimalValue
		{
			get { return decimalValue; }
			set
			{
				decimalValue = value;
				this.OnPropertyChanged("DecimalValue");
			}
		}
		[Range(typeof(DateTime), "01.01.1900", "01.01.2099")]
		public DateTime DateTimeValue
		{
			get { return dateTimeValue; }
			set
			{
				dateTimeValue = value;
				this.OnPropertyChanged("DateTimeValue");
			}
		}
		[StringLength(6)]
		[Required()]
		public string StringValue
		{
			get { return stringValue; }
			set
			{
				stringValue = value;
				this.OnPropertyChanged("StringValue");
			}
		}
	}
}
#endregion

#region radmaskedinput-features-validation_3
this.DataContext = new DataValidationViewModel();
#endregion

#region radmaskedinput-features-validation_5
public class DataAnnotationAttributesValidationViewModel : ViewModelBase
{
		private double doubleValue;
		private string stringValue;
		private decimal decimalValue;
		private DateTime dateTimeValue;
		[Range(-100d, 100d)]
		public double DoubleValue
		{
			get { return doubleValue; }
			set
			{
				Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "DoubleValue" });
				doubleValue = value;
				this.OnPropertyChanged("DoubleValue");
			}
		}
		[Range(typeof(decimal), "-100", "100")]
		public decimal DecimalValue
		{
			get { return decimalValue; }
			set
			{
				Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "DecimalValue" });
				decimalValue = value;
				this.OnPropertyChanged("DecimalValue");
			}
		}
		[Range(typeof(DateTime), "01.01.1900", "01.01.2099")]
		public DateTime DateTimeValue
		{
			get { return dateTimeValue; }
			set
			{
				Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "DateTimeValue" });
				dateTimeValue = value;
				this.OnPropertyChanged("DateTimeValue");
			}
		}
		[StringLength(6)]
		[Required()]
		public string StringValue
		{
			get { return stringValue; }
			set
			{
				Validator.ValidateProperty(value, new ValidationContext(this, null, null) {MemberName = "StringValue"});
				stringValue = value;
				this.OnPropertyChanged("StringValue");
			}
		}
	}
}

#endregion

#region radmaskedinput-features-validation_8
this.DataContext = new DataAnnotationAttributesValidationViewModel();
#endregion


}
