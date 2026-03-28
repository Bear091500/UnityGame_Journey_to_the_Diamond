/*using UnityEngine;
using UnityEngine.SceneManagement;
public class UIretry : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
            RestartGame();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIretry : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.R)){
            RestartGame();
        }
    }
    public void RestartGame()
    {
        Debug.Log("按鈕被按了");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}