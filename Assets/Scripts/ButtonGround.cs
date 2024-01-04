using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGround : MonoBehaviour
{
    [Header("Buttons of Menu")]
    [SerializeField] private GameObject[] buttons_menu;
    private bool isOpenMenu = false;
    private void Update() {
        if(isOpenMenu){
            foreach (var item in buttons_menu)
            {
                item.SetActive(isOpenMenu);
            }
        }
    
    }
    public void ButtonMenu(){
        isOpenMenu = !isOpenMenu;
    }
}
