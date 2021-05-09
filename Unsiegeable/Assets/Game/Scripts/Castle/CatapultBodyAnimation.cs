using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultBodyAnimation : MonoBehaviour
{
    [SerializeField] private Catapult _catapult;

    [SerializeField] private Animator _catapultBodyAnimator;

    private void OnEnable()
    {
        _catapultBodyAnimator = GetComponent<Animator>();

        _catapult.FireHappen += OnFireHappen;
        _catapult.FireEnded += OnFireEnded;
    }

    private void OnDisable()
    {
        _catapult.FireHappen -= OnFireHappen;
        _catapult.FireEnded -= OnFireEnded;
    }

    private void OnFireHappen()
    {
        _catapultBodyAnimator.SetBool("Tossing", true); 
    }

    private void OnFireEnded()
    {
        _catapultBodyAnimator.SetBool("Tossing", false);
    }
}
