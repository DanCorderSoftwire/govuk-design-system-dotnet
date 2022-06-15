using GovUkDesignSystem.Attributes.ValidationAttributes;

namespace GovUkDesignSystem.Demonstration.Models;

public class TextInputDemoViewModel
{
    [GovUkValidateRequired(ErrorMessageIfMissing = "Enter some text")]
    public string Text { get; set; } = "";
}