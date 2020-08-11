using System;
namespace DeliveryApi.Infrastructure.entities
{
    public class ShopSchedule : Entity
    {
        public string DayOfWeek { get; set; }
        public DateTime OpenAt { get; set; }
        public DateTime CloseAt { get; set; }
        public bool IsActive { get; set; }

        public Shop Shop { get; set; }
        public Guid ShopId { get; set; }
    }
}
