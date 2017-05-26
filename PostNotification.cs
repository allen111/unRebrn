//1.0.1
using UnityEngine;
using System.Collections;

public class PostNotification : MonoBehaviour {
	private NotificationsManager NM =null;


	//inizializzazione e creazione evento
	void Awake () {
		NM = GetComponentInParent<NotificationsManager> ();
		NM.CreateEvent ("eventoProva");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("g"))
			NM.PostNotification("eventoProva",0,0);
		
		if(Input.GetKeyDown("f"))
			NM.PostNotification("eventoProva",1,1);
		
	}
}
