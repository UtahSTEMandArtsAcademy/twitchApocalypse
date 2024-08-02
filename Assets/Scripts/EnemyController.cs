using UnityEngine;
using System.Linq;

public class EnemyController : MonoBehaviour{
    public enum State {
        Idle,
        Approach,
        Melee
    }

    public State state = State.Idle;
    public Transform[] players;
    public Transform nearestPlayer;

    void Start(){
        players = GameObject.FindGameObjectsWithTag("Player").Select(player => player.transform).ToArray();
        nearestPlayer = players[0];
    }
    void Update(){
        nearestPlayer = players.OrderBy(player => Vector3.Distance(transform.position, player.position)).FirstOrDefault();
    }


}