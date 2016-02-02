using UnityEngine;
using System.Collections;

public class GaleriaPersonaje : MonoBehaviour
{
	// Use this for initialization
	float a;
	public Texture[] tex = new Texture2D[6];
	Personaje[] personajes = new Personaje[6];

	void Start ()
	{
		a = 0;
		agregarPersonajes ();
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnGUI ()
	{
		a = GUI.HorizontalSlider (new Rect (Screen.width / 22 * 10, Screen.height / 19 * 1, Screen.width / 22 * 10, Screen.height / 19), a, 0, personajes.Length - 1);
		int i = (int)a;
		a = (float)i;
		GUI.DrawTexture (new Rect (Screen.width / 22, Screen.height / 19, Screen.width / 22 * 8, Screen.height / 19 * 8), tex [i]);
		GUI.Box (new Rect (Screen.width / 22 * 10, Screen.height / 19 * 2, Screen.width / 22 * 10, Screen.height / 19), personajes [i].getNombre ());
		GUI.Box (new Rect (Screen.width / 22 * 10, Screen.height / 19 * 4, Screen.width / 22 * 10, Screen.height / 19), "Nacimiento: " + personajes [i].getNac ());
		GUI.Box (new Rect (Screen.width / 22 * 10, Screen.height / 19 * 6, Screen.width / 22 * 10, Screen.height / 19), "Datos Interesantes: ");
		GUI.Box (new Rect (Screen.width / 22 * 10, Screen.height / 19 * 7, Screen.width / 22 * 10, Screen.height / 19 * 3), personajes [i].getDatInt ());
		GUI.Box (new Rect (Screen.width / 22 * 10, Screen.height / 19 * 11, Screen.width / 22 * 10, Screen.height / 19), "Muerte: " + personajes [i].getFechaMuerte ());
		GUI.Box (new Rect (Screen.width / 22 * 10, Screen.height / 19 * 13, Screen.width / 22 * 10, Screen.height / 19), "Causa de Muerte: ");
		GUI.Box (new Rect (Screen.width / 22 * 10, Screen.height / 19 * 14, Screen.width / 22 * 5, Screen.height / 19 * 4), personajes [i].getCausaMuerte ());
		GUI.Box (new Rect (Screen.width / 22, Screen.height / 19 * 9, Screen.width / 22 * 8, Screen.height / 19), "Batallas importantes: ");
		GUI.Box (new Rect (Screen.width / 22, Screen.height / 19 * 11, Screen.width / 22 * 8, Screen.height / 19 * 6), personajes [i].getBatInt ());
		if (GUI.Button (new Rect (Screen.width / 22 * 16, Screen.height / 19 * 16, Screen.width / 22 * 4, Screen.height / 19 * 2), "!Atras")) {
			Application.LoadLevel (2);
		}

	}

	void agregarPersonajes ()
	{
		personajes [0] = new Personaje ("Francisco Villa (Doroteo Arango Arámbula)", "5 de junio de 1878", "Por la pobreza de sus padres, Agustín Arango y Micaela \nArámbula, no tiene educación escolar. Trabaja de leñador \ny de labrador cuando fallece su padre. Se dedica al comercio, \ncon ayuda de Pablo Valenzuela, que le fía mercancía. ", "Toma de Zacatecas\nToma de Torreon", " El viernes 20 de julio de 1923", "Tras sufrir varios atentados, \nmuere emboscado en Hidalgo \ndel Parral, Chihuahua");
		personajes [1] = new Personaje ("Venustiano Carranza", "4 de enero de 1860", "Al estallar la Revolución Mexicana apoyó a Francisco I. Madero,\nquien lo nombró Ministro de Guerra", "La toma de ciudad Juarez", "El 21 de mayo de 1920", "fue asesinado a balazos en Tlaxcalantongo (Puebla).");
		personajes [2] = new Personaje ("Felipe Ángeles", "13 de junio de 1868", "Fue hijo de Felipe Ángeles Melo, un coronel que combatió contra la invasión estadounidense en 1847 y la francesa en 1862", "Decena Trágica \nBatalla de Torreón \nBatalla de Paredón \nBatalla de Zacatecas", "26 de noviembre de 1919", "Murió fusilado en Chihuahua. Como testamento político dijo durante su juicio: \n\"Mi muerte hará más bien a la causa democrática que todas las gestiones de mi vida. La sangre de los mártires fecundiza las buenas causas\n");
		personajes [3] = new Personaje ("Victoriano Huerta", "22 de diciembre de 1850", "Asesino a Madero y se auto proclamo presidente\nal estar en el cargo se dedico a tomar y fumar marihuana\nes por eso que se escribio en su honor la cancion \n\"La Cucaracha\"", "La decena trágica", "13 de enero de 1916", "Murió víctima de cirrosis hepática e ictericia");
		personajes [4] = new Personaje ("Kingo Nonaka", "Nació en la Prefectura de Fukuoka, Kyūshū en 1889", "Emigró a México a la edad de 17 años, \nacompañado por un hermano mayor y un tío", "Participó en 14 operaciones de combate durante la \nRevolución: dos con las fuerzas de Francisco I. Madero y 12 con la \nDivisión del Norte comandada por Pancho Villa", "1977", "Causas naturales");
		personajes [5] = new Personaje ("Rodolfo Fierro", "1880", "borracho y sanguinario,\nllego un punto en que todo lo malo que pasaba era adjudicado a él\ndescarriló el tren que conducia dos veces debido a sus problemas con alcohol", "La Toma de Zacatecas, La Toma de Torreón", "13 de octubre de 1915", "en medio de una borrachera intentó pasar un lago por el centro\nalegando \"éste es el camino de los hombres\" cuatro días\ndespués sacaron su cuerpo");

	}
}
