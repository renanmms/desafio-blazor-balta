using Microsoft.AspNetCore.Components;

namespace desafio.Components.Pages;

public class CidadeComponent : ComponentBase
{
    [Parameter]
    public string? Municipio { get; set; }

    [Parameter]
    public string? UF { get; set; }

    [Parameter]
    public string? CodigoIBGE { get; set; }
}