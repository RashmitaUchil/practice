using System.ComponentModel.DataAnnotations;

namespace Students.Api.Dtos;

public record class UpdateStudent
(
    [Required][StringLength(50)]string Name,
    int DeptId,
    [Required]string City
);
