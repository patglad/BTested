using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Tematem zadania piątego jest napisanie aplikacji uzależnionej od czasu. Jednym z zadań aplikacji ma być możliwie
precyzyjny pomiar lub odmierzanie czasu. Wykorzystując dowolny język programowania dla komputerów w standardzie PC
napisać aplikację spełniającą funkcję testera sprawności psychomotorycznej np. kandydatów na kierowców. Na aplikację
powinna się składać seria różnych testów badających prosty i złożony czas reakcji na bodźce optyczne i akustyczne. Każdy test
właściwy powinna poprzedzać informacja o przebiegu testu oraz faza szkoleniowa, w trakcie której badany wykona te same
czynności co w trakcie testu, ale bez oceny. Po wykonaniu serii testów badany powinien zostać poinformowany o osiągniętych
wynikach w formie syntetycznej i analitycznej z wykorzystaniem wartości liczbowych i reprezentacji graficznej.
 */
namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.mojeokno = new Fakustyka();
            this.mojeokno.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
