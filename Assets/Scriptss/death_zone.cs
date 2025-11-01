using UnityEngine;

public class DeathZoneAccelerating : MonoBehaviour
{
    [Header("Velocidade inicial e aceleração")]
    public float initialSpeed = 5f;    // velocidade inicial
    public float acceleration = 1f;  // quanto a velocidade aumenta por segundo
    public float maxSpeed = 50f;       // velocidade máxima

    private float currentSpeed;

    void Start()
    {
        currentSpeed = initialSpeed;
    }

    void Update()
    {
        // move no eixo Z negativo
        transform.Translate(0, 0, currentSpeed * Time.deltaTime, Space.World);

        // aumenta a velocidade até o máximo
        currentSpeed += acceleration * Time.deltaTime;
        if (currentSpeed > maxSpeed)
            currentSpeed = maxSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        // destrói tudo que seja raiz da rua ou qualquer outro objeto
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
