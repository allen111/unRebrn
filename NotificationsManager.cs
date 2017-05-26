//1.1
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NotificationsManager : MonoBehaviour
{
	//OVERVIEW:usa un dizionario string nome evento, lista di delegati
	//================================================================================================================
	
	//Declare listener delegate
	public delegate void ListenerDelegate(string E_key, params int[] values);
	
	
	//dizionario con nome evento e lista tipo hash
	private Dictionary<string,List<ListenerDelegate>> E_Listeners =new Dictionary<string, List<ListenerDelegate>>();
	
	//METODS==========================================================================================================
	
	//Add listener USALO IN START O PIU TARDI
	public void AddListener(ListenerDelegate Listener,string E_key)
	{
		//se l evento non esiste da warning 
		if (!E_Listeners.ContainsKey (E_key))
			Debug.Log ("WARNING:EVENTO NON ESISTENTE");
		//aggiunge alla lista dell evento E_key il listener
		E_Listeners [E_key].Add (Listener);
	}
	
	public void PostNotification(string E_key, params int[] values)
	{
		//Notify all listeners della lista dell evento E_key
		for(int i=0; i<E_Listeners[E_key].Count; i++)
		{
			//Call delegate like function
			E_Listeners[E_key][i](E_key, values);
		}
	}

	//gli eventi vanno creati nel
	//metodo void awake 
	public void CreateEvent(string E_key){
		E_Listeners.Add (E_key, new List<ListenerDelegate>());
	}

	public void RemoveListener(ListenerDelegate Listener,string E_key)
	{

		//rimuove dalla lista dell evento E_key il listener
		E_Listeners [E_key].Remove(Listener);
	}
}
