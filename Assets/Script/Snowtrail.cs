using UnityEngine;

public class Snowtrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowParticle;

    void OnCollisionEnter2D(Collision2D collision)
    {
      int layerIndex = LayerMask.NameToLayer("Floor");
    
        if(collision.gameObject.layer == layerIndex)
        {
            snowParticle.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Floor");
    
        if(collision.gameObject.layer == layerIndex)
        {
            snowParticle.Stop();
        }
    }
}