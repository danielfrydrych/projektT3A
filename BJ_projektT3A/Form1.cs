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

        int penize = 1000;
        int VsazenePenize = 0;

        char win = ' '; // Y = Yes (1:1), N = No (ztr·ta), B = BJ (3:2), P = Push (VracenÌ s·zky)
        public Form1()
        {
            InitializeComponent();
            Hit.Enabled = false;
            Stand.Enabled = false;
            Double.Enabled = false;
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
            if (CelkovySoucetDealera > 21) { win = 'Y'; return "Dealer prohr·l (bust)"; }

            if (CelkovySoucetDealera > CelkovySoucetHrace) { win = 'N'; return "Dealer vyhr·l!"; }
            else if (CelkovySoucetDealera < CelkovySoucetHrace) { win = 'Y'; return "Hr·Ë vyhr·l!"; }

            else { win = 'P'; return "RemÌza"; }
        }
        private int Vyplaceni(int vsazeno)
        {
            Sazkaminus10.Enabled = true;
            Sazkaplus10.Enabled = true;

            clear();
            VsazenePenize = 0;
            if (win == 'Y') return vsazeno * 2;
            if (win == 'N') return 0;
            if (win == 'P') return vsazeno;
            if (win == 'B') return vsazeno + ((vsazeno * 3) / 2);
            else return 0;
        }
        private void BJcheck()
        {

            if (RealnaHodnotaHrace == 21 && RealnaHodnotaDealera != 21)
            {
                win = 'B';
                MessageBox.Show("Hr·Ë vyhr·v· (BJ)");
                penize += Vyplaceni(VsazenePenize);
                StavPenez.Text = penize.ToString();
                Sazka.Text = VsazenePenize.ToString();
            }
            else if (RealnaHodnotaHrace == 21 && RealnaHodnotaDealera == 21)
            {
                win = 'P';
                MessageBox.Show("RemÌza (Push)");
                penize += Vyplaceni(VsazenePenize);
                StavPenez.Text = penize.ToString();
                Sazka.Text = VsazenePenize.ToString();
            }
            else if (RealnaHodnotaDealera == 21)
            {
                win = 'N';
                KartyD.Text += " " + karty[kartaD2];
                MessageBox.Show("Hr·Ë prohr·l (BJ)");
                penize += Vyplaceni(VsazenePenize);
                StavPenez.Text = penize.ToString();
                Sazka.Text = VsazenePenize.ToString();
            }
            else
            {
                Hit.Enabled = true;
                Stand.Enabled = true;
                Double.Enabled = true;
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (VsazenePenize <= 0) { MessageBox.Show("Sazka 0"); return; }

            Sazkaminus10.Enabled = false;
            Sazkaplus10.Enabled = false;

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

            BJcheck();
        }
        private void clear()
        {
            KartyD.Text = "0";
            KartyH.Text = "0";
        }
        private void Hit_Click(object sender, EventArgs e)
        {
            Double.Enabled = false;

            kartaH1Hit = 0;
            kartaH1Hit = rng.Next(13);

            KartyH.Text += " " + karty[kartaH1Hit];

            RealnaHodnotaHrace += RealnaHodnotaKaret(kartaH1Hit);

            if (kartaH1Hit == 0) pocetEsH++;

            RealnaHodnotaHrace = AceCheck(RealnaHodnotaHrace, ref pocetEsH);

            if (RealnaHodnotaHrace > 21)
            {
                win = 'N';
                MessageBox.Show("Hr·Ë prohr·l (Bust)");
                penize += Vyplaceni(VsazenePenize);

                StavPenez.Text = penize.ToString();
                Sazka.Text = VsazenePenize.ToString();

                Hit.Enabled = false;
                Stand.Enabled = false;
            }

            if (RealnaHodnotaHrace == 21) Stand.PerformClick();
        }
        private void Stand_Click(object sender, EventArgs e)
        {
            Double.Enabled = false;
            Hit.Enabled = false;
            Stand.Enabled = false;

            KartyD.Text += " " + karty[kartaD2];

            while (RealnaHodnotaDealera < 17)
            {
                kartaD1Hit = 0;
                kartaD1Hit = rng.Next(13);

                KartyD.Text += " " + karty[kartaD1Hit];

                RealnaHodnotaDealera += RealnaHodnotaKaret(kartaD1Hit);

                if (kartaD1Hit == 0) pocetEsD++;

                RealnaHodnotaDealera = AceCheck(RealnaHodnotaDealera, ref pocetEsD);

                MessageBox.Show("RealnaHodnotaDealera=" + RealnaHodnotaDealera);

            }

            MessageBox.Show(WinCheck(RealnaHodnotaHrace, RealnaHodnotaDealera));
            penize += Vyplaceni(VsazenePenize);

            StavPenez.Text = penize.ToString();
            Sazka.Text = VsazenePenize.ToString();

        }
        private void Stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Sazkaplus10_Click(object sender, EventArgs e)
        {
            if (penize > 0)
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
        private void Double_Click(object sender, EventArgs e)
        {
            if(penize>= VsazenePenize)
            {
                penize -= VsazenePenize;
                VsazenePenize *= 2;

                StavPenez.Text = penize.ToString();
                Sazka.Text = VsazenePenize.ToString();

                kartaH1Hit = 0;
                kartaH1Hit = rng.Next(13);

                KartyH.Text += " " + karty[kartaH1Hit];

                RealnaHodnotaHrace += RealnaHodnotaKaret(kartaH1Hit);

                if (kartaH1Hit == 0) pocetEsH++;

                RealnaHodnotaHrace = AceCheck(RealnaHodnotaHrace, ref pocetEsH);

                Hit.Enabled = false;
                Double.Enabled = false;

                if (RealnaHodnotaHrace > 21)
                {
                    win = 'N';
                    MessageBox.Show("Hr·Ë prohr·l (Bust)");
                    penize += Vyplaceni(VsazenePenize);

                    StavPenez.Text = penize.ToString();
                    Sazka.Text = VsazenePenize.ToString();

                    Hit.Enabled = false;
                    Stand.Enabled = false;
                }
                else{
                    Stand.PerformClick();
                    Stand.Enabled = false;
                }


            }
            else
            {
                MessageBox.Show("Nedostatek financÌ na double!");
            }
        }
    }
}
