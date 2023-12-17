namespace desafio.Data
{
    public class PesquisaService
    {
        public List<Cidade> GetCidades()
        {
            var cidades = new List<Cidade>(){
                new Cidade("3548708", "SP", "São Bernardo do Campo"), 
                new Cidade("XXXXXXX", "SP", "Santo André"), 
                new Cidade("YYYYYYY", "SP", "São Caetano do Sul")
            };  

            return cidades;
        }
    }
}