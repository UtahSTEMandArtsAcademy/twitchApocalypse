using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class MultiplayerManager : MonoBehaviour
{
    public static Dictionary<int, Player> players = new Dictionary<int, Player> {
        { 1, null },
        { 2, null },
        { 3, null },
        { 4, null }
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Join()
    {
        Debug.Log("Player Joined");
        Debug.Log($"The game object has {GameObject.Find("0Test(Clone)")} joined");
    }
}

public class Player
{
    public int index;
    public GameObject gameObject;

    public GameObject Spawn(GameObject prefab)
    {
        gameObject = Object.Instantiate(prefab);
        return gameObject;
    }
}