using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public City city;

    public World world;

    [SerializeField]
    private ResourceDatabase resourceDatabase;
    public ResourceDatabase ResourceDatabase => resourceDatabase;
    [SerializeField]
    private BuildingDatabase buildingDatabase;
    public BuildingDatabase BuildingDatabase => buildingDatabase;
    private TimeManager time;

    private float timer = 0f;

    private float gameSpeed = 1f;
    private float tickDuration = 4f;
    void Awake()
    {
        world = new World(20, 20);
        city = new City("Ma première ville", resourceDatabase);
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

    public void LoadTime(int year)
    {
        time.Load(year);
    }

    public SaveGame CreateSave()
    {
        SaveGame save = new SaveGame();
        save.City = city.CreateSave();
        save.Year = time.Year;
        save.World = world.CreateSave();
        save.LastSaveDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        return save;
    }

    public void LoadGame(SaveGame save)
    {
        city = City.FromSave(save.City, resourceDatabase, buildingDatabase);
        time.Load(save.Year);
        world = World.FromSave(save.World);
    }
}
