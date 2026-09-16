using UnityEngine;
using UnityEngine.SceneManagement;

public class CrushDetection : MonoBehaviour
{
    [SerializeField] float RestartDelay = 1f;
    [SerializeField] ParticleSystem CrashParticle;
    void OnTriggerEnter2D(Collider2D other) 
    {
        // define's index number for layer = floor
        int layerIndex = LayerMask.NameToLayer("Floor");
    
        //restarts the game when player collides
        if(other.gameObject.layer == layerIndex)
        {
            CrashParticle.Play();
            Invoke("ReloadScene", RestartDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
