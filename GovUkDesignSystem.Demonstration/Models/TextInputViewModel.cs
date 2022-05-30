using GovUkDesignSystem.Attributes.ValidationAttributes;

namespace GovUkDesignSystem.Demonstration.Models;

public class TextInputViewModel
{
    [GovUkValidateRequiredAttribute(ErrorMessageIfMissing = "Please enter some text")]
    public string Text { get; set; } = "";
}