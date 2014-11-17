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

#region raddataform-customize-commands_0
void MoveCurrentToFirst()
void MoveCurrentToLast()
void MoveCurrentToNext()
void MoveCurrentToPrevious()
void BeginEdit()
void CommitEdit()
void Delete()
void CancelEdit()
void AddNew()
#endregion

#region raddataform-customize-commands_1
bool CanMoveCurrentToFirstExecute()
bool CanMoveCurrentToLastExecute()
bool CanMoveCurrentToNextExecute()
bool CanMoveCurrentToPreviousExecute()
bool CanBeginEditExecute()
bool CanCommitEditExecute()
bool CanDeleteExecute()
bool CanCancelEditExecute()
bool CanAddNewExecute()
#endregion

#region raddataform-customize-commands_2
public class CustomCommandProvider : DataFormCommandProvider
{
	public CustomCommandProvider() : base(null)
	{
	}
 
	public CustomCommandProvider(RadDataForm dataForm)
			: base(dataForm)
	{
		this.DataForm = dataForm;
	}
	//. . .
}

#endregion

#region raddataform-customize-commands_3
protected override void MoveCurrentToNext()
{
	if (this.DataForm != null)
	{
		this.DataForm.MoveCurrentToNext();
		this.DataForm.BeginEdit();
	}
}
 
protected override void MoveCurrentToPrevious()
{
	if (this.DataForm != null)
	{
		this.DataForm.MoveCurrentToPrevious();
		this.DataForm.BeginEdit();
	}
}

#endregion

#region raddataform-customize-commands_4
protected override void CommitEdit()
{
	MessageBoxResult result = MessageBox.Show("Commit changes for the current edit item?", "CommitEdit confirmation", MessageBoxButton.OKCancel);
	if (result == MessageBoxResult.OK)
	{
		if (this.DataForm != null && this.DataForm.ValidateItem())
		{
			this.DataForm.CommitEdit();
		}
	}			
}
 
protected override void CancelEdit()
{
	MessageBoxResult result = MessageBox.Show("Cancel changes for the current edit item?", "CancelEdit confirmation", MessageBoxButton.OKCancel);
	if (result == MessageBoxResult.OK)
	{
		if (this.DataForm != null)
		{
			this.DataForm.CancelEdit();
		}
	}	
}

#endregion
#region raddataform-customize-commands_5
this.RadDataForm1.CommandProvider = new CustomCommandProvider(this.RadDataForm1);
#endregion

}
