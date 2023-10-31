using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float playerspeed = 15f;

    private float horizontalInput;

    private float xRange = 13f;

    [SerializeField] private GameObject projectileprefab;
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * playerspeed * Time.deltaTime * horizontalInput);

        PlayerBounds();


        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyUp(KeyCode.Space) )
        {
            Shoot();
        }
    }

    private void PlayerBounds()
    {
        Vector3 position = transform.position;

        if (position.x >= xRange)
        {
            transform.position = new Vector3(-xRange, position.y, position.z);
        }
        if (position.x <= -xRange)
        {
            transform.position = new Vector3(xRange, position.y, position.z);
        }

        
    }

    private void Shoot()
    {
        Instantiate(projectileprefab, transform.position, Quaternion.identity);
    }
}
