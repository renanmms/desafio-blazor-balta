using Microsoft.AspNetCore.Components;

namespace desafio.Components.Pages;

public class Cidade : ComponentBase
{
    [Parameter]
    public string? Municipio { get; set; }

    [Parameter]
    public string? UF { get; set; }

    [Parameter]
    public string? CodigoIBGE { get; set; }
}