using Microsoft.Data.SqlClient;

namespace WFA240119
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //comment for no reason

            InitializeComponent();
            this.Load += FillTypesCbx;
            this.Load += FillRentDgv;
            cbxTypes.SelectedIndexChanged += FillRentDgv;
            btnNewRent.Click += BtnNewRentClick;
        }

        private void BtnNewRentClick(object? sender, EventArgs e)
        {
            _ = new RentForm().ShowDialog();
            FillRentDgv(null, null!);
        }

        private void FillTypesCbx(object? sender, EventArgs e)
        {
            using SqlConnection conn = new(Program.connStr);
            conn.Open();
            SqlDataReader rdr = new SqlCommand(
                cmdText: "SELECT name FROM types;",
                conn).ExecuteReader();
            while (rdr.Read()) cbxTypes.Items.Add(rdr[0]);
        }

        private void FillRentDgv(object? sender, EventArgs e)
        {
            dgvRents.Rows.Clear();
            using SqlConnection conn = new(Program.connStr);
            conn.Open();
            SqlDataReader rdr = new SqlCommand(
                cmdText: "SELECT kobolds.name, types.name, bikes.color, types.size, rentals.start, rentals.days, types.price " +
                "FROM kobolds INNER JOIN rentals ON kobolds.id = koboldid " +
                "INNER JOIN bikes ON bikeid = bikes.id " +
                "INNER JOIN types ON typeid = types.id " +
                $"WHERE types.name LIKE '{cbxTypes.SelectedItem}%';",
                conn).ExecuteReader();

            while (rdr.Read())
            {
                string customer = (string)rdr[0];
                string bike = $"{rdr[1]} ({rdr[2]}, {(rdr.GetBoolean(3) ? "M" : "S")})";
                string start = $"{rdr.GetDateTime(4):yyyy-MM-dd}";
                string end = $"{rdr.GetDateTime(4).AddDays(rdr.GetInt32(5)):yyyy-MM-dd}";
                string price = $"{rdr.GetInt32(5) * rdr.GetInt32(6)} GP";
                dgvRents.Rows.Add(customer, bike, start, end, price);
            }
        }
    }
}
