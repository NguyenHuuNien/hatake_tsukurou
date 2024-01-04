using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] private Sprite[] imgTree;
    [SerializeField] private double speed;
    private double currentStateOfTree;
    private void Start() {
        currentStateOfTree = 0;
    }
    public GameObject getTree(){
        return this.gameObject;
    }
}
