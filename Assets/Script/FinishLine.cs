using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float RestartDelay = 1f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        //define's index number for layer = Player
        int layerIndex = LayerMask.NameToLayer("Player");

        if (other.gameObject.layer == layerIndex)
        {
            Invoke("ReloadScene", RestartDelay);
        }

    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
