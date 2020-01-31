using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class InstantiationExample : MonoBehaviour
{

    public GameObject enemyToCreate;
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        Object prefabObject = Resources.Load("Enemy", typeof(GameObject));
        enemyToCreate = PrefabUtility.InstantiatePrefab(prefabObject, spawn.transform) as GameObject;
        //enemyToCreate = Instantiate(Resources.Load("Enemy") as GameObject, new Vector3(0f, 0f, 158.4601f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
