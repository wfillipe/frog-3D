using UnityEngine;

public class PlayerCarAttach : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se o player encostou em um carro
        if (collision.gameObject.CompareTag("Car"))
        {
            // Torna o player filho do carro para seguir seu movimento
            transform.SetParent(collision.transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Quando o player sai do carro, ele se solta
        if (collision.gameObject.CompareTag("Car"))
        {
            transform.SetParent(null);
        }
    }
}
