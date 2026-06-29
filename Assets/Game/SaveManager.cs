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

    public void Save()
    {

        CitySave save = gameManager.city.CreateSave();
        string json = JsonUtility.ToJson(save, true);
        string savePath = Path.Combine(Application.persistentDataPath,"save.json");
        Debug.Log("City Save JSON path: " + savePath);
        File.WriteAllText(savePath, json);
    }

    private void AutoSave()
    {
        Debug.Log("Sauvegarde automatique du jeu...");
        Save();
    }
}
