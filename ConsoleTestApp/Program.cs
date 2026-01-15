using FreelanceFinancer.PricingLib;

namespace ConsoleTestApp;

internal class Program {
    private readonly FormulaManager _formulaManager = new();
    
    static void Main (){
        var program = new Program();

        program.CreateTestFormulas();

        var values = new Dictionary<string, decimal> {
            { "weight_g", 43.3M },
            { "material_cost_per_kg", 50M },
            { "material_extra_cost", 0M },
            { "labour_hours", 2M },
            { "hourly_rate", 15M },
            { "total_expenses", 8.45M },
            { "assumed_failure_percentage", 20M }
        };

        Dictionary<string, string> formulas = program._formulaManager.GetAllFormulas();

        foreach (var kvp in formulas){
            decimal result = FormulaEvaluator.EvaluateFormula(kvp.Value, values);
            
            Console.WriteLine($"{kvp.Key}: {result:F2}");
        }
    }

    private void CreateTestFormulas (){
        float gramsPerKg = 1000;
        float maxPercentage = 100;
        
        _formulaManager.AddFormulaToDictionary("total_material_cost", $"((field:weight_g / {gramsPerKg}) * field:material_cost_per_kg) + field:material_extra_cost");
        _formulaManager.AddFormulaToDictionary("total_labour_cost", "field:labour_hours * field:hourly_rate");
        _formulaManager.AddFormulaToDictionary("offset_Amount", $"field:total_expenses / (({maxPercentage} - field:assumed_failure_percentage) / {maxPercentage})");
    }
}