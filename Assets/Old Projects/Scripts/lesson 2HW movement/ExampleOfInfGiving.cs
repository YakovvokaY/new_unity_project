using UnityEngine;

public class ExampleOfInfGiving : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var KeyCollectble = other.GetComponent<IKollectble>();
        if (KeyCollectble != null)
        {
            KeyCollectble.AddKey();
            Destroy(this.gameObject);
        }
    }
}