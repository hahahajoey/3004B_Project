using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Save_and_load
{
    public static void Save()
    {
        BinaryFormatter bifile = new BinaryFormatter();
        string file_path = Application.persistentDataPath + "/player_saved_state";
        FileStream stream = new FileStream(file_path, FileMode.Create);
        PlayerState State = new PlayerState();
        bifile.Serialize(stream, State);
        stream.Close();
        Debug.Log("file saved");
    }

    public static void Save(PlayerControlScript player)
    {
        BinaryFormatter bifile = new BinaryFormatter();
        string file_path = Application.persistentDataPath + "/player_saved_state";
        FileStream stream = new FileStream(file_path, FileMode.Create);
        PlayerState State = new PlayerState(player);
        bifile.Serialize(stream, State);
        stream.Close();
        Debug.Log("file saved");
    }

    public static void Save(PlayerControlScript player, float[]getposition, int leveladd)
    {
        BinaryFormatter bifile = new BinaryFormatter();
        string file_path = Application.persistentDataPath + "/player_saved_state";
        FileStream stream = new FileStream(file_path, FileMode.Create);
        PlayerState State = new PlayerState(player,getposition,leveladd);
        bifile.Serialize(stream, State);
        stream.Close();
        Debug.Log("file saved");
    }

    public static PlayerState Loadinfo()
    {
        string file_path = Application.persistentDataPath + "/player_saved_state";
        if (File.Exists(file_path))
        {
            BinaryFormatter bifile = new BinaryFormatter();
            FileStream stream = new FileStream(file_path, FileMode.Open);
            PlayerState info = bifile.Deserialize(stream) as PlayerState;
            stream.Close();
            Debug.Log("readed");
            return info;
        }
        else
        {
            Debug.Log("new one");
            return (new PlayerState());
        }
    }
}
