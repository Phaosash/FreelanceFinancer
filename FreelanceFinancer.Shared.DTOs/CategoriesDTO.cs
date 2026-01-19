namespace FreelanceFinancer.Shared.DTOs;

internal class CategoriesDTO {
    public string CategoryName { get; set; } = string.Empty;
    public required List<SubcategoriesDTO> Subcategories { get; set; }
    public required FormulaDTO Formula { get; set; }
}