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
       
        #region radpropertygrid-features-validation_2
        public string this[string columnName]
        {
            get
            {
                if (columnName == "IntProp")
                {
                    return this.IntProp < 100 && this.IntProp > 0 ? string.Empty : "Value should be in the range of (0, 100)";
                }
                if (columnName == "StringProp")
                {
                    return this.StringProp != null && Regex.IsMatch(this.StringProp, @"^[0-9]+[\p{L}]*") ? string.Empty : @"Value should math the regex: ^[0-9]+[\p{L}]*";
                }
                if (columnName == "DateTimeProp")
                {
                    return this.DateTimeProp.Year > 1900 ? string.Empty : "Date should be after 1/1/1900";
                }
                return string.Empty;
            }
        }
        #endregion

        #region  radpropertygrid-features-validation_3
        void rpg_AutoGeneratingPropertyDefinition(object sender, Telerik.Windows.Controls.Data.PropertyGrid.AutoGeneratingPropertyDefinitionEventArgs e)
        {
            (e.PropertyDefinition.Binding as Binding).ValidatesOnDataErrors = true;
            (e.PropertyDefinition.Binding as Binding).NotifyOnValidationError = true;
        }
        #endregion

        #region  radpropertygrid-features-validation_4
        [Required(ErrorMessage = "This field is Required.")]
        public string RequiredField
        {
            get { return requiredField; }
            set
            {
                requiredField = value;
                ValidateProperty("RequiredField", value);
                this.OnPropertyChanged("RequiredField");
            }
        }
        #endregion

        #region  radpropertygrid-features-validation_5
        public void ValidateProperty(string propName, object value)
        {
            var result = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            Validator.TryValidateProperty(value, new ValidationContext(this, null, null) { MemberName = propName }, result);

            if (result.Count > 0)
            {
                throw new ValidationException(result[0].ErrorMessage);
            }
        }
        #endregion

        #region  radpropertygrid-features-validation_6
        void rpg_AutoGeneratingPropertyDefinition(object sender, Telerik.Windows.Controls.Data.PropertyGrid.AutoGeneratingPropertyDefinitionEventArgs e)
        {
            (e.PropertyDefinition.Binding as Binding).ValidatesOnExceptions = true;
        }
        #endregion

    }

}
