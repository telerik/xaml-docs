
#region radmaskedinput-howto-create-custom-tokens-0
using System.Linq;
using Telerik.Windows.Controls.MaskedInput.Tokens;

public class CustomToken : ITokenValidationRule
{

	#region ITokenValidationRule Members

	public bool IsRequired
	{
		get { throw new NotImplementedException(); }
	}

	public bool IsValid(char ch)
	{
		throw new NotImplementedException();
	}

	public char Token
	{
		get { throw new NotImplementedException(); }
	}

	public TokenTypes Type
	{
		get { throw new NotImplementedException(); }
	}

	public string ValidChars
	{
		get { throw new NotImplementedException(); }
	}

	#endregion
}
#endregion

#region radmaskedinput-howto-create-custom-tokens-1
using System.Linq;
using Telerik.Windows.Controls.MaskedInput.Tokens;

public class CustomToken : ITokenValidationRule
{
	#region ITokenValidationRule Members

	public bool IsRequired
	{
		get { return false; }
	}

	public bool IsValid(char ch)
	{
		throw new NotImplementedException();
	}

	public char Token
	{
		get { return '$'; }
	}

	public TokenTypes Type
	{
		get { return TokenTypes.AlphaNumeric; }
	}

	private string myValidChars = "0123456789#*";
	public string ValidChars
	{
		get { return myValidChars; }
	}

	#endregion
}
#endregion

#region radmaskedinput-howto-create-custom-tokens-2
public bool IsValid(char ch)
{
	return ValidChars.Contains(ch);
}
#endregion

#region radmaskedinput-howto-create-custom-tokens-3
using System.Linq;
using Telerik.Windows.Controls.MaskedInput.Tokens;

public class CustomToken : ITokenValidationRule
{
	#region ITokenValidationRule Members

	public bool IsRequired
	{
		get { return false; }
	}

	public bool IsValid(char ch)
	{
		return ValidChars.Contains(ch);
	}

	public char Token
	{
		get { return '$'; }
	}

	public TokenTypes Type
	{
		get { return TokenTypes.AlphaNumeric; }
	}

	private string myValidChars = "0123456789#*";
	public string ValidChars
	{
		get { return myValidChars; }
	}

	#endregion
}
#endregion

#region radmaskedinput-howto-create-custom-tokens-4
using System.Windows.Controls;
using Telerik.Windows.Controls.MaskedInput.Tokens;

namespace MaskedInputSample
{
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			TokenLocator.AddCustomValidationRule(new CustomToken());
			InitializeComponent();
		}
	}
}
#endregion

#region radmaskedinput-howto-create-custom-tokens-5
using System.Windows.Controls;
using Telerik.Windows.Controls.MaskedInput.Tokens;

namespace MaskedInputSample
{
	public partial class MainWindow : Window
	{
		public MainPage()
		{
			TokenLocator.AddCustomValidationRule(new CustomToken());
			InitializeComponent();
		}
	}
}
#endregion
