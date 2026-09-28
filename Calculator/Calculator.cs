namespace Calculator
{
    public partial class Calculator : Form
    {

        #region Constructors

        public Calculator()
        {
            InitializeComponent();
        }

        #endregion

        private void WriteScreen(string s)
        {
            if (txtScreen.Text == "0") txtScreen.Text = s;
            else txtScreen.Text += s;
        }

        private void Calculator_Load(object sender, EventArgs e) { }

        private void btnComma_Click(object sender, EventArgs e)
        {
            WriteScreen(".");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            WriteScreen("+");
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            WriteScreen("-");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            WriteScreen("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            WriteScreen("/");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            WriteScreen("%");
        }

        private void btnRightParenthesis_Click(object sender, EventArgs e)
        {
            WriteScreen(")");
        }

        private void btnLeftParenthesis_Click(object sender, EventArgs e)
        {
            WriteScreen("(");
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                NCalc.Expression expression = new NCalc.Expression(txtScreen.Text);
                if (expression.HasErrors()) throw new Exception("Expression invalide");

                object? result = expression.Evaluate();

                if (result == null) throw new Exception("Expression invalide");
                else if (result is double d && (double.IsInfinity(d) || double.IsNaN(d)))
                    throw new DivideByZeroException();

                txtScreen.Text = result.ToString();
            }
            catch (Exception ex)
            {
                txtScreen.Text = "Erreur";
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            WriteScreen("Sin(");
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            WriteScreen("Cos(");
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            WriteScreen("Tan(");
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            WriteScreen("Sqrt(");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            WriteScreen("Log10(");
        }

        #region Numpads

        private void btn0_Click(object sender, EventArgs e)
        {
            WriteScreen("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            WriteScreen("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            WriteScreen("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            WriteScreen("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            WriteScreen("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            WriteScreen("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            WriteScreen("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            WriteScreen("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            WriteScreen("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            WriteScreen("9");
        }

        #endregion
    }
}