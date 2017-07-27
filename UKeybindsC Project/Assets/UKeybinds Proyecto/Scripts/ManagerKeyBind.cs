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
		#region Variables Privadas
		/// <summary>
		/// <para>Coleccion de teclas</para>
		/// </summary>
		private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();		// Coleccion de teclas
		#endregion

		#region Inicializadores
		/// <summary>
		/// <para>Inicializador de <see cref="ManagerKeyBind"/>.</para>
		/// </summary>
		private void Start()// Inicializador de ManagerKeyBind
		{

		}
		#endregion
	}
}