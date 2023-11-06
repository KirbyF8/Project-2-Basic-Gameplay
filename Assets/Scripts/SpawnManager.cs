using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
   [SerializeField] private GameObject[] animalsArray;
    private int animalIndex;
    private float animalX;
    private float cameraLimitx = 12.5f;
    private int lastAnimal = 2;
    [SerializeField] private float startDelay = 2f;
    private float spawnInterval = 1.4f;
    private int MAS = 30;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay, spawnInterval);

        InvokeRepeating("SpawnRandomAnimal", startDelay+0.5f, spawnInterval * 2.1f);
    }

    private void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalsArray.Length);
        animalX = Random.Range(-cameraLimitx, cameraLimitx);
        if (lastAnimal == animalIndex)
        {
            animalIndex = Random.Range(0, animalsArray.Length);
        }
        else
        {
            Instantiate(animalsArray[animalIndex], new Vector3(animalX, 0, 24), Quaternion.Euler(0, 180, 0));
            lastAnimal = animalIndex;
            MAS--;
        }
    }
}
