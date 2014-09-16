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

#region radrichtextbox-features-mail-merge_0
public class ExamplesDataContext
    {
        private List<Employee> employees = new List<Employee>()
                    {
                        new Employee()
                        {
                            FirstName = "Andrew",
                            LastName = "Fuller", 
                            JobTitle = "Director - Finance",
                        }, 
                        new Employee()
                        {
                            FirstName = "Nancy",
                            LastName = "Davolio", 
                            JobTitle = "Director - Human Resources",
                        },
                        new Employee()
                        {
                            FirstName = "Robert",
                            LastName = "King", 
                            JobTitle = "Engineering Design Manager",
                        },
                        new Employee()
                        {
                            FirstName = "Margaret",
                            LastName = "Peacock", 
                            JobTitle = "Finance & Investments Officer",
                        }
                    };
        public List<Employee> Employees
        {
            get
            {
                return employees;
            } 
        }
    }
#endregion

#region radrichtextbox-features-mail-merge_1
this.radRichTextBox.Document.MailMergeDataSource.ItemsSource = new ExamplesDataContext().Employees;
#endregion

#region radrichtextbox-features-mail-merge_2
MergeField field = new MergeField() { PropertyPath = "FirstName" };
#endregion

#region radrichtextbox-features-mail-merge_3
field.DisplayMode = FieldDisplayMode.Result; 

this.radRichTextBox.Document.ChangeFieldDisplayMode(field.FieldStart, FieldDisplayMode.Result); 

this.radRichTextBox.ChangeFieldDisplayMode(field.FieldStart, FieldDisplayMode.Result); 

this.radRichTextBox.Document.ChangeAllFieldsDisplayMode(FieldDisplayMode.Result); 

this.radRichTextBox.ChangeAllFieldsDisplayMode(FieldDisplayMode.Result);
#endregion

#region radrichtextbox-features-mail-merge_4
this.radRichTextBox.InsertField(field); 

this.radRichTextBox.InsertField(field, FieldDisplayMode.DisplayName);
#endregion            

#region radrichtextbox-features-mail-merge_5
this.radRichTextBox.PreviewFirstMailMergeDataRecord();

this.radRichTextBox.PreviewLastMailMergeDataRecord();

this.radRichTextBox.PreviewMailMergeDataRecordAtIndex(0);

this.radRichTextBox.PreviewNextMailMergeDataRecord();

this.radRichTextBox.PreviewPreviousMailMergeDataRecord();
#endregion

#region radrichtextbox-features-mail-merge_6
this.radRichTextBox.MailMergeCurrentRecord(); // returns a RadDocument that is the result of substituting the merge fields with the data from the current record. The current record can be specified through the MailMergeSource API:</para>

this.radRichTextBox.Document.MailMergeDataSource.MoveToFirst();

this.radRichTextBox.Document.MailMergeDataSource.MoveToLast();

this.radRichTextBox.Document.MailMergeDataSource.MoveToNext();

this.radRichTextBox.Document.MailMergeDataSource.MoveToPrevious();

this.radRichTextBox.Document.MailMergeDataSource.MoveToIndex(index);

this.radRichTextBox.MailMerge(false); // returns a RadDocument that is the result of Mail Merging all records. The parameter specifies if a page break should be inserted between the records (default value is true).
#endregion

}
