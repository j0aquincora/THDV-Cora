using UnityEngine;

public class MysticRotationAndFloat : MonoBehaviour
{
    public float rotationSpeed = 50f;       
    //public float floatMagnitude = 0.5f;     
    //public float floatSpeed = 1f;           

    private Vector3 startPosition;          

    void Start()
    {
        startPosition = transform.position;    
    }

    void Update()
    {
        
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);

       
        //Vector3 floatOffset = Vector3.up * Mathf.Sin(Time.time * floatSpeed) * floatMagnitude;
        //transform.position = startPosition + floatOffset;
    }
}
