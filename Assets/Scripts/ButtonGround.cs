using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGround : MonoBehaviour
{
    [Header("Buttons of Menu")]
    [SerializeField] private GameObject[] buttons_menu;
    [Header("Buttons of Animals")]
    [SerializeField] private GameObject[] buttons_animal;
    [Header("Buttons of Trees")]
    [SerializeField] private GameObject[] buttons_tree;
    [Header("Buttons of Events")]
    [SerializeField] private GameObject[] buttons_event;
    private bool isOpenMenu = false;
    private void changeStateMenu(){
        foreach(var o in buttons_menu){
            o.SetActive(isOpenMenu);
        }
    }
    public void ButtonMenu(){
        isOpenMenu = !isOpenMenu;
        changeStateMenu();
    }
}
