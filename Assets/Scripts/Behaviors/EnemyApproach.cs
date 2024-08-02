using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.AI;

public class EnemyApproach : Behavior
{
    private NavMeshAgent ai;
    public float speed = 3.5f;
    void Start()
    {
        Debug.Log($"child: {self.name}");
        ai = GetComponent<NavMeshAgent>();
        ai.speed = speed;
        StartCoroutine(Target());
        Debug.Log($"child: {self.name}");
    }

    
    void Update() 
    {
        Debug.Log(EnemyController.State.Approach);
        if(overrides.Contains(self.state)) self.state = EnemyController.State.Approach;
        ai.isStopped = self.state != EnemyController.State.Approach;
    }
    IEnumerator Target()
    {
        ai.SetDestination(self.nearestPlayer.position);
        yield return new WaitForSeconds(rate);
        StartCoroutine(Target());
    }
}
