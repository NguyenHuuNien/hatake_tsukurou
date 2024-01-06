using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class SetTimeUpdate : MonoBehaviour
{
    [SerializeField] private Text txtTimeWorld;
    [SerializeField] private Text txtTimeSave;
    private void Start() {
        TimeWorld tw = new TimeWorld();
        tw = SaveLoadData.LoadData();
        txtTimeSave.text = tw.Gio + ":" + tw.Phut + ":" + tw.Giay;
    }
    private void Update() {
        txtTimeWorld.text = DateTime.Now.Hour + ":" + 
        DateTime.Now.Minute + ":" + DateTime.Now.Second;
    }
    private void OnDisable() {
        TimeWorld tw = new TimeWorld();
        tw.Gio = DateTime.Now.Hour;
        tw.Phut = DateTime.Now.Minute;
        tw.Giay = DateTime.Now.Second;
        SaveLoadData.SaveData(tw);
    }
}