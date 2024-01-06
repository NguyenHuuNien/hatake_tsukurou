using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class SetTimeUpdate : MonoBehaviour
{
    [SerializeField] private Text txtTimeWorld;
    private void Update() {
        string hour = DateTime.Now.Hour.ToString().Length == 1 ? 
                        "0"+DateTime.Now.Hour.ToString() : 
                        DateTime.Now.Hour.ToString();
        string minute = DateTime.Now.Minute.ToString().Length == 1 ? 
                        "0"+DateTime.Now.Minute.ToString() : 
                        DateTime.Now.Minute.ToString();
        string second = DateTime.Now.Second.ToString().Length == 1 ? 
                        "0"+DateTime.Now.Second.ToString() : 
                        DateTime.Now.Second.ToString();
                        
        txtTimeWorld.text = hour + ":" + minute + ":" + second;
    }
}