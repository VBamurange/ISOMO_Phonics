using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
    public Slider volumeSlider;
    private AudioSource[] audioSources;

    void Start()
    {
        
    }

    
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGameMethod()
    {
        // If we're in the editor, stop the play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // If we're not in the editor, quit the game
        Application.Quit();
#endif
    }
}
