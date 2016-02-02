using UnityEngine;
using System.Collections;

public class contador : MonoBehaviour
{
	public int jarrones;
	// Use this for initialization
	void Start ()
	{
		jarrones = 0;
	}

	void Update ()
	{
		if (jarrones == 5) {
			Application.LoadLevel ("Intermedio");
			
		}

	}
}