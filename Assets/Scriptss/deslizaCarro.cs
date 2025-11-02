using UnityEngine;

public class PlayerPlatformAttach : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            transform.parent = collision.transform; // o player “gruda” no carro
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            transform.parent = null; // solta quando sai do carro
        }
    }
}
