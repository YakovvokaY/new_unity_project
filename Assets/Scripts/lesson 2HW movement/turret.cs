using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class turret : MonoBehaviour
{
    [SerializeField] GameObject rocets;
    [SerializeField] Transform spawnPoint;
    public float spawnpoint = 1f;
    public float angularSpeed;
    [SerializeField] Transform aheadObj;
    private HashSet<GameObject> Obj = new HashSet<GameObject>();
    public Transform player;
    private float nextSpavnTime;
    private float aheadTime;
    Vector3 dirVect = new Vector3();
    private float bulletSpeed = 6;

    private void Update()
    {
        LookAtPlayer();
        shoot();
        StartCoroutine(AheadPoint());
    }
    private void LookAtPlayer()
    {
        Vector3 direction = player.transform.position - transform.position;
        Vector3 rotation = Vector3.RotateTowards(transform.forward,direction,angularSpeed * Time.deltaTime, 0F);
        transform.rotation = Quaternion.LookRotation(rotation);
    }
    private void shoot()
    {
        if (Time.time > nextSpavnTime)
        {
            Instantiate(rocets, spawnPoint.position, spawnPoint.rotation);
            nextSpavnTime = Time.time + 2;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Obj.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Obj.Remove(other.gameObject);
        }
    }
    IEnumerator AheadPoint()
    {
        foreach (GameObject body in Obj)
        {
            dirVect = body.transform.position;
            yield return new WaitForSeconds(0.016f);
            dirVect = body.transform.position - dirVect;

            Rigidbody bodyRb = body.GetComponent<Rigidbody>();
            aheadTime = ((body.transform.position-transform.position)/(bulletSpeed-bodyRb.velocity.magnitude*3)).magnitude;
            aheadObj.position = body.transform.position + dirVect*aheadTime*bodyRb.velocity.magnitude;
            Debug.Log(dirVect);
            StopCoroutine(AheadPoint());
            yield return new WaitForSeconds(0.016f);
        }
    }
}