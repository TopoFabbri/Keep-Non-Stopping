using TMPro;
using UnityEngine;

public class Hud : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    
    private void Start()
    {
        timeText.text = Time.time.ToString("F2");
    }
    
    private void Update()
    {
        timeText.text = Timer.GetTime.ToString("F2");
    }
}