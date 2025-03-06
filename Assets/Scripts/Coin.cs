using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 100f;

     void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {

            Destroy(gameObject);
        }
    }
}
