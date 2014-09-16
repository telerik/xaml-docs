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

#region gridview-pasting_0

private void radGridView1_Pasting(object sender, GridViewClipboardEventArgs e)
{
    e.Cancel = true;
}

private void radGridView1_PastingCellClipboardContent(object sender, GridViewCellClipboardEventArgs e)
{
   if (e.Cell.Column.UniqueName == "Company")
   {
      var companyName = e.Value.ToString();
      var company = this.EFContext.Companies.Where(c => c.Name == companyName).FirstOrDefault();
      if (company != null)
      {
          e.Value = company;
      }
      else
      {
          e.Cancel = true;
      }
   }
}
#endregion
}
