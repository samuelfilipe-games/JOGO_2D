using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float speed = 5f; //velociade do player
    private Rigidbody2D rb; // corpo do player
    public int coins; // moedas
    private bool isGrounded = false; // verifica se esta no chão
    public MenuScene menu; // cena de menu

    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); //corpo do player
    }

    
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // movimento horizontal
        rb.linearVelocity = new Vector2( moveHorizontal * speed, rb.linearVelocity.y ); //esse é pra fazer o player andar na horizontal
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) // quando a tecla espaço for clicada o player pula
        {
            rb.AddForce(new Vector2(0f, 8f), ForceMode2D.Impulse); // esse é pra fazer player pular
        }
    }

   void OnCollisionEnter2D(Collision2D collision) // colisão do player
    {
        if (collision.gameObject.CompareTag("Ground")) // tag chão
        {
            isGrounded = true; //vai reconhecer quando o jogador pular no chão
            
        }
        
        if (collision.gameObject.CompareTag("Dano")) // tag dano
        {
            menu.MostrarGameOver(); // se ele morrer aparece game over
        }


    }
    private void OnCollisionExit2D(Collision2D collision)  // colisão do player com o chão
    {
     if (collision.gameObject.CompareTag("Ground"))  // se ele estiver no chão ele pula
        {
            isGrounded = false; //ele está como falso ou seja não está no chão 
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) // colisão do player com as moedas
    {
     if (collision.gameObject.tag == "Coins") // se ele colidir com um objeto com tag "coins"
        {
            Destroy(collision.gameObject); // faz as moedas sumir após ser colidida 
            coins++; // +1 moeda
        }
            
    }
}
