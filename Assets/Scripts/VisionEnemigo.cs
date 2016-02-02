using UnityEngine;
using System.Collections;

public class VisionEnemigo : MonoBehaviour
{
	StatsDeLosPersonajes charStat;
	InteligenciaEnemigo enAi;

	// Use this for initialization
	void Start ()
	{
		//charStat = GetComponentInParent<statsDePerosnaje> ();
		enAi = GetComponentInParent<InteligenciaEnemigo> ();
		charStat = GetComponentInParent<StatsDeLosPersonajes> ();
	}

	void OnTriggerEnter (Collider other)
	{
		//Debug.Log("contactooooooooooooooooooooooo");
		if (other.GetComponent<StatsDeLosPersonajes> ()) {
			//Debug.Log("Personaje");
			if (other.GetComponent<StatsDeLosPersonajes> ().Id != charStat.Id) {

				if (!enAi.Enemies.Contains (other.gameObject)) {
					//Debug.Log("Personaje");
					enAi.Enemies.Add (other.gameObject);//agrega ala lista de enemigos
				}
			}
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (enAi.Enemies.Contains (other.gameObject)) {
			enAi.Enemies.Remove (other.gameObject);
		}

	}

}
