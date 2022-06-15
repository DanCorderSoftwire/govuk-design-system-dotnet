using GovUkDesignSystem.Attributes.ValidationAttributes;

namespace GovUkDesignSystem.Demonstration.Models;

public class TextInputViewModel
{
    [GovUkValidateRequired(ErrorMessageIfMissing = "Enter some text")]
    public string Text { get; set; } = "";
}