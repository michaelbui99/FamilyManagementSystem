using System.ComponentModel.DataAnnotations;

namespace FamilyManagementRestApi.Models {
public class Pet {
    [Key]
    public int Id { get; set; }
    public string Species { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
}