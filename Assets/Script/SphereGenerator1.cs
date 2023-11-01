using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator1 : MonoBehaviour
{
    public GameObject[] prefabs;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (CanGenerateSphere())
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                GenerateSphere();
            }
        }
    }

    bool CanGenerateSphere()
    {
        Vector3 objectSize = transform.localScale;

        Collider[] colliders = Physics.OverlapBox(transform.position, objectSize);


        foreach (var collider in colliders)
        {
            if (collider.gameObject.CompareTag("ball")) // "Ball"タグを持つオブジェクトが存在する場合
            {
                return false; // ボールが存在する場合、生成できない
            }
        }

        return true; // ボールが存在しない場合、生成可能
    }

    void GenerateSphere()
    {
        int randomIndex = Random.Range(0, prefabs.Length); // ランダムなインデックスを選ぶ
        GameObject selectedPrefab = prefabs[randomIndex]; // ランダムに選んだプレハブを取得
        // Sphereのインスタンスを生成
        GameObject instance = Instantiate(selectedPrefab, transform.position, Quaternion.identity);

        // 生成したSphereを必要に応じて初期化するなどの処理を追加することができます
    }
}
