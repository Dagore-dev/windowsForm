namespace PruebaFiltros
{
    public partial class PruebaFiltros : Form
    {
        public PruebaFiltros()
        {
            InitializeComponent();
        }

        private void TextBoxNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextFilters.CheckNumeric(e);
        }
        private void TextBoxEnteros_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextFilters.CheckInteger(sender, e);
        }
        private void TextBoxReales_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextFilters.CheckReal(sender, e);
        }
        private void TextBoxLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextFilters.CheckLetter(e);
        }
        private void TextBoxAlfanumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextFilters.CheckAlphanumeric(e);
        }
        private void TextBoxNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextFilters.CheckNIF(sender, e);
        }
    }
}