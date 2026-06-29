using UnityEngine;
using System.IO;

public class SaveManager : MonoBehaviour
{
    private float autoSaveTimer = 0f;
    private float autoSaveInterval = 120f;

    [SerializeField]
    private GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        autoSaveTimer += Time.deltaTime;

        if (autoSaveTimer >= autoSaveInterval)
        {
            autoSaveTimer = 0f;
            AutoSave();
        }
    }

    public void Save(string filename)
    {
        /*SaveGame save = new SaveGame();

        save.City = gameManager.city.CreateSave();
        save.Year = gameManager.GetYear();
        save.LastSaveDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");*/
        SaveGame save = gameManager.CreateSave();

        string json = JsonUtility.ToJson(save, true);
        string savePath = Path.Combine(Application.persistentDataPath,filename);
        Debug.Log("City Save JSON path: " + savePath);
        File.WriteAllText(savePath, json);
    }

    private void AutoSave()
    {
        Debug.Log("Sauvegarde automatique du jeu...");
        Save("autosave.json");
    }

    public void Load()
    {
        string savePath = Path.Combine(Application.persistentDataPath, "save.json");
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            SaveGame save = JsonUtility.FromJson<SaveGame>(json);
            gameManager.LoadGame(save);
            //ON enlève tout au dessus pour mettre gameManager.LoadGame(save) ici et éviter que SaveManager voie le contenu de GameManager  

            Debug.Log("Jeu chargé depuis le fichier de sauvegarde.");
        }
        else
        {
            Debug.LogWarning("Aucun fichier de sauvegarde trouvé.");
        }
    }
}
