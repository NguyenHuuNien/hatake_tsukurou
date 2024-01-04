using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteOnMouse;
    private void LateUpdate() {
        Vector3 x = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(x.x,x.y,0);
    }
    public void setSpriteOnMouse(Sprite sp){
        this.spriteOnMouse.sprite = sp;
    }
}
