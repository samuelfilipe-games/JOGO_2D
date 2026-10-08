using UnityEngine;
using UnityEngine.Rendering.Universal;


public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float minX, maxX;
    public float minY, maxY; // Adicione limites para o eixo Y se quiser
    public float timeLerp;

    private void FixedUpdate()
    {
        // Pega a posição do player no X e Y, mantendo o Z em -10
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y, -10f);

        // Suaviza o movimento da câmera até a posição do player
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, timeLerp);

        // Aplica os limites (clamp) no X e no Y
        float clampedX = Mathf.Clamp(smoothedPosition.x, minX, maxX);
        float clampedY = Mathf.Clamp(smoothedPosition.y, minY, maxY);

        transform.position = new Vector3(clampedX, clampedY, smoothedPosition.z);
    }
}

