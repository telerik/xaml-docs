using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using Telerik.Windows.Documents.Model;
using Telerik.Windows.Documents.Model.Fields;
using Telerik.Windows.Documents.Model.Fields.CodeExpressions;
using Telerik.Windows.Documents.UI;

namespace CustomFields
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Default_Cs : UserControl
    {
        public Default_Cs()
        {
            InitializeComponent();
        }
    }

    #region radrichtextbox-features-custom-fields_0
    public class CustomField : CodeBasedField
    #endregion
    {
        #region radrichtextbox-features-custom-fields_1
        private static readonly string FieldType = "CUSTOMFIELD";
        public override string FieldTypeName
        {
            get
            {
                return CustomField.FieldType;
            }
        }
        #endregion

        #region radrichtextbox-features-custom-fields_2
        static CustomField()
        {
            CodeBasedFieldFactory.RegisterFieldType(CustomField.FieldType, () => new CustomField());
        }
        #endregion

        #region radrichtextbox-features-custom-fields_3
        public override Field CreateInstance()
        {
            return new CustomField();
        }
        #endregion

        #region radrichtextbox-features-custom-fields_4
        private readonly FieldProperty myProperty;
        #endregion

        #region radrichtextbox-features-custom-fields_5
        [XamlSerializable]
        public string MyProperty
        {
            get
            {
                return this.myProperty.GetValue();
            }
            set
            {
                if (!this.myProperty.IsNestedField && this.myProperty.GetValue() == value)
                {
                    return;
                }

                this.myProperty.SetValue(value);
                this.InvalidateCode();
            }
        }
        #endregion

        #region radrichtextbox-features-custom-fields_6
        public static readonly FieldPropertyDefinition MyPropertyProperty = new FieldPropertyDefinition("MyProperty");
        #endregion

        #region radrichtextbox-features-custom-fields_7
        public CustomField()
        {
            this.myProperty = new FieldProperty(this, CustomField.MyPropertyProperty);
        }
        #endregion

        #region radrichtextbox-features-custom-fields_8
        protected override void CopyPropertiesFromCodeExpression(FieldCodeExpression fieldCodeExpression)
        {
            base.CopyPropertiesFromCodeExpression(fieldCodeExpression);
            this.myProperty.SetValue(fieldCodeExpression.FieldArgumentNode);
        }

        #endregion

        #region radrichtextbox-features-custom-fields_9
        protected override void BuildCodeOverride()
        {
            base.BuildCodeOverride();
            this.CodeBuilder.SetFieldArgument(this.myProperty);
        }

        #endregion

        #region radrichtextbox-features-custom-fields_10
        public override void CopyPropertiesFrom(Field fromField)
        {
            base.CopyPropertiesFrom(fromField);
            CustomField customField = (CustomField)fromField;
            this.myProperty.CopyPropertiesFrom(customField.myProperty);
        }
        #endregion

        #region radrichtextbox-features-custom-fields_11
        protected override DocumentFragment GetResultFragment()
        {
            return DocumentFragment.CreateFromInline(new Span(this.MyProperty));
        }
        #endregion
    }
}