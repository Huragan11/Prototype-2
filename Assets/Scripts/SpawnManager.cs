using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabsNorth;
    public GameObject[] animalPrefabsWest;
    public GameObject[] animalPrefabsEast;

    private int maxAnimalCount = 3;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private float spawnRangeZ = 13;
    private float spawnPosX = 30;

    // Start is called before the first frame update
    void Start()
    {
        //Spawning timer 
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        //Choosing randomly which animal to spawn and then spawn it at random location
        int animalIndex = Random.Range(0, maxAnimalCount);
        int spawnSide = Random.Range(0, 3);

        if (spawnSide == 0)
        {
            Instantiate(animalPrefabsNorth[animalIndex], ChooseRandomSpawnSide(spawnSide), animalPrefabsNorth[animalIndex].transform.rotation);
        }else if (spawnSide == 1)
        {
            Instantiate(animalPrefabsWest[animalIndex], ChooseRandomSpawnSide(spawnSide), animalPrefabsWest[animalIndex].transform.rotation);
        }else if (spawnSide == 2)
        {
            Instantiate(animalPrefabsEast[animalIndex], ChooseRandomSpawnSide(spawnSide), animalPrefabsEast[animalIndex].transform.rotation);
        }
    }

    private Vector3 ChooseRandomSpawnSide(int spawnSide)
    {
        if (spawnSide == 0) //north
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            return spawnPos;
        }
        else if (spawnSide == 1) //west
        {
            Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(0, spawnRangeZ));
            return spawnPos;
        }
        else if (spawnSide == 2) //east
        {
            Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(0, spawnRangeZ));
            return spawnPos;
        }
        else
        {
            return new Vector3();
        }
    }
}
