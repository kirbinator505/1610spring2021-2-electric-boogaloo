using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderBehavior : MonoBehaviour
{
    [SerializeField] private GameObject button;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void Awake()
    {
        button.SetActive(false);
    }
}
