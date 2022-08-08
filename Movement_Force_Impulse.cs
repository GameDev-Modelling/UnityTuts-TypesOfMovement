using UnityEngine;

public class Example : MonoBehaviour
{
    public float thrust = 1.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    
    void Update(){
      if(Input.GetButton("Jump")){
        rb.AddForce(0, thrust, 0, ForceMode.Impulse);  
      }
    }
}
