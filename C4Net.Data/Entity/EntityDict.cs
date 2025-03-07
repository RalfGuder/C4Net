using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4Net.Data.Entity
{
    public class EntityDict : Dictionary<string, object>
    {
        public void AddEntity(object entity) 
        {
            string key = EntityHelperManager.Get(entity.GetType()).GetPrimaryKeyStr(entity);
            if (this.ContainsKey(key))
            {
                this[key] = entity;
            }
            else
            {
                this.Add(key, entity);
            }
        }

        public void AddEntities(IList entities)
        {
            foreach (object entity in entities)
            {
                this.AddEntity(entity);
            }
        }

        public void AddEntities<T>(IList<T> entities)
        {
            foreach (T entity in entities)
            {
                this.AddEntity(entity);
            }
        }

        public void RemoveEntity(object entity)
        {
            string key = EntityHelperManager.Get(entity.GetType()).GetPrimaryKeyStr(entity);
            this.Remove(key);
        }

        public void RemoveEntities(IList entities)
        {
            foreach (object entity in entities)
            {
                this.RemoveEntity(entity);
            }
        }
    }
}
