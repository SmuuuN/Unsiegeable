using System;
using System.Collections.Generic;
using UnityEngine;

public class PropHood : MonoBehaviour
{
    [SerializeField] private List<Prop> _propList;

    [SerializeField] private Transform _startPosition;
    [SerializeField] private Transform _endPosition;

    [SerializeField] private float _spawnRepeatTime = 1f;

    public event Action<Prop> PropSpawned;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnProp), 1, _spawnRepeatTime);
    }

    private void SpawnProp()
    {
        var position = ChooseRandomPosition();
        var spawnedProp = Instantiate(ChooseRandomProp(), position, Quaternion.identity);

        PropSpawned?.Invoke(spawnedProp);
    }

    private Vector3 ChooseRandomPosition()
    {
        return new Vector3(UnityEngine.Random.Range(_startPosition.position.x, _endPosition.position.x),
                           UnityEngine.Random.Range(_startPosition.position.y, _endPosition.position.y),
                           UnityEngine.Random.Range(_startPosition.position.z, _endPosition.position.z));
    }

    private Prop ChooseRandomProp()
    {
        var randomIndex =   UnityEngine.Random.Range(0, _propList.Count);

        return _propList[randomIndex];
    }   
}
