namespace FreelanceFinancer.PricingLib;

public class FormulaManager {
    private readonly Dictionary<string, string> _calculationFormulas;

    public FormulaManager (){
        _calculationFormulas = [];
    }

    public Dictionary<string, string> GetAllFormulas (){
        return _calculationFormulas;
    }

    public void AddFormulaToDictionary (string label, string formula){
        _calculationFormulas.Add(label, formula);
    }
}