namespace FreelanceFinancer.Shared.DTOs;

internal class SubcategoryFieldDTO {
    public string Id { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public FormulaDTO? Formula { get; set; }
}