using Abp.Application.Services.Dto;

namespace TradePlatform.Application.TradeInvestment.Documents.DTO
{
    public class DocumentListDto : EntityDto<int>
    {
        public double Amount { get; set;}
        
        public string Status { get; set;}
        
        public string PaymentMode { get; set; }
        
        public int UserProfileId { get; set; }
    }
}