using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CallingScript : MonoBehaviour
{
    public Fungus.Flowchart callingFlowchart;
    public Collider2D col;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (callingFlowchart.FindBlock("MoveToCries").IsExecuting())
        {
            // this.GetComponent<PlayerMovement>().enabled = false;

            // callingFlowchart.ExecuteBlock("Polecatscries");
           // Debug.Log("block working");
            transform.position = col.transform.position;
        }
        if (callingFlowchart.FindBlock("MoveToCries").IsExecuting())
        {
            // this.GetComponent<PlayerMovement>().enabled = false;

            // callingFlowchart.ExecuteBlock("Polecatscries");
            // Debug.Log("block working");
            transform.position = col.transform.position;
        }
    }


}
