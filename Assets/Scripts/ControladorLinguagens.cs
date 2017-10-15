using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorLinguagens : MonoBehaviour {
	public string[] _linguagens;
	public Linguagem _linguagemSelecionada;

	private ControladorArquivos _ctlArquivos;
	// Use this for initialization
	void Start () {
		this._ctlArquivos = new ControladorArquivos ();
		this.lerLinguagem ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void lerLinguagem(){
		if(this._ctlArquivos.validarDiretorio("linguagens")){
			this._linguagens = this._ctlArquivos.listarArquivos ("linguagens","*.json");
			this.selecionarLinguagem ("en");
		}else{
			this._ctlArquivos.criarDiretorio ("linguagens");
			Linguagem padrao = new Linguagem ();
			padrao.nome_linguagem = "Português";

			this._linguagemSelecionada = padrao;
			this._ctlArquivos.criarArquivo ("linguagens/pt-br.json",JsonUtility.ToJson(padrao));
			this._linguagens = this._ctlArquivos.listarArquivos ("linguagens","*.json");
		}
	}

	public void selecionarLinguagem(string nome){
		_linguagemSelecionada = this._ctlArquivos.lerJson<Linguagem> ("linguagens/"+nome+".json");
	}
}
