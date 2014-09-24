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

#region raddataform-defining-custom-datafields_0
    public class DataFormNumericUpDownField : DataFormDataField
    {
        protected override DependencyProperty GetControlBindingProperty()
        {
            return RadNumericUpDown.ValueProperty;
        }

        protected override Control GetControl()
        {
            DependencyProperty dependencyProperty = this.GetControlBindingProperty();
            RadNumericUpDown numericUpDown = new RadNumericUpDown();
            if (this.DataMemberBinding != null)
            {
                var binding = this.DataMemberBinding;
                numericUpDown.SetBinding(dependencyProperty, binding);
            }
            numericUpDown.SetBinding(RadNumericUpDown.IsEnabledProperty, new Binding("IsReadOnly") { Source = this, Converter = new InvertedBooleanConverter() });

            return numericUpDown;
        }
    }
#endregion
    #region raddataform-defining-custom-datafields_1
    private void RadDataForm_AutoGeneratingField(object sender, Telerik.Windows.Controls.Data.DataForm.AutoGeneratingFieldEventArgs e)
		{
			if (e.DataField.Label.Equals("Number"))
			{
				e.DataField = new DataFormNumericUpDownField() {Label = e.DataField.Label, DataMemberBinding = e.DataField.DataMemberBinding };
			}
		}
#endregion
}
