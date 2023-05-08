using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager instance;

    public GameObject enemyObject;
    public int enemyQuantity;
    public GameObject enemyParent;
    public GameObject allyObject;
    public int allyQuantity;
    public GameObject allyParent;

    [HideInInspector]
    public List<GameObject> objectInPool = new List<GameObject>();

    private void Awake()
    {
        instance = this;

        for(int i = 0; i < enemyQuantity; i++)
        {
            InstantiateInPool(enemyObject, enemyParent);
        }

        for (int i = 0; i < allyQuantity; i++)
        {
            InstantiateInPool(allyObject, allyParent);
        }

    }

    public GameObject GetItem(GameObject obj, Vector3 pos , Quaternion rot)
    {
        for (int i = 0; i < objectInPool.Count; i++)
        {
            if (objectInPool[i].gameObject.name.Contains(obj.name) && !objectInPool[i].activeInHierarchy)
            {
                objectInPool[i].transform.position = pos;
                objectInPool[i].transform.rotation = rot;
                objectInPool[i].SetActive(true);

                return objectInPool[i];
            }
        }     

        return null;
    }    

    public void InstantiateInPool(GameObject obj, GameObject parent)
    {
        GameObject inst = Instantiate(obj, Vector3.zero, Quaternion.identity, parent.transform);
        objectInPool.Add(inst);
        inst.SetActive(false);
    }
}