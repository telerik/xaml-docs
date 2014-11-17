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

#region radmaskedinput-validation-regex_0
public class MaskedInputViewModel  : ViewModelBase
{
 private string email = "username@email.com";
 /// <summary>
 ///     Gets or sets the email.
 /// </summary>
 [RegularExpression(@"\b[a-z0-9._%-]+@[a-z0-9.-]+\.[a-z]{2,4}\b", ErrorMessage = "Invalid Email Address.")]
 public string Email
 {
  get
  {
   return this.email;
  }
  set
  {
   if (this.email != value)
   {
    Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Email" });
    this.email = value;
    OnPropertyChanged("Email");
   }
  }
 } private string webAddress = http://www.sampleaddress.com;
 /// <summary>
 ///     Gets or sets the webAddress.
 /// </summary>
 [RegularExpression(@"http://www.+\b[a-z0-9._%-]+\.[a-z]{2,4}\b", ErrorMessage = "Invalid Web Address.")]
 public string WebAddress
 {
  get
  {
   return this.webAddress;
  }
  set
  {
   if (this.webAddress != value)
   {
    Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "WebAddress" });
    this.webAddress = value;
    OnPropertyChanged("WebAddress");
   }
  }
 }
}
#endregion
}
