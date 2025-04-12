using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClassLibrary1.Models;

namespace MudBlazorWebApp1.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }
    public virtual DbSet<Payment> Payments { get; set; }
    public virtual DbSet<Fee> Fees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=WlodCar;");

}

