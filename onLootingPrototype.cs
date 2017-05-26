using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onLootingPrototype : MonoBehaviour {

    private NotificationsManager NM = null;
    string EtriggerSwitch = "TriggerSwitch";
    ArrayList inventory = new ArrayList();
    bool canLoot = false;
    int objid = -1;

    // Use this for initialization
    void Start () {
        NM = GetComponentInParent<NotificationsManager>();
        NM.AddListener(OnLoot, EtriggerSwitch);
	}

    private void OnLoot(string E_key, int[] values)
    {
        if (values[0] == 0) {
            //entrato
            objid = values[1];
            canLoot = true;
            
        }
        if (values[0] == 1)
        {
            //uscito 
            objid = -1;
            canLoot = false;

        }
    }






    // Update is called once per frame
    void Update () {

        if (canLoot && Input.GetKeyDown("e"))
            Loot(objid);

    }


    void Loot(int id) {
        inventory.Add(id);
        objid = -1;
        canLoot = false;
        Debug.Log(inventory.Count);
    }
}
