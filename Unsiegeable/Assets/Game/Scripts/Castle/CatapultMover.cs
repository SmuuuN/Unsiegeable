using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultMover : MonoBehaviour
{ 
    
    private void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out var hit);
        var pointToGo = new Vector3(-7, 2.3f, hit.point.z);

        transform.position = (pointToGo);
    }
}
