using UnityEngine;

public class CameraFluida : MonoBehaviour
{
    public Transform alvo; // o alvo é o player
    public Vector3 distancia = new Vector3(0f, 0f, -10f); // distância da camera
    public bool movimentoSuave = true;  // movimento suave ativo
    public float velocidade = 5f;  // velocidade do player

    private void LateUpdate()
    {
        Vector3 posicaoDesejada = alvo.position + distancia; //posição detalhada do player
        if (movimentoSuave) // se o movimento suave estiver ligado
        {
            transform.position = Vector3.Lerp(transform.position, posicaoDesejada, velocidade * Time.deltaTime); // ele vai criar vários pontos para torna a movimentação suave
        }
        else // se ele estiver desligado
        {
            transform.position = posicaoDesejada; // posição desejada
        }

                
    }



}
