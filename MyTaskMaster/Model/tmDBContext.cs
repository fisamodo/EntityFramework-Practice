using System.Data.Entity;


namespace MyTaskMaster.Model
{
    class tmDBContext : DbContext
    {
        public DbSet<Status> Statuses { get; set; }
    }
}
