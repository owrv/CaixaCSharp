using System;
using System.Collections.Generic;

/// <summary>
/// Obtem a posição de um objeto array do tipo string em int32
/// </summary>
public class ArrayUtil
{
	public ArrayUtil()
	{
		//
		// TODO: Add constructor logic here
		//
	}

	public string buscarPosicaoReferenciaNumerica(string[] lista, string numerador)
    {
		// lista: é a matrix buscada
		// numerador: é a posição esperada
		// espero receber uma matriz
		// irei retornar uma variável int com a posição desta variável
		// preciso encontrar a posição de um item em uma matriz 
		string posicaoBuscada = null;
		for (int xls = 0; xls < lista.Length; xls++)
        {
			if(xls.ToString() == numerador)
            {
				posicaoBuscada = xls.ToString();
            }
        }
		return posicaoBuscada;
    }
}
