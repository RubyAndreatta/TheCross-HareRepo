using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CallingScript : MonoBehaviour
{
    public Fungus.Flowchart callingFlowchart;
    public Collider2D colsounds;
    public Collider2D colignorepolecat;
    public Collider2D colfollowpolecat;
    public Collider2D colcat;

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
            transform.position = colsounds.transform.position;
        }

        else if (callingFlowchart.FindBlock("ignore").IsExecuting())
        {
            // this.GetComponent<PlayerMovement>().enabled = false;

            // callingFlowchart.ExecuteBlock("Polecatscries");
            // Debug.Log("block working");
            transform.position = colignorepolecat.transform.position;
        }

        else if (callingFlowchart.FindBlock("follow").IsExecuting())
        {
            // this.GetComponent<PlayerMovement>().enabled = false;

            // callingFlowchart.ExecuteBlock("Polecatscries");
            // Debug.Log("block working");
            transform.position = colfollowpolecat.transform.position;
        }

        else if (callingFlowchart.FindBlock("pathcombines").IsExecuting())
        {
            // this.GetComponent<PlayerMovement>().enabled = false;

            // callingFlowchart.ExecuteBlock("Polecatscries");
            // Debug.Log("block working");
            transform.position = colcat.transform.position;
        }
    }


}
