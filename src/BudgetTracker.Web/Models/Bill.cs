using System.ComponentModel.DataAnnotations;
using BudgetTracker.Web.Enums;

namespace BudgetTracker.Web.Models;

public class Bill
{
    public Bill()
    {
        
    }
    
    // TODO: Add Comments, Categories, Installments
    public int Id { get; set; }
    
    [Display(Name = "Bill")]
    public required string Name { get; set; }
    
    [Display(Name = "Total Due")]
    public required decimal TotalDue { get; set; }
    
    [Display(Name = "Due Date")]
    [DataType(DataType.Date)]
    public required DateTime DueDate { get; set; }
    
    [Display(Name = "Paid Date")]
    [DataType(DataType.Date)]
    public DateTime? PaidDate { get; set; }
    
    public BillStatus Status { get; set; }
}