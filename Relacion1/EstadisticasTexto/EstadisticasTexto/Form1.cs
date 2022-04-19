using System.Text;

namespace EstadisticasTexto
{
    public partial class EstadistiscasTexto : Form
    {
        public EstadistiscasTexto()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int letters = 0, spaces = 0, vowels = 0, consonants = 0, words = 0;
            string[] lines = textBoxInput.Lines;

            foreach (string line in lines)
            {
                words += CuentaPalabras(line);
                foreach (char c in line)
                {
                    if (char.IsLetter(c))
                    {
                        letters++;
                        if (IsVowel(c))
                        {
                            vowels++;
                        }
                        else
                        {
                            consonants++;
                        }
                    }
                    else
                    {
                        if (char.IsWhiteSpace(c))
                        {
                            spaces++;
                        }
                    }
                }
            }

            textBoxLetters.Text = letters.ToString();
            textBoxSpaces.Text = spaces.ToString();
            textBoxVowels.Text = vowels.ToString();
            textBoxConsonants.Text = consonants.ToString();
            textBoxWords.Text = words.ToString();
        }
        private bool IsVowel(char c)
        {
            string vowels = "aeiouyáéíóúýa̋e̋i̋őűàèìòùỳầềồḕṑǜừằȁȅȉȍȕăĕĭŏŭy̆ắằẳẵặḝȃȇȋȏȗǎěǐǒǔy̌a̧ȩə̧ɛ̧i̧ɨ̧o̧u̧âêîôûŷḙṷẩểổấếốẫễỗậệộäëïöüÿṳḯǘǚṏǟȫǖṻȧėıȯẏǡạẹịọụỵậȩ̇ǡȱảẻỉỏủỷơướứờừởửỡữợựāǣēīōūȳḗṓȭǭąęįǫųy̨åi̊ůḁǻą̊ãẽĩõũỹаэыуояеёюийⱥɇɨøɵꝋʉᵿɏөӫұɨαεηιοωυάέήίόώύὰὲὴὶὸὼὺἀἐἠἰὀὠὐἁἑἡἱὁὡὑᾶῆῖῶῦἆἦἶὦὖἇἧἷὧὗᾳῃῳᾷῇῷᾴῄῴᾲῂῲᾀᾐᾠᾁᾑᾡᾆᾖᾦᾇᾗᾧϊϋΐΰῒῢῗῧἅἕἥἵὅὥὕἄἔἤἴὄὤὔἂἒἢἲὂὢὒἃἓἣἳὃὣὓᾅᾕᾥᾄᾔᾤᾂᾒᾢᾃᾓᾣæɯɪʏʊøɘɤəɛœɜɞʌɔɐɶɑɒιυ";

            return vowels.Contains(c);
        }
        private int CuentaPalabras(string s)
        {
            StringBuilder sb = new StringBuilder();

            //Filtro para quedarte solo con letras y espacios en blanco
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]) || char.IsWhiteSpace(s[i]))
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}