using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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

        Debug.Log("GameManager initialisé");    
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * gameSpeed;

        if (timer >= tickDuration)
        {
            city.Tick();
            time.Tick();

            Debug.Log(
                "Année : "
                + time.Year
                + "\tPopulation : "
                + city.Population
                +"/"
                +city.GetHousingCapacity()
                + "\tNourriture : "
                
            );

            timer = 0f; // <-- il manquait ça
        }
    }

    public int GetYear()
    {
        return time.Year;
    }
}
