using UnityEngine;

public class ReloadObj : MonoBehaviour , IReload 
{
    private Rigidbody rb;
    private bool RbFlag = false;
    [SerializeField] private Transform ReloadAncor;
    private void Start()
    {
        if (gameObject.GetComponent<Rigidbody>() != null)
        {
            rb = gameObject.GetComponent<Rigidbody>();
            RbFlag = true;
        }
    }
    public void Reload()
    {
        if (RbFlag)
        {
            rb.isKinematic = RbFlag;
            transform.position = ReloadAncor.position;
            transform.rotation = ReloadAncor.rotation;
            transform.localScale = ReloadAncor.localScale;
            rb.isKinematic = false;
        }
        else
        {
            transform.position = ReloadAncor.position;
            transform.rotation = ReloadAncor.rotation;
            transform.localScale = ReloadAncor.localScale;
        }
        gameObject.SetActive(true);
    }
}