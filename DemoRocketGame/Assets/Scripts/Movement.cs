using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Movement : MonoBehaviour
{
    [SerializeField] float rocketThrust = 1000;
    [SerializeField] float rotateSpeed = 1;
    Rigidbody rigidBody;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
       rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            Vector3 thrustForce = new Vector3 { x=0, y=rocketThrust * Time.deltaTime, z=0 };
            rigidBody.AddRelativeForce(force: thrustForce);
            
        }  
        else
        {
            audioSource.Stop();
        }
    }

    void ProcessRotation()
    {
        rigidBody.freezeRotation = true;
        if (Input.GetKey(KeyCode.A))
        {

            Vector3 Rotate = new Vector3 { x = 0, y = 0, z = rotateSpeed * Time.deltaTime };
            transform.Rotate(eulers: Rotate);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            Vector3 Rotate = new Vector3 { x = 0, y = 0, z = rotateSpeed * Time.deltaTime };
            transform.Rotate(eulers: -Rotate);
        }
        rigidBody.freezeRotation = false;

    }
}
