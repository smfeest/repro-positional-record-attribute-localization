using System.ComponentModel.DataAnnotations;

namespace PositionalRecordAttributeLocalization.Models;

// This positional record does not get localized error messages
public record GreetingViewModel(
   [Required(ErrorMessage = "Error_NameRequired")] string? Name);

// This non-positional record does get localized error messages
// public record GreetingViewModel
// {
//     [Required(ErrorMessage = "Error_NameRequired")]
//     public string? Name { get; init; }
// }