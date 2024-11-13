using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public bool jogadorClicou;

    public float velocidade;

    public MeshRenderer meshRendererCubo;

    public ParticleSystem ExplosaoPrefab;


    private void Awake() // Primeiro método a ser chamado ao dar play. ** ANTES MESMO DO LOAD ** 
    {
        Debug.Log("Teste de chamada - função Awake");
    }

    private void OnEnable() // Segundo método a ser chamado, e sempre será chamado quando o objeto ficar ativo.
    {
        Debug.Log("Teste de chamada - função OnEnable");
    }

    private void OnDisable() // Sempre será chamada quando o objeto for desativado.
    {
        Debug.Log("Teste de chamada - função OnDisable");
    }

    private void Start() // Terceiro método a ser chamado ao dar play. ** DEPOIS DO LOAD ** 
    {
        Debug.Log("Teste de chamada - função Start");

        jogadorClicou = false;

        meshRendererCubo = GetComponent<MeshRenderer>();

    }

    private void Update() // método chamado TODO FRAME.
    {
        // Programa coisa como:
        // Input do jogador
        // Movimento continuo
        // Contagem de tempo
        // Ação em estado

        if (jogadorClicou == true)
        {
            transform.position += new Vector3(1,0,0) * Time.deltaTime * velocidade;
        }

        if (Input.GetMouseButtonDown(0))
        {
            jogadorClicou = true;
            Debug.Log("Teste de chamada - Update Botão esquerdo apertado.");
        }

        
    }

    private void FixedUpdate() // método chamado num tempo setado/fixado/unico de frames
    {
        // Debug.Log("Teste de chamada - FixedUpdate");
    }

    private void OnTriggerEnter(Collider other)
    {
        // abrir alguma coisa
        // mudar alguma fase
        // alterar alguma informacao
        // 
        Debug.Log("Teste de chamada - OnTriggerEnter");

        meshRendererCubo.materials[0].color = Color.green;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Teste de chamada - OnCollisionEnter - objeto: " + collision.gameObject.name);

        collision.gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.red;

        Destroy(this.gameObject);
    }

    private void OnDestroy() // Método chamado após a destruição de um objeto.
    {
        // chamar algum efeito pós destruição / pós morte

        Debug.Log("Teste de chamada - OnDestroy");

        Instantiate(ExplosaoPrefab, new Vector3(0, 2, 0), ExplosaoPrefab.transform.rotation);
    }

    private void OnMouseEnter() // método chamado após o mouse entrar em contato com certa UI
    {
        
    }

}
