using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;

public class SaveDataSerializer
{
    private static string SAVE_PATH = Application.persistentDataPath + "/SaveData.xml";

    public void Save(SaveData data)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
        FileStream stream = new FileStream(SAVE_PATH, FileMode.Create);
        serializer.Serialize(stream, data);
        stream.Close();
    }

    public SaveData Load()
    {
        if (File.Exists(SAVE_PATH) == false)
        {
            return null;
        }

        XmlSerializer serializer = new XmlSerializer(typeof(SaveData));
        FileStream stream = new FileStream(SAVE_PATH, FileMode.Open);
        SaveData saveData = serializer.Deserialize(stream) as SaveData;
        stream.Close();

        return saveData;
    }
}
