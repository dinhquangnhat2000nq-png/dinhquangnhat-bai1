namespace bài1_8_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs(out decimal unitPrice, out decimal quantity, out decimal discount))
                return;

            if (discount < 0 || discount > 100)
            {
                MessageBox.Show("% giảm phải nằm trong khoảng 0 - 100.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = (unitPrice * quantity) * (100 - discount) / 100m;
            lblTotal.Text = total.ToString("C2");
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            lblTotal.Text = "0.00";
            txtUnitPrice.Focus();
        }

        private bool ValidateInputs(out decimal unitPrice, out decimal quantity, out decimal discount)
        {
            unitPrice = 0m;
            quantity = 0m;
            discount = 0m;

            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text) || !decimal.TryParse(txtUnitPrice.Text, out unitPrice))
            {
                MessageBox.Show("Vui lòng nhập Đơn giá hợp lệ (số).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !decimal.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Vui lòng nhập Số lượng hợp lệ (số).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                discount = 0m;
            }
            else if (!decimal.TryParse(txtDiscount.Text, out discount))
            {
                MessageBox.Show("Vui lòng nhập % Giảm hợp lệ (số).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return false;
            }

            return true;
        }
    }
}
