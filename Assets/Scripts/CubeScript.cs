using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private Rigidbody rb;


    private void Awake() // Primeiro método a ser chamado antes do LOADING da scene
    {
        Debug.Log("Awake Call");

        rb = GetComponent<Rigidbody>();

        Debug.Log("Rigidbody atribuído com sucesso");
    }

    private void Start() // Segundo método a ser chamado, depois do LOADING
    {
        Debug.Log("Start Call");
    }

    private void Update() // Método que é chamado TODO Frame
    {
        // Inputs
        // Lógicas
        // Movimentos
        // Estados
        // Ações

        if (Input.GetMouseButtonDown(0)) // 0 == Botão esquerdo 1 == Botão direito
        {
            Debug.Log("Botão esquerdo apertado.");

            rb.isKinematic = false;
        }
     
    }

    private void OnTriggerEnter(Collider other) // método chamado quando ESSE GameObject tocar um Colisor Trigger
    {
        Debug.Log("OnTriggerEnter Call");

        gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.red;
    }

    private void OnCollisionEnter(Collision collision) // método chamado quando ESSE GameObject tocar um Colisor
    {
        Debug.Log("OnCollisionEnter Call");

        collision.gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.red;

        Destroy(this.gameObject);
    }

    private void OnDestroy() // método chamado ao destruir esse GameObject
    {
        Debug.Log("OnDestroy Call");

        // Explosoes
        // Efeitos
        // Mudanças
        // Animações

    }
}
