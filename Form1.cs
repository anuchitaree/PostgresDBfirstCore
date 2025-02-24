using PostgresDBfirstCore.Models;

namespace PostgresDBfirstCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            using  (var db= new  TimecardContext())
            {
                var result = db.TimecardRecords.ToList();
            }
        }
    }
}
