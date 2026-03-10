namespace BJ_projektT3A
{
    public partial class Form1 : Form
    {

        Random rng = new Random();

        string[] karty = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        int RealnaHodnotaHrace = 0;
        int RealnaHodnotaDealera = 0;
        int kartaH1Hit = 0;
        int kartaD1Hit = 0;
        int pocetEsH = 0;
        int pocetEsD = 0;

        int kartaD1 = 0;
        int kartaD2 = 0;
        int kartaH1 = 0;
        int kartaH2 = 0;

        string win = "";
        public Form1()
        {
            InitializeComponent();
            Hit.Enabled = false;
            Stand.Enabled = false;
        }


        private int RealnaHodnotaKaret(int cisloKarty)
        {
            if (cisloKarty == 0)
            {
                return 11;
            }
            if (cisloKarty >= 10)
            {
                return 10;
            }
            return cisloKarty + 1;
        }
        private int AceCheck(int soucet, ref int pocetEs)
        {
            if (soucet > 21 && pocetEs > 0)
            {
                pocetEs--;
                return soucet - 10;
            }
            else
            {
                return soucet;
            }
        }
        private string WinCheck(int CelkovySoucetHrace, int CelkovySoucetDealera)
        {
            if (CelkovySoucetDealera > 21) return "Dealer prohr·l (bust)";

            if (CelkovySoucetDealera > CelkovySoucetHrace) return "Dealer vyhr·l!";
            else if (CelkovySoucetDealera < CelkovySoucetHrace) return "Hr·Ë vyhr·l!";

            else if (CelkovySoucetDealera == CelkovySoucetHrace) return "RemÌza";

            else return "Chyba";
        }


        private void Start_Click(object sender, EventArgs e)
        {
            kartaD1 = rng.Next(13); // 0 = A; 2-10 = 1-9; 10 = J; 11 = Q; 12 = K
            kartaD2 = rng.Next(13);
            kartaH1 = rng.Next(13);
            kartaH2 = rng.Next(13);
            KartyD.Text = karty[kartaD1];
            KartyH.Text = karty[kartaH1] + " " + karty[kartaH2];

            pocetEsH = 0;
            pocetEsD = 0;

            if (kartaH1 == 0) pocetEsH++;
            if (kartaH2 == 0) pocetEsH++;
            if (kartaD1 == 0) pocetEsD++;
            if (kartaD2 == 0) pocetEsD++;

            RealnaHodnotaHrace = 0;
            RealnaHodnotaDealera = 0;


            RealnaHodnotaHrace = AceCheck(RealnaHodnotaKaret(kartaH1) + RealnaHodnotaKaret(kartaH2), ref pocetEsH);
            RealnaHodnotaDealera = AceCheck(RealnaHodnotaKaret(kartaD1) + RealnaHodnotaKaret(kartaD2), ref pocetEsD);

            if (RealnaHodnotaHrace == 21 || RealnaHodnotaDealera == 21) Stand.PerformClick();
            else { Hit.Enabled = true; Stand.Enabled = true; }
        }

        private void Hit_Click(object sender, EventArgs e)
        {

            kartaH1Hit = 0;
            kartaH1Hit = rng.Next(13);

            KartyH.Text += " " + karty[kartaH1Hit];

            RealnaHodnotaHrace += RealnaHodnotaKaret(kartaH1Hit);

            if (kartaH1Hit == 0) pocetEsH++;

            RealnaHodnotaHrace = AceCheck(RealnaHodnotaHrace, ref pocetEsH);

            if (RealnaHodnotaHrace > 21) MessageBox.Show("Hr·Ë prohr·l (Bust)");
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            KartyD.Text += " " + karty[kartaD2];

            while (RealnaHodnotaDealera < 17)
            {
                kartaD1Hit = 0;
                kartaD1Hit = rng.Next(13);

                KartyD.Text += " " + karty[kartaD1Hit];

                RealnaHodnotaDealera += RealnaHodnotaKaret(kartaD1Hit);

                if (kartaH1Hit == 0) pocetEsD++;

                RealnaHodnotaDealera = AceCheck(RealnaHodnotaDealera, ref pocetEsD);

                MessageBox.Show("RealnaHodnotaDealera=" + RealnaHodnotaDealera);

            }

            MessageBox.Show(WinCheck(RealnaHodnotaHrace, RealnaHodnotaDealera));
            Hit.Enabled = false;
            Stand.Enabled = false;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int penize = 1000;
        int VsazenePenize = 0;
        private void Sazkaplus10_Click(object sender, EventArgs e)
        {
            if(penize > 0)
            {
                penize -= 10;
                StavPenez.Text = penize.ToString();

                VsazenePenize += 10;
                Sazka.Text = VsazenePenize.ToString();
            }
            else
            {
                MessageBox.Show("Nedostatek financi");
            }

        }

        private void Sazkaminus10_Click(object sender, EventArgs e)
        {
            if (VsazenePenize > 0)
            {
                penize += 10;
                StavPenez.Text = penize.ToString();

                VsazenePenize -= 10;
                Sazka.Text = VsazenePenize.ToString();
            }
            else
            {
                MessageBox.Show("Vsazeno 0");
            }
        }
    }
}
