using AIFixer.Frontend.Repositories;
using AIFixer.Shared.Entites;
using AIFixer.Shared.Resources;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace AIFixer.Frontend.Pages.Countries;

public partial class CountriesIndex
{
    [Inject] private IStringLocalizer<Literals> Localizer { get; set; } = null!;
    [Inject] private IRepository Repository { get; set; } = null!;

    private List<Country>? Countries { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var responseHppt = await Repository.GetAsync<List<Country>>("api/countries");
        Countries = responseHppt.Response!;
    }
}