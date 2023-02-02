namespace HW02Ev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] myCVV = {"Студент: Святослав","Предмет: WinForms","Група: СПУ111"};
            int counterSymbol=0;
            string caption;

            for (int i = 0; i < myCVV.Length; i++) {
                counterSymbol += myCVV[i].Length;
                caption = (myCVV.Length - 1 == i) ? $"MessageBox{i + 1}.Середнє число символів - {counterSymbol / myCVV.Length}" : $"MessageBox{i + 1}";
                MessageBox.Show(myCVV[i],caption,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}