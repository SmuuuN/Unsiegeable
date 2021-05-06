using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsAudio : MonoBehaviour
{
    [SerializeField] private AudioSource _hitSound;

    private void OnEnable()
    {
        GetComponent<DefaultHitChecker>().HitHapened += OnHit;
    }

    private void OnHit()
    {
        _hitSound.Play();
    }
}
