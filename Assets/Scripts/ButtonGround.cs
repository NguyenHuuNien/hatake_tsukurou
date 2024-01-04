using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGround : MonoBehaviour
{
    [Header("Buttons of Menu")]
    [SerializeField] private GameObject[] buttons_menu;
    private bool isOpenMenu = false;
    private void changeStateMenu(){
        foreach(var o in buttons_menu){
            o.SetActive(o.active?false:true);
        }
    }
    public void ButtonMenu(){
        this.isOpenMenu = !isOpenMenu;
        changeStateMenu();
    }
}
