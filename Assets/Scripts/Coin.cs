using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{

    [SerializeField] private float rotationSpeed = 100f;
    public UnityEvent OnCoin = new UnityEvent();
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {
            OnCoin.Invoke();
            Destroy(gameObject);
            
        }
    }
}
