using UnityEngine;

public class Mud : MonoBehaviour
{
    [Range(1f, 3f)] public float _massMultiplier = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Rigidbody rb = other.GetComponent<Rigidbody>();

        rb.linearVelocity *= 0.5f;

        CarController controller = rb.GetComponent<CarController>();

        controller.ApplyBraking();

        controller.SlowMotorForce(_massMultiplier);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        CarController controller = other.GetComponent<CarController>();

        controller.PaceUpMotorForce(_massMultiplier);
    }
}
