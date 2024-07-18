using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class MeleeAttackBehavior : Behavior
{
    public float range;
    public float attackSpeed;
    public float attackTimer;
    public UnityEvent onAttack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, self.nearestPlayer.position) < range + 1.1f && overrides.Contains(self.state) && attackTimer == 0)
        {
            self.state = EnemyController.State.Melee;
            onAttack.Invoke();
            Debug.Log("Attacking!");
            attackTimer = 1 / attackSpeed;
            self.state = EnemyController.State.Idle;
        }
        attackTimer = Mathf.Max(0, attackTimer - Time.deltaTime);
    }


}
