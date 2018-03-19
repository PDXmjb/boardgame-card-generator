using System.Data.Entity;

namespace Card_generator.Models
{
    public class RDSContext : DbContext
    {
        public RDSContext()
          : base(Helpers.GetRDSConnectionString())
        {
        }

        public static RDSContext Create()
        {
            return new RDSContext();
        }
    }
}