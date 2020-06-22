using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    public float bulletForce = 1000f;
    
    public GameObject BulletSpawn;
    public Rigidbody Worm;
    public GameObject Projectile;
    public GameObject Weapon;
    public KeyCode jumpUP;
    public KeyCode right;
    public KeyCode left;
    public KeyCode shoot;

    public Vector3 jumpforce;
    public Vector3 moveforce;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(jumpUP))
        {
            Worm.AddForce(jumpforce);
            Debug.Log("jump Taste gedrückt");
        }

        if(Input.GetKey(left))
        {
            Worm.AddForce(-moveforce);
        }

        if(Input.GetKey(right))
        {
            Worm.AddForce(moveforce);
        }

        if(Input.GetKeyDown(shoot))
        {
            StartCoroutine(shooot());
        }
    }

    IEnumerator shooot()
    {
        GameObject clone = Instantiate(Projectile, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
        Rigidbody rigidbodyname = clone.GetComponent<Rigidbody>();
        rigidbodyname.AddForce(Weapon.transform.up * -bulletForce);
        yield return new WaitForSeconds(2);
        Destroy(clone);
    }
}
