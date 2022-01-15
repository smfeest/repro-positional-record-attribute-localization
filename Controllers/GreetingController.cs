using Microsoft.AspNetCore.Mvc;
using PositionalRecordAttributeLocalization.Models;

namespace PositionalRecordAttributeLocalization.Controllers;

[Route("/")]
public class GreetingController : Controller
{
    [HttpGet]
    public IActionResult Form() => this.View();

    [HttpPost]
    public IActionResult Greet(GreetingViewModel model) =>
        this.ModelState.IsValid ? this.View(model) : this.View("Form", model);
}
