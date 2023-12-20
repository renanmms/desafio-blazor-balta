namespace desafio.Data
{
    public class Cidade
    {
        public Cidade(string? codigoIBGE, string? uF, string? municipio)
        {
            CodigoIBGE = codigoIBGE;
            UF = uF;
            Municipio = municipio;
        }

        public string? CodigoIBGE { get; set; }
        public string? UF { get; set; }
        public string? Municipio { get; set; }
    }
}