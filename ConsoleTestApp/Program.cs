using NCalc;

namespace ConsoleTestApp;

internal class Program {
    static void Main (){
        var values = new Dictionary<string, decimal> {
            { "weight_g", 43.3M },
            { "material_cost_per_kg", 50M },
            { "material_extra_cost", 0M },
            { "labour_hours", 2M },
            { "hourly_rate", 15M }
        };

        var formulas = new Dictionary<string, string> {
            { "total_material_cost", "((field:weight_g / 1000) * field:material_cost_per_kg) + field:material_extra_cost" },
            { "total_labour_cost", "field:labour_hours * field:hourly_rate" }
        };

        foreach (var kvp in formulas){
            decimal result = EvaluateFormula(kvp.Value, values);
            Console.WriteLine($"{kvp.Key}: {result:F2}");
        }
    }

    static decimal EvaluateFormula (string expression, Dictionary<string, decimal> values){
        foreach (var kv in values){
            expression = expression.Replace($"field:{kv.Key}", kv.Value.ToString());
        }

        var e = new Expression(expression);
        var result = e.Evaluate();
        return Convert.ToDecimal(result);
    }
}