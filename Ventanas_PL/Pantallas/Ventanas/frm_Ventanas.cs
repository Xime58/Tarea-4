using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventanas_DAL.Ecua_DAL;
using Ventanas_BLL.Ecual_BLL;
using Ventanas_DAL.Timer_DAL;
using Ventanas_DAL.Rad_DAL;
using Ventanas_BLL.Rad_BLL;
using Ventanas_DAL.Check_DAL;
using Ventanas_BLL.Check_BLL;


using System.Diagnostics;

namespace Ventanas_PL.Pantallas.Ventanas
{
	public partial class frm_Ventanas : Form
	{
		Stopwatch oSW = new Stopwatch();
		cls_Ecua_BLL Obj_Ecua_BLL = new cls_Ecua_BLL();
		cls_Rad_BLL Obj_Rad_BLL = new cls_Rad_BLL();
		cls_Check_BLL Obj_Check_BLL = new cls_Check_BLL();
		char cSeparador;

		public frm_Ventanas()
		{
			InitializeComponent();
		}

		private void btn_salir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		#region PROGRAMACION TIMER
		private void tmr_general_Tick(object sender, EventArgs e)
		{
			TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);

			txt_minutos.Text = ts.Minutes.ToString().Length < 2 ? "" + ts.Minutes.ToString() : ts.Minutes.ToString();
			txt_segundos.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
			txt_milisegundos.Text = ts.Milliseconds.ToString();

			if (txt_tiempo.Text == txt_minutos.Text)
			{
				oSW.Stop();
				txt_milisegundos.Text = "000";
			}
		}


		private void btn_iniciar_Click(object sender, EventArgs e)
		{
			if ((txt_tiempo.Text == "1") || (txt_tiempo.Text == "2") || (txt_tiempo.Text == "3") || (txt_tiempo.Text == "4") || (txt_tiempo.Text == "5"))
			{

				erp_general.Clear();
				txt_tiempo.Enabled = false;
				cls_Timer_DAL Obj_Timer_DAL = new cls_Timer_DAL();
				Obj_Timer_DAL.itiempo = Convert.ToInt32(txt_tiempo.Text.Trim());
				btn_iniciar.Enabled = false;
				btn_detener.Enabled = true;
				btn_limpiarTimer.Enabled = false;

				oSW.Start();
				tmr_general.Enabled = true;

			}

		}



		private void btn_detener_Click(object sender, EventArgs e)
		{
			oSW.Stop();
			btn_detener.Enabled = false;
			btn_iniciar.Enabled = true;
			btn_limpiarTimer.Enabled = true;
		}

		private void btn_limpiarTimer_Click(object sender, EventArgs e)
		{
			btn_iniciar.Enabled = false;
			txt_tiempo.Text = "";
			txt_tiempo.Enabled = true;
			oSW.Reset();
			txt_minutos.Text = "0";
			txt_segundos.Text = "00";
			txt_milisegundos.Text = "000";
			tmr_general.Enabled = false;

		}

		private void txt_tiempo_Leave(object sender, EventArgs e)
		{
			if ((txt_tiempo.Text == "1") || (txt_tiempo.Text == "2") || (txt_tiempo.Text == "3") || (txt_tiempo.Text == "4") || (txt_tiempo.Text == "5"))
			{
				btn_iniciar.Enabled = true;
				erp_general.Clear();
				txt_tiempo.ForeColor = Color.Blue;
			}
			else
			{
				txt_tiempo.Focus();
				txt_tiempo.ForeColor = Color.Red;
				erp_general.SetError(txt_tiempo, "TIENE QUE LLENAR EL CAMPO CON UN VALOR ENTRE 1 Y 5");
			}

		}
		private void txt_tiempo_KeyPress(object sender, KeyPressEventArgs e)
		{

			if ((e.KeyChar == 49) || (e.KeyChar == 50) || (e.KeyChar == 51) || (e.KeyChar == 52) || (e.KeyChar == 53) || (e.KeyChar == 8))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}

		}
		#endregion


		#region PROGRAMACION ECUACIONES CUADRATICAS
		private void frm_Ventanas_Load(object sender, EventArgs e)
		{
			cSeparador = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString().Trim());
		}

		private void btn_calcularEcua_Click(object sender, EventArgs e)
		{
			btn_calcularEcua.Enabled = false;
			txt_numA.Enabled = false;
			txt_numB.Enabled = false;
			txt_numC.Enabled = false;
			cls_Ecua_DAL Obj_Ecua_DAL = new cls_Ecua_DAL();
			Ecuacion(Obj_Ecua_DAL);
			if ((txt_numA.Text == "0") && (txt_numB.Text == "0") && (txt_numC.Text == "0"))
			{
				txt_solucion1.Text = "∅";
				MessageBox.Show("Error matemático", "Ecuaciones Cuadráticas", MessageBoxButtons.OK);

			}
			else
			{
				if (Obj_Ecua_DAL.dbldiscriminante == 0)
				{
					MessageBox.Show("La ecuación tiene una única solución", "Ecuaciones Cuadráticas", MessageBoxButtons.OK);
				}
				if (Obj_Ecua_DAL.dbldiscriminante < 0)
				{
					MessageBox.Show("La ecuación no tiene solución", "Ecuaciones Cuadráticas", MessageBoxButtons.OK);
				}
				if (Obj_Ecua_DAL.dbldiscriminante > 0)
				{
					MessageBox.Show("La ecuación tiene dos soluciones", "Ecuaciones Cuadráticas", MessageBoxButtons.OK);
				}

			}
		}


		private void Ecuacion(cls_Ecua_DAL Obj_Ecua_DAL)
		{

			if ((txt_numA.Text == "") || (txt_numB.Text == "") || (txt_numC.Text == ""))
			{
				erp_general.SetError(btn_calcularEcua, "HAY CAMPOS VACÍOS");
			}
			else
			{
				erp_general.Clear();
				Obj_Ecua_DAL.dblnumA = Convert.ToDouble(txt_numA.Text.Trim());
				Obj_Ecua_DAL.dblnumB = Convert.ToDouble(txt_numB.Text.Trim());
				Obj_Ecua_DAL.dblnumC = Convert.ToDouble(txt_numC.Text.Trim());

				Obj_Ecua_BLL.CalcularEcuacion(ref Obj_Ecua_DAL);

				txt_discriminante.Text = Obj_Ecua_DAL.dbldiscriminante.ToString("f2");
				txt_solucion1.Text = Obj_Ecua_DAL.dblsolucion1.ToString("f2");
				txt_solucion2.Text = Obj_Ecua_DAL.dblsolucion2.ToString("f2");
				if (Obj_Ecua_DAL.dbldiscriminante == 0)
				{
					txt_solucion2.Text = "∅";
				}
				if (Obj_Ecua_DAL.dbldiscriminante < 0)
				{
					txt_solucion1.Text = "∅";
					txt_solucion2.Text = "∅";
				}

			}


		}

		private void btn_limpiarEcua_Click(object sender, EventArgs e)
		{
			btn_calcularEcua.Enabled = true;
			txt_numA.Enabled = true;
			txt_numB.Enabled = true;
			txt_numC.Enabled = true;
			txt_numA.Text = "0";
			txt_numB.Text = "0";
			txt_numC.Text = "0";
			txt_discriminante.Text = "";
			txt_solucion1.Text = "";
			txt_solucion2.Text = "";
		}

		private void KeyPressGnerico(KeyPressEventArgs e, TextBox txt)
		{
			if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == cSeparador) || (e.KeyChar == 45))
			{
				if ((e.KeyChar == cSeparador) && txt.Text.Contains(Convert.ToString(e.KeyChar)))
				{
					e.Handled = true;
				}
				else
				{
					if ((e.KeyChar == cSeparador) && (txt.SelectionStart == 0)) // NO DEJA PONER TECLA SIN DATOS
					{
						e.Handled = true;
					}
					else
					{
						e.Handled = false;
					}
				}
				if ((e.KeyChar == 45) && txt.Text.Contains(Convert.ToString(e.KeyChar)))  // NO REPITE TECLA
				{
					e.Handled = true;
				}
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txt_numA_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyPressGnerico(e, txt_numA);
		}

		private void txt_numB_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyPressGnerico(e, txt_numB);
		}

		private void txt_numC_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyPressGnerico(e, txt_numC);
		}

		private void ValidarCajasDeTexto(TextBox txt)
		{
			if (txt.Text.Length >= 2)
			{
				if (txt.Text.ToString().Substring((txt.Text.ToString().Length - 1), 1) == cSeparador.ToString())
				{
					txt.Text = txt.Text + "";
				}
			}

			float result = 0;
			if (!float.TryParse(txt.Text.Trim(), out result))
			{
				txt.Text = "";
			}
			else
				txt.Text = result.ToString();

			if (float.TryParse(txt.Text, out float fresult))
			{
				txt.ForeColor = Color.Blue;
				erp_general.Clear();
			}
			else
			{
				txt.Focus();
				txt.ForeColor = Color.Red;
				erp_general.SetError(txt, "DEBE DIGITAR ALMENOS UN NUMERO");
			}
		}

		private void txt_numA_Leave(object sender, EventArgs e)
		{
			ValidarCajasDeTexto(txt_numA);
		}

		private void txt_numB_Leave(object sender, EventArgs e)
		{
			ValidarCajasDeTexto(txt_numB);
		}

		private void txt_numC_Leave(object sender, EventArgs e)
		{
			ValidarCajasDeTexto(txt_numC);
		}
		#endregion



		#region PROGRAMACION RADDIONBUTTON
		private void btn_sumarRad_Click(object sender, EventArgs e)
		{
			if ((rdb_todos.Checked == false) && (rdb_soloPares.Checked == false) && (rdb_soloImpares.Checked == false) && (txt_numLimite.Text == ""))
			{
				MessageBox.Show("DEBE LLENAR EL CAMPO DE NUMERO LIMITE Y MARCAR AL MENOS UNA OPCION", "Error", MessageBoxButtons.OK);
			}
			else
			{
				if ((rdb_todos.Checked == false) && (rdb_soloPares.Checked == false) && (rdb_soloImpares.Checked == false))
				{
					MessageBox.Show("DEBE MARCAR AL MENOS UNA OPCION", "Error", MessageBoxButtons.OK);
				}
				else
				{
					if (txt_numLimite.Text == "")
					{
						MessageBox.Show("EL CAMPO NUMERO LIMITE ESTA VACÍO", "Error", MessageBoxButtons.OK);
					}
					else
					{
						erp_general.Clear();
						cls_Rad_DAL Obj_Rad_DAL = new cls_Rad_DAL();

						Sumatoria(Obj_Rad_DAL);
					}
				}
			}

		}

		private void Sumatoria(cls_Rad_DAL Obj_Rad_DAL)
		{

			Obj_Rad_DAL.dclnumLimite = Convert.ToDecimal(txt_numLimite.Text.Trim());

			Obj_Rad_BLL.SumarRaddionButton(ref Obj_Rad_DAL);

			if (rdb_todos.Checked)
			{
				txt_resultadoSumatoria.Text = Obj_Rad_DAL.dclresultadoSumatoria.ToString();
			}
			if (rdb_soloPares.Checked)
			{
				txt_resultadoSumatoria.Text = Obj_Rad_DAL.dclrPar.ToString();
			}
			if (rdb_soloImpares.Checked)
			{
				txt_resultadoSumatoria.Text = Obj_Rad_DAL.dclrImpar.ToString();
			}

		}

		private void btn_limpiarRad_Click(object sender, EventArgs e)
		{

			txt_numLimite.Text = "0";
			txt_resultadoSumatoria.Text = "";
			rdb_todos.Checked = false;
			rdb_soloPares.Checked = false;
			rdb_soloImpares.Checked = false;
		}

		private void txt_numLimite_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8) || (e.KeyChar == 45))
			{
				if ((e.KeyChar == 45) && txt_numLimite.Text.Contains(Convert.ToString(e.KeyChar)))  // NO REPITE TECLA
				{
					e.Handled = true;
				}
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txt_numLimite_Leave(object sender, EventArgs e)
		{
			float result = 0;
			if (!float.TryParse(txt_numLimite.Text.Trim(), out result))
			{
				txt_numLimite.Text = "";
			}
			else
				txt_numLimite.Text = result.ToString();

			if (float.TryParse(txt_numLimite.Text, out float fresult))
			{
				txt_numLimite.ForeColor = Color.Blue;
				erp_general.Clear();
			}
			else
			{
				txt_numLimite.Focus();
				txt_numLimite.ForeColor = Color.Red;
				erp_general.SetError(txt_numLimite, "ERROR, SIGNO NEGATIVO DEBE IR AL INICIO O EL ESPACIO ESTÁ VACÍO");
			}
		}
		#endregion



		#region PROGRAMACION CHECKBOX

		private void btn_llenarArreglo_Click(object sender, EventArgs e)
		{
			gpx_ControlCheck.Enabled = true;
			if (txt_tamArreglo.Text == "" || txt_limiteRandom.Text == "")
			{
				erp_general.SetError(txt_tamArreglo, "EL CAMPO ESTÁ VACÍO");
				erp_general.SetError(txt_limiteRandom, "EL CAMPO ESTÁ VACÍO");
			}
			else
			{
				erp_general.Clear();
				btn_llenarArreglo.Enabled = false;
				txt_tamArreglo.Enabled = false;
				txt_limiteRandom.Enabled = false;

				cls_Check_DAL Obj_Check_DAL = new cls_Check_DAL();
				Arreglo(Obj_Check_DAL);
				btn_verarregloCheck.Enabled = true;
			}
		}
		int[] numeros;
		private void Arreglo(cls_Check_DAL Obj_Check_DAL)
		{
			if (txt_tamArreglo.Text == "" || txt_limiteRandom.Text == "")
			{
				erp_general.SetError(btn_llenarArreglo, "HAY CAMPOS VACÍOS");
			}
			else
			{
				erp_general.Clear();
				Obj_Check_DAL.tamArreglo = Convert.ToInt32(txt_tamArreglo.Text.Trim());
				Obj_Check_DAL.limRandom = Convert.ToInt32(txt_limiteRandom.Text.Trim());



				numeros = Obj_Check_BLL.generarNumerosAleatoriosNoRepetidos(Obj_Check_DAL.tamArreglo, 0, Obj_Check_DAL.limRandom);

				if (numeros != null)
				{
					for (int i = 0; i < numeros.Length; i++)
					{

						Obj_Check_DAL.contArreglo = (numeros[i]);

						if (btn_verarregloCheck.Enabled == true)
						{
							txt_contenidoArreglo.Text += (" ( " + Obj_Check_DAL.contArreglo.ToString() + " ) ");
						}
						

					}

				}
				
			}
		}
		private void btn_verarregloCheck_Click(object sender, EventArgs e)
		{
			gpx_ControlCheck.Enabled = false;
			cls_Check_DAL Obj_Check_DAL = new cls_Check_DAL();
			Arreglo(Obj_Check_DAL);
			btn_verarregloCheck.Enabled = false;

			if (chk_removerPares.Checked == true && chk_removerMenorDiez.Checked == false && chk_removerMayorCincuenta.Checked == false)
			{
				txt_contenidoArreglo.Text = "";
				for (int i = 0; i < Obj_Check_DAL.tamArreglo; i++)
				{
					if (numeros[i] % 2 != 0)
					{
						txt_contenidoArreglo.Text += String.Join(",", " ( " + numeros[i] + " ) ");
					}
				}
			}

			if (chk_removerPares.Checked == false && chk_removerMenorDiez.Checked == true && chk_removerMayorCincuenta.Checked == false)
			{
				txt_contenidoArreglo.Text = "";
				for (int i = 0; i < numeros.Length; i++)
				{
					if (numeros[i] > 10)
					{
						txt_contenidoArreglo.Text += String.Join(",", " ( " + numeros[i] + " ) ");
					}
					
				}
			}

			if (chk_removerPares.Checked == false && chk_removerMenorDiez.Checked == false && chk_removerMayorCincuenta.Checked == true)
			{
				txt_contenidoArreglo.Text = "";
				for (int i = 0; i < numeros.Length; i++)
				{
					if (numeros[i] < 50)
					{
						txt_contenidoArreglo.Text += String.Join(",", " ( " + numeros[i] + " ) ");
					}
				}
			}

			if ((chk_removerPares.Checked == true) && (chk_removerMenorDiez.Checked == true) && (chk_removerMayorCincuenta.Checked == false))
			{
				txt_contenidoArreglo.Text = "";
				for (int i = 0; i < Obj_Check_DAL.tamArreglo; i++)
				{
					if (numeros[i] % 2 != 0 && numeros[i] > 10)
					{

						txt_contenidoArreglo.Text += String.Join(",", " ( " + numeros[i] + " ) ");
					}
				}
			}

			if ((chk_removerPares.Checked == true) && (chk_removerMenorDiez.Checked == true) && (chk_removerMayorCincuenta.Checked == true))
			{
				txt_contenidoArreglo.Text = "";
				for (int i = 0; i < Obj_Check_DAL.tamArreglo; i++)
				{
					if (numeros[i] % 2 != 0 && numeros[i] > 10 && numeros[i] < 50)
					{

						txt_contenidoArreglo.Text += String.Join(",", " ( " + numeros[i] + " ) ");
					}
				}
			}

			if ((chk_removerPares.Checked == false) && (chk_removerMenorDiez.Checked == true) && (chk_removerMayorCincuenta.Checked == true))
			{
				txt_contenidoArreglo.Text = "";
				for (int i = 0; i < Obj_Check_DAL.tamArreglo; i++)
				{
					if (numeros[i] > 10 && numeros[i] < 50)
					{
						txt_contenidoArreglo.Text += String.Join(",", " ( " + numeros[i] + " ) ");
					}
				}
			}

			if ((chk_removerPares.Checked == true) && (chk_removerMenorDiez.Checked == false) && (chk_removerMayorCincuenta.Checked == true))
			{
				txt_contenidoArreglo.Text = "";
				for (int i = 0; i < Obj_Check_DAL.tamArreglo; i++)
				{
					if (numeros[i] % 2 != 0 && numeros[i] < 50)
					{
						txt_contenidoArreglo.Text += String.Join(",", " ( " + numeros[i] + " ) ");
					}
				}
			}

		}

		private void btn_limpiarCheck_Click(object sender, EventArgs e)
		{
			gpx_ControlCheck.Enabled = false;
			txt_tamArreglo.Enabled = true;
			txt_limiteRandom.Enabled = false;
			btn_llenarArreglo.Enabled = false;
			btn_verarregloCheck.Enabled = false;
			txt_tamArreglo.Text = "";
			txt_limiteRandom.Text = "";
			txt_contenidoArreglo.Text = "";
			chk_removerMayorCincuenta.Enabled = true;
			chk_removerPares.Checked = false;
			chk_removerMenorDiez.Checked = false;
			chk_removerMayorCincuenta.Checked = false;

		}

		private void ValidarCajasDeTextoArreglo(TextBox txt)
		{
			float result = 0;
			if (!float.TryParse(txt.Text.Trim(), out result))
			{
				txt.Text = "";
			}
			else
				txt.Text = result.ToString();

			if (float.TryParse(txt.Text, out float fresult))
			{
				txt.ForeColor = Color.Blue;
				erp_general.Clear();
			}
			else
			{
				txt.Focus();
				txt.ForeColor = Color.Red;
				erp_general.SetError(txt, "DEBE DIGITAR ALMENOS UN NUMERO");
			}
		}
		private void txt_tamArreglo_Leave(object sender, EventArgs e)
		{
			txt_limiteRandom.Enabled = true;
			ValidarCajasDeTextoArreglo(txt_tamArreglo);
			if (int.TryParse(txt_tamArreglo.Text, out int aresu))
			{
				if (aresu <= 10 && aresu > 0)
				{
					txt_tamArreglo.ForeColor = Color.Blue;
					erp_general.Clear();
				}
				else
				{
					txt_tamArreglo.Focus();
					txt_tamArreglo.ForeColor = Color.Red;
					erp_general.SetError(txt_tamArreglo, "EL TAMAÑO DEL ARREGLO TIENE QUE SER MENOR O IGUAL A 10 Y MAYOR A CERO");
				}
			}
			
		}

		private void txt_limiteRandom_Leave(object sender, EventArgs e)
		{
			ValidarCajasDeTextoArreglo(txt_limiteRandom);
			if (int.TryParse(txt_limiteRandom.Text, out int aresult))
			{
				int.TryParse(txt_tamArreglo.Text, out int re);
				if (aresult >= re && aresult <= 100 )
				{
					
					if (int.TryParse(txt_limiteRandom.Text, out int ar))
					{
						if (ar < 50)
						{
							chk_removerMayorCincuenta.Enabled = false;
						}
					}
					txt_limiteRandom.ForeColor = Color.Blue;
					erp_general.Clear();
					btn_llenarArreglo.Enabled = true;
				}
				else
				{
					txt_limiteRandom.Focus();
					txt_limiteRandom.ForeColor = Color.Red;
					erp_general.SetError(txt_limiteRandom, "EL LIMITE RANDOM TIENE QUE SER MAYOR O IGUAL AL TAMAÑO DEL ARREGLO PERO MENOR O IGUAL A 100");
				}
				
			}
			
		}

		private void KeyPressArregloGenerico(KeyPressEventArgs e, TextBox txt)
		{

			if (char.IsNumber(e.KeyChar) || (e.KeyChar == 8))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}

		}

		private void txt_tamArreglo_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyPressArregloGenerico(e, txt_tamArreglo);
		}

		private void txt_limiteRandom_KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyPressArregloGenerico(e, txt_limiteRandom);
		}

		#endregion


	}
}

