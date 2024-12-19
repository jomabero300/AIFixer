using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using AIFixer.Shared.Resources;

namespace AIFixer.Frontend.Pages;

public partial class Home
{
    [Inject] private IStringLocalizer<Literals> Localizer { get; set; } = null!;
}