using Unity.VisualScripting;
using UnityEngine;

public class CrushDetection : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        int layerIndex = LayerMask.NameToLayer("Floor");

        if(other.gameObject.layer == layerIndex)
        {
            Debug.Log("You lose");
        }
    }
}
