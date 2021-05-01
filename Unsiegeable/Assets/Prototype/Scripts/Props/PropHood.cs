using System.Collections.Generic;
using UnityEngine;

public class PropHood : MonoBehaviour
{
    [SerializeField] private List<Prop> _propList;

    [SerializeField] private Transform _startPosition;
    [SerializeField] private Transform _endPosition;

    [SerializeField] private float _spawnRepeatTime = 1f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnProp), 1, _spawnRepeatTime);
    }

    private void SpawnProp()
    {
        var position = ChooseRandomPosition();
        Instantiate(_propList[0], position, Quaternion.identity);
    }

    private Vector3 ChooseRandomPosition()
    {
        return new Vector3(Random.Range(_startPosition.position.x, _endPosition.position.x),
                           Random.Range(_startPosition.position.y, _endPosition.position.y),
                           Random.Range(_startPosition.position.z, _endPosition.position.z));
    }
}
