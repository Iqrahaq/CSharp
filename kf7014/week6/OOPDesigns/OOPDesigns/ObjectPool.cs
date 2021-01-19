using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace OOPDesigns
{
    public class ObjectPool<T>
    {
        int minSize;
        int maxSize;
        T objectToClone;
        ArrayList pool;

        public ObjectPool(int minSize, int maxSize, T objectToClone)
        {
            this.minSize = minSize;
            this.maxSize = maxSize;
            this.objectToClone = objectToClone;
            pool = new ArrayList();
            AddClones(minSize);
        }

        public ObjectPool(T objectToClone) 
            : this(1, 2, objectToClone)
        {
        }

        private void AddClones(int numberToAdd)
        {
            for (int n = 0; n < numberToAdd; n++)
            {
                pool.Add(DeepClone(objectToClone));
            }
        }

        public void CheckIn(T obj)
        {
            bool poolOverFlowCheck = false;
            for(int n = 0; n < pool.Count; n++)
            {
                T position = (T)pool[n];
                if (Object.ReferenceEquals(position, obj))
                {
                    poolOverFlowCheck = true;
                }
            }

            if(poolOverFlowCheck == false)
            {
                pool.Add(obj);
            }

            while(pool.Count > maxSize)
            {
                pool.RemoveAt(0);
            }
        }

        public T CheckOut()
        {
            T obj = (T)pool[0];
            if(pool.Count < minSize + 1)
            {
                AddClones(minSize - pool.Count);
            }
            else
            {
                pool.RemoveAt(0);
            }
            return obj;
        }

        private static T DeepClone<T>(T obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, obj);
            stream.Seek(0, SeekOrigin.Begin);
            T result = (T)formatter.Deserialize(stream);
            stream.Close();
            return result;
        }
    }
}
