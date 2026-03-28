using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement_blue : MonoBehaviour
{
    Rigidbody2D rb;
    bool jumpPressed = false;
    public Door2pressed door;
    public float speed = 4f;
    public float jump = 4.2f;
    float movement;
    bool isGrounded = false;
    SpriteRenderer sr;
    void Awake(){
        sr = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Ground")){
            isGrounded = true;
            Debug.Log("touch");
        }
        if (other.CompareTag("Deadwater")){
            Debug.Log("dead");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        /*if (other.CompareTag("ButtonBlue")){
            Debug.Log("Blue");
            door.Button1Pressed = true;
        }*/
    }
    void OnTriggerExit2D(Collider2D other){
        if (other.CompareTag("Ground")){
            isGrounded = false;
            Debug.Log("off");
        }
        /*if (other.CompareTag("ButtonBlue")){
            Debug.Log("Blue");
            door.Button1Pressed = false;
        }*/
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)){
            movement = speed;
            sr.flipX = true;
        }else if (Input.GetKey(KeyCode.LeftArrow)){
            movement = -speed;
            sr.flipX = false;
        }
        else{
            movement = 0f;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            jumpPressed = true;
        }
    }
    void FixedUpdate()
    {
        rb.linearVelocityX = movement;
        if (jumpPressed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jump);
            jumpPressed = false;
        }
    }
}
