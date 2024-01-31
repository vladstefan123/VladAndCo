using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow1 : MonoBehaviour
{
     private Transform target;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        target= GameObject.FindGameObjectWithTag("MARIUS").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        var rotationVectorSlime = transform.rotation.eulerAngles;
        Quaternion rotationSlime = transform.rotation;
        transform.position= Vector2.MoveTowards(transform.position,target.position,speed* Time.deltaTime);
        if(transform.position.x > target.position.x)
        {
            rotationVectorSlime.y = 180;
            transform.rotation = Quaternion.Euler(rotationVectorSlime);
        }
        if (transform.position.x < target.position.x)
        {
            rotationVectorSlime.y = 0;
            transform.rotation = Quaternion.Euler(rotationVectorSlime);
        }

    }
}
