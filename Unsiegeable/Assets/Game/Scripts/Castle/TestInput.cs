using UnityEngine;

public class TestInput : MonoBehaviour
{
    private void Update()
    {
        if(Input.touchCount > 0 )
        {
            var touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            Physics.Raycast(ray, out var hit); 
            var pointToGo = new Vector3(-7, 2.3f, hit.point.z);            
        }
    }
}
