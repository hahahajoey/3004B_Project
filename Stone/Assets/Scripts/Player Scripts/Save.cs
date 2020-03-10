using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Save_and_load
{
    public static void Save(PlayerControlScript player)
    {
        BinaryFormatter bifile = new BinaryFormatter();
        string file_path = Application.persistentDataPath + "/player_saved_state.txt";
        FileStream stream = new FileStream(file_path, FileMode.Create);
        PlayerState State = new PlayerState(player);
        bifile.Serialize(stream, State);
        stream.Close();
        Debug.Log("file saved");
    }
}
