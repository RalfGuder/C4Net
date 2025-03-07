using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4Net.Data.Entity
{
    public class AllEntityDict
    {
        private Dictionary<Type, EntityDict> dicts = new Dictionary<Type, EntityDict>();

        public EntityDict GetDict(Type type)
        {
            if (this.dicts.ContainsKey(type))
            {
                return this.dicts[type];
            }
            EntityDict result = new EntityDict();
            this.dicts.Add(type, result);
            return result;
        }

        public EntityDict GetDict<T>() 
        {
            return this.GetDict(typeof(T));
        }

        public void AddEntity(object entity) 
        {
            this.GetDict(entity.GetType()).AddEntity(entity);
        }

        public void AddEntity<T>(object entity)
        {
            this.GetDict<T>().AddEntity(entity);
        }

        public void AddEntities(IList entities)
        {
            if (entities.Count > 0)
            {
                EntityDict dict = this.GetDict(entities[0].GetType());
                foreach (object entity in entities)
                {
                    dict.AddEntity(entity);
                }
            }
        }

        public void AddEntities<T>(IList<T> entities)
        {
            this.GetDict<T>().AddEntities(entities);
        }

        public void RemoveEntity(object entity)
        {
            this.GetDict(entity.GetType()).RemoveEntity(entity);
        }

        public void RemoveEntity<T>(object entity)
        {
            this.GetDict<T>().RemoveEntity(entity);
        }

        public void RemoveEntities(IList entities)
        {
            if (entities.Count > 0)
            {
                EntityDict dict = this.GetDict(entities[0].GetType());
                foreach (object entity in entities)
                {
                    dict.RemoveEntity(entity);
                }
            }
        }

        public void RemoveEntities<T>(IList entities)
        {
            this.GetDict<T>().RemoveEntities(entities);
        }

        public void Clear()
        {
            this.dicts.Clear();
        }
    }
}
