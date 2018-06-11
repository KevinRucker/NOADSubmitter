using System;

namespace NOADSubmitter.Framework
{
    public abstract class PersistentEntityBase
    {
        private int? _id = default(int?);
        private Guid? _internalId = default(Guid?);

        public int? Id { get { return _id; } }
        public Guid? InternalId { get { if (!_internalId.HasValue) { _internalId = Guid.NewGuid(); } return _internalId; } }
        public EntityChangeTracker ChangeTracker { get; } = new EntityChangeTracker();
    }
}
