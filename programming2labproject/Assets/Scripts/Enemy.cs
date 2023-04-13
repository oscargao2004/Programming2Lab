using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy<T> : MonoBehaviour
{
    float totalHealth = 10f;
    float attackDamage = 2f;
    float level;


    public TextMeshPro stats;

    public virtual void GetStats()
    {
        stats.text = $"Health: {totalHealth}\nAttack Damage: {attackDamage}\nLevel: {level}";

    }

    public virtual void LocatePlayer()
    {
        Transform playerPos = PlayerStats.Instance.playerPos;
    }

    public void DeclareType()
    {
        Debug.Log("Enemy type: " + typeof(T));
    }

    void Start()
    {
        DeclareType();
    }
    
}
