using System.ComponentModel.DataAnnotations;

namespace Students.Api.Dtos;

public record class CreateStudent
(
    [Required][StringLength(50)]string Name,
    int DeptId,
    [Required]string City

);
