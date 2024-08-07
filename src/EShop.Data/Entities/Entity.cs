using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Data.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public double Created { get; private set; } // TimeStamp

        public double LastModified { get; private set; }  // TimeStamp

        public bool IsDeleted { get; set; }

        public void SetCreated()
        {
            Created = DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds;
        }

        public void SetLastModified()
        {
            LastModified = DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds;
        }
    }
}
