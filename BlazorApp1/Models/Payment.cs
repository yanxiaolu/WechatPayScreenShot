namespace BlazorApp1.Pages.Models;
using BlazorApp1.Pages.Models;

public class Payment
{
    public string AvatarPath { get; set; }=String.Empty;
    public string TransferTo { get; set; }=String.Empty;
    public string TransferAmount { get; set; }=String.Empty;
    public string CurrentStat { get; set; }=String.Empty;
    public NoteType TransferNote { get; set; }
    public DateTime TransferDate { get; set; }
    public DateTime CollectionTime { get; set; }
    public string PaymentMethod { get; set; }=String.Empty;
    public string TransferOrderId { get; set; }=String.Empty;

    public Payment()
    {

        
    }
    
    
   
}