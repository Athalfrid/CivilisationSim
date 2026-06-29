using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    public City city;

    [SerializeField]
    private ResourceDatabase resourceDatabase;
    public ResourceDatabase ResourceDatabase => resourceDatabase;
    private TimeManager time;

    private float timer = 0f;

    private float gameSpeed = 1f;
    private float tickDuration = 4f;
    void Awake()
    {
        city = new City("Ma première ville",resourceDatabase);
        time = new TimeManager();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * gameSpeed;

        if (timer >= tickDuration)
        {
            city.Tick();
            time.Tick();
            timer = 0f; 
        }
    }

    public int GetYear()
    {
        return time.Year;
    }
}
