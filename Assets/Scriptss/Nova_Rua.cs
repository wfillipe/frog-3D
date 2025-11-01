using UnityEngine;

public class PlayerRoadSpawner : MonoBehaviour
{
    [Header("Referências")]
    public GameObject roadPrefab;     // o prefab da rua
    public float roadLength = 20f;    // tamanho da rua (Z)
    private GameObject lastSpawnedRoad;

    private void Start()
    {
        // encontra a primeira rua da cena (opcional)
        lastSpawnedRoad = GameObject.FindWithTag("Road");
    }

    private void OnTriggerEnter(Collider other)
    {
        // se o player entrar no trigger da rua
        if (other.CompareTag("RoadTrigger"))
        {
            // pega a posição da rua atual
            Transform currentRoad = other.transform.parent;
            Vector3 newPos = currentRoad.position + new Vector3(0, 0, roadLength);

            // instancia nova rua
            GameObject newRoad = Instantiate(roadPrefab, newPos, Quaternion.identity);
            lastSpawnedRoad = newRoad;

            Debug.Log("Nova rua gerada!");
        }
    }
}
