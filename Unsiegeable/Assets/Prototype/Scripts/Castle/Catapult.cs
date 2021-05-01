using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private Prop _currentProp;
    [SerializeField] private Transform _catapultPlace;

    [SerializeField] private States _state;

    [SerializeField] private float _propFireSpeed;

    
    private void Update()
    {
        CheckState();
        ChooseProp();
      //  CancelFireOfCatapult();
        Fire();
    }

    private void ChooseProp()
    {

        
        if ((Input.touchCount > 0) && (_state == States.Empty))
        {
            var touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out var hit))
            {

                if (hit.collider.gameObject.TryGetComponent<Prop>(out var comp))
                {                   
                    _currentProp = comp;
                    _state = States.Full;
                    

                }
            }
            _state = States.Full;
            
        }
        SetPropToCatapult();

    }

    private void SetPropToCatapult()
    {
        if (_currentProp != null)
        {
            _currentProp.transform.position = _catapultPlace.transform.position;
        }
        
    }

    private void CancelFireOfCatapult()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            _currentProp = null;
            _state = States.Empty;
        }
    }

    private void Fire()
    {
        if ((Input.touchCount > 0) && (_state == States.Full))
        {
            var touch = Input.GetTouch(1);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out var hit))
            {
                if(_currentProp != null && !hit.collider.gameObject.TryGetComponent<Castle>(out var castle))
                {
                   var direction = _catapultPlace.position - hit.point;
                   
                    _currentProp.GetComponent<Rigidbody>().AddForce(-direction.normalized * Time.deltaTime * _propFireSpeed, ForceMode.Impulse);
                    
                    _state = States.Empty;
                    _currentProp = null;
                }               
            }
        }
    }

    private void CheckState()
    {
        if (_currentProp == null && _state == States.Full)
        {
            _state = States.Empty;
        }

    }

    enum States
    {
        Empty,
        Full
    }


}
