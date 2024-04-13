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
        Instance.time = 0f;
    }
}