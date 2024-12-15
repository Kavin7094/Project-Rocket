using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrusting : MonoBehaviour
{

    [SerializeField] float initalrotate = 1f;
    [SerializeField] float intialthrust = 100f;
    Rigidbody rigid;
    AudioSource m_MyAudioSource;
    


    // Start is called before the first frame update
    void Start()
    {
        rigid=GetComponent<Rigidbody>();
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       ToProcess();
       Torotate();

    }

    void  ToProcess()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           rigid.AddRelativeForce(Vector3.up*Time.deltaTime*intialthrust);
           if(!m_MyAudioSource.isPlaying)
           {
              m_MyAudioSource.Play();
           }
        }
        else
        {
            m_MyAudioSource.Stop();
        }
    }

    void  Torotate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            ForRotation(initalrotate);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ForRotation(-initalrotate);
        }
    }

    void ForRotation(float rotationThisFrame)
    {
        rigid.freezeRotation =true;        
        transform.Rotate(Vector3.back*Time.deltaTime*rotationThisFrame);
        rigid.freezeRotation= false;

    }

}
