using NCalc;
using System.Globalization;

namespace FreelanceFinancer.PricingLib;

public class FormulaEvaluator {
    //  This method is used to evaluate the provided mathmatical expression, it replaces all placeholders in
    //  the expression with values from the dictionary and evaluates the resulting formula as a decimal.
    public static decimal EvaluateFormula (string expression, IReadOnlyDictionary<string, decimal> variableValues){
        foreach (var variable in variableValues){
            expression = expression.Replace($"field:{variable.Key}", variable.Value.ToString(CultureInfo.InvariantCulture));
        }

        var expressionEvaluator = new Expression(expression);
        var evaluationResult = expressionEvaluator.Evaluate();
        return Convert.ToDecimal(evaluationResult);
    }
}