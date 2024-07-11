using UnityEngine;

public class Behavior : MonoBehaviour {
    public EnemyController.State[] overrides = { EnemyController.State.Idle };
    protected EnemyController self;
    public float rate = 0f;

    void Awake() {
        self = GetComponent<EnemyController>();
    }
}