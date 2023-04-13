using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{

    private GameData gameData;

    public static SaveLoad instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
        {

        }

        instance = this;
    }

    public void NewGame()
    {

    }

    public void SaveGame()
    {

    }

    public void LoadGame()
    {

    }
}
