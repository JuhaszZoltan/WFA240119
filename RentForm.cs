using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA240119
{
    public partial class RentForm : Form
    {
        private int selectedBikeID = -1;
        private int selectedKoboldID = -1;

        public RentForm()
        {
            InitializeComponent();
            dtpStart.Value = DateTime.Today;
            this.Load += FillNamesCbx;
            cbxNames.SelectedIndexChanged += SetKoboldID;
            cbxNames.SelectedIndexChanged += FillBikesDgv;
            dgvBikes.CellClick += SetBikeID;
            btnNewRental.Click += BtnNewRentalClick;
        }

        private void SetKoboldID(object? sender, EventArgs e)
        {
            using SqlConnection conn = new(Program.connStr);
            conn.Open();
            SqlDataReader rdr = new SqlCommand(
                $"SELECT id FROM kobolds WHERE name = '{cbxNames.SelectedItem}'",
                conn).ExecuteReader();
            rdr.Read();
            selectedKoboldID = rdr.GetInt32(0);
        }

        private void BtnNewRentalClick(object? sender, EventArgs e)
        {
            if (cbxNames.SelectedItem is not null
                && dtpStart.Value >= DateTime.Today
                && nudDays.Value >= 1
                && selectedBikeID != -1)
            {
                if (LastrentEndDate() >= dtpStart.Value)
                {
                    _ = MessageBox.Show(
                        caption: "ERROR",
                        text: "The bike you want to rent is currently not avilable!\n" +
                        "Please choose another vehicle or date!",
                        icon: MessageBoxIcon.Error,
                        buttons: MessageBoxButtons.OK);
                }
                else
                {
                    using SqlConnection conn = new(Program.connStr);
                    conn.Open();

                    SqlDataAdapter adp = new()
                    {
                        InsertCommand = new(
                            "INSERT INTO rentals VALUES " +
                            $"('{dtpStart.Value:yyyy-MM-dd}', {nudDays.Value}, {selectedKoboldID}, {selectedBikeID});",
                            conn),
                    };
                    adp.InsertCommand.ExecuteNonQuery();
                    _ = MessageBox.Show(
                        caption: "SUCCESS",
                        text: "The new rental is added!",
                        icon: MessageBoxIcon.Information,
                        buttons: MessageBoxButtons.OK);
                    this.Close();
                }
           
            }
            else
            {
                _ = MessageBox.Show(
                    caption: "ERROR",
                    text: "All filds above are required!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
        }

        private void SetBikeID(object? sender, DataGridViewCellEventArgs e)
            => selectedBikeID = (int)dgvBikes[0, e.RowIndex].Value;


        private DateTime LastrentEndDate()
        {
            using SqlConnection conn = new(Program.connStr);
            conn.Open();
            List<DateTime> dates = new();
            SqlDataReader rdr = new SqlCommand(
                "SELECT rentals.start, rentals.days " +
                "FROM rentals INNER JOIN bikes ON bikeid = bikes.id " +
                $"WHERE bikes.id = {selectedBikeID};", conn)
                .ExecuteReader();
            while (rdr.Read()) dates.Add(rdr.GetDateTime(0).AddDays(rdr.GetInt32(1)));
            return dates.Max();
        }

        private void FillBikesDgv(object? sender, EventArgs e)
        {
            dgvBikes.Rows.Clear();
            using SqlConnection conn = new(Program.connStr);
            conn.Open();
            SqlDataReader rdr = new SqlCommand(
                "SELECT bikes.id, types.name, bikes.color, types.size " +
                "FROM BIKES INNER JOIN types ON typeid = types.id " +
                $"WHERE types.size = (SELECT size FROM kobolds WHERE name = '{cbxNames.SelectedItem}');",
                conn).ExecuteReader();
            while (rdr.Read()) dgvBikes.Rows.Add(rdr[0], rdr[1], rdr[2], rdr.GetBoolean(3) ? "M" : "S");

            dgvBikes.ClearSelection();
        }

        private void FillNamesCbx(object? sender, EventArgs e)
        {
            using SqlConnection conn = new(Program.connStr);
            conn.Open();

            SqlDataReader rdr = new SqlCommand(
                "SELECT name FROM kobolds;", conn)
                .ExecuteReader();
            while (rdr.Read()) cbxNames.Items.Add(rdr[0]);
        }
    }
}
