namespace Stock_Trading_App.Data.Models;


public class ComoditiyModel
{
    public string? comoditiyName { get; set; }
    public string? comoditiyInterval { get; set; }
    public string? comoditiyCost { get; set; }

    public List<Dictionary<string,DateTime>>? comoditiyData { get; set; }
}