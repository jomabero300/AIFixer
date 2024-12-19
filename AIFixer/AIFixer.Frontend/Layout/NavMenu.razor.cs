using AIFixer.Shared.Resources;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace AIFixer.Frontend.Layout;

public partial class NavMenu
{
    private bool collapseNavMenu = true;
    [Inject] private IStringLocalizer<Literals> Localizer { get; set; } = null!;
    private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
}