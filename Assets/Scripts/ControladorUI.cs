using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour {
	private ControladorLinguagens _ctlLinguagens;

	public Text _txtTituloSelecionar;
	public Text _txtNome;
	public Text _txtTituloProximo;
	public Text _txtTituloAnterior;
	// Use this for initialization
	void Start () {
		this._ctlLinguagens = FindObjectOfType <ControladorLinguagens>();
		this.atualizarUI ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void atualizarUI(){
		this._txtNome.text = this._ctlLinguagens._nomeSelecionada;
		this._txtTituloSelecionar.text = this._ctlLinguagens._linguagemSelecionada.titulo_selecionar_linguagem;
		this._txtTituloProximo.text = this._ctlLinguagens._linguagemSelecionada.proximo;
		this._txtTituloAnterior.text = this._ctlLinguagens._linguagemSelecionada.anterior;
	}

	public void selecionarProxima(){
		this._ctlLinguagens.selecionarProxima ();
		this.atualizarUI ();
	}

	public void selecionarAnterior(){
		this._ctlLinguagens.selecionarAnterior ();
		this.atualizarUI ();
	}
}
