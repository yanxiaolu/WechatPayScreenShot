namespace BlazorApp1.Pages.Models;

public class Payment
{
    public string AvatarPath { get; set; }
    public string TransferTo { get; set; }
    public string TransferAmount { get; set; }
    public string CurrentStat { get; set; }
    public string TransferNote { get; set; }
    public DateTime TransferDate { get; set; }
    public DateTime CollectionTime { get; set; }
    public string PaymentMethod { get; set; }
    public string TransferOrderId { get; set; }

    public Payment()
    {
        AvatarPath = "images/tx.jpg";
        TransferTo = "华达";
        TransferAmount = "-100";
        CurrentStat = "对方已收钱";
        TransferNote = "微信转账";
        TransferDate = DateTime.Now;
        CollectionTime = DateTime.Now;
        PaymentMethod = "中国银行储蓄卡(0155)";
        TransferOrderId = "1000050001202211150619806663124";
    }
}