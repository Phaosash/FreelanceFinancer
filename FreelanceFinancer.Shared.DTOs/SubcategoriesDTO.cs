namespace FreelanceFinancer.Shared.DTOs;

internal class SubcategoriesDTO {
    public string Name { get; set; } = string.Empty;
    public required List<SubcategoryFieldDTO> Fields { get; set; }
}