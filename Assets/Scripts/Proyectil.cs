using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    [SerializeField] private float Speed = 15f;
    private float zRange = 25f;
    private float zRange2 = -8f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0 , Speed * Time.deltaTime);
        ProjectileBounds();
    }

    private void ProjectileBounds()
    {
        Vector3 position = transform.position;

        if (position.z >= zRange)
        {
            Destroy(gameObject);
        }
        if (position.z <= zRange2)
        {
            Destroy(gameObject);
            Debug.Log("You Losed");
            Time.timeScale = 0;
        }

    }
}
