using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : Enemy
{
    string enemyType = "robot";
    void Start()
    {
        base.GetStats();
        stats.text += $"\nType: {enemyType}";
    }
}
