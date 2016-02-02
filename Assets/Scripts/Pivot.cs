//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
[ExecuteInEditMode]//corre en modo edicion
	public class Pivot	:	segirObjetivo{//subclase de segir objetivo

	protected Transform cam;
	protected Transform pivot;
	protected Vector3 lastTargetPossition;

	protected virtual void Awake(){
		cam = GetComponentInChildren<Camera> ().transform;
		pivot = cam.parent;
	}

	protected override void Start(){
		base.Start ();// estart de la clase base
	}
	virtual protected void Update(){
		if (! Application.isPlaying) {
			if(target != null){
				Follow(999);//es en modo edicion no pasa nada
				lastTargetPossition = target.position;
			}
			if(Mathf.Abs(cam.localPosition.x)> .5f || Mathf.Abs(cam.localPosition.y)> .5f){
				cam.localPosition = Vector3.Scale(cam.localPosition, Vector3.forward);
			}
			cam.localPosition=Vector3.Scale(cam.localPosition,Vector3.forward);

		}
	}

	protected override void Follow (float deltaTime){//cada subclase debe tener este metodo obligatoraimente
	
	}
	}


