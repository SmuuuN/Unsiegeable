using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class StandartEnemyMovement : MonoBehaviour, IEnemyMovement
{
    [SerializeField] private Rigidbody _selfRigidbody;
    private void Start()
    {
        _selfRigidbody = GetComponent<Rigidbody>();
    }
   
    public void MoveEnemy(EnemyStats data)
    {
        _selfRigidbody.AddForce(-Vector3.right * data.MovementSpeed * Time.fixedDeltaTime);
    }
}
