using System;
using System.Windows.Forms;
using FajrEnrollment.Database;

namespace FajrEnrollment.Forms
{
    public partial class Main : Form
    {
        public int MemberId;

        public Main()
        {
            InitializeComponent();

            dgvMembers.AutoGenerateColumns = false; // جلوگیری از ایجاد اتوماتیک ستون ها

            cmbActivityType.SelectedIndex = 0; // به صورت پیشفرض اولین آیتم کمبوباکس نوع فعالیت را انتخاب میکند 
        }

        // اطلاعات نمایش داده شده در گرید را به روزرسانی میکند
        public void ReBindGrid()
        {
            var query = @"SELECT [Id],[FirstName],[LastName],[NationalCode],[FatherName],[CertiNumber],[ActivityType]
                            FROM [dbo].[Members]
                            Order by Id desc";
            try
            {
                dgvMembers.DataSource = DbContext.Query(query);
            }
            catch // اگر خطایی اتفاق افتاد
            {
                MessageBox.Show(@"خطا در ارتباط با بانک اطلاعاتی");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ReBindGrid(); // به روز رسانی گریدویو
        }

        private void dgvMembers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            if(index == -1) return; // اگر گریدویو هیچ سطری نداشت

            MemberId = Convert.ToInt32(dgvMembers.Rows[index].Cells["gcId"].Value.ToString());
            txtFirstName.Text = dgvMembers.Rows[index].Cells["gcFirstName"].Value.ToString();
            txtLastName.Text = dgvMembers.Rows[index].Cells["gcLastName"].Value.ToString();
            txtCretiNumber.Text = dgvMembers.Rows[index].Cells["gcCertiNumber"].Value.ToString();
            txtNationalCode.Text = dgvMembers.Rows[index].Cells["gcNationalCode"].Value.ToString();
            txtFatherName.Text = dgvMembers.Rows[index].Cells["gcFatherName"].Value.ToString();
            cmbActivityType.SelectedIndex = Convert.ToInt32(dgvMembers.Rows[index].Cells["gcActivityType"].Value.ToString());
        }

        private void dgvMembers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // تغییر ستون نوع فعالیت از شماره به عنوان
            var dataGridViewColumn = dgvMembers.Columns["gcActivityType"];
            if (dataGridViewColumn == null || dataGridViewColumn.Index != e.ColumnIndex) return;

            if (e.Value != null)
            {
                e.Value = cmbActivityType.Items[(int) e.Value];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // بررسی میکند که آیا کد ملی 10 رقمی است یا خیر
            if (txtNationalCode.Text.Length != 10)
            {
                MessageBox.Show(@"کد ملی نادرست است");
                return;
            }

            var query = string.Format(
                @"INSERT INTO [dbo].[Members]([FirstName],[LastName],[NationalCode],[FatherName],[CertiNumber],[ActivityType])
                    VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',{5})", txtFirstName.Text, txtLastName.Text, txtNationalCode.Text, txtFatherName.Text ,txtCretiNumber.Text, cmbActivityType.SelectedIndex);
            DbContext.Command(query);

            ReBindGrid(); // به روز رسانی گریدویو
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var query = string.Format(@"UPDATE [dbo].[Members]
                            SET [FirstName] = N'{1}',[LastName] = N'{2}',[NationalCode] = N'{3}',[FatherName] = N'{4}',[CertiNumber] = N'{5}',[ActivityType] = {6}
                            WHERE Id = {0}",
                            MemberId, txtFirstName.Text, txtLastName.Text, txtNationalCode.Text, txtFatherName.Text, txtCretiNumber.Text, cmbActivityType.SelectedIndex);
            DbContext.Command(query);

            ReBindGrid(); // به روز رسانی گریدویو
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0) // اگر سطری انتخاب شده بود
            {
                var selectedIndex = dgvMembers.SelectedRows[0].Index; // ایندکس سطر انتخاب شده
                var memberId = Convert.ToInt32(dgvMembers.Rows[selectedIndex].Cells["gcId"].Value.ToString());  // شناسه سطر انتخاب شده
                var query = string.Format(@"DELETE FROM [dbo].[Members] WHERE Id = {0}", memberId);
                DbContext.Command(query);

                ReBindGrid(); // به روز رسانی گریدویو
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); // خروج از برنامه
        }
    }
}
