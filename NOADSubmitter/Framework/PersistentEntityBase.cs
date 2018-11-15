using System;

namespace NOADSubmitter.Framework
{
    public abstract class PersistentEntityBase
    {
        private int? _id = default(int?);
        private Guid? _internalId = default(Guid?);

        /// <summary>
        /// Entity database Id
        /// </summary>
        public int? Id { get { return _id; } }

        /// <summary>
        /// Temporary identifier for unsaved entities
        /// </summary>
        public Guid? InternalId { get { if (!_internalId.HasValue) { _internalId = Guid.NewGuid(); } return _internalId; } }

        /// <summary>
        /// Change tracker
        /// </summary>
        public EntityChangeTracker ChangeTracker { get; } = new EntityChangeTracker();
    }
}
