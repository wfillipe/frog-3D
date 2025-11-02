using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [Header("Configurações")]
    public GameObject carPrefab;        // prefab do carro
    public Transform leftSpawnPoint;    // ponto de spawn da esquerda
    public Transform rightSpawnPoint;   // ponto de spawn da direita
    public float minSpawnInterval = 1.5f; // intervalo mínimo entre spawns
    public float maxSpawnInterval = 3.5f; // intervalo máximo entre spawns
    public float carSpeed = 5f;         // velocidade dos carros

    private float timer = 0f;
    private float currentInterval;

    void Start()
    {
        // define um tempo inicial aleatório
        currentInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= currentInterval)
        {
            SpawnCars();
            timer = 0f;

            // define o próximo intervalo aleatoriamente
            currentInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        }
    }

    void SpawnCars()
    {
        // spawn da esquerda → direita
        GameObject carL = Instantiate(carPrefab, leftSpawnPoint.position, Quaternion.identity);
        carL.AddComponent<CarMovement>().Initialize(Vector3.right, carSpeed);

        // spawn da direita → esquerda
        GameObject carR = Instantiate(carPrefab, rightSpawnPoint.position, Quaternion.identity);
        carR.AddComponent<CarMovement>().Initialize(Vector3.left, carSpeed);
    }
}
