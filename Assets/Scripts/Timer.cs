public class Timer
{
    private static Timer _instance;
    private static Timer Instance => _instance ??= new Timer();
    
    private float time = 0f;
    
    public static float GetTime => Instance.time;
    
    public static void AddTime(float amount)
    {
        Instance.time += amount;
    }

    public static void Reset()
    {
        if (Instance.time > Score.bestTime || Score.bestTime == 0f)
            Score.bestTime = Instance.time;
        
        Instance.time = 0f;
    }
}