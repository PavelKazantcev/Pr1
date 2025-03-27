namespace Pr1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (ApplicationContex db = new ApplicationContex())
            {
                var users = db.Users.ToList();
                labelUsers.Text = "Список пользователей:";
                foreach (User u in users)
                { 
                    labellnfAboutUsers.Text +=($"{u.Id}.{u.Name} - {u.Age}\n");
                }
            }
        }
    }
}
