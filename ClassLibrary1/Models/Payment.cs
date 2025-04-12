namespace ClassLibrary1.Models;

public partial class Payment
{
    public Guid Id { get; set; }
    public string Number { get; set; }
    public double Value { get; set; }
    public DateTime DateIssue { get; set; }
    public DateTime DatePaymentDue { get; set; }
    public DateTime? DatePayment { get; set; }
    public string? Description { get; set; }
    public int ReservationId { get; set; }
    public virtual Reservation Reservation { get; set; } = null!;
}