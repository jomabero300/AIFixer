using AIFixer.Frontend.Repositories;
using AIFixer.Shared.Entites;
using AIFixer.Shared.Resources;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace AIFixer.Frontend.Pages.ComponentTypes;

public partial class ComponentTypesIndex
{
    [Inject] private IStringLocalizer<Literals> Localizer { get; set; } = null!;
    [Inject] private IRepository Repository { get; set; } = null!;

    private List<ComponentType>? ComponentTypes { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var responseHppt = await Repository.GetAsync<List<ComponentType>>("api/componentTypes");
        ComponentTypes = responseHppt.Response!;
    }
}