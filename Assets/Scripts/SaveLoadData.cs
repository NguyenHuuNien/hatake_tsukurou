using System.IO;
using UnityEngine;

public static class SaveLoadData
{
    private static string path = Application.dataPath;
    public static void SaveData(TimeWorld tw)
    {
        string s = JsonUtility.ToJson(tw,true);
        File.WriteAllText(path + "TimeWorld.json", s);
    }
    public static TimeWorld LoadData(){
        if(File.Exists(path + "TimeWorld.json"))
        {
            string s = File.ReadAllText(path + "TimeWorld.json");
            TimeWorld tw = JsonUtility.FromJson<TimeWorld>(s);
            return tw;
        }
        else{
            return null;
        }
    }
}