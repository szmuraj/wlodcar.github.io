namespace ClassLibrary1.Models;

public partial class Reservation
{
    public Guid Id { get; set; }

    public int CarId { get; set; }

    public int CustomerId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
    public Status Status { get; internal set; }
    public int Promotion { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

}
