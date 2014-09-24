using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Telerik.Windows.Documents.Spreadsheet.Expressions;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace FeaturesCustomFunctions
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void RegisteringArgumentsFunction()
        {
            #region radspreadprocessing-features-formulas-custom-functions_0
            FunctionManager.RegisterFunction(new ArgumentsFunction());
            #endregion
        }

        #region radspreadprocessing-features-formulas-custom-functions_1
        public static readonly ArgumentConversionRules BoolFunctionConversion = new ArgumentConversionRules(
                    emptyIndirectArgument: ArgumentInterpretation.Ignore,
                    textNumberDirectArgument: ArgumentInterpretation.TreatAsError,
                    textNumberIndirectArgument: ArgumentInterpretation.Ignore,
                    nonTextNumberDirectArgument: ArgumentInterpretation.TreatAsError,
                    nonTextNumberIndirectArgument: ArgumentInterpretation.Ignore,
                    arrayArgument: ArrayArgumentInterpretation.UseAllElements);
        #endregion

        public void FunctionInfo()
        {
            #region radspreadprocessing-features-formulas-custom-functions_2
            string functionName = "ADD";

            string description = "Adds all the numbers in range of cells.";

            IEnumerable<ArgumentInfo> requiredArguments = new ArgumentInfo[]
	        {
		        new ArgumentInfo("Number", "number1, number2,... are the numbers to sum. Logical values and text are ignored in cells, included if typed as arguments.", ArgumentType.Number),
	        };

            IEnumerable<ArgumentInfo> optionalArguments = new ArgumentInfo[]
	        {
		        new ArgumentInfo("Number", "number1, number2,... are the numbers to sum. Logical values and text are ignored in cells, included if typed as arguments.", ArgumentType.Number),
	        };

            FunctionInfo sumFunctionInfo = new FunctionInfo(functionName, FunctionCategory.MathTrig, description, requiredArguments, optionalArguments, 254, true);

            #endregion
        }

        private class ArgumentsFunction : FunctionBase
        {
            protected override RadExpression EvaluateOverride(RadExpression[] arguments)
            {
                // TODO: Implement this method
                throw new NotImplementedException();
            }

            public override string Name
            {
                get
                {
                    // TODO: Implement this property getter
                    throw new NotImplementedException();
                }
            }

            public override FunctionInfo FunctionInfo
            {
                get
                {
                    // TODO: Implement this property getter
                    throw new NotImplementedException();
                }
            }
        }
    }

    #region radspreadprocessing-features-formulas-custom-functions_3

    public class Arguments : FunctionBase
    {
        public static readonly string FunctionName = "ARGUMENTS";
        private static readonly FunctionInfo Info;

        public override string Name
        {
            get
            {
                return FunctionName;
            }
        }

        public override FunctionInfo FunctionInfo
        {
            get
            {
                return Info;
            }
        }

        static Arguments()
        {
            string description = "Returns number of used arguments.";

            IEnumerable<ArgumentInfo> requiredArguments = new ArgumentInfo[]
		{
			new ArgumentInfo("First", "First argument.", ArgumentType.Any),
			new ArgumentInfo("Second", "Second argument.", ArgumentType.Any),
			new ArgumentInfo("Third", "Third argument.", ArgumentType.Any),
		};

            IEnumerable<ArgumentInfo> optionalArguments = new ArgumentInfo[]
		{
			new ArgumentInfo("First", "First argument.", ArgumentType.Any),
			new ArgumentInfo("Second", "Second argument.", ArgumentType.Any),
			new ArgumentInfo("Third", "Third argument.", ArgumentType.Any),
		};

            Info = new FunctionInfo(FunctionName, FunctionCategory.MathTrig, description, requiredArguments, optionalArguments, optionalArgumentsRepeatCount: 3);
        }

        protected override RadExpression EvaluateOverride(RadExpression[] arguments)
        {
            return new NumberExpression(arguments.Length);
        }
    }
    #endregion

    #region radspreadprocessing-features-formulas-custom-functions_4
    public class E : FunctionBase
    {
        public static readonly string FunctionName = "E";
        private static readonly FunctionInfo Info;

        public override string Name
        {
            get
            {
                return FunctionName;
            }
        }

        public override FunctionInfo FunctionInfo
        {
            get
            {
                return Info;
            }
        }

        static E()
        {
            string description = "Returns the Napier's constant.";

            Info = new FunctionInfo(FunctionName, FunctionCategory.MathTrig, description);
        }

        protected override RadExpression EvaluateOverride(RadExpression[] arguments)
        {
            return NumberExpression.E;
        }
    }
    #endregion

    #region radspreadprocessing-features-formulas-custom-functions_5
    public class RepeatString : FunctionWithArguments
    {
        public static readonly string FunctionName = "REPEAT.STRING";
        private static readonly FunctionInfo Info;

        public override string Name
        {
            get
            {
                return FunctionName;
            }
        }

        public override FunctionInfo FunctionInfo
        {
            get
            {
                return Info;
            }
        }

        static RepeatString()
        {
            IEnumerable<ArgumentInfo> requiredArguments = new ArgumentInfo[]
            {
                 new ArgumentInfo("Text", "Text is the text you want to repeat.", ArgumentType.Text)
            };

            IEnumerable<ArgumentInfo> optionalArguments = new ArgumentInfo[]
            {
                new ArgumentInfo("NumberTimes", "NumberTimes is a positive number specifying the number of times to repeat text.", ArgumentType.Number)
            };

            string description = "REPEAT.STRING repeats some text a desired number of times.";

            Info = new FunctionInfo(FunctionName, FunctionCategory.Text, description, requiredArguments, optionalArguments, 1, false);
        }

        protected override RadExpression EvaluateOverride(object[] arguments)
        {
            string text = arguments[0].ToString();

            double numberTimes = 1;
            if (arguments.Length > 1)
            {
                numberTimes = (double)arguments[1];
            }
            StringBuilder builder = new StringBuilder();

            if (numberTimes < 0)
            {
                return ErrorExpressions.ValueError;
            }

            for (int i = 0; i < numberTimes; i++)
            {
                builder.Append(text);
            }

            return new StringExpression(builder.ToString());
        }
    }

    #endregion

    #region radspreadprocessing-features-formulas-custom-functions_6
    public class Add : NumbersInFunction
    {
        public static readonly string FunctionName = "ADD";
        private static readonly FunctionInfo Info;

        public override ArgumentConversionRules ArgumentConversionRules
        {
            get
            {
                return ArgumentConversionRules.NaryIgnoreIndirectNumberFunctionConversion;
            }
        }

        public override string Name
        {
            get
            {
                return FunctionName;
            }
        }

        public override FunctionInfo FunctionInfo
        {
            get
            {
                return Info;
            }
        }

        static Add()
        {
            #region FunctionInfo

            string description = "Adds all the numbers in range of cells.";

            IEnumerable<ArgumentInfo> requiredArguments = new ArgumentInfo[]
	        {
		        new ArgumentInfo("Number", "number1, number2,... are the numbers to sum. Logical values and text are ignored in cells, included if typed as arguments.", ArgumentType.Number),
	        };

            IEnumerable<ArgumentInfo> optionalArguments = new ArgumentInfo[]
	        {
		        new ArgumentInfo("Number", "number1, number2,... are the numbers to sum. Logical values and text are ignored in cells, included if typed as arguments.", ArgumentType.Number),
	        };

            Info = new FunctionInfo(FunctionName, FunctionCategory.MathTrig, description, requiredArguments, optionalArguments, 254, true);

            #endregion
        }

        protected override Telerik.Windows.Documents.Spreadsheet.Expressions.RadExpression EvaluateOverride(double[] arguments)
        {
            double result = 0;

            for (int i = 0; i < arguments.Length; i++)
            {
                result += arguments[i];
            }

            if (double.IsInfinity(result))
            {
                return ErrorExpressions.NumberError;
            }

            return new NumberExpression(result);
        }
    }

    #endregion

    #region radspreadprocessing-features-formulas-custom-functions_7
    class GeoMean : NumbersInFunction
    {
        public static readonly string FunctionName = "GEOMEAN";
        private static readonly FunctionInfo info;
        private static readonly ArgumentConversionRules conversionRules = new ArgumentConversionRules(
            nonTextNumberDirectArgument: ArgumentInterpretation.TreatAsError,
            nonTextNumberIndirectArgument: ArgumentInterpretation.TreatAsError,
            emptyIndirectArgument: ArgumentInterpretation.Ignore,
            emptyDirectArgument: ArgumentInterpretation.Ignore,
            arrayArgument: ArrayArgumentInterpretation.UseAllElements);

        public override ArgumentConversionRules ArgumentConversionRules
        {
            get
            {
                return GeoMean.conversionRules;
            }
        }

        public override string Name
        {
            get
            {
                return FunctionName;
            }
        }

        public override FunctionInfo FunctionInfo
        {
            get
            {
                return info;
            }
        }

        static GeoMean()
        {
            string description = "Returns the geometric mean of a sequance of numbers.";

            IEnumerable<ArgumentInfo> requiredArguments = new ArgumentInfo[]
            {
                new ArgumentInfo("Number", "Positive number", ArgumentType.Number),
            };

            IEnumerable<ArgumentInfo> optionalArguments = new ArgumentInfo[]
            {
                new ArgumentInfo("Number", "Positive number", ArgumentType.Number)
            };

            info = new FunctionInfo(FunctionName, FunctionCategory.Statistical, description, requiredArguments, optionalArguments, optionalArgumentsRepeatCount: 255);
        }

        protected override RadExpression EvaluateOverride(double[] arguments)
        {
            double product = 1;

            foreach (double argument in arguments)
            {
                if (argument <= 0)
                {
                    return ErrorExpressions.NumberError;
                }

                product *= argument;
            }

            double result = Math.Pow(product, 1.0 / arguments.Length);

            return new NumberExpression(result);
        }
    }

    #endregion

    #region radspreadprocessing-features-formulas-custom-functions_8

    public class Nand : BooleansInFunction
    {
        public static readonly string FunctionName = "NAND";
        private static readonly FunctionInfo Info;

        public override string Name
        {
            get
            {
                return FunctionName;
            }
        }

        public override FunctionInfo FunctionInfo
        {
            get
            {
                return Info;
            }
        }

        static Nand()
        {
            string description = "Returns the Sheffer stroke (or also known as the NAND operator) of two booleans.";

            IEnumerable<ArgumentInfo> requiredArguments = new ArgumentInfo[]
            {
                new ArgumentInfo("Logical", "The first logical argument.", ArgumentType.Logical),
                new ArgumentInfo("Logical", "The second logical argument.", ArgumentType.Logical)
            };

            Info = new FunctionInfo(FunctionName, FunctionCategory.Text, description, requiredArguments);
        }

        protected override RadExpression EvaluateOverride(bool[] arguments)
        {
            bool result = !(arguments[0] & arguments[1]);

            return result ? BooleanExpression.True : BooleanExpression.False;
        }
    }
    #endregion
}

namespace SpreadsheetDocumentationSourceCode.Examples.radspreadsheet_features_formulas_custom_functions
{
    #region radspreadprocessing-features-formulas-custom-functions_9

    public class Upper : StringsInFunction
    {
        public static readonly string FunctionName = "UPPER";
        private static readonly FunctionInfo Info;

        public override string Name
        {
            get
            {
                return FunctionName;
            }
        }

        public override FunctionInfo FunctionInfo
        {
            get
            {
                return Info;
            }
        }

        static Upper()
        {
            string description = "Converts text to uppercase.";

            IEnumerable<ArgumentInfo> requiredArguments = new ArgumentInfo[]
            {
                new ArgumentInfo("Text", "Text is the text you want converted to uppercase. Text can be a reference or text string.", ArgumentType.Text)
            };

            Info = new FunctionInfo(FunctionName, FunctionCategory.Text, description, requiredArguments);
        }

        protected override RadExpression EvaluateOverride(string[] arguments)
        {
            string text = arguments[0];

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char c = char.ToUpperInvariant(text[i]);
                builder.Append(c);
            }

            return new StringExpression(builder.ToString());
        }
    }
    #endregion
}
