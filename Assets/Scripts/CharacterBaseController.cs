using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBaseController : MonoBehaviour
{
    [SerializeField] private float size;
    [SerializeField] private float maxHealth;
    [SerializeField] private Sprite sprite;
    [SerializeField] private float contactDmg;
    [SerializeField] private float knockBack;
    [SerializeField] private float opacity; // this is mutiplyed to the vison cone matrix

    
    public float health;
    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        
    }
}
