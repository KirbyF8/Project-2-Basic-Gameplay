using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassMovement : MonoBehaviour
{

    [SerializeField] private float Speed = 0.5f;
    private float zRange = -40f;
    
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, -Speed * Time.deltaTime /2);
        Vector3 position = transform.position;

        if (position.z <= zRange)
        {
            transform.Translate(0, 0, 99);
            
        }
        
    }
}
