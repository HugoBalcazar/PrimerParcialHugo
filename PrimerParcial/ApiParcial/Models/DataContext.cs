using System.Data.Entity;

namespace APIParcial.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIParcial.Models.Friend> Friends { get; set; }
    }

}