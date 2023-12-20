using desafio.Models;
using desafio.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppContext = desafio.Data.AppContext;

namespace desafio.Controller;



public class LocalidadeController : ControllerBase
{

    private readonly AppContext _context;

    private readonly ILogger<LocalidadeController> _logger;

    public LocalidadeController(AppContext context, ILogger<LocalidadeController> logger)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IBGE> GetAsync(string id)
    {
        return await _context.IBGE.FirstOrDefaultAsync(x => x.Id == id);
    }

    public  Task<List<IBGE>> GetAll()
    {
        return _context.IBGE.ToListAsync();

    }


    public async Task<bool> Create(CreateIBGE ibge)
    {
        try
        {
            _context.IBGE.Add(new IBGE() { City = ibge.City, State = ibge.State});
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Ocorreu uma excessão ao salvar a localidade.");
            return false;
        }

}

    public async Task<bool> Update(IBGE ibge)
    {
        try
        {
            var updatedIbge = await GetAsync(ibge.Id);
            updatedIbge.State = ibge.State;
            updatedIbge.City = ibge.City;
            _context.Update(updatedIbge);
            return true;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Ocorreu uma excessão ao atulizar a localidade");
            return false;
            
        }
    }

    public async Task<bool> Delete(string id)
    {
        try
        {
            var deleteIbge = await GetAsync(id);
            _context.Remove(deleteIbge);
            _context.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Ocorreu uma excessão ao excluir a localidade");
            return false;
        }
    }
    
    
    
    
    
    
}