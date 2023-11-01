using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDestroy : MonoBehaviour
{
    public string type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        this.tag = type;

        if (collision.gameObject.CompareTag(type)) //タグが"ball"のオブジェクトに接触した場合
        {
            Destroy(this.gameObject); // このオブジェクトを破棄
        }
    }
}
