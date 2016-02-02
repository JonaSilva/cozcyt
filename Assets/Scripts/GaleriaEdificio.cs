using UnityEngine;
using System.Collections;

public class GaleriaEdificio : MonoBehaviour {
	// Use this for initialization
	private float a;
	public Texture[] tex =new Texture2D[5];
	private Edificio[] edificios=new Edificio[5]; 
	void Start () {
		a=0;
		agregarEdificios();
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnGUI(){
		a=GUI.HorizontalSlider(new Rect(Screen.width/22*10,Screen.height/19*1,Screen.width/22*10,Screen.height/19),a,0,edificios.Length-1);
		int i=(int)a;
		a = (float)i;
		GUI.DrawTexture(new Rect(Screen.width/22,Screen.height/19,Screen.width/22*8,Screen.height/19*8), tex[i]);
		GUI.Box(new Rect(Screen.width/22*10,Screen.height/19*2,Screen.width/22*10,Screen.height/19),edificios[i].getNombre());
		GUI.Box(new Rect(Screen.width/22*10,Screen.height/19*4,Screen.width/22*10,Screen.height/19),"Construccion: ");
		GUI.Box(new Rect(Screen.width/22*10,Screen.height/19*5,Screen.width/22*10,Screen.height/19),edificios[i].getEpocaCon());
		GUI.Box(new Rect(Screen.width/22*10,Screen.height/19*7,Screen.width/22*10,Screen.height/19),"Constrores: ");
		GUI.Box(new Rect(Screen.width/22*10,Screen.height/19*8,Screen.width/22*10,Screen.height/19*3),edificios[i].getConst());
		GUI.Box(new Rect(Screen.width/22,Screen.height/19*12,Screen.width/22*8,Screen.height/19),"Datos Interesantes: ");
		GUI.Box(new Rect(Screen.width/22,Screen.height/19*13,Screen.width/22*14,Screen.height/19*5),edificios[i].getDatInt());
		if (GUI.Button(new Rect(Screen.width/22*16,Screen.height/19*16,Screen.width/22*4,Screen.height/19*2),"!Atras")) {
			Application.LoadLevel(2);
		}

	}
	private void agregarEdificios(){
		edificios[0]=new Edificio("catedral","1730 a 1760 aunque en el lugar han existido iglesias desde 1559","Anonimo","Torre Norte terminada en\n1904");
		edificios[1]=new Edificio("Santo Domingo","1746 a 1749","Orden de los Jesuitas","Fue avandonada en 1767 al ser expulsada la orden de los Jesuitas\ny siendo ocupado en 1785 por la Orden de los Dominicos");
		edificios[2]=new Edificio("Guadalupito","12 de agosto de 1891","el muy ilustre canónigo José Anastasio Díaz López","La obra material estuvo a cargo del arquitecto \nzacatecano Refugio Reyes\nEl lienzo con la Virgen Morena que fue\nrealizado en el siglo XVIII por José de Alzíbar");
		edificios[3]=new Edificio("Mercado Gral. Jesús González Ortega","1886","Ing. Carlos Suárez Fiallo","contaba con un piso más que fue destruido en un incendio en 1901");
		edificios[4]=new Edificio("Portal de Rosales","1827","Anonimo","Anteriormente era una carcel y al terminar la guerra de independencia\nse construyo como monumento al insurgente Rosales");

	}
}
