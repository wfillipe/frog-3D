using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private Vector3 direction;
    private float speed;

    public void Initialize(Vector3 dir, float spd)
    {
        direction = dir;
        speed = spd;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        // destrói o carro depois de sair da área visível
        if (Mathf.Abs(transform.position.x) > 200f)
        {
            Destroy(gameObject);
        }
    }
}
