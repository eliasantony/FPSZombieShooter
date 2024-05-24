using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraTracker : MonoBehaviour
{
    [SerializeField] public Transform playerCamera;
    public float yOffset = 5f;
    

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = playerCamera.position;
        newPosition.y = yOffset;
        
        this.transform.position = newPosition;
    }
}
