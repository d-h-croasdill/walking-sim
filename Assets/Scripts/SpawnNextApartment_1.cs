using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNextApartment_1 : MonoBehaviour
{
    int triggered = 0;

    public GameObject old;
    public GameObject next;
    public float x = 0;
    public float y = 0;
    public float z = 0;
    public float rotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        triggered = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
      //  if (triggered < 1)
    //    {
            Debug.Log("Swap");
            Destroy(old);
            Instantiate(next);
            next.transform.position = new Vector3(x, y, z);
            triggered += 1;
       // }
    }

    //#region destroy
    //void DestroyGameObject()
    //{
    //    Destroy(gameObject);
    //}

    //void DestroyScriptInstance()
    //{
    //    // Removes this script instance from the game object
    //    Destroy(this);
    //}

    //void DestroyComponent()
    //{
    //    // Removes the rigidbody from the game object
    //    Destroy(GetComponent<Rigidbody>());
    //}

    //void DestroyObjectDelayed()
    //{
    //    // Kills the game object in 5 seconds after loading the object
    //    Destroy(gameObject, 5);
    //}
    //#endregion
  
}
