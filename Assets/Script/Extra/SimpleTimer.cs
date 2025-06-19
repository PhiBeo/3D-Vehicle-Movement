using TMPro;
using UnityEngine;

public class SimpleTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;

    private float second = 0;
    private int minute = 0;

    bool isRuning = true;

    private void Update()
    {
        if (!isRuning) return;

        second += Time.deltaTime;

        if(second >= 60)
        {
            second = 0;
            minute++;
        }

        timerText.text = minute.ToString() + " : " + Mathf.RoundToInt(second).ToString();
    }

    public void StopTimer()
    {
        isRuning = false;
    }
}
