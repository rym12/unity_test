using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereContact : MonoBehaviour
{
    public string type;
    public GameObject next;

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
            ChangeSphere();
            Destroy(this.gameObject); // このオブジェクトを破棄
        }
    }

    void  ChangeSphere()
    {
        // Sphereのインスタンスを生成
        GameObject a = Instantiate(next, transform.position, Quaternion.identity);

        // 生成したSphereを必要に応じて初期化するなどの処理を追加することができます
    }
}
