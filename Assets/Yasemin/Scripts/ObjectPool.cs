using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private Queue<GameObject> pooledObjects; //oyun nesnelerini olusturan bir queue
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private int poolSize;

    private void Awake()
    {
        pooledObjects = new Queue<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab); //prefableri olusturduk
            obj.SetActive(false); //baslangicta görünmesin diye false yaptik
            pooledObjects.Enqueue(obj); //bunlari siraya koyduk
        }
    }

    public GameObject GetPooledObject()
    {
        GameObject obj = pooledObjects.Dequeue(); //kuyruktan, siradan cikarmak icin
        obj.SetActive(true);
        pooledObjects.Enqueue(obj); //siranin sonuna tekrar ekledik
        return obj;
    }
}
