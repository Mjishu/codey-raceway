using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimersCountdown : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI countdownText;

    public float totalLapTime;
    public float totalCountdowntime;

    public CodeyMove move;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (totalCountdowntime > 0)
        {
            totalCountdowntime -= Time.deltaTime;
            countdownText.text = Mathf.Round(totalCountdowntime).ToString();
            move.Speed = 0;
        }
        else
        {
            countdownText.text = "";
            totalLapTime -= Time.deltaTime;
            timerText.text = Mathf.Round(totalLapTime).ToString();
            move.Speed = 40;
        }

        if (totalLapTime <= 0)
        {
            print("Time is up");
        }
    }
}
