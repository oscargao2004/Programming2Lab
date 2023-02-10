using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine;

public class Skeleton : Enemy
{
    string enemyType = "skeleton";
    void Start()
    {
        base.GetStats();
        stats.text += $"\nType: {enemyType}";
    }

}
