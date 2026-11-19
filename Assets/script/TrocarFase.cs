using UnityEngine;
using UnityEngine.SceneManagement;

public class TracarFase : MonoBehaviour
{
    public string nomeDaFase; // variavel feita pra colocar no nome da fase

    private void OnTriggerEnter2D(Collider2D other) // colisor da linha de chegada
    {
        if (other.CompareTag("Player")) // se o player tocar na linha de chegada
        {
            CarregarNovaFase(); // vai carregar a nova fase
        }
    }

    private void CarregarNovaFase() // carrega a nova fase
    {
        SceneManager.LoadScene(nomeDaFase); //vai iniciar a fase da variavel 
    }
}

