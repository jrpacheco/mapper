using System;
using System.Collections.Generic;

namespace JrPacheco.MapperBase
{
    public abstract class MapperBase<TFirst, TSecond>
    {
        public abstract TFirst Map(TSecond element);
        public abstract TSecond Map(TFirst element);

        public List<TFirst> Map(List<TSecond> elements, Action<TFirst> callback = null)
        {
            var objecCollection = new List<TFirst>();

            if (elements != null)
            {
                foreach (TSecond item in elements)
                {
                    TFirst newObject = Map(item);

                    if (newObject != null)
                    {
                        if (callback != null)
                            callback(newObject);

                        objecCollection.Add(newObject);
                    }
                }
            }
            return objecCollection;
        }

        public List<TSecond> Map(List<TFirst> elements, Action<TSecond> callback = null)
        {
            var objecCollection = new List<TSecond>();

            if (elements != null)
            {
                foreach (TFirst item in elements)
                {
                    TSecond newObject = Map(item);

                    if (newObject != null)
                    {
                        if (callback != null)
                            callback(newObject);

                        objecCollection.Add(newObject);
                    }
                }
            }
            return objecCollection;
        }
    }
}
