using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public ExitDoor redDoor;
    public ExitDoor blueDoor;
    private bool levelFinished = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (!levelFinished && redDoor.isFullyOpen && blueDoor.isFullyOpen)
        {
            levelFinished = true;
            LoadEndingScene();
            Debug.Log("Level Completed!");

        }
    }
    public void LoadEndingScene()
    {
        SceneManager.LoadScene("EndingScene");
    }
   
}
