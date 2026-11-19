using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public GameObject painelPause; // game object da tela de pause 
    public GameObject painelGameOver;// game object da tela de game over

    bool pausado = false;  // verifica se o o jogo está pausado, ele começa como falso
    bool jogoAcabou = false;    //Variável booleana é um tipo de dado lógico que pode assumir apenas dois valores possíveis: verdadeiro (true) ou falso (false). 
    void Start()
    {
        painelPause.SetActive(false); // tela de pause
        painelGameOver.SetActive(false); // SetActive ativa e desativa o GameObject
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // serve para pausar o jogo. Se o jogo está pausado ele continua, se não ele pausa
        {
            if (pausado) // se o jogo estiver pausado 
            {
                Continuar(); // continua
            }
            else // se não
            {
                Pausar(); // ele vai pausar
            }
        }
    }
    public void Pausar()
    {
        if(jogoAcabou == false) //enquanto o jogoAcabou estiver como falso
        {
            pausado = true; // jogo pausado como verdadeiro
            painelPause.SetActive (true); // ativa a tela de pause
            Time.timeScale = 0f; // a escala dele no zero 
        }
    }

    public void Continuar()
    {
        pausado = false; // o jogo não está pausado
        painelPause.SetActive(false); // o painel de pause não está ativo
        Time.timeScale = 1f; // escala do jogo 
    }
    public void MostrarGameOver()   // tela de morte, verifica de o player morreu
    {
        jogoAcabou = true; //se o player morrer 
        painelGameOver.SetActive (true); // ativa o painel de game over
        Time.timeScale = 0f; //escala do jogo como 0
    }
    public void Reiniciar()  //reinicia a fase 
    {
        Time.timeScale = 1f; // escala padrão do jogo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // gerenciamento de cenas
    
    }
    public void VoltarMenu()  // menu de cena
    {
        Time.timeScale = 1f; // escala do jogo
        SceneManager.LoadScene(0); // cena do menu como 0
    }
}

