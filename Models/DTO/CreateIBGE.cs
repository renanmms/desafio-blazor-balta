namespace desafio.Models.DTO;

public class CreateIBGE
{
    public string State { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public CreateIBGE(string state, string city)
    {
        this.State = state;
        this.City = city;
    }
    
}