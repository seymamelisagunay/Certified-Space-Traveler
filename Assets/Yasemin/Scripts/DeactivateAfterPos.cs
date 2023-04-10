using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateAfterPos : MonoBehaviour
{
    public float bulletDeactivatePos;

    void Update()
    {
        if (transform.position.y > bulletDeactivatePos || transform.position.y < -bulletDeactivatePos) //belirli bir yere ulastiktan sonra deactive olur
        {
            gameObject.SetActive(false);
        }

    }
}
