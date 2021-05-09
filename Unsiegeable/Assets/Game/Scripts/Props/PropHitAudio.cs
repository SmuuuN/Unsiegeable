using UnityEngine;

public class PropHitAudio : MonoBehaviour
{
    [SerializeField] private AudioSource _hitSound;
    [SerializeField] private PropHood _propHood;

    private void OnEnable()
    { 
        _hitSound = GetComponent<AudioSource>();

        _propHood.PropSpawned += OnPropSpawned;
    }

    private void OnDisable()
    {
        _propHood.PropSpawned -= OnPropSpawned;
    }

    private void OnPropSpawned(Prop prop)
    {
        prop.gameObject.GetComponent<IHitChecker>().HitHapened += OnHit;
    }

    private void OnHit()
    {
        _hitSound.Play();
    }
}
