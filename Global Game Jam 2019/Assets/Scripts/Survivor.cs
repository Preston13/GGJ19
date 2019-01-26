using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Survivor : MonoBehaviour
{
    /// <summary>
    /// This will control aspects of the player that is not movement
    /// </summary>

    private bool hasGasMaskBottom = false;
    private bool hasGasMaskTop = false;
    private bool fullgasMask = false;
    private bool inHome = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasGasMaskBottom && hasGasMaskTop && inHome)
        {
            fullgasMask = true;
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        PickUp pup = coll.GetComponent<PickUp>();

        if(pup == null)
        {
            return;
        }

        if(pup.itemType == PickUp.eType.gasMaskBottom)
        {
            hasGasMaskBottom = true;
        }
        if(pup.itemType == PickUp.eType.gasMaskTop)
        {
            hasGasMaskTop = true;
        }
        Destroy(coll.gameObject);
    }
}
