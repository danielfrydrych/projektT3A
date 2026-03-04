namespace BJ_projektT3A
{
    public partial class Form1 : Form
    {

        Random rng = new Random();

        string[] karty = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        int RealnaHodnotaHrace = 0;
        int RealnaHodnotaDealera = 0;
        int kartaH1Hit = 0;
        int pocetEs = 0;
        public Form1()
        {
            InitializeComponent();
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

        private void AceCheck()
        {
            if (RealnaHodnotaHrace > 21 && pocetEs > 0)
            {
                RealnaHodnotaHrace -= 10;
                pocetEs--;
            }
        }


        private void Start_Click(object sender, EventArgs e)
        {
            int kartaD1 = rng.Next(13); // 0 = A; 2-10 = 1-9; 10 = J; 11 = Q; 12 = K
            int kartaD2 = rng.Next(13);
            int kartaH1 = rng.Next(13);
            int kartaH2 = rng.Next(13);
            KartyD.Text = karty[kartaD1];
            KartyH.Text = karty[kartaH1] + " " + karty[kartaH2];

            pocetEs = 0;

            if (kartaH1 == 0) pocetEs++;
            if (kartaH2 == 0) pocetEs++;


            RealnaHodnotaHrace = 0;
            RealnaHodnotaDealera = 0;


            RealnaHodnotaHrace = RealnaHodnotaKaret(kartaH1) + RealnaHodnotaKaret(kartaH2);
            RealnaHodnotaDealera = RealnaHodnotaKaret(kartaD1) + RealnaHodnotaKaret(kartaD2);

            AceCheck();

            MessageBox.Show("RealnaHodnotaHrace=" + RealnaHodnotaHrace);
            MessageBox.Show("RealnaHodnotaDealera=" + RealnaHodnotaDealera);

        }

        private void Hit_Click(object sender, EventArgs e)
        {
            kartaH1Hit = 0;
            kartaH1Hit = rng.Next(13);

            KartyH.Text += " " + karty[kartaH1Hit];

            RealnaHodnotaHrace += RealnaHodnotaKaret(kartaH1Hit);

            AceCheck();

            MessageBox.Show("RealnaHodnotaHrace=" + RealnaHodnotaHrace);

        }
    }
}
