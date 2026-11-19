using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void StartGame()  // todo o código serve para do menu ir até Fase1
    {
        SceneManager.LoadScene("Fase1"); // loga a fase1
    }

   
    public void QuitGame() //sair do jogo
    {
        Application.Quit(); // sair do jogo
    }

}
