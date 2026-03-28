using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement_red : MonoBehaviour
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
        sr.flipX = true;
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Ground")){
            isGrounded = true;
        }
        if (other.CompareTag("Deadwater")||other.CompareTag("RedDead")){
            Debug.Log("dead");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        /*if (other.CompareTag("ButtonRed")){
            Debug.Log("Red");
            door.Button2Pressed = true;
        }*/
    }
    void OnTriggerExit2D(Collider2D other){
        if (other.CompareTag("Ground")){
            isGrounded = false;
        }
        /*if (other.CompareTag("ButtonRed")){
            Debug.Log("Red");
            door.Button2Pressed = false;
        }*/
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            movement = speed;
            sr.flipX = true;
        }else if (Input.GetKey(KeyCode.A)){
            movement = -speed;
            sr.flipX = false;
        }
        else{
            movement = 0f;
        }
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
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
