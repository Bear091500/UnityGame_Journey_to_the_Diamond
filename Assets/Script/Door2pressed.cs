using UnityEngine;

public class Door2pressed : MonoBehaviour
{
    public bool Button1Pressed = false;
    public bool Button2Pressed = false;
    public Button_Pig_red red;
    public Button_Pig_blue blue;
    void Start(){
        
    }

    void Update()
    {
        if(Button1Pressed == true && Button2Pressed == true)
        {
            Disappear();
            red.Disappear();
            blue.Disappear();
        }
    }
    public void Disappear()
    {
        GetComponent<SpriteRenderer>().enabled = false; 
        GetComponent<Collider2D>().enabled = false;  
    }
}
