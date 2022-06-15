using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public int Speed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xAxisValue = Input.GetAxis("Horizontal") * Speed;
        float zAxisValue = Input.GetAxis("Vertical") * Speed;
        float yValue = 0.0f;
 
         if (Input.GetKey(KeyCode.Q))
         {
             yValue = -Speed;
         }
         if (Input.GetKey(KeyCode.E))
         {
             yValue = Speed;
         }

        transform.position -= new Vector3(xAxisValue, yValue,  zAxisValue)  * Time.deltaTime;
       
    }
}
