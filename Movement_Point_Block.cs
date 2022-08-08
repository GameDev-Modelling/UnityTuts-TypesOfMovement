using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MovementCar : MonoBehaviour
{
    public float horizontalInput, vertiInput;
    public float speedmultiplier; 
 
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        float vertiInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
 
 
        Vector3 direction = new Vector3(horizontalInput, 0, vertiInput);
        transform.Translate(direction * Time.deltaTime * 5 * speedmultiplier);
    }
}
