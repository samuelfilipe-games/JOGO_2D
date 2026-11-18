using UnityEngine;
using UnityEngine.SceneManagement;

public class TracarFase : MonoBehaviour
{
    public string nomeDaFase;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CarregarNovaFase();
        }
    }

    private void CarregarNovaFase()
    {
        SceneManager.LoadScene(nomeDaFase);
    }
}

