using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [Header("Configurações")]
    public GameObject carPrefab;       // prefab do carro
    public Transform leftSpawnPoint;   // ponto de spawn da esquerda
    public Transform rightSpawnPoint;  // ponto de spawn da direita
    public float spawnInterval = 2f;   // tempo entre spawns
    public float carSpeed = 5f;        // velocidade dos carros

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnCars();
            timer = 0f;
        }
    }

    void SpawnCars()
    {
        // spawn da esquerda > direita
        GameObject carL = Instantiate(carPrefab, leftSpawnPoint.position, Quaternion.identity, transform);
        carL.AddComponent<CarMovement>().Initialize(Vector3.right, carSpeed);

        // spawn da direita > esquerda
        GameObject carR = Instantiate(carPrefab, rightSpawnPoint.position, Quaternion.identity, transform);
        carR.AddComponent<CarMovement>().Initialize(Vector3.left, carSpeed);
    }
}
