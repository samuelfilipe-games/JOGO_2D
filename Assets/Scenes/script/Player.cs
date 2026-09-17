using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2( moveHorizontal * speed, rb.linearVelocity.y ); //esse é pra fazer o player andar na horizontal
       if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); // esse é pra fazer player pular
        }
    }
}
