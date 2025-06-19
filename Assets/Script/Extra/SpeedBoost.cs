using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float _speed;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        
        Debug.Log(other.gameObject.name);

        Rigidbody rb = new Rigidbody();

        if(other.TryGetComponent<Rigidbody>(out rb))
        {
            rb.AddForce(Vector3.forward * _speed, ForceMode.VelocityChange);
        }
    }
}
