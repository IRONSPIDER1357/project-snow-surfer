using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float RestartDelay = 1f;
    [SerializeField] ParticleSystem FinishParticle;   
    void OnTriggerEnter2D(Collider2D other) 
    {
        //define's index number for layer = Player
        int layerIndex = LayerMask.NameToLayer("Player");

        //Restarts the game when player clear the level
        if (other.gameObject.layer == layerIndex)
        {
            FinishParticle.Play();
            Invoke("ReloadScene", RestartDelay);
        }

    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
