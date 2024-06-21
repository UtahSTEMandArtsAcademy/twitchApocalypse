using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.AI;

public class EnemyApproach : MonoBehaviour
{
    private NavMeshAgent ai;
    public Transform player;
    public float speed = 3.5f;
    void Start()
    {
        ai = GetComponent<NavMeshAgent>();
        ai.speed = speed;
    }

       void Update()
    {
        ai.SetDestination(player.position);
    }
}
