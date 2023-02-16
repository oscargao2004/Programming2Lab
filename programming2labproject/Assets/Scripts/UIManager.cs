using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text healthDisplay;

    void Update()
    {
        healthDisplay.text = $"Health: {PlayerStats.Instance.playerHealth.ToString()}";
    }

}
