namespace Ej2
{
    public partial class PasswdChecker : Form
    {
        Dictionary<Label, bool> validations;
        public PasswdChecker()
        {
            InitializeComponent();
            validations = new Dictionary<Label, bool>();
            validations.Add(labelForEight, false);
            validations.Add(labelForMinus, false);
            validations.Add(labelForMayus, false);
            validations.Add(labelForDigit, false);
            validations.Add(labelForSpecial, false);
            validations.Add(labelForSpaces, true);
            validations.Add(labelForEqual, false);
        }

        private void TextBoxForPasswd_TextChanged(object sender, EventArgs e)
        {
            CheckPasswd();
            CheckEqual();
            UpdateLabels();
            EnableSave();
        }
        private void TextBoxForRepeatPass_TextChanged(object sender, EventArgs e)
        {
            CheckPasswd();
            CheckEqual();
            UpdateLabels();
            EnableSave();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Contraseña guardada!", "", MessageBoxButtons.OK);
            Close();
        }
        
        private void CheckPasswd()
        {
            validations[labelForEight] = CheckEight();
            validations[labelForMinus] = CheckMinus();
            validations[labelForMayus] = CheckMayus();
            validations[labelForDigit] = CheckDigit();
            validations[labelForSpecial] = CheckSpecial();
            validations[labelForSpaces] = CheckNoSpaces();
        }
        private void CheckEqual()
        {
            validations[labelForEqual] = textBoxForPasswd.Text == textBoxForRepeatPass.Text;
        }
        private void UpdateLabels()
        {
            foreach (KeyValuePair<Label, bool> pair in validations)
            {
                if (pair.Value)
                {
                    pair.Key.ForeColor = Color.Lime;
                }
                else
                {
                    pair.Key.ForeColor = Color.Red;
                }
            }
        }
        private void EnableSave()
        {
            btnSave.Enabled = validations[labelForEight] && validations[labelForMinus] && validations[labelForMayus] && validations[labelForDigit] && validations[labelForSpecial] && validations[labelForSpaces] && validations[labelForEqual];
        }
        private bool CheckEight ()
        {
            return textBoxForPasswd.Text.Length >= 8;
        }
        private bool CheckMinus ()
        {
            string text = textBoxForPasswd.Text;
            bool hasMinus = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLower(text[i]))
                {
                    hasMinus = true;
                    i = text.Length;
                }
            }

            return hasMinus;
        }
        private bool CheckMayus()
        {
            string text = textBoxForPasswd.Text;
            bool hasMayus = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    hasMayus = true;
                    i = text.Length;
                }
            }

            return hasMayus;
        }
        private bool CheckDigit ()
        {
            string text = textBoxForPasswd.Text;
            bool hasDigit = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    hasDigit = true;
                    i = text.Length;
                }
            }

            return hasDigit;
        }
        private bool CheckSpecial ()
        {
            string text = textBoxForPasswd.Text;
            bool hasSpecial = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetterOrDigit(text[i]) && !char.IsWhiteSpace(text[i]))
                {
                    hasSpecial = true;
                    i = text.Length;
                }
            }

            return hasSpecial;
        }
        private bool CheckNoSpaces ()
        {
            string text = textBoxForPasswd.Text;
            bool hasSpaces = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(text[i]))
                {
                    hasSpaces = true;
                    i = text.Length;
                }
            }

            return !hasSpaces;
        }

    }
}