//1.0.1
using UnityEngine;
using System.Collections;

public class Listener : MonoBehaviour
{
	private NotificationsManager NM = null;
	private string a = "ciao come va?";
	private string b = "muori ";
	
	void Start()
	{
		//Get notifications manager
		NM = GetComponentInParent<NotificationsManager>();
		
		//Add as listener
		NM.AddListener(OnEventCall,"eventoProva");
	}
	
	//Function prototype matches delegate
	public void OnEventCall(string E_key, params int[] values)
	{
		if (values[0] ==0)
			Debug.Log(a);
		if (values[1] ==1)
			Debug.Log(b);
	}
}
