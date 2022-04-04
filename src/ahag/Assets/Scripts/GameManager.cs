using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    //Ressources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> xpTable;

    //References
    public Player player;

    //Logic
    public int experience;

    //223
    public void SaveState()
    {
        Debug.Log("Save state");
    }

    public void LoadState()
    {
        Debug.Log("Load state");
    }
}
