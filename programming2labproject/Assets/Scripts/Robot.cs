using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : Enemy<Robot>
{
    string enemyType = "robot";
    void Start()
    {
        base.LocatePlayer();
        base.GetStats();
        stats.text += $"\nType: {enemyType}";

        DeclareType();
    }
}
