using UnityEngine;

public class billboarding : MonoBehaviour
{
    public Camera mainCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = mainCamera.transform.position;
       // transform.LookAt(targetPosition);
        targetPosition.z =transform.position.z;
    }
}
