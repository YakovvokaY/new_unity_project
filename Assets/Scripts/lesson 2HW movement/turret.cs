using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class turret : MonoBehaviour
{
    [SerializeField] GameObject rocets;
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject light;
    public float spawnpoint = 1f;
    public float angularSpeed;
    [SerializeField] Transform aheadObj;
    private HashSet<GameObject> Obj = new HashSet<GameObject>();
    public Transform player;
    private float aheadTime;
    Vector3 dirVect = new Vector3();
    private float bulletSpeed = 6;
    private bool flagNum = true;

    private void Update()
    {
        LookAtPlayer();
        if (flagNum == true)
        {
            flagNum = false;
            StartCoroutine(shoot());
        }
        
        StartCoroutine(AheadPoint());
    }
    private void LookAtPlayer()
    {
        Vector3 direction = player.transform.position - transform.position;
        Vector3 rotation = Vector3.RotateTowards(transform.forward,direction,angularSpeed * Time.deltaTime, 0F);
        transform.rotation = Quaternion.LookRotation(rotation);
    }
    private IEnumerator shoot()
    {
        yield return new WaitForSeconds(1);
        light.SetActive(true);
        Instantiate(rocets, spawnPoint.position, spawnPoint.rotation);
        yield return new WaitForSeconds(0.3f);
        light.SetActive(false);
        flagNum = true;
        StopCoroutine(shoot());
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