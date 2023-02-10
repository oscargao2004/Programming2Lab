using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float totalHealth = 10f;
    float attackDamage = 2f;
    float level;

    public TextMeshPro stats;

    public virtual void GetStats()
    {
        stats.text = $"Health: {totalHealth}\nAttack Damage: {attackDamage}\nLevel: {level}";

    }
}
