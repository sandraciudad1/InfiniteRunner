using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadMove : MonoBehaviour
{
    private float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sectionTrigger trigger = GameObject.Find("Sphere").GetComponent<sectionTrigger>();
        if (trigger != null && trigger.lose==false)
        {
            if(trigger.seconds>0 && trigger.seconds % 15 == 0)
            {
                speed += 0.001f;
            }
            transform.position += new Vector3(0, 0, 2) * Time.deltaTime * speed;
        } 

        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("destroy"))
        {
            Destroy(gameObject);
        }
    }

}
