
namespace Ventanas_PL.Pantallas.Ventanas
{
	partial class frm_Ventanas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ventanas));
			this.tbc_ventanas = new System.Windows.Forms.TabControl();
			this.tbp_Ecua = new System.Windows.Forms.TabPage();
			this.gpx_ecua = new System.Windows.Forms.GroupBox();
			this.gpx_opcEcua = new System.Windows.Forms.GroupBox();
			this.btn_calcularEcua = new System.Windows.Forms.Button();
			this.btn_limpiarEcua = new System.Windows.Forms.Button();
			this.txt_solucion2 = new System.Windows.Forms.TextBox();
			this.txt_solucion1 = new System.Windows.Forms.TextBox();
			this.txt_discriminante = new System.Windows.Forms.TextBox();
			this.lbl_solucion2 = new System.Windows.Forms.Label();
			this.lbl_solucion1 = new System.Windows.Forms.Label();
			this.lbl_discriminante = new System.Windows.Forms.Label();
			this.txt_numC = new System.Windows.Forms.TextBox();
			this.txt_numB = new System.Windows.Forms.TextBox();
			this.txt_numA = new System.Windows.Forms.TextBox();
			this.lbl_numC = new System.Windows.Forms.Label();
			this.lbl_numB = new System.Windows.Forms.Label();
			this.lbl_numA = new System.Windows.Forms.Label();
			this.tbp_Rad = new System.Windows.Forms.TabPage();
			this.gpx_sumatoriaRad = new System.Windows.Forms.GroupBox();
			this.txt_resultadoSumatoria = new System.Windows.Forms.TextBox();
			this.txt_numLimite = new System.Windows.Forms.TextBox();
			this.lbl_resultadoSumatoriaRad = new System.Windows.Forms.Label();
			this.lbl_numeroLimiteRad = new System.Windows.Forms.Label();
			this.gpx_OpcRad = new System.Windows.Forms.GroupBox();
			this.btn_sumarRad = new System.Windows.Forms.Button();
			this.btn_limpiarRad = new System.Windows.Forms.Button();
			this.gpx_ControlRad = new System.Windows.Forms.GroupBox();
			this.rdb_soloImpares = new System.Windows.Forms.RadioButton();
			this.rdb_soloPares = new System.Windows.Forms.RadioButton();
			this.rdb_todos = new System.Windows.Forms.RadioButton();
			this.tbp_Check = new System.Windows.Forms.TabPage();
			this.gpx_Arreglo = new System.Windows.Forms.GroupBox();
			this.txt_contenidoArreglo = new System.Windows.Forms.TextBox();
			this.lbl_contenidoArreglo = new System.Windows.Forms.Label();
			this.gpx_ControlCheck = new System.Windows.Forms.GroupBox();
			this.chk_removerMayorCincuenta = new System.Windows.Forms.CheckBox();
			this.chk_removerMenorDiez = new System.Windows.Forms.CheckBox();
			this.chk_removerPares = new System.Windows.Forms.CheckBox();
			this.btn_llenarArreglo = new System.Windows.Forms.Button();
			this.txt_limiteRandom = new System.Windows.Forms.TextBox();
			this.lbl_limiteRandom = new System.Windows.Forms.Label();
			this.txt_tamArreglo = new System.Windows.Forms.TextBox();
			this.lbl_TamArreglo = new System.Windows.Forms.Label();
			this.gpx_OpcCheck = new System.Windows.Forms.GroupBox();
			this.btn_verarregloCheck = new System.Windows.Forms.Button();
			this.btn_limpiarCheck = new System.Windows.Forms.Button();
			this.tbp_Timer = new System.Windows.Forms.TabPage();
			this.gpx_cronometro = new System.Windows.Forms.GroupBox();
			this.txt_milisegundos = new System.Windows.Forms.TextBox();
			this.txt_segundos = new System.Windows.Forms.TextBox();
			this.lbl_milisegundos = new System.Windows.Forms.Label();
			this.lbl_segundos = new System.Windows.Forms.Label();
			this.txt_minutos = new System.Windows.Forms.TextBox();
			this.gpx_opcTimer = new System.Windows.Forms.GroupBox();
			this.btn_detener = new System.Windows.Forms.Button();
			this.btn_iniciar = new System.Windows.Forms.Button();
			this.btn_limpiarTimer = new System.Windows.Forms.Button();
			this.txt_tiempo = new System.Windows.Forms.TextBox();
			this.lbl_minutos = new System.Windows.Forms.Label();
			this.lbl_min = new System.Windows.Forms.Label();
			this.lbl_tiempo = new System.Windows.Forms.Label();
			this.btn_salir = new System.Windows.Forms.Button();
			this.tmr_general = new System.Windows.Forms.Timer(this.components);
			this.erp_general = new System.Windows.Forms.ErrorProvider(this.components);
			this.tbc_ventanas.SuspendLayout();
			this.tbp_Ecua.SuspendLayout();
			this.gpx_ecua.SuspendLayout();
			this.gpx_opcEcua.SuspendLayout();
			this.tbp_Rad.SuspendLayout();
			this.gpx_sumatoriaRad.SuspendLayout();
			this.gpx_OpcRad.SuspendLayout();
			this.gpx_ControlRad.SuspendLayout();
			this.tbp_Check.SuspendLayout();
			this.gpx_Arreglo.SuspendLayout();
			this.gpx_ControlCheck.SuspendLayout();
			this.gpx_OpcCheck.SuspendLayout();
			this.tbp_Timer.SuspendLayout();
			this.gpx_cronometro.SuspendLayout();
			this.gpx_opcTimer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.erp_general)).BeginInit();
			this.SuspendLayout();
			// 
			// tbc_ventanas
			// 
			this.tbc_ventanas.Controls.Add(this.tbp_Ecua);
			this.tbc_ventanas.Controls.Add(this.tbp_Rad);
			this.tbc_ventanas.Controls.Add(this.tbp_Check);
			this.tbc_ventanas.Controls.Add(this.tbp_Timer);
			this.tbc_ventanas.Location = new System.Drawing.Point(12, 12);
			this.tbc_ventanas.Name = "tbc_ventanas";
			this.tbc_ventanas.SelectedIndex = 0;
			this.tbc_ventanas.Size = new System.Drawing.Size(747, 427);
			this.tbc_ventanas.TabIndex = 0;
			// 
			// tbp_Ecua
			// 
			this.tbp_Ecua.Controls.Add(this.gpx_ecua);
			this.tbp_Ecua.Location = new System.Drawing.Point(4, 22);
			this.tbp_Ecua.Name = "tbp_Ecua";
			this.tbp_Ecua.Padding = new System.Windows.Forms.Padding(3);
			this.tbp_Ecua.Size = new System.Drawing.Size(739, 401);
			this.tbp_Ecua.TabIndex = 0;
			this.tbp_Ecua.Text = "Ecuaciones Cuadráticas";
			this.tbp_Ecua.UseVisualStyleBackColor = true;
			// 
			// gpx_ecua
			// 
			this.gpx_ecua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gpx_ecua.BackgroundImage")));
			this.gpx_ecua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gpx_ecua.Controls.Add(this.gpx_opcEcua);
			this.gpx_ecua.Controls.Add(this.txt_solucion2);
			this.gpx_ecua.Controls.Add(this.txt_solucion1);
			this.gpx_ecua.Controls.Add(this.txt_discriminante);
			this.gpx_ecua.Controls.Add(this.lbl_solucion2);
			this.gpx_ecua.Controls.Add(this.lbl_solucion1);
			this.gpx_ecua.Controls.Add(this.lbl_discriminante);
			this.gpx_ecua.Controls.Add(this.txt_numC);
			this.gpx_ecua.Controls.Add(this.txt_numB);
			this.gpx_ecua.Controls.Add(this.txt_numA);
			this.gpx_ecua.Controls.Add(this.lbl_numC);
			this.gpx_ecua.Controls.Add(this.lbl_numB);
			this.gpx_ecua.Controls.Add(this.lbl_numA);
			this.gpx_ecua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpx_ecua.Location = new System.Drawing.Point(3, 6);
			this.gpx_ecua.Name = "gpx_ecua";
			this.gpx_ecua.Size = new System.Drawing.Size(733, 392);
			this.gpx_ecua.TabIndex = 1;
			this.gpx_ecua.TabStop = false;
			this.gpx_ecua.Text = "Información de la Ecuación";
			// 
			// gpx_opcEcua
			// 
			this.gpx_opcEcua.Controls.Add(this.btn_calcularEcua);
			this.gpx_opcEcua.Controls.Add(this.btn_limpiarEcua);
			this.gpx_opcEcua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpx_opcEcua.Location = new System.Drawing.Point(445, 84);
			this.gpx_opcEcua.Name = "gpx_opcEcua";
			this.gpx_opcEcua.Size = new System.Drawing.Size(200, 100);
			this.gpx_opcEcua.TabIndex = 5;
			this.gpx_opcEcua.TabStop = false;
			this.gpx_opcEcua.Text = "Opciones";
			// 
			// btn_calcularEcua
			// 
			this.btn_calcularEcua.Location = new System.Drawing.Point(48, 21);
			this.btn_calcularEcua.Name = "btn_calcularEcua";
			this.btn_calcularEcua.Size = new System.Drawing.Size(93, 29);
			this.btn_calcularEcua.TabIndex = 6;
			this.btn_calcularEcua.Text = "Calcular";
			this.btn_calcularEcua.UseVisualStyleBackColor = true;
			this.btn_calcularEcua.Click += new System.EventHandler(this.btn_calcularEcua_Click);
			// 
			// btn_limpiarEcua
			// 
			this.btn_limpiarEcua.Location = new System.Drawing.Point(48, 56);
			this.btn_limpiarEcua.Name = "btn_limpiarEcua";
			this.btn_limpiarEcua.Size = new System.Drawing.Size(93, 29);
			this.btn_limpiarEcua.TabIndex = 7;
			this.btn_limpiarEcua.Text = "Limpiar";
			this.btn_limpiarEcua.UseVisualStyleBackColor = true;
			this.btn_limpiarEcua.Click += new System.EventHandler(this.btn_limpiarEcua_Click);
			// 
			// txt_solucion2
			// 
			this.txt_solucion2.Enabled = false;
			this.txt_solucion2.Location = new System.Drawing.Point(214, 256);
			this.txt_solucion2.Name = "txt_solucion2";
			this.txt_solucion2.Size = new System.Drawing.Size(100, 22);
			this.txt_solucion2.TabIndex = 0;
			this.txt_solucion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_solucion1
			// 
			this.txt_solucion1.Enabled = false;
			this.txt_solucion1.Location = new System.Drawing.Point(214, 219);
			this.txt_solucion1.Name = "txt_solucion1";
			this.txt_solucion1.Size = new System.Drawing.Size(100, 22);
			this.txt_solucion1.TabIndex = 0;
			this.txt_solucion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_discriminante
			// 
			this.txt_discriminante.Enabled = false;
			this.txt_discriminante.Location = new System.Drawing.Point(214, 181);
			this.txt_discriminante.Name = "txt_discriminante";
			this.txt_discriminante.Size = new System.Drawing.Size(100, 22);
			this.txt_discriminante.TabIndex = 0;
			this.txt_discriminante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_solucion2
			// 
			this.lbl_solucion2.AutoSize = true;
			this.lbl_solucion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_solucion2.Location = new System.Drawing.Point(108, 256);
			this.lbl_solucion2.Name = "lbl_solucion2";
			this.lbl_solucion2.Size = new System.Drawing.Size(84, 16);
			this.lbl_solucion2.TabIndex = 0;
			this.lbl_solucion2.Text = "Solución 2:";
			// 
			// lbl_solucion1
			// 
			this.lbl_solucion1.AutoSize = true;
			this.lbl_solucion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_solucion1.Location = new System.Drawing.Point(108, 219);
			this.lbl_solucion1.Name = "lbl_solucion1";
			this.lbl_solucion1.Size = new System.Drawing.Size(84, 16);
			this.lbl_solucion1.TabIndex = 0;
			this.lbl_solucion1.Text = "Solución 1:";
			// 
			// lbl_discriminante
			// 
			this.lbl_discriminante.AutoSize = true;
			this.lbl_discriminante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_discriminante.Location = new System.Drawing.Point(108, 181);
			this.lbl_discriminante.Name = "lbl_discriminante";
			this.lbl_discriminante.Size = new System.Drawing.Size(106, 16);
			this.lbl_discriminante.TabIndex = 0;
			this.lbl_discriminante.Text = "Discriminante:";
			// 
			// txt_numC
			// 
			this.txt_numC.Location = new System.Drawing.Point(291, 117);
			this.txt_numC.Name = "txt_numC";
			this.txt_numC.Size = new System.Drawing.Size(100, 22);
			this.txt_numC.TabIndex = 4;
			this.txt_numC.Text = "0";
			this.txt_numC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_numC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numC_KeyPress);
			this.txt_numC.Leave += new System.EventHandler(this.txt_numC_Leave);
			// 
			// txt_numB
			// 
			this.txt_numB.Location = new System.Drawing.Point(155, 117);
			this.txt_numB.Name = "txt_numB";
			this.txt_numB.Size = new System.Drawing.Size(100, 22);
			this.txt_numB.TabIndex = 3;
			this.txt_numB.Text = "0";
			this.txt_numB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_numB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numB_KeyPress);
			this.txt_numB.Leave += new System.EventHandler(this.txt_numB_Leave);
			// 
			// txt_numA
			// 
			this.txt_numA.Location = new System.Drawing.Point(28, 117);
			this.txt_numA.Name = "txt_numA";
			this.txt_numA.Size = new System.Drawing.Size(100, 22);
			this.txt_numA.TabIndex = 2;
			this.txt_numA.Text = "0";
			this.txt_numA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_numA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numA_KeyPress);
			this.txt_numA.Leave += new System.EventHandler(this.txt_numA_Leave);
			// 
			// lbl_numC
			// 
			this.lbl_numC.AutoSize = true;
			this.lbl_numC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_numC.Location = new System.Drawing.Point(326, 74);
			this.lbl_numC.Name = "lbl_numC";
			this.lbl_numC.Size = new System.Drawing.Size(31, 29);
			this.lbl_numC.TabIndex = 0;
			this.lbl_numC.Text = "C";
			// 
			// lbl_numB
			// 
			this.lbl_numB.AutoSize = true;
			this.lbl_numB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_numB.Location = new System.Drawing.Point(193, 74);
			this.lbl_numB.Name = "lbl_numB";
			this.lbl_numB.Size = new System.Drawing.Size(30, 29);
			this.lbl_numB.TabIndex = 0;
			this.lbl_numB.Text = "B";
			// 
			// lbl_numA
			// 
			this.lbl_numA.AutoSize = true;
			this.lbl_numA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_numA.Location = new System.Drawing.Point(64, 74);
			this.lbl_numA.Name = "lbl_numA";
			this.lbl_numA.Size = new System.Drawing.Size(29, 29);
			this.lbl_numA.TabIndex = 0;
			this.lbl_numA.Text = "A";
			// 
			// tbp_Rad
			// 
			this.tbp_Rad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbp_Rad.BackgroundImage")));
			this.tbp_Rad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tbp_Rad.Controls.Add(this.gpx_sumatoriaRad);
			this.tbp_Rad.Location = new System.Drawing.Point(4, 22);
			this.tbp_Rad.Name = "tbp_Rad";
			this.tbp_Rad.Padding = new System.Windows.Forms.Padding(3);
			this.tbp_Rad.Size = new System.Drawing.Size(739, 401);
			this.tbp_Rad.TabIndex = 1;
			this.tbp_Rad.Text = "Sumatoria Consecutiva";
			this.tbp_Rad.UseVisualStyleBackColor = true;
			// 
			// gpx_sumatoriaRad
			// 
			this.gpx_sumatoriaRad.Controls.Add(this.txt_resultadoSumatoria);
			this.gpx_sumatoriaRad.Controls.Add(this.txt_numLimite);
			this.gpx_sumatoriaRad.Controls.Add(this.lbl_resultadoSumatoriaRad);
			this.gpx_sumatoriaRad.Controls.Add(this.lbl_numeroLimiteRad);
			this.gpx_sumatoriaRad.Controls.Add(this.gpx_OpcRad);
			this.gpx_sumatoriaRad.Controls.Add(this.gpx_ControlRad);
			this.gpx_sumatoriaRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpx_sumatoriaRad.Location = new System.Drawing.Point(21, 22);
			this.gpx_sumatoriaRad.Name = "gpx_sumatoriaRad";
			this.gpx_sumatoriaRad.Size = new System.Drawing.Size(579, 318);
			this.gpx_sumatoriaRad.TabIndex = 8;
			this.gpx_sumatoriaRad.TabStop = false;
			this.gpx_sumatoriaRad.Text = "Sumatoria";
			// 
			// txt_resultadoSumatoria
			// 
			this.txt_resultadoSumatoria.Enabled = false;
			this.txt_resultadoSumatoria.Location = new System.Drawing.Point(193, 222);
			this.txt_resultadoSumatoria.Name = "txt_resultadoSumatoria";
			this.txt_resultadoSumatoria.Size = new System.Drawing.Size(100, 22);
			this.txt_resultadoSumatoria.TabIndex = 0;
			this.txt_resultadoSumatoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_numLimite
			// 
			this.txt_numLimite.Location = new System.Drawing.Point(186, 38);
			this.txt_numLimite.Name = "txt_numLimite";
			this.txt_numLimite.Size = new System.Drawing.Size(100, 22);
			this.txt_numLimite.TabIndex = 9;
			this.txt_numLimite.Text = "0";
			this.txt_numLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_numLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numLimite_KeyPress);
			this.txt_numLimite.Leave += new System.EventHandler(this.txt_numLimite_Leave);
			// 
			// lbl_resultadoSumatoriaRad
			// 
			this.lbl_resultadoSumatoriaRad.AutoSize = true;
			this.lbl_resultadoSumatoriaRad.Location = new System.Drawing.Point(43, 222);
			this.lbl_resultadoSumatoriaRad.Name = "lbl_resultadoSumatoriaRad";
			this.lbl_resultadoSumatoriaRad.Size = new System.Drawing.Size(157, 16);
			this.lbl_resultadoSumatoriaRad.TabIndex = 0;
			this.lbl_resultadoSumatoriaRad.Text = "Resultado Sumatoria:";
			// 
			// lbl_numeroLimiteRad
			// 
			this.lbl_numeroLimiteRad.AutoSize = true;
			this.lbl_numeroLimiteRad.Location = new System.Drawing.Point(80, 38);
			this.lbl_numeroLimiteRad.Name = "lbl_numeroLimiteRad";
			this.lbl_numeroLimiteRad.Size = new System.Drawing.Size(115, 16);
			this.lbl_numeroLimiteRad.TabIndex = 0;
			this.lbl_numeroLimiteRad.Text = "Número Límite: ";
			// 
			// gpx_OpcRad
			// 
			this.gpx_OpcRad.Controls.Add(this.btn_sumarRad);
			this.gpx_OpcRad.Controls.Add(this.btn_limpiarRad);
			this.gpx_OpcRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpx_OpcRad.Location = new System.Drawing.Point(338, 35);
			this.gpx_OpcRad.Name = "gpx_OpcRad";
			this.gpx_OpcRad.Size = new System.Drawing.Size(200, 100);
			this.gpx_OpcRad.TabIndex = 14;
			this.gpx_OpcRad.TabStop = false;
			this.gpx_OpcRad.Text = "Opciones";
			// 
			// btn_sumarRad
			// 
			this.btn_sumarRad.Location = new System.Drawing.Point(48, 21);
			this.btn_sumarRad.Name = "btn_sumarRad";
			this.btn_sumarRad.Size = new System.Drawing.Size(93, 29);
			this.btn_sumarRad.TabIndex = 15;
			this.btn_sumarRad.Text = "Sumar";
			this.btn_sumarRad.UseVisualStyleBackColor = true;
			this.btn_sumarRad.Click += new System.EventHandler(this.btn_sumarRad_Click);
			// 
			// btn_limpiarRad
			// 
			this.btn_limpiarRad.Location = new System.Drawing.Point(48, 56);
			this.btn_limpiarRad.Name = "btn_limpiarRad";
			this.btn_limpiarRad.Size = new System.Drawing.Size(93, 29);
			this.btn_limpiarRad.TabIndex = 16;
			this.btn_limpiarRad.Text = "Limpiar";
			this.btn_limpiarRad.UseVisualStyleBackColor = true;
			this.btn_limpiarRad.Click += new System.EventHandler(this.btn_limpiarRad_Click);
			// 
			// gpx_ControlRad
			// 
			this.gpx_ControlRad.Controls.Add(this.rdb_soloImpares);
			this.gpx_ControlRad.Controls.Add(this.rdb_soloPares);
			this.gpx_ControlRad.Controls.Add(this.rdb_todos);
			this.gpx_ControlRad.Location = new System.Drawing.Point(27, 94);
			this.gpx_ControlRad.Name = "gpx_ControlRad";
			this.gpx_ControlRad.Size = new System.Drawing.Size(305, 61);
			this.gpx_ControlRad.TabIndex = 10;
			this.gpx_ControlRad.TabStop = false;
			this.gpx_ControlRad.Text = "Control";
			// 
			// rdb_soloImpares
			// 
			this.rdb_soloImpares.AutoSize = true;
			this.rdb_soloImpares.Location = new System.Drawing.Point(193, 21);
			this.rdb_soloImpares.Name = "rdb_soloImpares";
			this.rdb_soloImpares.Size = new System.Drawing.Size(118, 20);
			this.rdb_soloImpares.TabIndex = 13;
			this.rdb_soloImpares.TabStop = true;
			this.rdb_soloImpares.Text = "Solo Impares";
			this.rdb_soloImpares.UseVisualStyleBackColor = true;
			// 
			// rdb_soloPares
			// 
			this.rdb_soloPares.AutoSize = true;
			this.rdb_soloPares.Location = new System.Drawing.Point(91, 21);
			this.rdb_soloPares.Name = "rdb_soloPares";
			this.rdb_soloPares.Size = new System.Drawing.Size(103, 20);
			this.rdb_soloPares.TabIndex = 12;
			this.rdb_soloPares.TabStop = true;
			this.rdb_soloPares.Text = "Solo Pares";
			this.rdb_soloPares.UseVisualStyleBackColor = true;
			// 
			// rdb_todos
			// 
			this.rdb_todos.AutoSize = true;
			this.rdb_todos.Location = new System.Drawing.Point(19, 20);
			this.rdb_todos.Name = "rdb_todos";
			this.rdb_todos.Size = new System.Drawing.Size(71, 20);
			this.rdb_todos.TabIndex = 11;
			this.rdb_todos.TabStop = true;
			this.rdb_todos.Text = "Todos";
			this.rdb_todos.UseVisualStyleBackColor = true;
			// 
			// tbp_Check
			// 
			this.tbp_Check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbp_Check.BackgroundImage")));
			this.tbp_Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tbp_Check.Controls.Add(this.gpx_Arreglo);
			this.tbp_Check.Location = new System.Drawing.Point(4, 22);
			this.tbp_Check.Name = "tbp_Check";
			this.tbp_Check.Padding = new System.Windows.Forms.Padding(3);
			this.tbp_Check.Size = new System.Drawing.Size(739, 401);
			this.tbp_Check.TabIndex = 2;
			this.tbp_Check.Text = "Arreglo";
			this.tbp_Check.UseVisualStyleBackColor = true;
			// 
			// gpx_Arreglo
			// 
			this.gpx_Arreglo.Controls.Add(this.txt_contenidoArreglo);
			this.gpx_Arreglo.Controls.Add(this.lbl_contenidoArreglo);
			this.gpx_Arreglo.Controls.Add(this.gpx_ControlCheck);
			this.gpx_Arreglo.Controls.Add(this.btn_llenarArreglo);
			this.gpx_Arreglo.Controls.Add(this.txt_limiteRandom);
			this.gpx_Arreglo.Controls.Add(this.lbl_limiteRandom);
			this.gpx_Arreglo.Controls.Add(this.txt_tamArreglo);
			this.gpx_Arreglo.Controls.Add(this.lbl_TamArreglo);
			this.gpx_Arreglo.Controls.Add(this.gpx_OpcCheck);
			this.gpx_Arreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpx_Arreglo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gpx_Arreglo.Location = new System.Drawing.Point(15, 18);
			this.gpx_Arreglo.Name = "gpx_Arreglo";
			this.gpx_Arreglo.Size = new System.Drawing.Size(645, 335);
			this.gpx_Arreglo.TabIndex = 17;
			this.gpx_Arreglo.TabStop = false;
			this.gpx_Arreglo.Text = "Arreglo";
			// 
			// txt_contenidoArreglo
			// 
			this.txt_contenidoArreglo.Enabled = false;
			this.txt_contenidoArreglo.Location = new System.Drawing.Point(194, 295);
			this.txt_contenidoArreglo.Name = "txt_contenidoArreglo";
			this.txt_contenidoArreglo.Size = new System.Drawing.Size(445, 22);
			this.txt_contenidoArreglo.TabIndex = 0;
			// 
			// lbl_contenidoArreglo
			// 
			this.lbl_contenidoArreglo.AutoSize = true;
			this.lbl_contenidoArreglo.Location = new System.Drawing.Point(51, 298);
			this.lbl_contenidoArreglo.Name = "lbl_contenidoArreglo";
			this.lbl_contenidoArreglo.Size = new System.Drawing.Size(137, 16);
			this.lbl_contenidoArreglo.TabIndex = 0;
			this.lbl_contenidoArreglo.Text = "Contenido Arreglo:";
			// 
			// gpx_ControlCheck
			// 
			this.gpx_ControlCheck.Controls.Add(this.chk_removerMayorCincuenta);
			this.gpx_ControlCheck.Controls.Add(this.chk_removerMenorDiez);
			this.gpx_ControlCheck.Controls.Add(this.chk_removerPares);
			this.gpx_ControlCheck.Enabled = false;
			this.gpx_ControlCheck.Location = new System.Drawing.Point(23, 142);
			this.gpx_ControlCheck.Name = "gpx_ControlCheck";
			this.gpx_ControlCheck.Size = new System.Drawing.Size(280, 100);
			this.gpx_ControlCheck.TabIndex = 21;
			this.gpx_ControlCheck.TabStop = false;
			this.gpx_ControlCheck.Text = "Control";
			// 
			// chk_removerMayorCincuenta
			// 
			this.chk_removerMayorCincuenta.AutoSize = true;
			this.chk_removerMayorCincuenta.Location = new System.Drawing.Point(17, 74);
			this.chk_removerMayorCincuenta.Name = "chk_removerMayorCincuenta";
			this.chk_removerMayorCincuenta.Size = new System.Drawing.Size(250, 20);
			this.chk_removerMayorCincuenta.TabIndex = 24;
			this.chk_removerMayorCincuenta.Text = "Remover números mayores a 50";
			this.chk_removerMayorCincuenta.UseVisualStyleBackColor = true;
			// 
			// chk_removerMenorDiez
			// 
			this.chk_removerMenorDiez.AutoSize = true;
			this.chk_removerMenorDiez.Location = new System.Drawing.Point(17, 48);
			this.chk_removerMenorDiez.Name = "chk_removerMenorDiez";
			this.chk_removerMenorDiez.Size = new System.Drawing.Size(250, 20);
			this.chk_removerMenorDiez.TabIndex = 23;
			this.chk_removerMenorDiez.Text = "Remover números menores a 10";
			this.chk_removerMenorDiez.UseVisualStyleBackColor = true;
			// 
			// chk_removerPares
			// 
			this.chk_removerPares.AutoSize = true;
			this.chk_removerPares.Location = new System.Drawing.Point(17, 22);
			this.chk_removerPares.Name = "chk_removerPares";
			this.chk_removerPares.Size = new System.Drawing.Size(197, 20);
			this.chk_removerPares.TabIndex = 22;
			this.chk_removerPares.Text = "Remover números pares";
			this.chk_removerPares.UseVisualStyleBackColor = true;
			// 
			// btn_llenarArreglo
			// 
			this.btn_llenarArreglo.Enabled = false;
			this.btn_llenarArreglo.Location = new System.Drawing.Point(286, 67);
			this.btn_llenarArreglo.Name = "btn_llenarArreglo";
			this.btn_llenarArreglo.Size = new System.Drawing.Size(118, 29);
			this.btn_llenarArreglo.TabIndex = 20;
			this.btn_llenarArreglo.Text = "Llenar Arreglo";
			this.btn_llenarArreglo.UseVisualStyleBackColor = true;
			this.btn_llenarArreglo.Click += new System.EventHandler(this.btn_llenarArreglo_Click);
			// 
			// txt_limiteRandom
			// 
			this.txt_limiteRandom.Enabled = false;
			this.txt_limiteRandom.Location = new System.Drawing.Point(164, 70);
			this.txt_limiteRandom.Name = "txt_limiteRandom";
			this.txt_limiteRandom.Size = new System.Drawing.Size(100, 22);
			this.txt_limiteRandom.TabIndex = 19;
			this.txt_limiteRandom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_limiteRandom_KeyPress);
			this.txt_limiteRandom.Leave += new System.EventHandler(this.txt_limiteRandom_Leave);
			// 
			// lbl_limiteRandom
			// 
			this.lbl_limiteRandom.AutoSize = true;
			this.lbl_limiteRandom.Location = new System.Drawing.Point(20, 73);
			this.lbl_limiteRandom.Name = "lbl_limiteRandom";
			this.lbl_limiteRandom.Size = new System.Drawing.Size(145, 16);
			this.lbl_limiteRandom.TabIndex = 0;
			this.lbl_limiteRandom.Text = "Limite del Random: ";
			// 
			// txt_tamArreglo
			// 
			this.txt_tamArreglo.Location = new System.Drawing.Point(164, 39);
			this.txt_tamArreglo.Name = "txt_tamArreglo";
			this.txt_tamArreglo.Size = new System.Drawing.Size(100, 22);
			this.txt_tamArreglo.TabIndex = 18;
			this.txt_tamArreglo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tamArreglo_KeyPress);
			this.txt_tamArreglo.Leave += new System.EventHandler(this.txt_tamArreglo_Leave);
			// 
			// lbl_TamArreglo
			// 
			this.lbl_TamArreglo.AutoSize = true;
			this.lbl_TamArreglo.Location = new System.Drawing.Point(20, 39);
			this.lbl_TamArreglo.Name = "lbl_TamArreglo";
			this.lbl_TamArreglo.Size = new System.Drawing.Size(128, 16);
			this.lbl_TamArreglo.TabIndex = 0;
			this.lbl_TamArreglo.Text = "Tamaño Arreglo: ";
			// 
			// gpx_OpcCheck
			// 
			this.gpx_OpcCheck.Controls.Add(this.btn_verarregloCheck);
			this.gpx_OpcCheck.Controls.Add(this.btn_limpiarCheck);
			this.gpx_OpcCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpx_OpcCheck.Location = new System.Drawing.Point(410, 39);
			this.gpx_OpcCheck.Name = "gpx_OpcCheck";
			this.gpx_OpcCheck.Size = new System.Drawing.Size(200, 100);
			this.gpx_OpcCheck.TabIndex = 25;
			this.gpx_OpcCheck.TabStop = false;
			this.gpx_OpcCheck.Text = "Opciones";
			// 
			// btn_verarregloCheck
			// 
			this.btn_verarregloCheck.Enabled = false;
			this.btn_verarregloCheck.Location = new System.Drawing.Point(40, 21);
			this.btn_verarregloCheck.Name = "btn_verarregloCheck";
			this.btn_verarregloCheck.Size = new System.Drawing.Size(101, 29);
			this.btn_verarregloCheck.TabIndex = 26;
			this.btn_verarregloCheck.Text = "Ver Arreglo";
			this.btn_verarregloCheck.UseVisualStyleBackColor = true;
			this.btn_verarregloCheck.Click += new System.EventHandler(this.btn_verarregloCheck_Click);
			// 
			// btn_limpiarCheck
			// 
			this.btn_limpiarCheck.Location = new System.Drawing.Point(40, 56);
			this.btn_limpiarCheck.Name = "btn_limpiarCheck";
			this.btn_limpiarCheck.Size = new System.Drawing.Size(101, 29);
			this.btn_limpiarCheck.TabIndex = 27;
			this.btn_limpiarCheck.Text = "Limpiar";
			this.btn_limpiarCheck.UseVisualStyleBackColor = true;
			this.btn_limpiarCheck.Click += new System.EventHandler(this.btn_limpiarCheck_Click);
			// 
			// tbp_Timer
			// 
			this.tbp_Timer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbp_Timer.BackgroundImage")));
			this.tbp_Timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tbp_Timer.Controls.Add(this.gpx_cronometro);
			this.tbp_Timer.Location = new System.Drawing.Point(4, 22);
			this.tbp_Timer.Name = "tbp_Timer";
			this.tbp_Timer.Padding = new System.Windows.Forms.Padding(3);
			this.tbp_Timer.Size = new System.Drawing.Size(739, 401);
			this.tbp_Timer.TabIndex = 3;
			this.tbp_Timer.Text = "Timer";
			this.tbp_Timer.UseVisualStyleBackColor = true;
			// 
			// gpx_cronometro
			// 
			this.gpx_cronometro.Controls.Add(this.txt_milisegundos);
			this.gpx_cronometro.Controls.Add(this.txt_segundos);
			this.gpx_cronometro.Controls.Add(this.lbl_milisegundos);
			this.gpx_cronometro.Controls.Add(this.lbl_segundos);
			this.gpx_cronometro.Controls.Add(this.txt_minutos);
			this.gpx_cronometro.Controls.Add(this.gpx_opcTimer);
			this.gpx_cronometro.Controls.Add(this.txt_tiempo);
			this.gpx_cronometro.Controls.Add(this.lbl_minutos);
			this.gpx_cronometro.Controls.Add(this.lbl_min);
			this.gpx_cronometro.Controls.Add(this.lbl_tiempo);
			this.gpx_cronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpx_cronometro.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.gpx_cronometro.Location = new System.Drawing.Point(23, 17);
			this.gpx_cronometro.Name = "gpx_cronometro";
			this.gpx_cronometro.Size = new System.Drawing.Size(591, 294);
			this.gpx_cronometro.TabIndex = 28;
			this.gpx_cronometro.TabStop = false;
			this.gpx_cronometro.Text = "Cronómetro";
			// 
			// txt_milisegundos
			// 
			this.txt_milisegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.txt_milisegundos.BackColor = System.Drawing.Color.White;
			this.txt_milisegundos.Enabled = false;
			this.txt_milisegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_milisegundos.Location = new System.Drawing.Point(415, 203);
			this.txt_milisegundos.Name = "txt_milisegundos";
			this.txt_milisegundos.Size = new System.Drawing.Size(85, 49);
			this.txt_milisegundos.TabIndex = 0;
			this.txt_milisegundos.Text = "000";
			this.txt_milisegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_segundos
			// 
			this.txt_segundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.txt_segundos.BackColor = System.Drawing.Color.White;
			this.txt_segundos.Enabled = false;
			this.txt_segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_segundos.Location = new System.Drawing.Point(243, 203);
			this.txt_segundos.Name = "txt_segundos";
			this.txt_segundos.Size = new System.Drawing.Size(66, 49);
			this.txt_segundos.TabIndex = 0;
			this.txt_segundos.Text = "00";
			this.txt_segundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_milisegundos
			// 
			this.lbl_milisegundos.AutoSize = true;
			this.lbl_milisegundos.Location = new System.Drawing.Point(315, 228);
			this.lbl_milisegundos.Name = "lbl_milisegundos";
			this.lbl_milisegundos.Size = new System.Drawing.Size(108, 16);
			this.lbl_milisegundos.TabIndex = 0;
			this.lbl_milisegundos.Text = "Milisegundos: ";
			// 
			// lbl_segundos
			// 
			this.lbl_segundos.AutoSize = true;
			this.lbl_segundos.Location = new System.Drawing.Point(165, 225);
			this.lbl_segundos.Name = "lbl_segundos";
			this.lbl_segundos.Size = new System.Drawing.Size(86, 16);
			this.lbl_segundos.TabIndex = 0;
			this.lbl_segundos.Text = "Segundos: ";
			// 
			// txt_minutos
			// 
			this.txt_minutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.txt_minutos.BackColor = System.Drawing.Color.White;
			this.txt_minutos.Enabled = false;
			this.txt_minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_minutos.Location = new System.Drawing.Point(91, 203);
			this.txt_minutos.Name = "txt_minutos";
			this.txt_minutos.Size = new System.Drawing.Size(66, 49);
			this.txt_minutos.TabIndex = 0;
			this.txt_minutos.Text = "0";
			this.txt_minutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// gpx_opcTimer
			// 
			this.gpx_opcTimer.Controls.Add(this.btn_detener);
			this.gpx_opcTimer.Controls.Add(this.btn_iniciar);
			this.gpx_opcTimer.Controls.Add(this.btn_limpiarTimer);
			this.gpx_opcTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpx_opcTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.gpx_opcTimer.Location = new System.Drawing.Point(327, 21);
			this.gpx_opcTimer.Name = "gpx_opcTimer";
			this.gpx_opcTimer.Size = new System.Drawing.Size(200, 144);
			this.gpx_opcTimer.TabIndex = 30;
			this.gpx_opcTimer.TabStop = false;
			this.gpx_opcTimer.Text = "Opciones";
			// 
			// btn_detener
			// 
			this.btn_detener.Enabled = false;
			this.btn_detener.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_detener.Location = new System.Drawing.Point(48, 56);
			this.btn_detener.Name = "btn_detener";
			this.btn_detener.Size = new System.Drawing.Size(93, 29);
			this.btn_detener.TabIndex = 32;
			this.btn_detener.Text = "Detener";
			this.btn_detener.UseVisualStyleBackColor = true;
			this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
			// 
			// btn_iniciar
			// 
			this.btn_iniciar.Enabled = false;
			this.btn_iniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_iniciar.Location = new System.Drawing.Point(48, 21);
			this.btn_iniciar.Name = "btn_iniciar";
			this.btn_iniciar.Size = new System.Drawing.Size(93, 29);
			this.btn_iniciar.TabIndex = 31;
			this.btn_iniciar.Text = "Iniciar";
			this.btn_iniciar.UseVisualStyleBackColor = true;
			this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
			// 
			// btn_limpiarTimer
			// 
			this.btn_limpiarTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_limpiarTimer.Location = new System.Drawing.Point(48, 91);
			this.btn_limpiarTimer.Name = "btn_limpiarTimer";
			this.btn_limpiarTimer.Size = new System.Drawing.Size(93, 29);
			this.btn_limpiarTimer.TabIndex = 33;
			this.btn_limpiarTimer.Text = "Limpiar";
			this.btn_limpiarTimer.UseVisualStyleBackColor = true;
			this.btn_limpiarTimer.Click += new System.EventHandler(this.btn_limpiarTimer_Click);
			// 
			// txt_tiempo
			// 
			this.txt_tiempo.Location = new System.Drawing.Point(91, 33);
			this.txt_tiempo.Name = "txt_tiempo";
			this.txt_tiempo.Size = new System.Drawing.Size(123, 22);
			this.txt_tiempo.TabIndex = 29;
			this.txt_tiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txt_tiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tiempo_KeyPress);
			this.txt_tiempo.Leave += new System.EventHandler(this.txt_tiempo_Leave);
			// 
			// lbl_minutos
			// 
			this.lbl_minutos.AutoSize = true;
			this.lbl_minutos.Location = new System.Drawing.Point(27, 225);
			this.lbl_minutos.Name = "lbl_minutos";
			this.lbl_minutos.Size = new System.Drawing.Size(69, 16);
			this.lbl_minutos.TabIndex = 0;
			this.lbl_minutos.Text = "Minutos: ";
			// 
			// lbl_min
			// 
			this.lbl_min.AutoSize = true;
			this.lbl_min.Location = new System.Drawing.Point(240, 36);
			this.lbl_min.Name = "lbl_min";
			this.lbl_min.Size = new System.Drawing.Size(61, 16);
			this.lbl_min.TabIndex = 0;
			this.lbl_min.Text = "minutos";
			// 
			// lbl_tiempo
			// 
			this.lbl_tiempo.AutoSize = true;
			this.lbl_tiempo.Location = new System.Drawing.Point(27, 36);
			this.lbl_tiempo.Name = "lbl_tiempo";
			this.lbl_tiempo.Size = new System.Drawing.Size(65, 16);
			this.lbl_tiempo.TabIndex = 0;
			this.lbl_tiempo.Text = "Tiempo:";
			// 
			// btn_salir
			// 
			this.btn_salir.Location = new System.Drawing.Point(653, 445);
			this.btn_salir.Name = "btn_salir";
			this.btn_salir.Size = new System.Drawing.Size(93, 29);
			this.btn_salir.TabIndex = 0;
			this.btn_salir.Text = "Salir";
			this.btn_salir.UseVisualStyleBackColor = true;
			this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
			// 
			// tmr_general
			// 
			this.tmr_general.Tick += new System.EventHandler(this.tmr_general_Tick);
			// 
			// erp_general
			// 
			this.erp_general.ContainerControl = this;
			// 
			// frm_Ventanas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(773, 494);
			this.Controls.Add(this.btn_salir);
			this.Controls.Add(this.tbc_ventanas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frm_Ventanas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_Ventanas";
			this.Load += new System.EventHandler(this.frm_Ventanas_Load);
			this.tbc_ventanas.ResumeLayout(false);
			this.tbp_Ecua.ResumeLayout(false);
			this.gpx_ecua.ResumeLayout(false);
			this.gpx_ecua.PerformLayout();
			this.gpx_opcEcua.ResumeLayout(false);
			this.tbp_Rad.ResumeLayout(false);
			this.gpx_sumatoriaRad.ResumeLayout(false);
			this.gpx_sumatoriaRad.PerformLayout();
			this.gpx_OpcRad.ResumeLayout(false);
			this.gpx_ControlRad.ResumeLayout(false);
			this.gpx_ControlRad.PerformLayout();
			this.tbp_Check.ResumeLayout(false);
			this.gpx_Arreglo.ResumeLayout(false);
			this.gpx_Arreglo.PerformLayout();
			this.gpx_ControlCheck.ResumeLayout(false);
			this.gpx_ControlCheck.PerformLayout();
			this.gpx_OpcCheck.ResumeLayout(false);
			this.tbp_Timer.ResumeLayout(false);
			this.gpx_cronometro.ResumeLayout(false);
			this.gpx_cronometro.PerformLayout();
			this.gpx_opcTimer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.erp_general)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tbc_ventanas;
		private System.Windows.Forms.TabPage tbp_Ecua;
		private System.Windows.Forms.TabPage tbp_Rad;
		private System.Windows.Forms.TabPage tbp_Check;
		private System.Windows.Forms.TabPage tbp_Timer;
		private System.Windows.Forms.GroupBox gpx_ecua;
		private System.Windows.Forms.GroupBox gpx_opcEcua;
		private System.Windows.Forms.Button btn_calcularEcua;
		private System.Windows.Forms.Button btn_limpiarEcua;
		private System.Windows.Forms.TextBox txt_solucion2;
		private System.Windows.Forms.TextBox txt_solucion1;
		private System.Windows.Forms.TextBox txt_discriminante;
		private System.Windows.Forms.Label lbl_solucion2;
		private System.Windows.Forms.Label lbl_solucion1;
		private System.Windows.Forms.Label lbl_discriminante;
		private System.Windows.Forms.TextBox txt_numC;
		private System.Windows.Forms.TextBox txt_numB;
		private System.Windows.Forms.TextBox txt_numA;
		private System.Windows.Forms.Label lbl_numC;
		private System.Windows.Forms.Label lbl_numB;
		private System.Windows.Forms.Label lbl_numA;
		private System.Windows.Forms.GroupBox gpx_sumatoriaRad;
		private System.Windows.Forms.TextBox txt_resultadoSumatoria;
		private System.Windows.Forms.TextBox txt_numLimite;
		private System.Windows.Forms.Label lbl_resultadoSumatoriaRad;
		private System.Windows.Forms.Label lbl_numeroLimiteRad;
		private System.Windows.Forms.GroupBox gpx_OpcRad;
		private System.Windows.Forms.Button btn_sumarRad;
		private System.Windows.Forms.Button btn_limpiarRad;
		private System.Windows.Forms.GroupBox gpx_ControlRad;
		private System.Windows.Forms.Button btn_salir;
		private System.Windows.Forms.RadioButton rdb_soloImpares;
		private System.Windows.Forms.RadioButton rdb_soloPares;
		private System.Windows.Forms.RadioButton rdb_todos;
		private System.Windows.Forms.GroupBox gpx_Arreglo;
		private System.Windows.Forms.TextBox txt_tamArreglo;
		private System.Windows.Forms.Label lbl_TamArreglo;
		private System.Windows.Forms.GroupBox gpx_OpcCheck;
		private System.Windows.Forms.Button btn_verarregloCheck;
		private System.Windows.Forms.Button btn_limpiarCheck;
		private System.Windows.Forms.TextBox txt_contenidoArreglo;
		private System.Windows.Forms.Label lbl_contenidoArreglo;
		private System.Windows.Forms.GroupBox gpx_ControlCheck;
		private System.Windows.Forms.CheckBox chk_removerMayorCincuenta;
		private System.Windows.Forms.CheckBox chk_removerMenorDiez;
		private System.Windows.Forms.CheckBox chk_removerPares;
		private System.Windows.Forms.Button btn_llenarArreglo;
		private System.Windows.Forms.TextBox txt_limiteRandom;
		private System.Windows.Forms.Label lbl_limiteRandom;
		private System.Windows.Forms.GroupBox gpx_cronometro;
		private System.Windows.Forms.Label lbl_minutos;
		private System.Windows.Forms.Label lbl_min;
		private System.Windows.Forms.Label lbl_tiempo;
		private System.Windows.Forms.TextBox txt_tiempo;
		private System.Windows.Forms.TextBox txt_milisegundos;
		private System.Windows.Forms.TextBox txt_segundos;
		private System.Windows.Forms.Label lbl_milisegundos;
		private System.Windows.Forms.Label lbl_segundos;
		private System.Windows.Forms.TextBox txt_minutos;
		private System.Windows.Forms.GroupBox gpx_opcTimer;
		private System.Windows.Forms.Button btn_detener;
		private System.Windows.Forms.Button btn_iniciar;
		private System.Windows.Forms.Button btn_limpiarTimer;
		private System.Windows.Forms.Timer tmr_general;
		private System.Windows.Forms.ErrorProvider erp_general;
	}
}