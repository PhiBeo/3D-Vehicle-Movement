using UnityEngine;

public class FinishRun : MonoBehaviour
{
    [SerializeField] private SimpleTimer timer;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Debug.Log("Player Found!");

        timer.StopTimer();
    }
}
