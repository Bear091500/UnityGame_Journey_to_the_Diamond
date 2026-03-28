using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    
    void Start()
    {
        
    }
    public void LoadSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void Loadstarmenu()
    {
        SceneManager.LoadScene("starmenu");
    }
    public void LoadEndingScene()
    {
        SceneManager.LoadScene("EndingScene");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
