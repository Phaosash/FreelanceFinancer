using System.Collections.Generic;

namespace FreelanceFinancer.App.Models;

internal class CatagoriesDTO {
    public string CatagoryId { get; set; } = string.Empty;
    public List<SubCategoryField> SubCategories { get; set; } = [];
    public string Expression { get; set; } = string.Empty;
}