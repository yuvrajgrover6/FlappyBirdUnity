using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovescript : MonoBehaviour
{

    public float moveSpeed;
    // Start is called before the first frame update
    public float deadZone = -39;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        Debug.Log("Pipe Deleted");
        if(transform.position.x<deadZone){
            Destroy(gameObject);
        }
    }
}
