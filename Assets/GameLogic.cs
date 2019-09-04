using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {
    public GameObject Cl;
    public GameObject Na;
    public GameObject NaCl;
    public bool Fusion;
    private void Start()
    {
        Na.GetComponent<BoxCollider>().enabled= true;
        Cl.GetComponent<BoxCollider>().enabled = true;
    }
    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Cl)
        {
            //Na.SetActive(false);
            //Cl.SetActive(false);
            //NaCl.SetActive(true);
            Fusion = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject==NaCl)
        //Na.SetActive(true);
        //Cl.SetActive(true);
        //NaCl.SetActive(false);
        //Debug.Log("hello"); 
        Fusion = false;
    }
    // Update is called once per frame
    void FixedUpdate () {
		if(Fusion==true)
        {
            Na.SetActive(false);
            Cl.SetActive(false);
            NaCl.SetActive(true);
        }
        else if(Fusion==false)
        {
            Na.SetActive(true);
            Cl.SetActive(true);
            NaCl.SetActive(false);
        }
    }
}
