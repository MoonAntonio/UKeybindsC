//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// ManagerKeyBind.cs (28/07/2017)												\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Manager general del sistema KeyBind							\\
// Fecha Mod:		28/07/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Manager general del sistema KeyBind</para>
	/// </summary>
	[AddComponentMenu("Moon Antonio/ManagerKeyBind")]
	public class ManagerKeyBind : MonoBehaviour 
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Texto de keys</para>
		/// </summary>
		public Text arriba, abajo, derecha, izquierda, atacar, defender, saltar, correr;	// Texto de keys
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Coleccion de teclas</para>
		/// </summary>
		private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();       // Coleccion de teclas
		/// <summary>
		/// <para>Key actual guardada</para>
		/// </summary>
		private GameObject actualKey;                                                       // Key actual guardada
		/// <summary>
		/// <para>Color del btn en estado normal</para>
		/// </summary>
		private Color32 btnColorNormal = new Color32(39,171,249,255);						// Color del btn en estado normal
		/// <summary>
		/// <para>Color del btn en estado seleccionado</para>
		/// </summary>
		private Color32 btnColorSeleccionado = new Color32(0, 255, 244, 255);				// Color del btn en estado seleccionado
		#endregion

		#region Inicializadores
		/// <summary>
		/// <para>Inicializador de <see cref="ManagerKeyBind"/>.</para>
		/// </summary>
		private void Start()// Inicializador de ManagerKeyBind
		{
			// Agregar al diccionario las keys
			keys.Add("arriba", KeyCode.W);
			keys.Add("abajo", KeyCode.S);
			keys.Add("derecha", KeyCode.D);
			keys.Add("izquierda", KeyCode.A);
			keys.Add("atacar", KeyCode.Mouse0);
			keys.Add("defender", KeyCode.Mouse1);
			keys.Add("saltar", KeyCode.Space);
			keys.Add("correr", KeyCode.LeftShift);

			// Representar en la UI las keys
			arriba.text = keys["arriba"].ToString();
			abajo.text = keys["abajo"].ToString();
			derecha.text = keys["derecha"].ToString();
			izquierda.text = keys["izquierda"].ToString();
			atacar.text = keys["atacar"].ToString();
			defender.text = keys["defender"].ToString();
			saltar.text = keys["saltar"].ToString();
			correr.text = keys["correr"].ToString();
		}
		#endregion

		#region Actualizadores
		/// <summary>
		/// <para>Actualizador de <see cref="ManagerKeyBind"/>.</para>
		/// </summary>
		private void Update()// Actualizador de ManagerKeyBind
		{
			// Seguimiento de los inputs
			if (Input.GetKeyDown(keys["arriba"]))
			{
				Debug.Log("Arriba");
			}

			if (Input.GetKeyDown(keys["abajo"]))
			{
				Debug.Log("Abajo");
			}

			if (Input.GetKeyDown(keys["derecha"]))
			{
				Debug.Log("Derecha");
			}

			if (Input.GetKeyDown(keys["izquierda"]))
			{
				Debug.Log("Izquierda");
			}

			if (Input.GetKeyDown(keys["atacar"]))
			{
				Debug.Log("Atacar");
			}

			if (Input.GetKeyDown(keys["defender"]))
			{
				Debug.Log("Defender");
			}

			if (Input.GetKeyDown(keys["saltar"]))
			{
				Debug.Log("Saltar");
			}

			if (Input.GetKeyDown(keys["correr"]))
			{
				Debug.Log("Correr");
			}
		}
		#endregion

		#region GUI
		/// <summary>
		/// <para>GUI</para>
		/// </summary>
		private void OnGUI()// GUI
		{
			// Comprobamos si la key actual no es nula
			if (actualKey != null)
			{
				// Agregamos un evento
				Event e = Event.current;
				if (e.isKey)
				{
					// Asignamos la key obtenida del evento a nuestra base de keys
					keys[actualKey.name] = e.keyCode;

					// Actualizamos la UI de la key
					actualKey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
					actualKey.GetComponent<Image>().color = btnColorNormal;
					actualKey = null;
				}
			}
		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Cambia la key</para>
		/// </summary>
		/// <param name="obj">Objeto</param>
		public void CambiarKey(GameObject obj)// Cambia la key
		{
			// Cambiamos a normal el estado del btn
			if (actualKey != null)
			{
				actualKey.GetComponent<Image>().color = btnColorNormal;
			}

			// Asignamos la nueva key
			actualKey = obj;
			actualKey.GetComponent<Image>().color = btnColorSeleccionado;
		}
		#endregion
	}
}