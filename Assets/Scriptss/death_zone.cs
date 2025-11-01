using UnityEngine;

public class DeathZoneMovement : MonoBehaviour
{
    [Header("Velocidade da Death Zone")]
    public float speed = 5f; // velocidade no eixo Z (quanto maior, mais rápido ela anda)

    void Update()
    {
        // move a Death Zone para frente no eixo Z (diminuindo Z)
        transform.Translate(0, 0, speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        // destrói qualquer objeto que seja parte da rua
        if (other.transform.root.CompareTag("Road"))
        {
            Destroy(other.transform.root.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
