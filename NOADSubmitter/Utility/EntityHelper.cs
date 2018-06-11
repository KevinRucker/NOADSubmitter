using System.Reflection;

namespace NOADSubmitter.Utility
{
    public class EntityHelper
    {
        public void SetId(object entity, int? id)
        {
            var field = entity.GetType().GetField("_id", BindingFlags.NonPublic | BindingFlags.Instance);
            if(id.HasValue)
            {
                field.SetValue(entity, id.Value);
            }
        }
    }
}
