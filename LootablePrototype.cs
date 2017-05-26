//EtriggerSwitch evento attivato in entrata con valore "0" e in uscita con valore "1"
// secondo valore id oggetto 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootablePrototype : MonoBehaviour {

    private NotificationsManager NM = null;
    string EtriggerSwitch = "TriggerSwitch";
    int id = 1001;


    //inizializzazione e creazione evento
    void Awake()
    {
        NM = GetComponentInParent<NotificationsManager>();
        NM.CreateEvent(EtriggerSwitch);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {

            NM.PostNotification(EtriggerSwitch,0,id);
            }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            NM.PostNotification(EtriggerSwitch, 1);
        }
    }

}
