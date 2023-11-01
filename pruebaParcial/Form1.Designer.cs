namespace pruebaParcial;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.txtResultado = new System.Windows.Forms.TextBox();
        this.btnUno = new System.Windows.Forms.Button();
        this.btnDos = new System.Windows.Forms.Button();
        this.btnTres = new System.Windows.Forms.Button();
        this.btnSeis = new System.Windows.Forms.Button();
        this.btnCinco = new System.Windows.Forms.Button();
        this.btnCuatro = new System.Windows.Forms.Button();
        this.btnQuitar = new System.Windows.Forms.Button();
        this.btnBorrarTodo = new System.Windows.Forms.Button();
        this.btnBorrar = new System.Windows.Forms.Button();
        this.btnNueve = new System.Windows.Forms.Button();
        this.btnOcho = new System.Windows.Forms.Button();
        this.btnSiete = new System.Windows.Forms.Button();
        this.btnParentesisAbierto = new System.Windows.Forms.Button();
        this.btnParentesisCerrado = new System.Windows.Forms.Button();
        this.btnMultiplicar = new System.Windows.Forms.Button();
        this.btnDividir = new System.Windows.Forms.Button();
        this.btnRestar = new System.Windows.Forms.Button();
        this.btnSumar = new System.Windows.Forms.Button();
        this.btnResultado = new System.Windows.Forms.Button();
        this.btnPunto = new System.Windows.Forms.Button();
        this.btnCero = new System.Windows.Forms.Button();
        this.btnSigno = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // btnPunto
        // 
        this.btnPunto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnPunto.Location = new System.Drawing.Point(127, 310);
        this.btnPunto.Name = "btnPunto";
        this.btnPunto.Size = new System.Drawing.Size(45, 45);
        // this.btnPunto.TabIndex = 22;
        this.btnPunto.Text = ".";
        this.btnPunto.UseVisualStyleBackColor = true;
        this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
        // 
        // btnCero
        // 
        this.btnCero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnCero.Location = new System.Drawing.Point(70, 310);
        this.btnCero.Name = "btnCero";
        this.btnCero.Size = new System.Drawing.Size(45, 45);
        this.btnCero.Tag = "0";
        this.btnCero.Text = "0";
        this.btnCero.UseVisualStyleBackColor = true;
        this.btnCero.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnSigno
        // 
        this.btnSigno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnSigno.Location = new System.Drawing.Point(13, 310);
        this.btnSigno.Name = "btnSigno";
        this.btnSigno.Size = new System.Drawing.Size(45, 45);
        this.btnSigno.Text = "+/-";
        this.btnSigno.UseVisualStyleBackColor = true;
        this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
        // 
        // btnUno
        // 
        this.btnUno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnUno.Location = new System.Drawing.Point(13, 249);
        this.btnUno.Name = "btnUno";
        this.btnUno.Size = new System.Drawing.Size(45, 45);
        this.btnUno.Tag = "1";
        this.btnUno.Text = "1";
        this.btnUno.UseVisualStyleBackColor = true;
        this.btnUno.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnDos
        // 
        this.btnDos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnDos.Location = new System.Drawing.Point(70, 249);
        this.btnDos.Name = "btnDos";
        this.btnDos.Size = new System.Drawing.Size(45, 45);
        this.btnDos.Tag = "2";
        this.btnDos.Text = "2";
        this.btnDos.UseVisualStyleBackColor = true;
        this.btnDos.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnTres
        // 
        this.btnTres.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnTres.Location = new System.Drawing.Point(127, 249);
        this.btnTres.Name = "btnTres";
        this.btnTres.Size = new System.Drawing.Size(45, 45);
        this.btnTres.Tag = "3";
        this.btnTres.Text = "3";
        this.btnTres.UseVisualStyleBackColor = true;
        this.btnTres.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnCuatro
        // 
        this.btnCuatro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnCuatro.Location = new System.Drawing.Point(13, 190);
        this.btnCuatro.Name = "btnCuatro";
        this.btnCuatro.Size = new System.Drawing.Size(45, 45);
        this.btnCuatro.Tag = "4";
        this.btnCuatro.Text = "4";
        this.btnCuatro.UseVisualStyleBackColor = true;
        this.btnCuatro.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnCinco
        // 
        this.btnCinco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnCinco.Location = new System.Drawing.Point(70, 190);
        this.btnCinco.Name = "btnCinco";
        this.btnCinco.Size = new System.Drawing.Size(45, 45);
        this.btnCinco.Tag = "5";
        this.btnCinco.Text = "5";
        this.btnCinco.UseVisualStyleBackColor = true;
        this.btnCinco.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnSeis
        // 
        this.btnSeis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnSeis.Location = new System.Drawing.Point(127, 190);
        this.btnSeis.Name = "btnSeis";
        this.btnSeis.Size = new System.Drawing.Size(45, 45);
        this.btnSeis.Tag = "6";
        this.btnSeis.Text = "6";
        this.btnSeis.UseVisualStyleBackColor = true;
        this.btnSeis.Click += new System.EventHandler(this.agregarValor);
        //

        // btnSiete
        // 
        this.btnSiete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnSiete.Location = new System.Drawing.Point(13, 131);
        this.btnSiete.Name = "btnSiete";
        this.btnSiete.Size = new System.Drawing.Size(45, 45);
        this.btnSiete.Tag = "7";
        this.btnSiete.Text = "7";
        this.btnSiete.UseVisualStyleBackColor = true;
        this.btnSiete.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnOcho
        // 
        this.btnOcho.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnOcho.Location = new System.Drawing.Point(70, 131);
        this.btnOcho.Name = "btnOcho";
        this.btnOcho.Size = new System.Drawing.Size(45, 45);
        this.btnOcho.Tag = "8";
        this.btnOcho.Text = "8";
        this.btnOcho.UseVisualStyleBackColor = true;
        this.btnOcho.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnNueve
        // 
        this.btnNueve.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnNueve.Location = new System.Drawing.Point(127, 131);
        this.btnNueve.Name = "btnNueve";
        this.btnNueve.Size = new System.Drawing.Size(45, 45);
        this.btnNueve.Tag = "9";
        this.btnNueve.Text = "9";
        this.btnNueve.UseVisualStyleBackColor = true;
        this.btnNueve.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnBorrarTodo
        // 
        this.btnBorrarTodo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnBorrarTodo.Location = new System.Drawing.Point(70, 71);
        this.btnBorrarTodo.Name = "btnBorrarTodo";
        this.btnBorrarTodo.Size = new System.Drawing.Size(45, 45);
        this.btnBorrarTodo.Text = "C";
        this.btnBorrarTodo.UseVisualStyleBackColor = true;
        this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
        // 
        // btnBorrar
        // 
        this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnBorrar.Location = new System.Drawing.Point(13, 71);
        this.btnBorrar.Name = "btnBorrar";
        this.btnBorrar.Size = new System.Drawing.Size(45, 45);
        this.btnBorrar.Text = "CE";
        this.btnBorrar.UseVisualStyleBackColor = true;
        this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
        // 
        // btnQuitar
        // 
        this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnQuitar.Location = new System.Drawing.Point(127, 71);
        this.btnQuitar.Name = "btnQuitar";
        this.btnQuitar.Size = new System.Drawing.Size(45, 45);
        this.btnQuitar.Text = "<-";
        this.btnQuitar.UseVisualStyleBackColor = true;
        this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
        // 
        // btnParentesisCerrado
        // 
        this.btnParentesisCerrado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnParentesisCerrado.Location = new System.Drawing.Point(271, 71);
        this.btnParentesisCerrado.Name = "btnParentesisCerrado";
        this.btnParentesisCerrado.Size = new System.Drawing.Size(45, 45);
        this.btnParentesisCerrado.Tag = ")";
        this.btnParentesisCerrado.Text = ")";
        this.btnParentesisCerrado.UseVisualStyleBackColor = true;
        this.btnParentesisCerrado.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnParentesisAbierto
        // 
        this.btnParentesisAbierto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnParentesisAbierto.Location = new System.Drawing.Point(214, 71);
        this.btnParentesisAbierto.Name = "btnParentesisAbierto";
        this.btnParentesisAbierto.Size = new System.Drawing.Size(45, 45);
        this.btnParentesisAbierto.Tag = "(";
        this.btnParentesisAbierto.Text = "(";
        this.btnParentesisAbierto.UseVisualStyleBackColor = true;
        this.btnParentesisAbierto.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnMultiplicar
        // 
        this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnMultiplicar.Location = new System.Drawing.Point(271, 131);
        this.btnMultiplicar.Name = "btnMultiplicar";
        this.btnMultiplicar.Size = new System.Drawing.Size(45, 45);
        this.btnMultiplicar.Tag = "x";
        this.btnMultiplicar.Text = "X";
        this.btnMultiplicar.UseVisualStyleBackColor = true;
        this.btnMultiplicar.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnDividir
        // 
        this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnDividir.Location = new System.Drawing.Point(214, 131);
        this.btnDividir.Name = "btnDividir";
        this.btnDividir.Size = new System.Drawing.Size(45, 45);
        this.btnDividir.Tag = "/";
        this.btnDividir.Text = "∕";
        this.btnDividir.UseVisualStyleBackColor = true;
        this.btnDividir.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnSumar
        // 
        this.btnSumar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnSumar.Location = new System.Drawing.Point(214, 190);
        this.btnSumar.Name = "btnSumar";
        this.btnSumar.Size = new System.Drawing.Size(45, 45);
        this.btnSumar.Tag = "+";
        this.btnSumar.Text = "+";
        this.btnSumar.UseVisualStyleBackColor = true;
        this.btnSumar.Click += new System.EventHandler(this.agregarValor);
        // 
        // btnRestar
        // 
        this.btnRestar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnRestar.Location = new System.Drawing.Point(271, 190);
        this.btnRestar.Name = "btnRestar";
        this.btnRestar.Size = new System.Drawing.Size(45, 45);
        this.btnRestar.Tag = "-";
        this.btnRestar.Text = "−";
        this.btnRestar.UseVisualStyleBackColor = true;
        this.btnRestar.Click += new System.EventHandler(this.agregarValor);
        // 
        // txtResultado
        // 
        this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtResultado.Location = new System.Drawing.Point(13, 13);
        this.txtResultado.MaxLength = 21;
        this.txtResultado.Multiline = true;
        this.txtResultado.Name = "txtResultado";
        this.txtResultado.ReadOnly = true;
        this.txtResultado.Size = new System.Drawing.Size(303, 45);
        this.txtResultado.Text = "0";
        this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // btnResultado
        // 
        this.btnResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnResultado.Location = new System.Drawing.Point(214, 249);
        this.btnResultado.Name = "btnResultado";
        this.btnResultado.Size = new System.Drawing.Size(102, 45);
        this.btnResultado.Text = "=";
        this.btnResultado.UseVisualStyleBackColor = true;
        this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(331, 365);
        this.Controls.Add(this.btnPunto);
        this.Controls.Add(this.btnCero);
        this.Controls.Add(this.btnSigno);
        this.Controls.Add(this.btnResultado);
        this.Controls.Add(this.btnRestar);
        this.Controls.Add(this.btnSumar);
        this.Controls.Add(this.btnMultiplicar);
        this.Controls.Add(this.btnDividir);
        this.Controls.Add(this.btnParentesisAbierto);
        this.Controls.Add(this.btnParentesisCerrado);
        this.Controls.Add(this.btnQuitar);
        this.Controls.Add(this.btnBorrarTodo);
        this.Controls.Add(this.btnBorrar);
        this.Controls.Add(this.btnNueve);
        this.Controls.Add(this.btnOcho);
        this.Controls.Add(this.btnSiete);
        this.Controls.Add(this.btnSeis);
        this.Controls.Add(this.btnCinco);
        this.Controls.Add(this.btnCuatro);
        this.Controls.Add(this.btnTres);
        this.Controls.Add(this.btnDos);
        this.Controls.Add(this.btnUno);
        this.Controls.Add(this.txtResultado);
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Parcial 2 Calculadora";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    private System.Windows.Forms.TextBox txtResultado;
    private System.Windows.Forms.Button btnUno;
    private System.Windows.Forms.Button btnDos;
    private System.Windows.Forms.Button btnTres;
    private System.Windows.Forms.Button btnSeis;
    private System.Windows.Forms.Button btnCinco;
    private System.Windows.Forms.Button btnCuatro;
    private System.Windows.Forms.Button btnQuitar;
    private System.Windows.Forms.Button btnBorrarTodo;
    private System.Windows.Forms.Button btnBorrar;
    private System.Windows.Forms.Button btnNueve;
    private System.Windows.Forms.Button btnOcho;
    private System.Windows.Forms.Button btnSiete;
    private System.Windows.Forms.Button btnParentesisAbierto;
    private System.Windows.Forms.Button btnParentesisCerrado;
    private System.Windows.Forms.Button btnMultiplicar;
    private System.Windows.Forms.Button btnDividir;
    private System.Windows.Forms.Button btnRestar;
    private System.Windows.Forms.Button btnSumar;
    private System.Windows.Forms.Button btnResultado;
    private System.Windows.Forms.Button btnPunto;
    private System.Windows.Forms.Button btnCero;
    private System.Windows.Forms.Button btnSigno;
}
