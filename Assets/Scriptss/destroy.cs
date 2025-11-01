using UnityEngine;

public class DestroyOnDeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathZone"))
        {
            Destroy(gameObject);
        }
    }
}
