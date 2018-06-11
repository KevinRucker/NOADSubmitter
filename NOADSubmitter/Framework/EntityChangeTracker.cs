using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NOADSubmitter.Framework
{
    public class EntityChangeTracker
    {
        public Dictionary<string, object> OriginalValues { get; } = new Dictionary<string, object>();
        public Dictionary<string, object> NewValues { get; private set; } = new Dictionary<string, object>();
        public bool HasChanges { get; private set; } = default(bool);

        public void Initialize(object entity)
        {
            var infos = entity.GetType().GetRuntimeProperties();
            foreach(var info in infos)
            {
                if(info.Name != "Id" && info.Name != "InternalId")
                {
                    OriginalValues.Add(info.Name, info.GetValue(entity));
                }
            }
        }

        public void ChangePropertyValue(string propertyName, object value)
        {
            if(!NewValues.Keys.Contains(propertyName))
            {
                NewValues.Add(propertyName, value);
            }
            else
            {
                if(NewValues[propertyName] != value)
                {
                    NewValues.Remove(propertyName);
                    NewValues.Add(propertyName, value);
                }
            }

            HasChanges = NewValues.Any();
        }

        public void Reset()
        {
            NewValues = new Dictionary<string, object>();
            HasChanges = false;
        }
    }
}
