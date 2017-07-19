using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlv : MonoBehaviour
{

    [SerializeField]
    int layerFilter = 11;
    [SerializeField]
    float triggerRadius = 5f;



    void Start()
    {
        SphereCollider sphereCollider = gameObject.AddComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
        sphereCollider.radius = triggerRadius;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == layerFilter)
        {
            SceneManager.LoadScene("WIn");
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 255f, 0, .5f);
        Gizmos.DrawWireSphere(transform.position, triggerRadius);
    }
}