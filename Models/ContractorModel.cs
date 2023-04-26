namespace ContractorFinder.Models;


public class ContractorModel
{
    public string? ContractorID {get;} = Random.Shared.Next().ToString();
    public string? ContractorName {get; set;}
    public string? ContractorProfile {get; set;}
    public string? ContractorEmail {get; set;}
    public string? ContractorTelephone {get; set;}
    public string? ContractorPhoto {get;set;}
}