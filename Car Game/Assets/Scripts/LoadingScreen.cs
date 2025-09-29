using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{
    public string sceneToLoad = "GameScene"; // Assign in Inspector

    public void LoadSpecificScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}