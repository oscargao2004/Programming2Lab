using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public Transform charTrans;

    public GameData()
    {
        this.charTrans = GameObject.Find("Player").GetComponent<Transform>();
    }
    
}
