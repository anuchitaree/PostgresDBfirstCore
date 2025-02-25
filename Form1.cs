
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
            using (var db = new dekidaka_local_dbContext())
            {
                var today = DateOnly.FromDateTime(DateTime.Now);

                var result = db.ScanBuffers.Where(x => x.OperationalDate == today).ToList();

                db.ScanBuffers.RemoveRange(result);
                db.SaveChanges();

                var result1 = db.ShiftSlots.Where(x => x.OperationalDate == today).ToList();

                db.ShiftSlots.RemoveRange(result1);
                db.SaveChanges();

                MessageBox.Show("Clean data in today completed", "info");
            }
        }
    }
}
