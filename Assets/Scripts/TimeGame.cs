using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Text;

public class TimeGame : MonoBehaviour
{
    private int gio, phut, giay;
    private void Awake() {
    }
    private void Update() {
        setTimeNow();
        Debug.Log(gio+":"+phut+":"+giay);
    }
    private void setTimeNow(){
        gio = DateTime.Now.Hour;
        phut = DateTime.Now.Minute;
        giay = DateTime.Now.Second;
    }
    public void SaveTime(){
        FileStream file = new FileStream("data.txt",FileMode.Create,FileAccess.Write);
        if(file.CanWrite){
            byte[] bytes = Encoding.ASCII.GetBytes(gio+":"+phut+":"+giay);
            file.Write(bytes,0,bytes.Length);
            Debug.Log("Save Completed!");
        }
        file.Flush();
        file.Close();
    }
    public void LoadTime(){
        FileStream file = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
        if(file.CanRead){
            byte[] bytes = new byte[file.Length];
            int byteReader = file.Read(bytes,0,bytes.Length);

            Debug.Log(Encoding.ASCII.GetString(bytes,0,byteReader));
        }
        file.Close();
    }
}
