using System.Text;
using Cseveges;

namespace CsevegesGUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        static List<Beszelgetes> BeszelgetesekLST = new();
        static List<string> TagokLST = new();

        static bool KodreszVege = false;
        private void CsevegesGUI_Load(object sender, EventArgs e)
        {
            Cseveges.Program cmdProgram = new();
            cmdProgram.ListaMegszerzo(BeszelgetesekLST,TagokLST);

            TagokLST.Sort();

            for (int i = 0; i < TagokLST.Count; i++)
            {
                kezedemenyezo_comboBox.Items.Add(TagokLST[i]);
                fogado_comboBox.Items.Add(TagokLST[i]);
            }

            kezedemenyezo_comboBox.SelectedIndex = 0;
            fogado_comboBox.SelectedIndex = TagokLST.Count - 1;

            KodreszVege = true;
            Frissites();
        }

        private void Frissites()
        {
            if (!KodreszVege)
                return;
            csevegesek_listbox.Items.Clear();

            int index = 1;
            for (int i = 0; i < BeszelgetesekLST.Count; i++)
            {
                if (BeszelgetesekLST[i].kezdemenyezo == kezedemenyezo_comboBox.Items[kezedemenyezo_comboBox.SelectedIndex].ToString() && BeszelgetesekLST[i].fogado == fogado_comboBox.Items[fogado_comboBox.SelectedIndex].ToString())
                    csevegesek_listbox.Items.Add($"{index++}. {BeszelgetesekLST[i].kezdet} --> {BeszelgetesekLST[i].veg}");
            }

            if (csevegesek_listbox.Items.Count < 1)
            {
                csevegesek_listbox.Items.Add("Nem történt beszélgetés");
            }
        }
        private void kezedemenyezo_comboBox_SelectedIndexChanged(object sender, EventArgs e)
            => Frissites();

        private void fogado_comboBox_SelectedIndexChanged(object sender, EventArgs e)
            => Frissites();
    }
}