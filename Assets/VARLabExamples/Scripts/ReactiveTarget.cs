using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    [SerializeField] private GameObject explosionCartoon;

    [SerializeField] private MeshRenderer enemyMesh;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "ThrowSB")
        {
            explosionCartoon.SetActive(true);
            enemyMesh.enabled = false;
            // Instantiate(gameObject);
            //explode.Play();
            StartCoroutine(StopExplosion());
        }
    }
    IEnumerator StopExplosion()
    {
        yield return new WaitForSeconds(1f);
        //explosionCartoon.SetActive(false);
        Destroy(gameObject);
        Debug.Log("Target hit");
    }
}
