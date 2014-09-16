---
title: Custom Functions
page_title: Custom Functions
description: Custom Functions
slug: radspreadsheet-features-formulas-custom-functions
tags: custom,functions
publish: False
position: 4
---

# Custom Functions



* [
              Inheriting FunctionBase abstract class
            ](#inheriting-functionbase-abstract-class)

* [
              Functions inheritance tree
            ](#functions-inheritance-tree)

* [
              ArgumentConversionRules
            ](#argumentconversionrules)

* [
              FunctionInfo
            ](#functioninfo)

* [
              Custom Function Examples
            ](#custom-function-examples)

## Inheriting FunctionBase abstract class

RadSpreadsheet provides powerful API for creating custom functions. All functions must inherit from the abstract FunctionBase class, providing basic methods and properties for each function instance.
        

Here are listed the basic FunctionBase members:
        

* __Name__ – property of type String, defining the name of the function. This property is used for registering the function in RadSpreadsheet, so the name of the function must be unique (case insensitive). If a function with repeating name is registered it overrides the previous function registered with this name.
            

* __FunctionInfo__ – property returning an instance of FunctionInfo class, providing description of the function and its arguments. For more detailed description of this class you may follow this [FunctionInfo](#functioninfo) link.
            

* __ArgumentConversionRules__ – property describing the way different argument types are interpreted. RadSpreadsheet functions API works with 5 argument types (Logical, Number, Text, Reference and Array) and each function may interpret each of this argument types differently. For more information you may follow this [ArgumentConverstionRules](#argumentconversionrules) link.
            

* __Evaluate__ and __EvaluateOverride methods__ – these are the methods where the function calculations take place. In order to define custom function you need to override the __EvaluateOverride__ so that later you may take function calculations value through the __Evaluate__ method.
            

Additionally in order some custom function to be usable in RadSpreadsheet, it needs to be registered through FunctionManager class. This is easily done by passing an instance of the function class to the static Register method.
        

Here is a sample code on how to register some function class ArgumentsFunction, inheritor of FunctionBase:
        

#### __C#__

{{region radspreadsheet-features-formulas-custom-functions_0}}
	            FunctionManager.RegisterFunction(new ArgumentsFunction());
	{{endregion}}



## Functions inheritance tree

RadSpreadsheet provides inheritance tree of classes providing ready to use functionalities for different function types, depending on function arguments and desired result.
        

Here follows a class diagram of the base abstract function classes.
        ![Rad Spreadsheet Features Formulas Custom-Functions 01](images/RadSpreadsheet_Features_Formulas_Custom-Functions_01.png)

Here follows description of each level of the above tree:
        

* __FunctionBase__ – Provides the base functions properties (__Name, FunctionInfo, ArgumentConvertionRules__). Also provides the logic of __IsArgumentNumberValid__ method which handles the logic when invalid arguments count is inputted by the user. By inheriting FunctionBase you must override __EvaluateOverride(RadExpression[] arguments)__ method, so you need to handle the whole logic of converting RadExpression arguments to desired function arguments.
            

* __FunctionWithArguments__ – This class handles the basic logic of converting RadExpression’s value to some other value type corresponding to the ArgumentType defined in FunctionInfo property. This way by inheriting from this class you need to override __EvaluateOverride(object[] arguments)__ and handle and array of already converted function arguments values.
            

* __FunctionWithSameTypeArguments<T>__ – By inheriting this class you need to override __EvaluateOverride(T[] arguments)__ method and this way handle and array of arguments with same type T.
            

* __StringInFunctions, NumbersInFunction, BooleansInFunction__ – This classes inherit directly from __FunctionWithSameTypeArguments<String>, FunctionWithSameTypeArguments<double> and FunctionWithSameTypeArguments<bool>__. This is appropriate in cases when the function have same argument type - accordingly string, double or Boolean.
            

## ArgumentConversionRules

__ArgumentConversionRules__ class provides properties describing the way different function argument types are interpreted. RadSpreadsheet functions API works with 5 __argument types__ (Logical, Number, Text, Reference and Array) and each function may interpret each of this argument types differently. Additionally RadSpreadsheet allows to be made difference between __direct arguments__ (value passed directly into the formula) and __indirect arguments__ (values that depending on some other cells referencing).
        

Here follows a brief description of ArgumentConversionRules properties:
        

* __EmptyDirectArgument__ – the ArgumentInterpretation of an Empty cell value, passed as direct argument.
            

* __NumberDirectArgument__ – the ArgumentInterpretation of a Number cell value, passed as direct argument.
            

* __BoolDirectArgument__ – the ArgumentInterpretation of a Boolean cell value, passed as direct argument.
            

* __TextNumberDirectArgument__ – the ArgumentInterpretation of a String cell value that may successfully be parsed to number, passed as direct argument.
            

* __NonTextNumberDirectArgument__ – the ArgumentInterpretation of a String cell value that cannot be parsed to number, passed as direct argument.
            

* __EmptyIndirectArgument__ – the ArgumentInterpretation of an Empty cell value, passed as indirect argument.
            

* __NumberIndirectArgument__ – the ArgumentInterpretation of a Number cell value, passed as direct argument.
            

* __BoolIndirectArgument__ – the ArgumentInterpretation of a Boolean cell value, passed as indirect argument.
            

* __TextNumberIndirectArgument__ – the ArgumentInterpretation of a String cell value that may successfully be parsed to number, passed as indirect argument.
            

* __NonTextNumberIndirectArgument__ – the ArgumentInterpretation of a String cell value that cannot be parsed to number, passed as indirect argument.
            

* __ArrayArgument__ – the ArrayArgumentInterpretaion.
            

The value of this properties are from the enumerations __ArgumentInterpretation__ and __ArrayArgumentInterpretation__ and they are set through ArgumentConversionRules constructor. The __default values__ of this interpretations in the constructor are accordingly __ArgumentInterpretation.UseAsIs__ and __ArrayArgumentInterpretation.UseFirstElement__.
        

Here follows a code snippet for creating an instance of ArgumentConversionRules:
        

#### __C#__

{{region radspreadsheet-features-formulas-custom-functions_argumentconversionrules_1}}
	        public static readonly ArgumentConversionRules BoolFunctionConversion = new ArgumentConversionRules(
	                    emptyIndirectArgument: ArgumentInterpretation.Ignore,
	                    textNumberDirectArgument: ArgumentInterpretation.TreatAsError,
	                    textNumberIndirectArgument: ArgumentInterpretation.Ignore,
	                    nonTextNumberDirectArgument: ArgumentInterpretation.TreatAsError,
	                    nonTextNumberIndirectArgument: ArgumentInterpretation.Ignore,
	                    arrayArgument: ArrayArgumentInterpretation.UseAllElements);
	{{endregion}}



## FunctionInfo

FunctionInfo class provides properties describing the purpose of the function and each of its arguments.
        

Here follows a brief description of each FunctionInfo properties.
        

* __Category__ – the FunctionCategory to which the function belongs.
            

* __Description__ – description of the function as string value.
            

* __RequiredArgumentsCount__ – returns the number of required arguments of the function. If the user inputs less arguments than the RequiredArgumentsCount and error is raised.
            

* __OptionalArgumentsCount__ – returns the count of the optional arguments group.
            

* __OptionalArgumentsRepetitionCount__ – returns the number of repetitions of the optional group. The valid count of all arguments depends on this value by satisfying the following conditions:
            

* When __OptionalArgumentsRepetionCount <= 1:__

* __ValidArgumentsCount >= RequiredArgumentsCount__

* __ValidArgumentsCount <= RequiredArgumentsCount + OptionalArgumentsCount__

* When __OptionalArgumentsRepetitionsCount > 1:__

* __ValidArgumentsCount = RequiredArgumentsCount + i * OptionalArgumentsCount__

* __i >= 0__

* __i <= OptionalArgumentsRepetitionsCount__

* __i is integer number__

* __IsDefaultValueFunction__ - returns Boolean indicating whether the function is default value function.
            

* When __true__ – the function returns some default value when __all inputted values__ have __ArgumentInterpretation.Ignore__ in ArgumentConversionRules of the function.
                

* When __false__ – the function returns ErrorExpressions.ValueError when __all inputted values__ are invalid even if they have __ArgumentInterpretation.Ignore__ in ArgumentConversionRules of the function.
                

* __Format__ – returns the CellValueFormat of the function result, if the result needs specific formatting (for example DateTime or Currency).
            

Here follows a sample code snippet on how to create an instance of FunctionInfo class.
        

#### __C#__

{{region radspreadsheet-features-formulas-custom-functions_2}}
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
	
	{{endregion}}



## Custom function examples

The next example is of a custom function named __“ARGUMENTS”__ inheriting from __FunctionBase__ class. In the FunctionInfo definition you may see that the function has three required arguments and three optional arguments with __optionalArgumentsRepeatsCount__ equal to 3. For more info on FunctionInfo constructor you may follow this [FunctionInfo link](#functioninfo).
        

As a result of functions calculations we get the number of arguments passed to the function, as you may see in the EvaluateOverride function method.
        

Here follows a sample code snippet for the “ARGUMENTS” function.
        

#### __C#__

{{region radspreadsheet-features-formulas-custom-functions_3}}
	
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
	{{endregion}}



The next example is of a custom function named “E”, that inherits from __FunctionBase__ class. The function takes no arguments and it always returns the Napier’s constant.
        

Here follows the code snippet for the “E” function:
        

#### __C#__

{{region radspreadsheet-features-formulas-custom-functions_4}}
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
	{{endregion}}



The next example is of a custom function named __“REPEAT.STRING”__ that inherits from __FunctionWithArguments__ class. The function has two arguments of different type. The first argument is of ArgumentType Text and represents the text to be repeated. The second argument is optional argument of ArgumentType Number and represents the number on the repetitions. If the optional argument is omitted then the text is repeated exactly once. If the optional argument has negative value the function returns #Value! error.
        

Here follows the “REPEAT.STRING” function code snippet:
        

#### __C#__

{{region radspreadsheet-features-formulas-custom-functions_5}}
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
	
	{{endregion}}



The next example is of a custom function named __“ADD”__ that inherits from __NumbersInFunction__ class. The function has one required argument an one optional with __optionalArgumentsRepeatsCount__ equal to 254. The function calculates the sum of its arguments and returns the result. If the result is too big, the function returns #Num! error instead of Infinity.
        

Here follows the “ADD” function code snippet:
        

#### __C#__

{{region radspreadsheet-features-formulas-custom-functions_6}}
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
	
	{{endregion}}



The next example is of a custom function named __“GEOMEAN”__ that inherits from __NumbersInFunction__ class. The function has one required argument an one optional with __optionalArgumentsRepeatsCount__ equal to 254. The function calculates the geometric mean of a sequence of positive numbers. In any of the arguments is non-positive the function returns #Num! error. You may additionally notice that the function uses its own custom __ArgumentConversionRules__ that ignores the empty arguments and uses all the elements of an array argument.
        

Here follows the “GEOMEAN” function code snippet:
        

#### __C#__

{{region radspreadsheet-features-formulas-custom-functions_7}}
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
	
	{{endregion}}



The next example is of a custom function named __“NAND”__ that inherits from __BooleansInFunction__ class. The function has two arguments and calculates the Sheffer’s stroke (also known as NAND operator) of this two Boolean values.
        

Here follows the “NAND” function code snippet:
        

#### __C#__

{{region radspreadsheet-features-formulas-custom-functions_8}}
	
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
	{{endregion}}



The next example is of a custom function named __“UPPER”__ that inherits from __StringsInFunction__ class. You should notice that RadSpreadsheet supports “UPPER” function by default. By registering this custom function with the same name we simply override the old function definition. The function returns as result the uppercased function argument.
        

Here follows the “UPPER” function code snippet:
        

#### __C#__

{{region radspreadsheet-features-formulas-custom-functions_9}}
	
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
	{{endregion}}



# See Also
