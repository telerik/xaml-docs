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
#region gridview-how-to-use-mixed-clr-dlr-properties_0
public override bool TryGetMember(GetMemberBinder binder, out object result)
{
    if (binder.Name == "IsReadOnly")
    {
        result = this.IsReadonly;
        return true;
    }
     
    if (this.dynamicFields.ContainsKey(binder.Name))
    {
        result = dynamicFields[binder.Name];
        return true;
    }
    else
    {
        result = null;
        return false;
    }
}
#endregion

}
