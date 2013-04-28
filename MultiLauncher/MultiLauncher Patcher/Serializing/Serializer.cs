using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MultiLauncher.Serializing
{
    public abstract class Serializer
    {
        public static void SerializeObject(string filename, object objectToSerialize)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objectToSerialize);
            stream.Close();
        }

        public static T DeSerializeObject<T>(string filename) 
        {
            T objectToSerialize;
            try
            {
                using (Stream stream = File.Open(filename, FileMode.Open))
                {
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    objectToSerialize = (T)bFormatter.Deserialize(stream);
                    stream.Close();
                }
            }
            catch
            {
                return default(T);
            }
            return objectToSerialize;
        }
    }
}
