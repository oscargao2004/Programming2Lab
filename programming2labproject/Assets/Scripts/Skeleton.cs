using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy<Skeleton>
{
    string enemyType = "skeleton";

    void Start()
    {
        base.LocatePlayer();
        base.GetStats();
        stats.text += $"\nType: {enemyType}";

        DeclareType();
        
    }
}
