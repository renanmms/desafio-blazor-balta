using Microsoft.AspNetCore.Components;
using desafio.Data;

namespace desafio.Components.Pages;

public class PesquisaComponent : ComponentBase
{
    protected Cidade CidadeSelecionada;
    protected List<Cidade> cidades;

    protected override void OnInitialized()
    {
        var service = new PesquisaService();
        cidades = service.GetCidades();
    }

    protected async Task<IEnumerable<Cidade>> ProcuraCidades(string criterio)
    {
        return await Task.FromResult(cidades.Where(c => c.Municipio.ToLower().Contains(criterio.ToLower()) || 
                                                        c.UF.ToLower().Contains(criterio.ToLower()) ||
                                                        c.CodigoIBGE.Contains(criterio.ToLower())).ToList());
    }
}