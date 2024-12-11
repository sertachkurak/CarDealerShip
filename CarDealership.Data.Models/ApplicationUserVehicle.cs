namespace CarDealership.Data.Models
{
    public class ApplicationUserVehicle
    {
        public Guid ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public Guid VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; } = null!;
    }
}
