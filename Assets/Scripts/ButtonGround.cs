using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGround : MonoBehaviour
{
    [Header("Buttons of Menu")]
    [SerializeField] private GameObject[] buttons_menu;
    [Header("Buttons childrent")]
    [SerializeField] private GameObject[] buttons_childrent;
    [SerializeField] private FollowMouse objFollowMouse;
    private bool isOpenMenu = false;
    private void Update() {
        if(Input.GetMouseButtonDown(1)){
            objFollowMouse.setSpriteOnMouse(null);
            offAllButtonsChildrent();
        }
    }
    private void changeStateMenu(){
        foreach(var o in buttons_menu){
            o.SetActive(isOpenMenu);
        }
    }
    private void offAllButtonsChildrent(){
        foreach(var o in buttons_childrent) o.SetActive(false);
    }
    public void ButtonMenu(){
        isOpenMenu = !isOpenMenu;
        changeStateMenu();
        offAllButtonsChildrent();
        objFollowMouse.setSpriteOnMouse(null);
    }
    public void ButtonsEventMenu(int index){
        objFollowMouse.setSpriteOnMouse(null);
        for(int i = 0; i < buttons_childrent.Length; i++){
            if(i != index){
                buttons_childrent[i].SetActive(false);
            }
            else{
                buttons_childrent[i].SetActive(true);
            }
        }        
    }
    public void ButtonWaterFollow(Sprite imgWaterFollowMouse){
        objFollowMouse.setSpriteOnMouse(imgWaterFollowMouse);
        offAllButtonsChildrent();
        FollowMouse.curSelect = "Water";
    }
    public void ButtonTreeFollow(Sprite imgWaterFollowMouse){
        objFollowMouse.setSpriteOnMouse(imgWaterFollowMouse);
        offAllButtonsChildrent();
        FollowMouse.curSelect = "Tree";
    }
    public void ButtonEggFollow(Sprite imgWaterFollowMouse){
        objFollowMouse.setSpriteOnMouse(imgWaterFollowMouse);
        offAllButtonsChildrent();
        FollowMouse.curSelect = "Egg";
    }
}
