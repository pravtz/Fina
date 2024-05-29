using System.ComponentModel.DataAnnotations;
using Fina.Core.Enum;

namespace Fina.Core.Requests.Transactions;

public class CreateTransactionRequest: Request
{
    [Required(ErrorMessage = "Título é obrigatório")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tipo Inválido")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdrawal;
    
    [Required(ErrorMessage = "Valor é obrigatório")]
    public decimal Amount { get; set; }
    
    [Required(ErrorMessage = "Categoria é obrigatória")]
    public long CategoryId { get; set; }
    
    [Required(ErrorMessage = "Data de pagamento ou recebimento é obrigatória")]
    public DateTime? PaidOrReceivedAt { get; set; }
}