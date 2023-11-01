using System.Collections;

namespace pruebaParcial;

public partial class Form1 : Form
{
    double Numero1 = 0;
    char Operador;
    bool OperacionTerminada = false;
    bool OperadorAgregado = true;
    int ContadorParentesis = 0;
    public Form1()
    {
        InitializeComponent();
    }

    private void agregarValor(object sender, EventArgs e)
    {
        var boton = ((Button)sender);
        string[] pocosOperadores = { "+", "-", "x", "/" };
        if (txtResultado.Text == "0")
            txtResultado.Text = "";

        //Si la operación ya terminó y se presiona un número o paréntesis, se limpia el resultado
        if (OperacionTerminada && !pocosOperadores.Contains(boton.Tag?.ToString()))
        {
            txtResultado.Text = "";
        }
        OperacionTerminada = false;

        //Si el último caracter es un operador, se reemplaza por el nuevo
        if (pocosOperadores.Contains(boton.Tag?.ToString()))
        {
            if (txtResultado.Text.Length >= 3 &&
                pocosOperadores.Contains(txtResultado.Text.Substring(txtResultado.Text.Length - 2, 1)) &&
                pocosOperadores.Contains(boton.Tag))
            {
                string parte1 = txtResultado.Text.Substring(0, txtResultado.Text.Length - 3);
                Console.WriteLine("parte1: " + parte1);
                //Cambiando el operador
                txtResultado.Text = parte1 + " " + boton.Tag + " ";
            }
            else
            {
                //Agregando operador nuevo
                txtResultado.Text += " " + boton.Tag?.ToString() + " ";
            }
            OperadorAgregado = true;
        }
        else
        {
            //Agregando paréntesis
            txtResultado.Text += boton.Tag;
        if (boton.Tag?.ToString() == "(")
    {
     ContadorParentesis++;
    if (txtResultado.Text.Length > 0 && !pocosOperadores.Contains(txtResultado.Text.Substring(txtResultado.Text.Length - 1)) && txtResultado.Text.Substring(txtResultado.Text.Length - 1) != "(")
    {
        txtResultado.Text += " x (";
    }
}
    else if (boton.Tag?.ToString() == ")")
    {
    ContadorParentesis--;
    if (ContadorParentesis < 0)
         {
            txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            ContadorParentesis = 0;
        }
    }

        }
    }

    private void btnResultado_Click(object sender, EventArgs e)
    {
        OperacionTerminada = true;
        OperadorAgregado = true;
        try
        {
            // Realizar validación de la entrada aquí si es necesario

            // Código de evaluación de la expresión
            Console.WriteLine(txtResultado.Text);

            string expression = txtResultado.Text;
            txtResultado.Text = EvaluateExpression(expression).ToString();
        }
        catch (Exception ex)
        {
            txtResultado.Text = "Error: " + ex.Message;
        }
    }

    private double EvaluateExpression(string expression)
    {
        // Divide la expresión en tokens(números, operadores y paréntesis)
        string[] firstSplit = expression.Split(" ");
        List<string> tokens = new List<string>();

        foreach (string token in firstSplit)
        {
            if (token.Length > 1 && token.Contains("(") || token.Contains(")")) {
                
                if (token.Contains("(") && token.Contains(")")) {
                    tokens.Add("(");
                    tokens.Add(token.Substring(1, token.Length - 2));
                    tokens.Add(")");
                }
                else if (token.Contains("(")) {
                    tokens.Add("(");
                    tokens.Add(token.Substring(1, token.Length - 1));
                } else {
                    tokens.Add(token.Substring(0, token.Length - 1));
                    tokens.Add(")");
                }
            } else {
                tokens.Add(token);
            }
            Console.WriteLine("Division de token: " + token);
        }
        
        
        // Si falta cerrar paréntesis, los cierra
        while (ContadorParentesis > 0) {
            tokens.Add(")"); 
            ContadorParentesis--;
        }

        // Inicializa una pila para los números y operadores
        Stack<double> numberStack = new Stack<double>();
        Stack<char> operatorStack = new Stack<char>();

        // Itera sobre los tokens
        foreach (string token in tokens)
        {
            Console.WriteLine("Caracter: " + token);
            if (double.TryParse(token, out double number))
            {
                numberStack.Push(number);
            }
            else if (token == "(")
            {
                operatorStack.Push('(');
            }
            else if (token == ")")
            {
                // Mientras el operador en el tope de la pila no sea un paréntesis izquierdo
                while (operatorStack.Peek() != '(')
                {
                    // Realiza la operación
                    double result = Operar(numberStack.Pop(), numberStack.Pop(), operatorStack.Pop());
                    // Guarda el resultado en la pila de números
                    numberStack.Push(result);
                }
                // Elimina el paréntesis izquierdo
                operatorStack.Pop();
                Console.WriteLine(operatorStack.Count);
                if (operatorStack.Count == 0) {
                    return numberStack.Pop();
                }
            }
            else
            {
                Console.WriteLine("funcion que se fija precedencia => stack número: " + numberStack.Count + ", stack operador: " + operatorStack.Count);
                // Mientras el operador en el tope de la pila tenga mayor o igual precedencia
                while (operatorStack.Count > 0 && numberStack.Count >= 2 && Precedencia(operatorStack.Peek()) >= Precedencia(token[0]))
                {
                    // Realiza la operación
                    double result = Operar(numberStack.Pop(), numberStack.Pop(), operatorStack.Pop());
                    // Guarda el resultado en la pila de números
                    numberStack.Push(result);
                }
                // Guarda el operador en la pila de operadores
                operatorStack.Push(token[0]);
            }
        }

        // Mientras la pila de operadores no esté vacía
        while (operatorStack.Count > 0)
        {
            // Realiza la operación
            double result = Operar(numberStack.Pop(), numberStack.Pop(), operatorStack.Pop());
            // Guarda el resultado en la pila de números
            numberStack.Push(result);
        }

        // El resultado es el único número en la pila de números
        double response = numberStack.Pop();
        txtResultado.Text = response.ToString();
        return response;
    }

    // Función que realiza la operación
    double Operar(double num2, double num1, char operador)
    {
        switch (operador)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case 'x':
                return num1 * num2;
            case '/':
                return num1 / num2;
            default:
                throw new ArgumentException("Operador no válido: " + operador);
        }
    }

    // Función que regresa la precedencia de un operador
    int Precedencia(char operador)
    {
        switch (operador)
        {
            case '+':
            case '-':
                return 1;
            case 'x':
            case '/':
                return 2;
            default:
                return 0;
        }
    }


    private void btnQuitar_Click(object sender, EventArgs e)
    {
        if (txtResultado.Text.Length > 1)
        {
            Console.WriteLine("ultimoCaracter: " + txtResultado.Text.Substring(txtResultado.Text.Length - 1, 1));
            if (txtResultado.Text.Substring(txtResultado.Text.Length - 1, 1) == " ")
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 3);
            }
            else
            {
                if (txtResultado.Text.Substring(txtResultado.Text.Length - 1, 1) == "(") {
                    ContadorParentesis--;
                } else if (txtResultado.Text.Substring(txtResultado.Text.Length - 1, 1) == ")") {
                    ContadorParentesis++;
                }
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
        }
        else
        {
            txtResultado.Text = "0";
        }
    }

    private void btnBorrarTodo_Click(object sender, EventArgs e)
    {
        Numero1 = 0;
        Operador = '\0';
        txtResultado.Text = "0";
        OperacionTerminada = false;
        OperadorAgregado = true;
    }

    private void btnBorrar_Click(object sender, EventArgs e)
    {
        txtResultado.Text = "0";
    }

    private void btnPunto_Click(object sender, EventArgs e)
    {
        string[] muchosOperadores = { "+", "-", "x", "/" };

        if (OperacionTerminada)
        {
            txtResultado.Text = "0,";
        }
        else if (OperadorAgregado)
        {
            if (txtResultado.Text.Length <= 1) 
            {
                    txtResultado.Text += ",";
            }
            else
            {
                string ultimoCaracter = txtResultado.Text.Substring(txtResultado.Text.Length - 1, 1);
                string penultimoCaracter = txtResultado.Text.Substring(txtResultado.Text.Length - 2, 1);
                Console.WriteLine("ultimoCaracter: " + ultimoCaracter + ", penultimoCaracter: " + penultimoCaracter);

                if ( muchosOperadores.Contains(penultimoCaracter) ||
                    ultimoCaracter == "(" ) {
                    txtResultado.Text += "0,";
                } else {
                    txtResultado.Text += ",";
                }
            }
        }
        OperacionTerminada = false;
        OperadorAgregado = false;
    }

    private void btnSigno_Click(object sender, EventArgs e)
    {
        Numero1 = Convert.ToDouble(txtResultado.Text);
        Numero1 *= -1;
        txtResultado.Text = Numero1.ToString();
    }

    private void clickOperador(object sender, EventArgs e)
    {
        var boton = ((Button)sender);
        Operador = Convert.ToChar(boton.Tag);

        if (Operador == '(')
        {
            txtResultado.Text += "(";
        }
        else if (Operador == ')')
        {
            txtResultado.Text += ")";
        }
        else
        {
            txtResultado.Text += " " + Operador + " ";
        }
    }
}