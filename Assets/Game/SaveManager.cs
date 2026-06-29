using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private float autoSaveTimer = 0f;
    private float autoSaveInterval = 120f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        autoSaveTimer += Time.deltaTime;

        if(autoSaveTimer >= autoSaveInterval)
        {
            autoSaveTimer = 0f;
            AutoSave();
        }
    }

    public void Save()
    {
        Debug.Log("Sauvegarde du jeu...");
    }

    private void AutoSave()
    {
        Debug.Log("Sauvegarde automatique du jeu...");
        Save();
    }
}
