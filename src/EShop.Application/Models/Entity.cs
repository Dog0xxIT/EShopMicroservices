namespace EShop.Application.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public double Created { get; private set; } // TimeStamp

        public double LastModified { get; private set; }  // TimeStamp

        public bool IsDeleted { get; set; }

        public void SetTimeCreated()
        {
            Created = DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds;
        }

        public void SetTimeLastModified()
        {
            LastModified = DateTime.UtcNow.Subtract(DateTime.UnixEpoch).TotalSeconds;
        }

        protected Entity()
        {
            SetTimeCreated();
        }
    }
}
