using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RelaxLitte.Util
{
    //json
    public class Tree<TKey, TValue>
    {
        readonly ConcurrentDictionary<TKey, LinkedList<TValue>> dicts;
        Object lockObject;

        public Tree()
        {
            dicts = new ConcurrentDictionary<TKey, LinkedList<TValue>>();
            lockObject = new object();
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException("The key can't be null!");
            }
            LinkedList<TValue> values;
            lock (lockObject)
            {
                if (dicts.TryGetValue(key, out values))
                {
                    values.AddLast(value);
                    dicts.AddOrUpdate(key, values, UpdateValues);
                }
            }
        }

        private LinkedList<TValue> UpdateValues(TKey key, LinkedList<TValue> values)
        {
            return values;
        }
    }
}
