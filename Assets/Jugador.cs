using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 500 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 500 * Time.deltaTime);
        }
        
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
    }

}
