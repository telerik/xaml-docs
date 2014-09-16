using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;
using Telerik.Windows.Documents.Model;
using Telerik.Windows.Documents.Model.Fields;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs : UserControl
    {
        RadRichTextBox radRichTextBox;

        public Default_Cs()
        {
            InitializeComponent();
        }

        private void InsertField()
        {
            #region radrichtextbox-features-fields_0
            this.radRichTextBox.InsertField(new PageField());
            #endregion
        }

        private void UpdateField(FieldRangeStart fieldStart)
        {
            #region radrichtextbox-features-fields_1
            this.radRichTextBox.UpdateField(fieldStart);
            #endregion
        }

        private void ChangeUpdatePriority()
        {
            #region radrichtextbox-features-fields_2
            FieldsUpdateManager.RegisterFieldUpdatePriority(typeof(ReferenceField), 1000);
            #endregion
        }
    }





}
