using TMPro;
using UnityEngine;

public class Hud : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private TextMeshProUGUI bestTimeText;
    
    private void Start()
    {
        timeText.text = Time.time.ToString("F2");
    }
    
    private void Update()
    {
        timeText.text = Timer.GetTime.ToString("F2");
        bestTimeText.text = Score.bestTime.ToString("F2");
    }
}