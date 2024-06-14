using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManeger : MonoBehaviour
{
    [SerializeField] GameObject _item;
    void Start()
    {
        /*float _random = Random.Range(100, -100);*/
        for (int i = 1; i < 50; i++)
        {
            Instantiate(_item,new Vector3(0,5,i * 20 + 5),Quaternion.identity) ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
