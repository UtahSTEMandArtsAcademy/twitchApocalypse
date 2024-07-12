using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public float healthPercentage
    {
        get { return health / maxHealth; }
    }
    public RectTransform healthBar;

    public UnityEvent onDeath;
    public UnityEvent onDamaged;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        health = Mathf.Clamp(health - damage, 0, maxHealth);
        if (onDamaged != null)
        {
            onDamaged.Invoke();
        }
        if (health <= 0)
        {
            onDeath.Invoke();
        }
        UpdateHealthbar();
    }

    public void UpdateHealthbar()
    {
        healthBar.localScale = new Vector2(healthPercentage, 1);
    }
}
