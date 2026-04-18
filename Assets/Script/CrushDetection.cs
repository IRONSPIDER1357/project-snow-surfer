using UnityEngine;
using UnityEngine.SceneManagement;

public class CrushDetection : MonoBehaviour
{
    [SerializeField] float RestartDelay = 1f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        // define's index number for layer = floor
        int layerIndex = LayerMask.NameToLayer("Floor");

        if(other.gameObject.layer == layerIndex)
        {
            Invoke("ReloadScene", RestartDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
