using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.AI;

public class EnemyApproach : Behavior
{
    private NavMeshAgent ai;
    public Transform player;
    public float speed = 3.5f;
    void Start()
    {
        ai = GetComponent<NavMeshAgent>();
        ai.speed = speed;
        StartCoroutine(Target());
    }
    void Update() 
    {
        if(overrides.Contains(self.state)) self.state = EnemyController.State.Approach;
        ai.isStopped = self.state != EnemyController.State.Approach;
    }
    IEnumerator Target()
    {
        ai.SetDestination(player.position);
        yield return new WaitForSeconds(rate);
        StartCoroutine(Target());
    }
}
