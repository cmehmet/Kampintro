using System.Security.Cryptography;

namespace GenericsDemo
{
    internal class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        TKey[] tempKeys;
        TValue[] tempValues;
        public MyDictionary() 
        {
            keys = new TKey[0] { };
            values = new TValue[0] { };
        }
        public void Add(TKey item1, TValue item2) 
        {
            tempKeys = keys;
            keys = new TKey[keys.Length + 1];
            tempValues = values;
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = item1;
            values[values.Length - 1] = item2;
        }

        public int Length()
        {
            return keys.Length;
        }

        public TKey GetKey(int index)
        {
            return keys[index];
        }

        
        public TValue GetValue(TKey key)
        {
            keys[0] = key;
            bool keyExists = false;
            int index = 0;
            for (int i = 0;i < keys.Length;i++)
            {
                if (keys[i].Equals(key))
                {
                    keyExists = true;
                    index = i;
                    break;
                }
            }
            if (keyExists == false) 
            {
                throw new Exception(key + " isimli bir anahtar bulunamadı.");
            }
            else
            {
                return values[index];
            }
        }
    }
}
