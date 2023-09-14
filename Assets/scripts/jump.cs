using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class Pulo : MonoBehaviour {

 public Vector3 direcaoDoPulo = new Vector3 (0, 1, 0);
 [Range(1,20)]
 public float forcaDoPulo = 5.0f;
 [Range(0.5f,10.0f)]
 public float DistanciaDoChao = 1;
 [Range(0.5f,5.0f)]
 public float TempoPorPulo = 1.5f;
 public LayerMask LayersNaoIgnoradas = -1;
 private bool estaNoChao, contar = false;
 private float cronometro = 0;
 private Rigidbody corpoRigido;

 void Start(){
 corpoRigido = GetComponent<Rigidbody>();
 }

 void Update(){

 estaNoChao = Physics.Linecast (transform.position, transform.position - Vector3.up*DistanciaDoChao, LayersNaoIgnoradas);

 if(Input.GetKeyDown(KeyCode.Space) && estaNoChao == true && contar == false){
 corpoRigido.AddForce(direcaoDoPulo * forcaDoPulo, ForceMode.Impulse);
 estaNoChao = false;
 contar = true;
 }

 if (contar == true) {
 cronometro += Time.deltaTime;
 }
 if (cronometro >= TempoPorPulo) {
 contar = false;
 cronometro = 0;
 }
 }
}