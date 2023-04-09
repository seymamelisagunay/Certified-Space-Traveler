using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;

    private float speed = 4f;
    private bool isShooting;
    private float cooldown = 0.5f;

    private const float maxX = 7.7f;
    private const float minX = -4.4f;


    [SerializeField] private ObjectPool objectPool = null;

    void Update()
    {
#if UNITY_EDITOR //editor kontrolu icin
        //verdigimiz sinirlar arasinda saga sola gitme hareketimiz gerceklesir
        if(Input.GetKey(KeyCode.A) && transform.position.x > minX)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        if(Input.GetKey(KeyCode.D) && transform.position.x < maxX)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.Space) && !isShooting) //her space'e bastigimizda shoot icerisindeki adimlar tekrarlanir
        {
            StartCoroutine(Shoot());
        }
#endif


        IEnumerator Shoot()
        {
            isShooting = true;
            GameObject obj = objectPool.GetPooledObject();
            obj.transform.position = gameObject.transform.position;
            yield return new WaitForSeconds(cooldown); 
            isShooting = false;
        }

    }
}
