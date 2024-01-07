using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounds : MonoBehaviour
{
    [SerializeField] private Sprite[] imgGrounds;
    [SerializeField] private SpriteRenderer spRen;
    [SerializeField] private SpriteRenderer spHatGiong;
    private DatTrong dt;
    // Start is called before the first frame update
    void Start()
    {
        spRen.sprite = imgGrounds[0];
        dt = new DatTrong();
        spHatGiong.sprite = null;
    }

    // Update is called once per frame
    void Update()
    {
        if(dt.luongNuoc<=1){
            spRen.sprite = imgGrounds[0];
        }else{
            spRen.sprite = imgGrounds[1];
            decLuongNuoc();
        }
    }
    private void decLuongNuoc(){
        dt.luongNuoc -= Time.fixedDeltaTime / 5;
    }
    public void DatTrongCay(){
        if(FollowMouse.curSelect == "Water"){
            dt.luongNuoc = 100;
        }else if(FollowMouse.curSelect == "Tree"){
            spHatGiong.sprite = imgGrounds[2];
        }
    }
}
