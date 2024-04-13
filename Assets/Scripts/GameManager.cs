using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance != null) return _instance;
            
            _instance = FindObjectOfType<GameManager>();

            if (_instance != null) return _instance;
            
            GameObject singletonObject = new("GameManager");
            _instance = singletonObject.AddComponent<GameManager>();
            DontDestroyOnLoad(singletonObject);
            return _instance;
        }
    }

    private void Update()
    {
        Timer.AddTime(Time.deltaTime);
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
            Destroy(gameObject);
        else
            _instance = this;
        
        Timer.Reset();
    }
}

public class Score
{
    public static float bestTime = 0f;
}