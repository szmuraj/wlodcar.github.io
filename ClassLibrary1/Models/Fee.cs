namespace ClassLibrary1.Models;

public partial class Fee
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string AccountFrom { get; set; }
    public required string AccountTo { get; set; }
    public DateTime Date { get; set; }
    public required string Sender { get; set; }
    public required string Recipient { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? Country { get; set; }
    public required double Value { get; set; }
    public string? Description { get; set; }
    public int? PaymentId { get; set; }
}