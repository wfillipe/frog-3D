using UnityEngine;

public class DestroyerCollider : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // se encostar no player -> Game Over
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over! Player atingido pelo destruidor.");
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("rua") || other.CompareTag("carro") || other.CompareTag("carro2"))
        {
            // destrói ruas e carros
            Destroy(other.gameObject);
        }
        else
        {
            // destrói qualquer outro objeto que não precise ficar
            Destroy(other.gameObject);
        }
    }
}
