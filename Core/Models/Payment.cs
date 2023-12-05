using Core.Enums;

namespace Core.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime PaidOn { get; set; }
        public int CardTypeId { get; set; }
        public int CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string CardTransactionNo { get; set;}
        public int Month {  get; set; }
        public int Year { get; set; }
        public string SecurityCode { get; set; }
        public string PaymentNote { get; set; }
        public string ChequeNo { get; set; }
        public string BankAccountNo { get;set; }
        public decimal CashDiscount {  get; set; }
        public string Reference { get; set;}
        public PaymentType PaymentType { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public CardType CardType { get; set; }


    }
}
